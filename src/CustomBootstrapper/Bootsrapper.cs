namespace CustomBootstrapper
{
    using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Interop;
    using System.Windows.Threading;

    public class Bootsrapper : BootstrapperApplication
    {
        protected override void Run()
        {
            Engine.Log(LogLevel.Verbose, "Custom Bootstrapper Run Start.");
            

            Engine.Detect();
            if (Command.Display == Display.Passive || Command.Display == Display.Full)
            {
                var view = new MainView();
                var vm = new MainViewModel(this);
                view.DataContext = vm;
                view.Show();
            }
            Dispatcher.Run();

            Engine.Quit(0);
            Engine.Log(LogLevel.Verbose, "Custom Bootstrapper Run End.");
        }
    }
}
