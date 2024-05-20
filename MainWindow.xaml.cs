using NewDealMetaverse.Day3.Chapter3;
using NewDealMetaverse.Day4.Cahptor5;
using NewDealMetaverse.Day4.Cahptor6;
using NewDealMetaverse.Day5.Cahptor7;
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

namespace NewDealMetaverse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //WriteResult(new SignedUnsignedEx());
            //WriteResult(new FloatDoubleEx());
            //WriteResult(new FloatDoubleEx2());
            //WriteResult(new CharEx());
            //WriteResult(new StringEx());
            //WriteResult(new WhileEx());
            //WriteResult(new DoWhileEx());
            //WriteResult(new ForEx());
            //WriteResult(new BreakWhile());
            //WriteResult(new BreakFor());
            //WriteResult(new ContinueEx());
            //WriteResult(new CalculatorEx());
            //WriteResult(new SwapbyValueEx());
            //WriteResult(new OverLoadingEx
            //WriteResult(new ParamsEx());
            //WriteResult(new OptionalParameterEx());

            //객체 생성
            Animal animal = new Animal();
        }

        private void WriteResult(IPrint result)
        {
            txtConsole.Text = result.GetData();
        }
    }
}