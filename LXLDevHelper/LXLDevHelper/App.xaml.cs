﻿using System;
using System.Windows;

namespace LXLDevHelper
{
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var boot = new Bootstrapper();
            boot.Run();
        }
    }
}