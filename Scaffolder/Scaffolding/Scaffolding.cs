using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolder.Scaffolding
{
    public class Scaffolding
    {

        public string NameSpace { get; set; }
        public string ClassName { get; set; }
        public string UpperCaseClassName { get; set; }
        public string LowerCaseClassName { get; set; }
        public string DatabaseContext { get; set; }
        public string ModelInput { get; set; }
       
        public char Open
        {
            get
            {
                return '{';
            }
            set
            {
                value = '{';
            }
        }
        
        public char Close
        {
            get
            {
                return '}';
            }
            set
            {
                value = '}';
            }
        }
        public char Quote
        {
            get
            {
                return '"';
            }
            set
            {
                value = '"';
            }
        }




        public string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}