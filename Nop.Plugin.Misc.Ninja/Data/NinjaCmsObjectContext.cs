using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Nop.Core;
using Nop.Data;
using Nop.Data.Extensions;
using Nop.Plugin.Misc.Ninja.Domain;

namespace Nop.Plugin.Misc.Ninja.Data
{
    public class NinjaCmsObjectContext:DbContext,IDbContext
    {
        public NinjaCmsObjectContext(DbContextOptions<NinjaCmsObjectContext>options):base(options)
        {

        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NinjaMap());
            base.OnModelCreating(modelBuilder);


        }
        public virtual string GenerateCreateScript()
        {
            return Database.GenerateCreateScript();

        }

        public void Install()
        {
            this.ExecuteSqlScript(GenerateCreateScript());
        }

        public void UnInstall()
        {
            this.DropPluginTable(nameof(NinjaCms));
        }
        public new virtual DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public IQueryable<TQuery> QueryFromSql<TQuery>(string sql, params object[] parameters) where TQuery : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> EntityFromSql<TEntity>(string sql, params object[] parameters) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(RawSqlString sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Detach<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
