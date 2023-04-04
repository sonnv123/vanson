using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using vanson.Authorization.Roles;
using vanson.Authorization.Users;
using vanson.MultiTenancy;
using vanson.Domains.DanhMuc;
using vanson.Domains.DanhMuc.NewFolder;

namespace vanson.EntityFrameworkCore
{
    public class vansonDbContext : AbpZeroDbContext<Tenant, Role, User, vansonDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<DmTinhThanh> DSDmTinhthanh { get; set; }
        public virtual DbSet<DmQuanHuyen> DSDmQuanHuyen { get; set; }
        public vansonDbContext(DbContextOptions<vansonDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
