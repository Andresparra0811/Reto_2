using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Capa_Presentacion;

namespace BibliotecaEanAP
{
    public partial class Form1 : Form
    {
        ClaseLogica objlog = new ClaseLogica();
        ClasePresentacion objpres = new ClasePresentacion();
        public Form1()
        {
            InitializeComponent();
        }

        void CUD(String accion)
        {
            objlog.codigo= Convert.ToInt32(txtcodigo.Text);
            objlog.titulo= txttitulo.Text;
            objlog.autor= txtautor.Text;
            objlog.editorial=txteditorial.Text;
            objlog.precio=Convert.ToDouble(txtprecio.Text);
            objlog.cantidad=Convert.ToInt16(txtcantidad.Text);
            objlog.accion=accion;
            String men = objpres.N_CUD(objlog);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtcodigo.Text= "0";
            txttitulo.Text="";
            txtautor.Text= "";
            txteditorial.Text="";
            txtprecio.Text="";
            txtcantidad.Text="";
            dataGridView1.DataSource=objpres.N_listar_libros();

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=objpres.N_listar_libros();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text= dataGridView1[0, fila].Value.ToString();
            txttitulo.Text= dataGridView1[1, fila].Value.ToString();
            txtautor.Text= dataGridView1[2, fila].Value.ToString();
            txteditorial.Text=dataGridView1[3, fila].Value.ToString();
            txtprecio.Text=dataGridView1[4, fila].Value.ToString();
            txtcantidad.Text=dataGridView1[5, fila].Value.ToString();
        }

        private void Libro_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtbusqueda.Text != "")
            {
                objlog.titulo= txtbusqueda.Text;
                DataTable dt = new DataTable();
                dt= objpres.N_buscar_libro(objlog);
                dataGridView1.DataSource= dt;
            }
            else {
                dataGridView1.DataSource= objpres.N_listar_libros();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "0") {
                if (MessageBox.Show("¿Deseas registrar el libro " + txttitulo.Text+"?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)== System.Windows.Forms.DialogResult.Yes) {

                    CUD("1");
                    limpiar();
                }
            
            }
            
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void editarbutt_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar el libro " + txttitulo.Text+"?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)== System.Windows.Forms.DialogResult.Yes) {

                    CUD("2");
                    limpiar();
                }


            }
           
        }

        private void borrarbutt_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar el libro " + txttitulo.Text+"?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)== System.Windows.Forms.DialogResult.Yes)
                {

                    CUD("3");
                    limpiar();
                }


            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            limpiar(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
