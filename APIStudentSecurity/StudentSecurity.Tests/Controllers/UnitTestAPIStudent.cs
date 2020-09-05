using System;
using APIStudentSecurity.Controllers;
using APIStudentSecurity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace StudentSecurity.Tests.Controllers
{   [TestClass]
    public class UnitTestAPIStudent
    {
        [TestMethod]
        public void TestGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController(); //objeto

            //Act
            var listaEstudiantes = studentsController.GetStudents();

            //Assert
            Assert.IsNotNull(listaEstudiantes);

        }
    }
}
