using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace Visual
{
    public partial class frmBuscar : Form
    { 
        List<Articulo> list;
        public frmBuscar()
        {
            InitializeComponent();
        }
        

        private void btnAceptarBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string codigo = txbCodigo.Text;
                string nombre = txbNombre.Text;
                string descripcion = txbDescripcion.Text;
                decimal precio = nmPrecio.Value;
                
                list = negocio.filtrar(codigo, nombre, descripcion, precio);
                DialogResult = DialogResult.OK;
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Por favor verificar que los datos se ingresen de forma correcta");
            }
            
        
        
        }
        public List<Articulo> ArticulosFiltrados()
        {
            return list;
        }
        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
