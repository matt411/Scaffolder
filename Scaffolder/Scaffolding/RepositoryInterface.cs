using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolder.Scaffolding
{
    public class RepositoryInterface : Scaffolding
    {
       
        //private const char Open = '{';
        //private const char Close = '}';
        //private const char Quote = '"';
        //public string UpperCaseClassName { get; set; }
        //public string NameSpace { get; set; }
        //public string DatabaseContext { get; set; }
        //public string LowerCaseClassName { get; set; }


        public override string ToString()
        {
            return string.Format(@"
//WebAPI or Json
namespace {0}
{2}
    public interface I{1}Repository
    {2}
        IEnumerable GetAll();
        {1} Get(int id);
        {1} Add({1} item);
        bool Update({1} item);
        bool Delete(int id); 
    {3}
{3}   

// Unit of Work
namespace {0}
{2}
    public interface I{1}Repository
    {2}
        IQueryable<{1}> Meals {2} get;{3}
        IEnumerable<{4}l> GetAll();
        {1} GetById(int? id);
        void Insert({1} id);
        void Delete(int {4}Id);
        void Update({1} {4});
        void Save();
        void Dispose();
    {3}
{3}"


,NameSpace,UpperCaseClassName, Open,Close,LowerCaseClassName);
        }
    }
}