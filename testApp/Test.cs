using NUnit.Framework;
using System;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Configuration;

namespace testApp
{
    [TestFixture]
    public class Test
    {
        iOSApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            string deviceUDID = Environment.GetEnvironmentVariable("IOS_SIMULATOR_UDID");
            string bundleID = "com.memberzonestaff.alpha";

            app = ConfigureApp
                .iOS
                .InstalledApp(bundleID)
                .DeviceIdentifier(deviceUDID)
                .StartApp();
        }

        //[SetUp]
        //public void Setup()
        //{
        //    string path = "/Users/fropcorn/Desktop/Ravi/MemberZoneStaffiOS.app";
        //    string device = "C68F5B31-9082-46D1-9F89-BD6B5BB65DBA";
        //    app = ConfigureApp.iOS.AppBundle(path).DeviceIdentifier(device).PreferIdeSettings().EnableLocalScreenshots().StartApp();
        //}

        [Test]
        public void TestCase()
        {
            //app.WaitForElement(c => c.Text("SignUp"));
            app.Tap(c => c.Text("Sign Up"));
            app.Tap(c => c.Marked("Email"));
            app.EnterText(c => c.Marked("Email"), "ravi@mailinator.com");
            app.PressEnter();
            app.Tap(c => c.Marked("Get Started!"));

        }
    }
}
