using Microsoft.VisualStudio.TestTools.UnitTesting;
using IPS_Mejora_tu_Salud.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPS_Mejora_tu_Salud.Modelo.Tests
{
    [TestClass()]
    public class IPSTests
    {
        IPS ips = new IPS();
        [TestMethod()]
        public void RegistrarPacienteTest()
        {
            //Arrange
            Paciente paciente = new Paciente("98585", "Santiago", "Gómez", "2001-05-19", "calle 80", "5085005", "santigm1905@gmail.com", "2020-04-13");
            int resultado_esperado = 1;
            //Act
            int resultado = ips.RegistrarPaciente(paciente);

            //Assert

            Assert.AreEqual(resultado_esperado, resultado);
        }

        [TestMethod()]
        public void ActualizarPacienteTest()
        {
            //Arrange
            string id = "1111";
            string email = "asdg7@gmail.com";
            string direccion = "romboy";
            string telefono = "3145609";
            int resultado_esperado = 1;

            //Act
            int resultado = ips.ActualizarPaciente(email, direccion, telefono, id);

            //Assert
            Assert.AreEqual(resultado_esperado, resultado);
        }

        [TestMethod()]
        public void ActualizarMedicoTest()
        {
            //Arrange
            string id = "465453";
            string nombre = "Roberto";
            int salario = 4000000;
            int resultado_esperado = 1;

            //Act
            int resultado = ips.ActualizarMedico(nombre, salario, id);

            //Assert

            Assert.AreEqual(resultado_esperado, resultado);
        }
    }
}