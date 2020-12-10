using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementos_y_Componentes_c
{
    public partial class BindingNavigator1 : Form
    {
        public BindingNavigator1()
        {
            InitializeComponent();
        }

        private void BindingNavigator1_Load(object sender, EventArgs e)
        {
                usersBindingSource.Add(new Users() { username = "admin", password = "admin" });
                usersBindingSource.Add(new Users() { username = "user", password = "123" });
                usersBindingSource.Add(new Users() { username = "sa", password = "admin" });
                usersBindingSource.Add(new Users() { username = "lucy", password = "456" });

            
        }
    }
}
