using System;

namespace Scaffolder.Scaffolding
{
    public class JsonController 
    {
        public string databaseContext;
        private const char Open = '{';
        private const char Closed = '}';
        public string UpperCaseClassName {get; set;}
        public string LowerCaseClassName{get; set;}
        public string NameSpace {get; set;}
        
        public override string ToString()
        {
            return string.Format(@" 
namespace {0}
    {3}
        public class {1}Controller : Controller
        {3}
            static readonly I{1}Repository {2}Repository = new {1}Repository();

            public ActionResult {1}()
            {3}
                return View();
            {4}

            public JsonResult GetAll{1}s()
            {3}
                return Json(repository.GetAll(), JsonRequestBehavior.AllowGet);
            {4}

            public JsonResult Add{1}({1} item)
            {3}
                item = repository.Add(item);
                return Json(item, JsonRequestBehavior.AllowGet);
            {4}

            public JsonResult Edit{1}(int id, {1} {2})
            {3}
                {2}.Id = id;
                if (repository.Update({2}))
                {3}
                    return Json(repository.GetAll(), JsonRequestBehavior.AllowGet);
                {4}

                return Json(null);
            {4}

            public JsonResult Delete{1}(int id)
            {3}

                if (repository.Delete(id))
                {3}
                    return Json(new {3} Status = true {4}, JsonRequestBehavior.AllowGet);
                {4}

                return Json(new {3} Status = false {4}, JsonRequestBehavior.AllowGet);{4}
            {4}
        {4}
    {4}"
                , NameSpace, UpperCaseClassName, LowerCaseClassName, Open, Closed);
        }

    }
}