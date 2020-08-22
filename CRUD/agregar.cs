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
    public partial class agregar : Form
    {
        public agregar()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            String sql = "INSERT INTO libros (titulo, autor, tematica, editorial ) VALUES ('"+ textBoxX1.Text + "', '" + textBoxX2.Text + "', '" + textBoxX3.Text + "', '" + textBoxX4.Text + "')";
            String mensaje = conexion.ejecutaquery("insertar",sql);
            MessageBox.Show (mensaje);
           
        }
        private void labelX2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void agregar_Load(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
