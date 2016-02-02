using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffdexMe
{
    class FilePath
    {
        static public String GetClassifierDataFolder()
        {
            // First see if we can get the Install Path from the registry 
            RegistryKey rkCurrentUser = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            RegistryKey rkAffdexMe = rkCurrentUser.OpenSubKey("Software\\Affectiva\\AffdexMe");
            String classifierPath = String.Empty;
            if (rkAffdexMe != null && !String.IsNullOrEmpty((String)rkAffdexMe.GetValue("Install Directory")))
            {
                classifierPath = (String)rkAffdexMe.GetValue("Install Directory") + "\\data";
            }
            else
            {
                String affdexClassifierDir = Environment.GetEnvironmentVariable("AFFDEX_DATA_DIR");
                if (String.IsNullOrEmpty(affdexClassifierDir))
                {
                    throw new Exception("AFFDEX_DATA_DIR environment variable (Classifier Data Directory) is not set");
                }
                else
                {
                    classifierPath = affdexClassifierDir;
                }
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(classifierPath);
            if (!directoryInfo.Exists)
            {
                throw new Exception("AFFDEX_DATA_DIR (Classifier Data Directory) is set to an invalid folder location");
            }

            return classifierPath;
        }

        static public String GetAffdexLicense()
        {
            // First see if we can get the License from the registry 
            RegistryKey rkCurrentUser = Registry.LocalMachine;
            RegistryKey rkAffdexMe = rkCurrentUser.OpenSubKey("Software\\Affectiva\\AffdexMe");
            String licensePath = String.Empty;
            if ( rkAffdexMe != null && !String.IsNullOrEmpty((string)rkAffdexMe.GetValue("Install Directory")))
            {
                licensePath = (String)rkAffdexMe.GetValue("Install Directory");
            }
            else
            {
                licensePath = Environment.GetEnvironmentVariable("AFFDEX_LICENSE_DIR");
                if (String.IsNullOrEmpty(licensePath))
                {
                    throw new Exception("AFFDEX_LICENSE_DIR environment variable (Affdex License Folder) is not set");
                }
            }

            // Test the directory
            DirectoryInfo directoryInfo = new DirectoryInfo(licensePath);
            if (!directoryInfo.Exists)
            {
                throw new Exception("AFFDEX_License_DIR (Affex License Folder) is set to an invalid folder location");
            }

            return licensePath + "\\affdex.license";
        }
    }
}
