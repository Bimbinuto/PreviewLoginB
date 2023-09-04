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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace VistaPreviaBiblioteca.Interfaces
{
    /// <summary>
    /// Lógica de interacción para TestConexionBD.xaml
    /// </summary>
    public partial class TestConexionBD : Window
    {
        public TestConexionBD()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost; database=vehicles;uid=root; pwd=\"\"";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Conectado!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo conectar...");
            }
        }
    }
}
