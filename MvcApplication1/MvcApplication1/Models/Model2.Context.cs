﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class testdbEntities2 : DbContext
    {
        public testdbEntities2()
            : base("name=testdbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<data> data { get; set; }
        public DbSet<dataTemplate> dataTemplate { get; set; }
    
        public virtual ObjectResult<spData_Result> spData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spData_Result>("spData");
        }
    }
}
