using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_EmployeesWithGridView
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Id"] == null)
            {
                Response.Redirect("Employees.aspx");
            }

            this.dvEmployees.DataSource = this.GetEmployee(int.Parse(Request.Params["Id"]));
            this.DataBind();
        }

        private List<Employee> GetEmployee(int id)
        {
            using (var db = new NorthwindEntities())
            {
                var employees = db.Employees
                    .Where(e => e.EmployeeID == id)
                    .ToList();

                return employees;
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employees.aspx");
        }
    }
}