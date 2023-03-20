using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;


namespace WindowsFormsAppVaidrollTeam
{
    public partial class Alumnos2 : Form
    {
        ClassNegocio objneg2 = new ClassNegocio();
        ClassEntidad objent2 = new ClassEntidad();

        public Alumnos2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /*private void Alumnos_Load(object sender, EventArgs e)
        {
            


        }*/

        void mantalumno(String accion)
        {
            objent2.id_alumno = txtcodigo2.Text;
            objent2.nombre = txtnombre2.Text;
            objent2.telefono = Convert.ToInt32(txttel2.Text);
            objent2.matricula = Convert.ToInt32(txtmatricula2.Text);
            objent2.id_curso = cbocurso2.SelectedValue.ToString();
            objent2.id_salon = cbosalon2.SelectedValue.ToString();
            objent2.accion = accion;
            String men = objneg2.N_mantenimientoalumno(objent2);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtcodigo2.Text = "";
            txtnombre2.Text = "";
            txttel2.Text = "";
            txtmatricula2.Text = "";
            cbocurso2.SelectedIndex = 0;
            cbosalon2.SelectedIndex = 0;
            dataGridView1.DataSource = objneg2.N_listaralumnos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo2.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre2.Text = dataGridView1[1, fila].Value.ToString();
            txttel2.Text = dataGridView1[2, fila].Value.ToString();
            txtmatricula2.Text = dataGridView1[3, fila].Value.ToString();
            cbocurso2.SelectedValue = dataGridView1[4, fila].Value.ToString();
            cbosalon2.SelectedValue = dataGridView1[6, fila].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            objent2.nombre = textBox8.Text + "%";
            DataTable dt = new DataTable();
            dt = objneg2.N_buscaralumnos(objent2);
            dataGridView1.DataSource = dt;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cargar esta materia y grupo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
         System.Windows.Forms.DialogResult.Yes)
            {
                mantalumno("2");
                limpiar();
            }
        }

        private void Alumnos2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg2.N_listaralumnos();

            cbocurso2.DataSource = objneg2.N_listar_curso();
            cbocurso2.ValueMember = "id_cursos";
            cbocurso2.DisplayMember = "curso_nombre";

            cbosalon2.DataSource = objneg2.N_listar_salon();
            cbosalon2.ValueMember = "id_salon";
            cbosalon2.DisplayMember = "salon_nombre";
        }

        private void cbocurso2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbosalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
