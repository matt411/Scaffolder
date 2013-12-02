namespace Scaffolder.Scaffolding
{
    public class Repository: Scaffolding
    {
        public override string ToString()
        {
            return string.Format(@" 
//namespace = {0}
//uppercase entity name = {1}
//lowercase entity name = {2}
//dbContext (if applicable) = {3}
//open = {3}
//closed = {4}
/*begin scaffold*/namespace {0}
{3}
    public class {1}Repository : I{1}Repository
    {3}
        private {3} context = new {3}();

        public {1}Repository()
        {3}
            
        {4}
        public {1}Repository({3} context)
        {3}
            this.context = context;
        {4}
        public IQueryable<{1}> {1}s
        {3}
            get {3} return context.{1}s; {4}
        {4}
        public IEnumerable<{1}> Get{1}s()
        {3}
            return context.{1}s.ToList();
        {4}
        public {1} Get{1}ById(int? id)
        {3}
            return context.{1}s.Find(id);
        {4}
        public void Insert{1}({1} {2})
        {3}
            context.{1}s.Add({2});
        {4}
        public void Delete{1}(int {2}Id)
        {3}
            {1} {2} = context.{1}s.Find({2}Id);
            context.{1}s.Remove({2});
        {4}
        public void Update{1}({1} {2})
        {3}
            context.Entry({2}).State = EntityState.Modified;
        {4}
        public void Save()
        {3}
            context.SaveChanges();
        {4}
        private bool disposed;
        protected virtual void Dispose(bool disposing)
        {3}if (!disposed)
            {3}
                if (disposing)
                {3}
                    context.Dispose();
                {4}
            {4}
            disposed = true;
        {4}

        public void Dispose()
        {3}
            if (context != null) context.Dispose();
        {4}
    {4}
{4}"
            , NameSpace, UpperCaseClassName, LowerCaseClassName,  Open, Close);
        }
    }
}