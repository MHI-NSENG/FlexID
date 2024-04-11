using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Input;

namespace FlexID.Viewer.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static RoutedCommand AlertCommand = new RoutedCommand();
        private readonly Model model;

        public MainWindow(Model model)
        {
            InitializeComponent();
            this.model = model;
            FilePath.AddHandler(DragOverEvent, new DragEventHandler(DragEvent), true);
            FilePath.AddHandler(DropEvent, new DragEventHandler(EventDrop), true);
        }

        private void EventDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            model.SelectPath = filenames[0];
        }

        private void DragEvent(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = true;
        }
    }
}
