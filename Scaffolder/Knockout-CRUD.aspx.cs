using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Scaffolder.Scaffolding;

namespace Scaffolder
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string UpperCaseClassName { get; set; }
        public string LowerCaseClassName { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            KnockoutCrud koc = new KnockoutCrud();
            koc.UpperCaseClassName = UppercaseFirst(TextBox2.Text);
            koc.LowerCaseClassName = TextBox2.Text.ToLower();
            koc.Attribute2 = TextBox1.Text;
            koc.Attribute3 = TextBox4.Text;
            koc.Attribute4 = TextBox5.Text;
            TextBox6.Text = koc.ToString();
        }
    }
}