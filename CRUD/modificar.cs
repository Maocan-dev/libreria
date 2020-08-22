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
    public partial class modificar : Form
    {
        public modificar(String id, String titulo, String autor, String tematica, String editorial)
        {
            InitializeComponent();
            textBoxX1.Text = id;
            textBoxX2.Text = titulo;
            textBoxX3.Text = autor;
            textBoxX4.Text = tematica;
            textBoxX5.Text = editorial;
        }

        private void modificar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE libros SET titulo='"+ textBoxX2.Text + "', autor='" + textBoxX3.Text + "', tematica='" + textBoxX4.Text + "', editorial='" + textBoxX5.Text + "' WHERE id=" + textBoxX1.Text;
            String mensaje = conexion.ejecutaquery("modificar", sql);
            MessageBox.Show(mensaje);

        }
    }
}
