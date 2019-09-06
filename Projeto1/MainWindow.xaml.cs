using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Consumo consumo = new Consumo();
            DataContext = new ConsumoViewModel(consumo);
        }

        private void InitializeComponent()
        {
           
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }

    internal class ConsumoViewModel
    {
        public List<Consumo> Consumo { get ; private set;}

        public ConsumoViewModel(Consumo consumo)
        {
            Consumo = new List<Consumo>();
            Consumo.Add(consumo);
        }
    }

    internal class Consumo
    {
        public string consumo { get; private set; }
        public int Porcentagem { get; private set; }
        public Consumo()
        {
            consumo = "Consumo Atual";
            Porcentagem = calcularPorcentagem();
        }

        private int calcularPorcentagem()
        {
            return 47;
        }
    }
}
