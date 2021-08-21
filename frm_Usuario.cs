using Capa_Datos;
using Capa_Logica;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }
        private Int64 id;
        private DataTable tabla;
        N_InsertarUsuario objI = new N_InsertarUsuario();
        N_ActualizarUsuario objA = new N_ActualizarUsuario();
        N_EliminarUsuario objE = new N_EliminarUsuario();
        Conexion cn = new Conexion();
        L_Usuario objL = new L_Usuario();
        void BFiltrar()
        {
            btn_EliminarUsuario.Visible = false;
            btn_ActualizarUsuario.Visible = false;
            btn_AgregarUsuario.Visible = false;
            cb_filtrar.Visible = true;
            txt_filtrar.Visible = true;
        }
        void BEliminarVisible()
        {
            btn_EliminarUsuario.Visible = true;
            btn_ActualizarUsuario.Visible = false;
            btn_AgregarUsuario.Visible = false;
            cb_filtrar.Visible = false;
            txt_filtrar.Visible = false;
        }
        void BActualizarVisible()
        {
            btn_EliminarUsuario.Visible = false;
            btn_ActualizarUsuario.Visible = true;
            btn_AgregarUsuario.Visible = false;
            cb_filtrar.Visible = false;
            txt_filtrar.Visible = false;
        }
        void BAgregarVisible()
        {
            P_Usuarios.Visible = true;
            btn_AgregarUsuario.Visible = false;
            btn_EliminarUsuario.Visible = false;
            btn_ActualizarUsuario.Visible = false;
            btn_AgregarUsuario.Visible = true;
            cb_filtrar.Visible = false;
            txt_filtrar.Visible = false;
            dg_usuarios.Visible = true;
        }
        void VaciarTextBoxes()
        {
            txt_nombre.Text = "";
            txt_apaterno.Text = "";
            txt_amaterno.Text = "";
            txt_correo.Text = "";
            txt_tfijo.Text = "";
            txt_tcelular.Text = "";
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(P_Usuarios.Visible == true)
            {
                if (btn_Agregar.Name == "btn_Agregar")
                {
                    BAgregarVisible();
                }
            }
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (P_Usuarios.Visible == true)
            {
                if (btn_Actualizar.Name == "btn_Actualizar")
                {
                    BActualizarVisible();
                    if (cb_filtrar.Visible == false && txt_filtrar.Visible == false)
                    {
                        btn_ActualizarUsuario.Location = new Point(355, 117);
                    }
                }
            }   
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(P_Usuarios.Visible == true)
            {
                if (btn_Eliminar.Name == "btn_Eliminar")
                {
                    BEliminarVisible();
                    if(cb_filtrar.Visible == false && txt_filtrar.Visible == false)
                    {
                        btn_EliminarUsuario.Location = new Point(355, 117);
                    }
                }
            }
        }
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            frm_Principal abrir = new frm_Principal();
            abrir.Show();
            this.Close();
        }
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.sp_ListarUsuario' Puede moverla o quitarla según sea necesario.
            this.sp_ListarUsuarioTableAdapter.Fill(this.bibliotecaDataSet.sp_ListarUsuario);
            //dg_usuarios.RowHeadersVisible = false;
            ListarUsuarios();
        }
        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (P_Usuarios.Visible == true)
            {
                if (btn_Filtrar.Name == "btn_Filtrar")
                {
                    BFiltrar();
                    if (cb_filtrar.Visible == true && txt_filtrar.Visible == true)
                    {
                        btn_ActualizarUsuario.Visible = true;
                        btn_ActualizarUsuario.Location = new Point(598, 117);
                        btn_EliminarUsuario.Visible = true;
                        btn_EliminarUsuario.Location = new Point(700, 117);
                        txt_filtrar.Size = new Size(440, 22);
                    }
                }
            }
        }
        private void ListarUsuarios()
        {
            N_ListarUsuario listar = new N_ListarUsuario();
            tabla = listar.ListarUsuarios();
            dg_usuarios.DataSource = tabla;

            foreach (DataGridViewColumn columna in dg_usuarios.Columns)
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            dg_usuarios.RowHeadersVisible = false;
            dg_usuarios.Columns[0].Visible = false;
            dg_usuarios.Columns[2].Visible = false;
            dg_usuarios.Columns[3].Visible = false;
            dg_usuarios.Columns[4].Visible = false;
        }
        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                objL.id = id;
                objL.nombre = txt_nombre.Text;
                objL.APaterno = txt_apaterno.Text;
                objL.AMaterno = txt_amaterno.Text;
                objL.correo = txt_correo.Text;
                objL.TFijo = Convert.ToInt32(txt_tfijo.Text);
                objL.TCelular = Convert.ToInt32(txt_tcelular.Text);
                if (objI.InsertarUsuarios(objL) == true)
                {
                    MessageBox.Show("Guardado Correctamente");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Se produjo un error: No guardado");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe llenar los campos", "Atención!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dg_usuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Emboque mejor el mouse en la fila");
                return;
            }
            else
            {
                txt_nombre.Text = tabla.Rows[e.RowIndex].Field<string>(2);
                txt_apaterno.Text = tabla.Rows[e.RowIndex].Field<string>(3);
                txt_amaterno.Text = tabla.Rows[e.RowIndex].Field<string>(4);
                txt_tfijo.Text = tabla.Rows[e.RowIndex].Field<int>(5).ToString();
                txt_tcelular.Text = tabla.Rows[e.RowIndex].Field<int>(6).ToString();
                txt_correo.Text = tabla.Rows[e.RowIndex].Field<string>(7);
                id = tabla.Rows[e.RowIndex].Field<long>(0);
                ListarUsuarios();
            }
        }
        private void btn_ActualizarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                objL.id = id;
                objL.nombre = txt_nombre.Text;
                objL.APaterno = txt_apaterno.Text;
                objL.AMaterno = txt_amaterno.Text;
                objL.correo = txt_correo.Text;
                objL.TFijo = Convert.ToInt32(txt_tfijo.Text);
                objL.TCelular = Convert.ToInt32(txt_tcelular.Text);
                if (objA.ActualizarUsuario(objL) == true)
                {
                    MessageBox.Show("Actualizado Correctamente");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Se produjo un error: No actualizado");
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay datos para actualziar", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Bloquear el frm_Usuario para que solo se muestre una sola vez
        private static frm_Usuario frm_Instancia = null;
        public static frm_Usuario Instancia()
        {
            if (((frm_Instancia == null) || (frm_Instancia.IsDisposed == true)))
            {
                frm_Instancia = new frm_Usuario();
            }
            frm_Instancia.BringToFront();
            return frm_Instancia;
        }
        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            objL.id = id;
            DialogResult result = MessageBox.Show("Seguro que dese eliminar " + txt_nombre.Text + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (objE.EliminarUsuario(objL) == true)
                {
                    VaciarTextBoxes();
                    ListarUsuarios();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Se produjo un error: No se eliminó");
            }
        }
        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            if (cb_filtrar.Text == "Nombre Completo")
            {
                var aux = new N_Filtros();
                aux.FiltrarNombre(dg_usuarios, txt_filtrar.Text.Trim());
            }
            else if (cb_filtrar.Text == "Teléfono")
            {
                var aux = new N_Filtros();
                aux.filtrarTelefono(dg_usuarios, txt_filtrar.Text.Trim());
            }
            else if (cb_filtrar.Text == "Celular")
            {
                var aux = new N_Filtros();
                aux.filtrarCelular(dg_usuarios, txt_filtrar.Text.Trim());
            }
            else if (cb_filtrar.Text == "Correo")
            {
                var aux = new N_Filtros();
                aux.filtrarCorreo(dg_usuarios, txt_filtrar.Text.Trim());
            }
        }
    }
}
