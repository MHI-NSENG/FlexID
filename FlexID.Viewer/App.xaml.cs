using FlexID.Viewer.ViewModels;
using FlexID.Viewer.Views;
using Prism.Ioc;
using System.Windows;

namespace FlexID.Viewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Args ==1     入力GUIからの実行
            // Args !=1(0)  exeファイル直接実行
            if (e.Args.Length == 1)
                MainWindowViewModel.OutPath = e.Args[0];

            base.OnStartup(e);
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Model>();
        }
    }
}
