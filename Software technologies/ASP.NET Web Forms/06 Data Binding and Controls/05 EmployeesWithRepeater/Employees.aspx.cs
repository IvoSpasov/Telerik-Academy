using Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05_EmployeesWithRepeater
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            this.RepeaterEmployees.DataSource = this.GetAllEmployees();
            this.RepeaterEmployees2.DataSource = this.GetAllEmployees();
            this.DataBind();
        }

        private List<Employee> GetAllEmployees()
        {
            using (var db = new NorthwindEntities())
            {
                var employees = db.Employees
                    .ToList();

                return employees;
            }
        }
    }
}