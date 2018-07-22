﻿using UIKit;
using System;
using System.Diagnostics;

namespace eShopOnContainers.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try {
                UIApplication.Main(args, null, "AppDelegate");    
            } catch (Exception ex) {
                Debug.Print("Error : {0}", ex);
            }

        }
    }
}
