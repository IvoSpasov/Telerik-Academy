using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_CarSearch
{
    public partial class CarSearch : System.Web.UI.Page
    {
        private static List<Model> audiModels = new List<Model>
            {
                new Model(){Name="A1"},
                new Model(){Name="A2"},
                new Model(){Name="A3"},
                new Model(){Name="A4"},
                new Model(){Name="A5"},
                new Model(){Name="A6"},
                new Model(){Name="A7"},
                new Model(){Name="A8"}
            };

        private static List<Model> bmwModels = new List<Model>
            {
                new Model(){Name="X6"},
                new Model(){Name="M3"},
                new Model(){Name="M4"},
                new Model(){Name="M5"},
                new Model(){Name="M6"},
                new Model(){Name="Z3"},
                new Model(){Name="Z4"}
            };

        private static List<Model> lexusModels = new List<Model> 
            { 
                new Model(){Name="LFA"},
                new Model(){Name="IS"},
                new Model(){Name="GS"},
                new Model(){Name="LS"},
                new Model(){Name="ES"}
            };


        private List<Producer> producers = new List<Producer>
            {
                new Producer(){Name="Audi", Models=audiModels},
                new Producer(){Name="BMW", Models=bmwModels},
                new Producer(){Name="Lexus", Models=lexusModels}
            };

        private List<Extra> extras = new List<Extra>()
        {
            new Extra(){Name="Aircon"},
            new Extra(){Name="ABS"},
            new Extra(){Name="TCS"},
            new Extra(){Name="Airbags"},
            new Extra(){Name="GPS"},
            new Extra(){Name="And so much more"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            string[] engineTypes = new string[] 
            {
                "Gasoline", "Diesel", "Hybrid", "Electric"
            };

            this.ddlProducer.DataSource = this.producers;
            this.ddlProducer.DataBind();
            this.ddlModel.DataSource = this.GetModelsForCurrentProducer();
            this.cblExtras.DataSource = this.extras.Select(ex => ex.Name);
            this.rblEngines.DataSource = engineTypes;
            this.DataBind();
        }
        
        protected void ddlProducer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlModel.DataSource = this.GetModelsForCurrentProducer();
            this.ddlModel.DataBind();
        }

        private IEnumerable GetModelsForCurrentProducer()
        {
            var modelsForCurrentManufacturer = this.producers
                .Where(p => p.Name == this.ddlProducer.SelectedValue)
                .Select(p => p.Models)
                .FirstOrDefault()
                .Select(m => m.Name);

            return modelsForCurrentManufacturer;
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("<br />Form result:<br />");
            result.AppendLine("<b>Car Manufacturer:</b> " + this.ddlProducer.SelectedValue + "<br />");
            result.AppendLine("<b>Car Model:</b> " + this.ddlModel.SelectedValue + "<br />");
            result.AppendLine("<b>Extras:</b>");

            var checkedExtras = new List<string>();
            for (int i = 0; i < this.cblExtras.Items.Count; i++)
            {
                if (this.cblExtras.Items[i].Selected)
                {
                    checkedExtras.Add(this.cblExtras.Items[i].Text);
                }
            }

            result.AppendLine(string.Join(", ", checkedExtras) + "<br />");
            result.AppendLine("<b>Engine type: </b>" + this.rblEngines.Text);

            this.LiteralResult.Text = result.ToString();
        }
    }
}