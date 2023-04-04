using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using vanson.EntityFrameworkCore;
using vanson.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace vanson.Web.Tests
{
    [DependsOn(
        typeof(vansonWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class vansonWebTestModule : AbpModule
    {
        public vansonWebTestModule(vansonEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(vansonWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(vansonWebMvcModule).Assembly);
        }
    }
}