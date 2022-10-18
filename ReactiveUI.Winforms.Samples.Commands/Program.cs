﻿using ReactiveUI.Winforms.Samples.Commands.Views;
using System;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Commands
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
