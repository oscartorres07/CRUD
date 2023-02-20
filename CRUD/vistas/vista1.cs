using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.config;

namespace CRUD.vistas
{
    public partial class vista1 : Form
    {
        public int? id;
        public TablaEjercicio tabla=null;
        public vista1(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null) { CargarDatos(); }
        }
        private void CargarDatos() 
        {
            using (InterlogicEntities2 db = new InterlogicEntities2()) 
            {
                tabla = db.TablaEjercicio.Find(id);
                tb_cliente.Text = tabla.cliente;
                tb_descripcion.Text = tabla.descripcion;
                dtp_fecha.Value = tabla.fecha;
                if (tabla.estado == true)
                {
                    radioButton1.Checked = true;
                }
                else 
                {
                    radioButton2.Checked = true;
                }
                
            }
        }
        private void btn_crear_Click(object sender, EventArgs e)
        {
            bool var = true;

            
            if (radioButton2.Checked==true){
                var = false;
            }
               
            
            using (InterlogicEntities2 db = new InterlogicEntities2())
            {

                try 
                {
                    if (id == null)
                         tabla = new TablaEjercicio();

                    tabla.cliente = tb_cliente.Text;
                    tabla.fecha = dtp_fecha.Value;
                    tabla.descripcion = tb_descripcion.Text;
                    tabla.estado = var;
                    if (id == null)
                        db.TablaEjercicio.Add(tabla);
                    else {
                        db.Entry(tabla).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Operacion realizada con exito.");    
                } catch(Exception ex) {
                    MessageBox.Show("Ocurrio un error al intentar realizar la operacion.Consulte al administrador.  "+ ex);
                }

                this.Close();
            }
        }

        private void vista1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
