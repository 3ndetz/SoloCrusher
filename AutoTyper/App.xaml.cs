using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace AutoTyper
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() : base()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
        }
        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("KeyboardHookManager"))
            {
                return Assembly.Load(AutoTyper.Properties.Resources.KeyboardHookManager);
            }
            if (args.Name.Contains("WindowsInput"))
            {
                return Assembly.Load(AutoTyper.Properties.Resources.WindowsInput);
            }
            else return null;
        }
    }
}
