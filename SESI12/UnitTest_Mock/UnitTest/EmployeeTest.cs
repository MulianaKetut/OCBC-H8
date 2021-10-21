using System;
using Moq;
using Xunit;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;

namespace UnitTest
{
    public class EmployeeTest
    {
        #region Property

        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();

        #endregion

        [Fact]
        public async void GetEmployeebyID()
        {
            mock.Setup(p => p.GetEmployeebyId(2)).ReturnsAsync("BAYA");
            EmployeeController emp = new EmployeeController(mock.Object);
            string result = await emp.GetEmployeeById(2);
            Assert.Equal("BAYA", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 2,
                Name = "BAYA",
                Desgination = "Staff"
            };

            mock.Setup(
                p => p.GetEmployeeDetails(2)).ReturnsAsync(employeeDTO);

            EmployeeController emp = new EmployeeController(mock.Object);
            var result = await emp.GetEmployeeDetails(2);

            Assert.True(employeeDTO.Equals(result));

        }
    }
}
