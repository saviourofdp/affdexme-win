# AffdexMe

**Affdex SDK** is the culmination of years of scientific research into emotion detection, validated across thousands of tests worldwide on PC platforms, and now made available as a software development kit for Windows. Affdex SDK turns your ordinary app into an extraordinary app by emotion-enabling it to respond in real-time to user emotions.

**AffdexMe** is a windows application that demonstrates the use of the Affdex SDK for Windows. It uses the camera on your Windows PC to view, process and analyze live video of your face. Start the app and you will see your own face on the screen, and metrics describing your expressions.

<div id="fb-root"></div>
<script>(function(d, s, id) {  var js, fjs = d.getElementsByTagName(s)[0];  if (d.getElementById(id)) return;  js = d.createElement(s); js.id = id;  js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.3";  fjs.parentNode.insertBefore(js, fjs);}(document, 'script', 'facebook-jssdk'));</script>
<div class="fb-video" data-allowfullscreen="1" data-href="/ahamino/videos/vb.134501200/857058591896/?type=3">
   <div class="fb-xfbml-parse-ignore">
      <blockquote cite="https://www.facebook.com/ahamino/videos/857058591896/">
         <a href="https://www.facebook.com/ahamino/videos/857058591896/"></a>
         <p>Coz its too much work to use an #emoji keyboard #affectiva #sneak_peak #AffdexSDK</p>
         Posted by <a href="#" role="button">Abdelrahman Mahmoud</a> on Wednesday, January 6, 2016
      </blockquote>
   </div>
</div>

#### This app includes the following command buttons:

*   Start - Starts the camera processing
*   Reset - Resets the context of the video frames
*   ShowPoints/HidePoints - toggles the display of facial feature points, which Affdex uses to detect expressions
*   Display metrics - Displays the emotion and expressions
*   Display emojis - Displays the most likely / dominant emoji
*   Display Appearance - Displays appearance metrics (gender / eye glasses)
*   Take a screenshot - Takes a screenshot of the camera feed with the metrics overlayed
*   Stop - Stops the camera processing
*   Exit - exits the application

This application runs on Windows 7.0, 8.0 and 8.1

#### To use this project, you will need:

*   Visual Studio 2013

*   To [download and install the Windows SDK (32-bit)](http://developer.affectiva.com/downloads) from Affectiva By default, the Windows SDK is installed to the following location: C:\Program Files (x86)\Affectiva\Affdex SDK

    Modify the ```FilePath.GetClassifierDataFolder``` and ```FilePath.GetAffdexLicense``` in ```FilePath.cs```:

    *   **FilePath.GetClassifierDataFolder**

        The function should return the full path of the Affdex SDK data folder.

        If you installed Affdex SDK in a location other than the default. Please change the return value to match the location of the data folder in your installed location.
    *   **FilePath.GetAffdexLicense**

        The function reads the license file and returns its contents. You can signup for an evaluation license to use with the app [by filling this form](http://www.affectiva.com/45-day-free-trial/)

        Set ```string fileName``` variable to the location of the your license file

*   Build the project

*   Run the app through Visual Studio

**Note** It is important not to mix Release and Debug versions of the DLLs. If you run into issues when switching between the two different build types, check to make sure that your system path points to the matching build type.

Copyright (c) 2016 Affectiva. All rights reserved.
