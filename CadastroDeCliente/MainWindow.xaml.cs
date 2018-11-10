using CadastroDeCliente.Contextos;
using CadastroDeCliente.Model;
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

namespace AGENDA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Salvar(Object sender, RoutedEventArgs e)
        {
            Contato contato = new Contato()
            {
                ContatoId = Convert.ToInt32(codTbx.Text),
                Nome = nomeTbx.Text,
                Endereço = enderecoTbx.Text,
                Numero = Convert.ToInt32(numeroTbx.Text),
                Bairro = bairroTbx.Text,
                Cep = cepTbx.Text,
                Cidade = cidadeTbx.Text,
                Estado = estadoTbx.Text,


            };

            using (var contexto = new AgendaContexto())
            {
                contexto.Client.Add(contato);
                contexto.SaveChanges();
                MessageBox.Show("Contato Incluido com  Sucesso!!");
            }

        }

        private void cidadeTbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}