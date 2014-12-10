using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04_Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var firstName = this.TextBoxFirstName.Text;
            var lastName = this.TextBoxLastName.Text;
            var facultyNumber = this.TextBoxFacultyNumber.Text;
            var university = this.ddlUniversity.SelectedValue;
            var specialty = this.ddlSpecialty.SelectedValue;
            var courses = this.cblCourses.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .Select(li => li.Value)
                .ToList();

            this.LabelResult.Text = "<h2>Summary</h2>";
            this.LabelResult.Text += "<p>";
            this.LabelResult.Text += firstName + " " + lastName + " with faculty number: " + facultyNumber;
            this.LabelResult.Text += "<br /> University: " + university;
            this.LabelResult.Text += "<br /> Specialty: " + specialty;
            this.LabelResult.Text += "<br /> Courses: " + string.Join(", ", courses);
            this.LabelResult.Text += "</p>";
        }
    }
}