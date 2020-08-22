using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form2 : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "manuel" && textBoxX2.Text == "1234")
            {
                this.Hide();
                Form1 Nueva = new Form1();
                Nueva.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");
                textBoxX1.Text = "";
                textBoxX2.Text = "";

            }
        }
    }
}
