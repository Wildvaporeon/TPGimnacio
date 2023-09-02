using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private CD_Clientes clientes; // Declaración de la instancia CD_Clientes





        [TestInitialize]
        public void SetUp()
        {
            clientes = new CD_Clientes(); // Inicializar la instancia antes de cada prueba
        }

        public void MiPrueba()
        {
            // Ahora puedes usar 'clientes' en esta prueba
            DataTable resultado = clientes.Mostrar();

            // Realizar las aserciones necesarias
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void PruebaBuscarDniExistente()
        {
            
            CD_Clientes clientes = new CD_Clientes();

           
            int dniExistente = 33587282;

            // Llama al método BuscarDni con el DNI válido
            var resultado = clientes.BuscarDni(dniExistente);

            // Verifica que el resultado no sea nulo y que contenga al menos una fila (cliente encontrado)
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Rows.Count > 0);
        }

        [TestMethod]
        public void PruebaBuscarIDxistente()
        {

            CD_Clientes clientes = new CD_Clientes();


            int IDexistente = 5;

            var resultado = clientes.BuscarCliente(IDexistente);
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Rows.Count > 0);
        }

        [TestMethod]
        public void BuscarDni_DebeRetornarDataTableConDatosSiExisteClienteConEseDni()
        {

            int dniExistente = 38498049;


            DataTable resultado = clientes.BuscarDni(dniExistente);
            Assert.IsNotNull(resultado);
            Assert.IsInstanceOfType(resultado, typeof(DataTable));
            Assert.AreNotEqual(0, resultado.Rows.Count);
        }

        [TestMethod]
        public void PruebaEliminarCliente()
        {
            CD_Clientes clientes = new CD_Clientes();
            int idCliente = 16;
            clientes.Eliminar(idCliente);

            // Verifica que el cliente se haya eliminado correctamente
            var resultado = clientes.BuscarCliente(idCliente);
            Assert.IsNotNull(resultado);
            Assert.AreEqual(0, resultado.Rows.Count);
        }

        [TestMethod]
        public void Insertar_DebeInsertarUnClienteEnLaBaseDeDatos()
        {
            // Arrange: Datos del cliente a insertar
            string nombre = "Jose";
            string apellido = "Perez";
            string direccion = "tucuman 1370";
            string localidad = "turdera";
            string provincia = "buenos aires";
            int dni = 38498049;
            DateTime fechaNac = new DateTime(1994, 8, 22);
            string genero = "masculino";
            int celular = 1150505050;
            int telefono = 1150505050;
            string email = "aranda22@gmail.com";
            string abono = "oro";
            byte[] xfoto = { 0xFF, 0xD8, 0xFF, 0xE0 }; ;
            DateTime aptoFisico = DateTime.Now;
               

            
            clientes.Insertar(nombre, apellido, direccion, localidad, provincia, dni, fechaNac, genero, celular, telefono, email, abono, xfoto, aptoFisico );

            // Assert: Verificar si el cliente se insertó correctamente

            DataTable clienteInsertado = ObtenerClientePorNombreApellido(nombre, apellido); // Define esta función para obtener el cliente por su nombre y apellido
            Assert.IsNotNull(clienteInsertado);
            Assert.AreEqual(1, clienteInsertado.Rows.Count);
        }

        private DataTable ObtenerClientePorNombreApellido(string nombre, string apellido)
        {

            throw new NotImplementedException();
        }
    }
}
