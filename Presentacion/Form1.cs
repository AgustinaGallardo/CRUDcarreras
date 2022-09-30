using CRUDcarreras.Datos;
using CRUDcarreras.Dominio;
using CRUDcarreras.Servicios.Implementacion;
using CRUDcarreras.Servicios.Intefaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDcarreras
{
    public partial class AltaCarrera : Form
    {
        private IServicio gestor;
        private Carrera nueva;
        public AltaCarrera()
        {
            InitializeComponent();
            gestor = new Servicio();
            nueva = new Carrera();
        }

        private void AltaCarrera_Load(object sender, EventArgs e)
        {
            ObtenerProximo();
            ObtenerMaterias();
        }

        private void ObtenerMaterias()
        {
            cboMateria.ValueMember="IdMateria";
            cboMateria.DisplayMember="nombre";
            cboMateria.DataSource = gestor.ObtenerMaterias();
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ObtenerProximo()
        {
            int Next = gestor.ObtenerProximo();
            if(Next > 0)
            {
                lblNextCarrera.Text = "Carrera Nro " + Next.ToString();
            }
            else
            {
                MessageBox.Show("No se pudo Obtener la Proxima Carrera", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboMateria.SelectedIndex ==-1)
            {
                MessageBox.Show("Selecione una Materia", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            if(txtAni0Cursado.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un año", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            if(txtCuatri.Text == string.Empty)
            {
                MessageBox.Show("Ingrese cantidad de materias", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }

            Materia mat = (Materia)cboMateria.SelectedItem;
            int anio = Convert.ToInt32(txtAni0Cursado.Text);
            int cuatri = Convert.ToInt32(txtCuatri.Text);
            DetalleCarrera dt = new DetalleCarrera( anio, cuatri, mat);

            nueva.AgregarDetalle(dt);
            dgvCarreras.Rows.Add(dt.Materia.IdMateria,
                dt.Materia.Nombre, dt.AnioCursado, dt.Cuatrimestre);

            txtCantMateria.Text = nueva.CalcularTotal().ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text== string.Empty)
            {
                MessageBox.Show("Ingrese el nombre de la  carrera", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            if(txtTitulo.Text ==String.Empty)
            {
                MessageBox.Show("Ingrese titulo de la carrera", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            AgregarCarrera();
        }

        private void AgregarCarrera()
        {
            nueva.Nombre=txtNombre.Text;
            nueva.Titulo=txtTitulo.Text;
            if(Helper.ObtenerInstancia().ConfirmasCarrera(nueva))
            {
                MessageBox.Show("Se agrego con exito una neva carrera", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("No se puede agregar la nueva carrera", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtTitulo.Text=string.Empty;
            txtNombre.Text=string.Empty;
            txtCuatri.Text=string.Empty;
            txtCantMateria.Text=string.Empty;
            txtAni0Cursado.Text=string.Empty;
            dgvCarreras.Rows.Clear();
        }
    }
}
