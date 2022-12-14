using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesC
{
    [Softwareattribute("project description", "projectname", "clientname", "startdate", "enddate")]
    public class iciciaccount
    {
        [Softwareattribute(description = "this is project description")]
            public string projectname { get; set; }
            public string description { get; set; }

            public string clientname { get; set; }

            public string startdate { get; set; }

            public string enddate { get; set; }




            [Softwareattribute(description = "default constructor")]
            public iciciaccount() { }

            [Softwareattribute(description = "paramererised constructor with description")]
            public iciciaccount(string a, string b, string c, string d, string e)
            {
                this.description = a;
                this.projectname = b;
                this.clientname = c;
                this.startdate = d;
                this.enddate = e;

            }



        }
    }


    

