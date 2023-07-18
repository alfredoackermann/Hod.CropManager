using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using CropManager.Domain;
using Volo.Abp.EntityFrameworkCore.Modeling;
using System.Reflection.Emit;
using System.Linq;

namespace Hod.CropManager.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CropManagerDbContext :
    AbpDbContext<CropManagerDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Crop> Crops { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<CropType> CropTypes { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Field> Fields { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<IrrigationSystem> IrrigationSystems { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Harvest> Harvests { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<CropIssue> CropIssues { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Equipment> Equipment { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<GrowthStage> GrowthStages { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<CropRotation> CropRotations { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<FertilizationSchedule> FertilizationSchedules { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<IrrigationSchedule> IrrigationSchedules { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<LandPreparation> LandPreparations { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<PesticideSchedule> PesticideSchedules { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<IssueType> IssueTypes { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Fertilizer> Fertilizers { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Pesticide> Pesticides { get; set; }

    public CropManagerDbContext(DbContextOptions<CropManagerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();
        
        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(CropManagerConsts.DbTablePrefix + "YourEntities", CropManagerConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});


        builder.Entity<Crop>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Crops", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<CropType>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "CropTypes", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<Field>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Fields", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<IrrigationSystem>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "IrrigationSystems", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<Harvest>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Harvests", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<CropIssue>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "CropIssues", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<Equipment>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Equipment", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<GrowthStage>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "GrowthStages", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<CropRotation>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "CropRotations", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<FertilizationSchedule>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "FertilizationSchedules", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<IrrigationSchedule>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "IrrigationSchedules", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });

        builder.Entity<LandPreparation>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "LandPreparations", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<PesticideSchedule>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "PesticideSchedules", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<IssueType>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "IssueTypes", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<Fertilizer>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Fertilizers", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention(); 
            

            /* Configure more properties here */
        });


        builder.Entity<Pesticide>(b =>
        {
            b.ToTable(CropManagerConsts.DbTablePrefix + "Pesticides", CropManagerConsts.DbSchema, table => table.HasComment(""));
            b.ConfigureByConvention();


            /* Configure more properties here */
        });


        var cascadeFKs = builder.Model.GetEntityTypes()
            .Where(t => !t.GetTableName().StartsWith("Abp"))
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
            fk.DeleteBehavior = DeleteBehavior.Restrict;
    }
}
