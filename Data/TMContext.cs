using System;
using System.Data.Entity;
using System.Linq;
using TM.Data.Interfaces;
using TM.Data.Models;

namespace TM.Data
{
    public class TMContext : DbContext
    {
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<AppLogon> AppLogons { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppEntityRole> AppEntityRoles { get; set; }
        public DbSet<AppUserFacility> AppUserFacilities { get; set; }
        public DbSet<Facility> Facilities { get; set; }



        public TMContext() : base("name=TMContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(c => c.Ignore("IsDirty"));

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach(var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added || e.State == EntityState.Modified))
                .Select(e => e.Entity as IModificationHistory))
            {
                history.DateModified = DateTime.Now;
                if(history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }

            int result =  base.SaveChanges();

            foreach(var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory)
                .Select(e => e.Entity as IModificationHistory))
            {
                history.IsDirty = false;
            }

            return result;
        }



    }

}