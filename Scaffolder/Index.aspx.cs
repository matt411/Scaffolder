using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Scaffolder.Scaffolding;

namespace Scaffolder
{
    public partial class Index : System.Web.UI.Page
    {
        private string className;
        private string nameSpace;

        private string UppercaseFirst(string s)
        {
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                return char.ToUpper(s[0]) + s.Substring(1);
            }
        }

        public string NameSpace
        {
            get { return nameSpace; }
            set { nameSpace = value; }
        }

        public string UpperCaseClassName { get; set; }
        public string LowerCaseClassName { get; set; }
        public string DatabaseContext { get; set; }

        //Json Controller Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            JsonController cma = new JsonController(); //naming convention revrsed 
            className = TextBox1.Text;
            cma.LowerCaseClassName = className.ToLower();
            cma.UpperCaseClassName = UppercaseFirst(className);
            cma.databaseContext = TextBox3.Text;
            cma.NameSpace = TextBox2.Text;
            try
            {
                Label1.Text = cma.ToString();
            }
            catch (HttpRequestValidationException)
            {
            }
        }
        //Entity Repository
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Repository repo = new Repository();
            nameSpace = TextBox2.Text;
            className = TextBox1.Text;
            repo.LowerCaseClassName = className.ToLower();
            repo.UpperCaseClassName = UppercaseFirst(className);
            repo.NameSpace = UppercaseFirst(className);
           // repo.DatabaseContext = TextBox4.Text;
            try
            {
                Label1.Text = repo.ToString();
            }
            catch (HttpRequestValidationException)
            {

            }
        }

        //repo interface
            protected void Button3_Click (object sender, EventArgs e)
            {
                RepositoryInterface ri = new RepositoryInterface();   
                nameSpace = TextBox2.Text;
                className = TextBox1.Text;
                ri.UpperCaseClassName = UppercaseFirst(className);
                ri.NameSpace = UppercaseFirst(nameSpace);
                try
                {
                    Label1.Text = ri.ToString();
                }
                catch (HttpRequestValidationException)
                {

                }
            }
        
            private string modelInput = "";
            private string nameS = "";
            private string context = "";

            protected void Button4_Click(object sender, EventArgs e)
            {
                IRepoController ric = new IRepoController();
                nameS = TextBox2.Text;
                modelInput = TextBox1.Text;
                context = TextBox3.Text;
                ric.NameSpace = nameS;
                ric.DatabaseContext = context;
                ric.UpperCaseClassName = UppercaseFirst(modelInput);
                ric.LowerCaseClassName = modelInput.ToLower();
                Label1.Text = ric.ToString();
            }
        }
    }

