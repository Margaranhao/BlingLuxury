using BlingLuxury.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlingLuxury.Vistas
{
    public partial class frmReporteInventario : Form
    {
        DataGridView dgvInventario;
        public frmReporteInventario(DataGridView dgvInventario)
        {
            InitializeComponent();
            this.dgvInventario = dgvInventario;
        }

        private void frmReporteInventario_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();//carga los datos que se van a enviar al xml
            DataTable dt = new DataTable();//vrea la tabla 
            //no poner valores doubles porque no los carga cristal reports
            dt.Columns.Add("Id",typeof(Int32));
            dt.Columns.Add("Fecha", typeof(string));
            dt.Columns.Add("Cantidad", typeof(Int32));
            dt.Columns.Add("Codigo de Barras", typeof(string));
            dt.Columns.Add("Modelo", typeof(string));
            dt.Columns.Add("Marca", typeof(string));
            dt.Columns.Add("Precio", typeof(float));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Categoria", typeof(string));

            foreach(DataGridViewRow dgv in dgvInventario.Rows)//recorre los datos de mi tabla
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value,
                    dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value,
                    dgv.Cells[8].Value);//valores que se van a mostrar en el reporte
            }

            ds.Tables.Add(dt);//agregar los datos de mi tabla al dataset
            ds.WriteXmlSchema("ReporteInventario.xml");//generaa el archivo xml

            RepoInventario cr = new RepoInventario();
            cr.SetDataSource(ds);


            crystalReportViewerInventario.ReportSource = cr;
        }
    }
}
