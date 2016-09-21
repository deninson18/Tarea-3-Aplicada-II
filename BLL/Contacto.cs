using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Contacto : ClaseMaestra
    {

        ConexionDb conexion = new ConexionDb();
        public int ContactoId { get; set; }
        public string Email { get; set; }
        public string Asunto { get; set; }
        public string Mensajes { get; set; }

        public Contacto()
        {
            this.ContactoId = 0;
            this.Email = "";
            this.Asunto = "";
            this.Mensajes = "";
        }

        public Contacto(int ContactoId,string Email, string Asunto,string Mensajes)
        {
            this.ContactoId = ContactoId;
            this.Email = Email;
            this.Asunto = Asunto;
            this.Mensajes = Mensajes;
        }

        public override bool buscar(int Buscado)
        {
            DataTable dataTable = new DataTable();
            dataTable = conexion.ObtenerDatos(String.Format("select ContactoId,Email,Asunto,Mensajes from Mensajes where ContactoId={0}", Buscado));
            if (dataTable.Rows.Count > 0)
            {
                this.ContactoId = (int)dataTable.Rows[0]["ContactoId"];
                this.Email = dataTable.Rows[0]["Email"].ToString();
                this.Asunto = dataTable.Rows[0]["Asunto"].ToString();
                this.Mensajes = dataTable.Rows[0]["Mensajes"].ToString();
                
            }
            return dataTable.Rows.Count > 0;

        }

        public override bool eliminar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Delete from Mensajes where ContactoId={0}", this.ContactoId));
                return retorno;

            }catch(Exception ex)
            {
                throw ex;
            }
            

        }

        public override bool insertar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("insert into Mensajes(Email,Asunto,Mensajes)values('{0}','{1}','{2}')", this.Email, this.Asunto, this.Mensajes));
                return retorno;

            }catch(Exception ex)

            {
                throw ex;
            }
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }

        public override bool modificar()
        {
            throw new NotImplementedException();
        }
    }
}
