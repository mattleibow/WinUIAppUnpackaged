using Microsoft.ApplicationModel.Resources;
using Microsoft.System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.ApplicationModel;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace DynamicDependenciesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take a dependency on the Windows App SDK v0.8 preview.
            var result = MddBootstrap.Initialize(8, "preview");

            Marshal.ThrowExceptionForHR(result);

            Console.WriteLine($"MddBootstrap.Initialize() => {result}");

            WinRT.ComWrappersSupport.InitializeComWrappers();
            Console.WriteLine("ComWrappersSupport.InitializeComWrappers()");

            Application.Start((p) =>
            {
                Console.WriteLine("Application.Start()");

                var context = new DispatcherQueueSynchronizationContext(DispatcherQueue.GetForCurrentThread());
                SynchronizationContext.SetSynchronizationContext(context);

                new App();
            });

            // Release the DDLM and clean up.
            Console.WriteLine("MddBootstrap.Shutdown()");
            MddBootstrap.Shutdown();
        }
    }

    partial class App : Application
    {
        private Window window;

        public App()
        {
            Console.WriteLine("App()");

            //Resources.MergedDictionaries.Add(new XamlControlsResources());
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            Console.WriteLine("OnLaunched()");

            window = new Window();
            window.Activate();
        }
    }
}