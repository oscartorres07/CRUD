using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using CRUD.config;
using CRUD.config.request;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class vista0 : Form
    {
        public vista0()
        {
            InitializeComponent();
        }

        private void vista0_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        #region Helper
        private void refrescar()
        {
            using (InterlogicEntities2 db = new InterlogicEntities2())
            {
                var lst = from d in db.TablaEjercicio
                          select d;
                dgv_ordenes.DataSource = lst.ToList();
            }
        }
        private void CargarDatos() { 
            using(InterlogicEntities2 db = new InterlogicEntities2())
            {
               
                
               
            }
        }
        private int? obtenerID (){
            try
            {
                return int.Parse(dgv_ordenes.Rows[dgv_ordenes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch {
                return null;
            }
            
        }
        #endregion

        private void btn_nuevaorden_Click(object sender, EventArgs e)
        {
            vistas.vista1 vistaCrear = new vistas.vista1();
            vistaCrear.ShowDialog();

            refrescar();
        }

        private void btn_modificarorden_Click(object sender, EventArgs e)
        {
            int? id = obtenerID();
            if (id != null)
            { 
                vistas.vista1 VistaModificar = new vistas.vista1(id);
                VistaModificar.ShowDialog();
                refrescar();
            }
        }

        private void btn_eliminarorden_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desa eleminar la orden seleccionada?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int? id = obtenerID();
                if (id != null)
                {

                    using (InterlogicEntities2 db = new InterlogicEntities2())
                    {
                        TablaEjercicio tabla = db.TablaEjercicio.Find(id);
                        db.TablaEjercicio.Remove(tabla);
                        db.SaveChanges();
                    }
                    refrescar();
                }
            }   
        }

        //Metodo creado para recibir una cadena, EJ: "EXITO"
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                
            }
            catch (Exception e)
            {
                //en caso de error lo manejamos en el mensaje
                result = e.Message;

            }

            return result;
        }

        private void btn_enviarordenes_Click(object sender, EventArgs e)
        {
            int? id = obtenerID();
            if (id != null) {
                DialogResult dr = MessageBox.Show("¿Desa enviar la orden seleccionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //URL de API
                    string url = "";

                    OrdenRequest ObjetoRequest = new OrdenRequest();
                    string resultado = Send<OrdenRequest>(url, ObjetoRequest, "POST");

                }
            }
            
        }
    }
}

