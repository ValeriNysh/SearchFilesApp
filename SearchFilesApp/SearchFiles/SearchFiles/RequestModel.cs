using System;
using System.Data.Entity;
using System.Linq;

namespace SearchFiles
{
    public class RequestModel : DbContext
    {
        // Your context has been configured to use a 'RequestModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SearchFiles.RequestModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RequestModel' 
        // connection string in the application configuration file.
        public RequestModel() : base("name=RequestModel")
        {
        }
        public virtual DbSet<RequestString> RequestString { get; set; }
        public virtual DbSet<RequestPath> RequestPath { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RequestString>().HasKey(x => x.RequestId);
            modelBuilder.Entity<RequestPath>().HasKey(x => x.PathId);
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}