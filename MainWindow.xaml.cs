using ReqManLib;
using ReqManLib.Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReqMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ReqMgmt reqMan;

        public List<string> projectNames = new List<string>();

        public MainWindow(ReqMgmt reqMan)
        {
            InitializeComponent();
            this.reqMan = reqMan;
        }



        public async Task Initialize()
        {
            RMResult<List<string>> rmResult = await reqMan.GetProjects();
            projectNames = rmResult.Result!;
        }
    }
}