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
    public partial class Form1 : Form
    {
        String sql = null;
        DataTable datos = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void collapsibleSplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            actualizardatagrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = "SELECT * from libros";
            datos = conexion.recuperadatos(sql);
            dataGridViewX1.DataSource = datos;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas eliminar el registro", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                String id = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                sql = "DELETE FROM libros WHERE id=" + id;
                String mensaje = conexion.ejecutaquery("eliminar", sql);
                MessageBox.Show(mensaje);
                actualizardatagrid();
            }
        }
        private void actualizardatagrid()
        {
            sql = "SELECT * from libros WHERE titulo LIKE '%" + textBoxX1.Text + "%'";
            datos = conexion.recuperadatos(sql);
            dataGridViewX1.DataSource = datos;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            agregar agregar = new agregar();
            agregar.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            String idenvio = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
            String nombreenvio = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            String autorenvio = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            String tematicaenvio = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            String editorialenvio = dataGridViewX1.CurrentRow.Cells[4].Value.ToString();

            modificar modificar = new modificar(idenvio,nombreenvio,autorenvio,tematicaenvio,editorialenvio);
            modificar.Show();

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Form3 impresion = new Form3();
            impresion.Show();
        }
    }
}
