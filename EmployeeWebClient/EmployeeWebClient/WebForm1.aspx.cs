using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new
                EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = client.GetEmployee(Convert.ToInt32(txtId.Text));
            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();

            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.Employee employee = new EmployeeService.Employee();
            employee.ID = Convert.ToInt32(txtId.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee saved";
        }
    }
}