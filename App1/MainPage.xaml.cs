using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Models.Fabricante> fabricantes;
        List<Models.Veiculo> veiculos;
        public MainPage()
        {
            fabricantes = new List<Models.Fabricante>();
            veiculos = new List<Models.Veiculo>();
            this.InitializeComponent();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            Models.Fabricante f = new Models.Fabricante
            {
                id = int.Parse(txtIdFab.Text),
                descricao = txtDesc.Text
            };
            fabricantes.Add(f);
            lstFabricantes.Items.Add(f.ToString());
            cmbFabricantes.ItemsSource = fabricantes;
        }

        private void btnInserirVeic_Click(object sender, RoutedEventArgs e)
        {
            bool k;
            if ((bool)checkBox.IsChecked)
                k = true;
            else
                k = false;

            Models.Veiculo v = new Models.Veiculo
            {
                id = int.Parse(txtIdVeic.Text),
                modelo = txtModelo.Text,
                ano = txtAno.Text,
                preco = double.Parse(txtPreco.Text),
                fabricante = Convert.ToString(cmbFabricantes.SelectedValue),
                situacaoVenda = k
            };

            veiculos.Add(v);
            lstVeic.Items.Add(v);

            if (v.situacaoVenda)
                lstVeicDisp.Items.Add(v);
            else
                lstveicVendidos.Items.Add(v);
        }
    }
}
