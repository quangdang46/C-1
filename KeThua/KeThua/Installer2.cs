using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace KeThua
{
    [RunInstaller(true)]
    public partial class Installer2 : System.Configuration.Install.Installer
    {
        public Installer2()
        {
            InitializeComponent();
        }
    }
}
