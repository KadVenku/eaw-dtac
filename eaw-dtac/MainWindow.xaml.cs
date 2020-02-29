using System.Runtime.CompilerServices;
using eaw.dtac.commons;
using Serilog;

[assembly: InternalsVisibleTo("eaw-dtac.test")]

namespace eaw.dtac
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            Log.Logger = LogUtility.GetLogger();
            InitializeComponent();
        }
    }
}
