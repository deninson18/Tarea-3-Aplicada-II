using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace PaginaContacto.PaginaContact
{
    public partial class RegistroContacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            AsuntoTextBox.Text = string.Empty;
            mensajeTextBox.Text = string.Empty;
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            Contacto conta = new Contacto();

            conta.Email = emailTextBox.Text;
            conta.Asunto = AsuntoTextBox.Text;
            conta.Mensajes = mensajeTextBox.Text;

            conta.insertar();
            
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Contacto conta = new Contacto();
            conta.ContactoId = int.Parse(IdTextBox.Text);
            conta.eliminar();

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            Contacto conta = new Contacto();
            int id;
            int.TryParse(IdTextBox.Text, out id);
            conta.buscar(id);
            emailTextBox.Text = conta.Email;
            AsuntoTextBox.Text = conta.Asunto;
            mensajeTextBox.Text = conta.Mensajes;
        }
    }
}