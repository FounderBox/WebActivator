﻿using System;
using System.Collections.Generic;
using System.Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(AppCodeStartupCode), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AppCodeStartupCode), "Shutdown")]

public class AppCodeStartupCode
{
    public static bool StartCalled { get; set; }
    public static void Start()
    {
        if (StartCalled)
        {
            throw new Exception("Unexpected second call to Start");
        }

        StartCalled = true;
    }

    public static bool ShutdownCalled { get; set; }
    public static void Shutdown()
    {
        if (ShutdownCalled)
        {
            throw new Exception("Unexpected second call to Shutdown");
        }

        ShutdownCalled = true;
    }
}
