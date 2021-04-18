using ControlsLibrary.Controls.ErrorReporter;
using ControlsLibrary.Controls.Toolbar;
using ControlsLibrary.Controls.Executor;
using System.Windows;

namespace AutomataConstructor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            scene.Toolbar = (ToolbarViewModel)toolbar.DataContext;
            scene.ErrorReporter = (ErrorReporterViewModel)errorReporter.DataContext;
            scene.Executor = (ExecutorViewModel)executor.DataContext;
        }

    }
}
