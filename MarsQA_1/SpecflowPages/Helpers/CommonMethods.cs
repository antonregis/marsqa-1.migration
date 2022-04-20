﻿using OpenQA.Selenium;
using System.Text;


namespace MarsQA_1.Helpers
{
    public class CommonMethods
    {
        // For capturing screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName)
            {
                var folderLocation = (@"D:\marsqa_1.migration\MarsQA_1\TestReports\Screenshots\");

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_yyyy-MM-dd_HHmmss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
	}
}