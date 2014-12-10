using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_CarSearch
{
    public class Producer
    {
        private IEnumerable<Model> models;

        public Producer()
        {
            this.models = new List<Model>();
        }

        public string Name { get; set; }

        //public string Models { get; set; }

        public IEnumerable<Model> Models
        {
            get { return this.models; }
            set { this.models = value; }
        }
    }
}