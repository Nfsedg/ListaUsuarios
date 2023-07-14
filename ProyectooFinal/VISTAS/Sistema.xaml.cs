using ProyectooFinal.ENTITIES;
using ProyectooFinal.SERVICES;
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

namespace ProyectooFinal.VISTAS
{
    /// <summary>
    /// Lógica de interacción para Sistema.xaml
    /// </summary>
    public partial class Sistema : Window
    {
        public Sistema()
        {
            InitializeComponent();
            GetUserTable();
            getRoles();
        }

        UsuarioServices services = new UsuarioServices();
        public void getRoles()
        {
            SelectName.ItemsSource = services.getRoles();
            SelectName.DisplayMemberPath = "Nombre";
            SelectName.SelectedValuePath = "PkRol";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.UserName = txtUserName.Text;
            usuario.Password = txtPassword.Text;

            services.addUser(usuario);

            txtNombre.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            GetUserTable();

        }

        public void editItem(object sender, RoutedEventArgs e)
        {
            //usuario  = (sender as FrameworkContentElement).DataContext as Usuario;
            // Editar y eliminar
            Usuario usuario = new Usuario();
            txtId.Text = usuario.PkUsuario.ToString();
            txtNombre.Text = usuario.Nombre;
            txtUserName.Text = usuario.UserName;
        }
        public void GetUserTable()
        {
            UserTable.ItemsSource = services.getUsuarios();
        }
        

    }
}
