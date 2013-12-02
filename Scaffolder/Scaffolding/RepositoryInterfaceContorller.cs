using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolder.Scaffolding
{
    public class RepositoryInterfaceContorller : Scaffolding
    {
        public override string ToString()
        {
            return string.Format(@"
namespace {0}
{5}   
    public class {1}Controller : Controller
    {5}
        public UnitOfWork unitOfWork = new UnitOfWork();
        public {1}Repository {2}Repository = new {1}Repository(new {3}());
        
        public ViewResult Index()
        {5}
            var viewModel = new {1}ViewModel();
            viewModel.{1} = unitOfWork.{1}Repository.Get();
           
            return View(viewModel);
        {6}

        // GET: /{1}/Details/5
        public ViewResult Details(int id)
        {5}
            return View(unitOfWork.{1}Repository.GetById(id));
        {6}

        // GET: /{1}/Create
        public ActionResult Create()
        {5}
            return View();
        {6} 

        // POST: /{1}/Create
        [HttpPost]
        /*Include Object Properties to Bind*/
        public ActionResult Create (
        [Bind(Include = {4}{1}Id,{4})]{1} {2})
        {5}
            if (ModelState.IsValid) {5}
                unitOfWork.{1}Repository.Insert({2});
                unitOfWork.{1}Repository.Update({2});
                return RedirectToAction({4}Index{4});
            {6} else {5}
				return View();
			{6}
        {6}
        
        // GET: /{1}/Edit/5
 
        public ActionResult Edit(int id)
        {5}
             return View(unitOfWork.{1}Repository.GetById(id));
        {6}

        // POST: /{1}/Edit/5

        [HttpPost]
        public ActionResult Edit({1} {2})
        {5}
            if (ModelState.IsValid) {5}
                unitOfWork.{1}Repository.Update({2});
                unitOfWork.Save();
                return RedirectToAction({4}Index{4});
            {6} else {5}
				return View();
			{6}
        {6}

        // GET: /{1}/Delete/5
 
        public ActionResult Delete(int id)
        {5}
            return View(unitOfWork.{1}Repository.GetById(id));
        {6}

        // POST: /{1}/Delete/5

        [HttpPost, ActionName({4}Delete{4})]
        public ActionResult DeleteConfirmed(int id)
        {5}
            unitOfWork.MealRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction({4}Index{4});
        {6}

        protected override void Dispose(bool disposing)
        {5}
            if (disposing) 
            {5}
                unitOfWork.Dispose();
            {6}
            base.Dispose(disposing);
        {6}
    {6}
{6}

/////////////////////////////////

namespace {0}
{5}
    public interface I{1}Repository : IDisposable
    {5}
        IQueryable<{1}> {1}s {5} get; {6}
        IEnumerable<{1}> Get{1}s();
        {1} Get{1}ById(int? id);
        void Insert{1}({1} id);
        void Delete{1}(int {2}Id);
        void Update{1}({1} {2});
        void Save();
        new void Dispose();
    {6}
{6}
/////////////////////////////////

    public class {1}Repository : I{1}Repository
    {5}
        private {3} context = new {3}();

        public {1}Repository({3} context)
        {5}
            this.context = context;
        {6}

        public IQueryable<{1}> {1}s
        {5}
            get {5} return context.{1}s; {6}
        {6}

        public IEnumerable<{1}> Get{1}s()
        {5}
            return context.{1}s.ToList();
        {6}

        public {1} Get{1}ById(int? id)
        {5}
            return context.{1}s.Find(id);
        {6}

        public void Insert{1}({1} {2})
        {5}
            context.{1}s.Add({2});
        {6}

        public void Delete{1}(int {2}Id)
        {5}
            {1} {2} = context.{1}s.Find({2}Id);
            context.{1}s.Remove({2});
        {6}

        public void Update{1}({1} {2})
        {5}
            context.Entry({2}).State = 
                System.Data.Entity.EntityState.Modified;
        {6}

        public void Save()
        {5}
            context.SaveChanges();
        {6}

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {5}
            if (!disposed)
            {5}
                if (disposing)
                {5}
                    context.Dispose();
                {6}
            {6}
            disposed = true;
        {6}

        public void Dispose()
        {5}
            if (context != null) context.Dispose();
        {6}
    {6}
{6}", NameSpace, UpperCaseClassName, LowerCaseClassName, DatabaseContext, Quote, Open, Close);
        }
    }
}

//﻿using System; 
//using ContosoUniversity.Models; 
 
//namespace ContosoUniversity.DAL 
//{ 
//    public class UnitOfWork : IDisposable 
//    { 
//        private SchoolContext context = new SchoolContext(); 
//        private GenericRepository<Department> departmentRepository; 
//        private CourseRepository courseRepository; 
 
//        public GenericRepository<Department> DepartmentRepository 
//        { 
//            get 
//            { 
 
//                if (this.departmentRepository == null) 
//                { 
//                    this.departmentRepository = new GenericRepository<Department>(context); 
//                } 
//                return departmentRepository; 
//            } 
//        } 
         
//        public CourseRepository CourseRepository 
//        { 
//            get 
//            { 
 
//                if (this.courseRepository == null) 
//                { 
//                    this.courseRepository = new CourseRepository(context); 
//                } 
//                return courseRepository; 
//            } 
//        } 