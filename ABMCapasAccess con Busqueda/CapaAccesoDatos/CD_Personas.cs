using System.Data;
using System.Data.OleDb;

namespace CapaAccesoDatos
{
    public class CD_Personas : CD_Conexion
    {

        #region ATRIBUTOS
        private string ayn;
        private int idpersona;
        private string apellido;
        private string nombre;
        private int tipodoc;
        private int nrodoc;
        private string telefono;
        private string correo;
        private string calle;
        private string nro;
        private string piso;
        private string dto;
        private int idlocalidad;
        private int idprovincia;
        #endregion

        #region PROPERTIES

        public string AyN
            {
                set { ayn = value; }
            }

        public int IdPersona
        {
            get => idpersona; //Expresion Lambda (Se suprime el Return y las llaves)
            set { idpersona = value; }
        }

        public string Apellido 
        {
            get => apellido; 
            set {apellido = value;}
        }

        public string Nombre
        {
            get => nombre;
            set {nombre = value;}
        }

        public int TipoDoc
        {
            get => tipodoc;
            set {tipodoc = value;}
        }

        public int NroDoc
        {
            get => nrodoc; 
            set {nrodoc = value;}
        }

        public string Telefono
        {
            get => telefono; 
            set {telefono = value;}
        }

        public string Correo
        {
            get => correo;
            set {correo = value;}
        }

        public string Calle
        {
            get => calle;
            set {calle = value;}
        }

        public string Nro
        {
            get => nro;
            set {nro = value;}
        }

        public string Piso
        {
            get => piso;
            set {piso = value;}
        }

        public string Dto
        {
            get => dto;
            set {dto = value;}
        }

        public int IdLocalidad
        {
            get => idlocalidad;
            set {idlocalidad = value;}
        }

        public int IdProvincia
        {
            get => idprovincia;
            set {idprovincia = value;}
        }
        #endregion

        #region METODOS

        public DataTable BuscarPersona()
        {
            
            string condicion = null;
            if ( !string.IsNullOrEmpty(ayn) )
            {
                condicion = " Personas.Apellido + Personas.Nombre Like '%" + ayn.Trim() + "%'";
            }
            else if (nrodoc != 0)
            {
                condicion = " TipoDoc = " + tipodoc + " and NroDoc =" + nrodoc;
            }

            //Armo la consulta SQL
            string sSql;
            if (condicion == null)
            {
                sSql = "Select * from Personas";
            }
            else
            {
                sSql = "Select * from Personas where " + condicion;
            }
            return EjecutarBusqueda(sSql);
        }

        public DataTable Mostrar()
        {
            string sSql = "Select * from Personas ";
            return EjecutarBusqueda(sSql);
        }

        public void InsertarPersona()
        {
            string sSql = "INSERT INTO Personas " +
               "(Apellido, Nombre, TipoDoc, NroDoc, Telefono, Correo, Calle, Nro, Piso, Dto, IdLocalidad, IdProvincia) " +
                "values" +
                " ('" + apellido + "','" + nombre + "'," + tipodoc + "," + nrodoc +
                ",'" +telefono + "','" + correo + "','" + calle + "','" + nro +
                "','" + piso + "','" + dto + "'," + idlocalidad+ ", " + idprovincia + ")";
            EjecucionDirecta(sSql);
        }

        public void ModificarPersona()
        {
            string sSql = "UPDATE Personas set " +
                "Apellido='" + apellido + "', Nombre='" + nombre  + "', TipoDoc =" + tipodoc  +
                ", NroDoc = " + nrodoc  + ", Telefono = '" + telefono + "', Correo = '" + correo  +
                "', Calle = '" + calle + "', Nro = '" + nro + "', Piso = '" + piso + "', Dto = '" + dto +
                "', IdLocalidad = " + idlocalidad + ", IdProvincia = " + idprovincia  +
                " WHERE Id =" + idpersona;
            EjecucionDirecta(sSql);
        }

        public void EliminarPersona()
        {
            string sSql = "DELETE FROM Personas WHERE Id =" + idpersona;
            EjecucionDirecta(sSql);
        }

        #endregion
    }
}
