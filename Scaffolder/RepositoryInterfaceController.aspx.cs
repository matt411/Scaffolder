using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scaffolder.Scaffolding;
using System.Web.UI.WebControls;

namespace Scaffolder
{
    public partial class RepositoryInterfaceController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public string NameSpace { get; set; }
        public string UpperCaseClassName { get; set; }
        public string LowerCaseClassName { get; set; }
        public string DatabaseContext { get; set; }
        public string ModelInput { get; set; }
        private string modelInput = "";
        private string nameS = "";
        private string context = "";

        protected void Button1_Click(object sender, EventArgs e)
        {
            RepositoryInterfaceController ric = new RepositoryInterfaceController();
            nameS= TextBox1.Text;
            modelInput= TextBox2.Text;
            context = TextBox3.Text;
            ric.NameSpace = nameS;
            ric.DatabaseContext = context;
            ric.UpperCaseClassName = UppercaseFirst(modelInput);
            ric.LowerCaseClassName = modelInput.ToLower();
            Label2.Text = ric.ToString();
        }
    }
}

