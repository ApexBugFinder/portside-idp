using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using IDP.Models;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Design;
using IDP.Services;
namespace IDP.Data
{
public class ApplicationDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
  {
    // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

private  string connect = Helper.GetConnectionString;
// private static readonly DbContextOptions<ApplicationDbContext> options =
//   new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(connect).Options;

    // private static readonly Lazy<ApplicationDbContext> lazy = new Lazy<ApplicationDbContext>(() => new ApplicationDbContext(options));

    // public static ApplicationDbContext Instance
    // {
    //   get
    //   {
    //     return lazy.Value;
    //   }
    // }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public ApplicationDbContext(string connectionString) {

    }

    public ApplicationDbContext(DbSet<User> aspNetUsers, DbSet<Role> aspNetRoles, DbSet<UserRole> aspNetUserRoles, DbSet<UserLogin> aspNetUserLogins, DbSet<UserClaim> aspNetUserClaims, DbSet<UserToken> aspNetUserTokens, DbSet<RoleClaim> aspNetRoleClaims, DbSet<User> users, DbSet<UserClaim> userClaims, DbSet<UserLogin> userLogins, DbSet<UserToken> userTokens, DbSet<UserRole> userRoles, DbSet<Role> roles, DbSet<RoleClaim> roleClaims)
    {
      AspNetUsers = aspNetUsers;
      AspNetRoles = aspNetRoles;
      AspNetUserRoles = aspNetUserRoles;
      AspNetUserLogins = aspNetUserLogins;
      AspNetUserClaims = aspNetUserClaims;
      AspNetUserTokens = aspNetUserTokens;
      AspNetRoleClaims = aspNetRoleClaims;
      Users = users;
      UserClaims = userClaims;
      UserLogins = userLogins;
      UserTokens = userTokens;
      UserRoles = userRoles;
      Roles = roles;
      RoleClaims = roleClaims;
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<User>().ToTable("AspNetUsers").HasKey(p => p.Id);
        builder.Entity<Role>().ToTable("AspNetRoles").HasKey(p => p.Id);

        builder.Entity<UserRole>().ToTable("AspNetUserRoles").HasKey(p => new { p.UserId, p.RoleId });
        builder.Entity<UserLogin>().ToTable("AspNetUserLogins").HasKey(p => new { p.LoginProvider, p.ProviderKey});
        builder.Entity<UserClaim>().ToTable("AspNetUserClaims").HasKey(p => p.Id);
        builder.Entity<UserToken>().ToTable("AspNetUserTokens").HasKey(p => new { p.UserId, p.LoginProvider, p.Name});
        builder.Entity<RoleClaim>().ToTable("AspNetRoleClaims").HasKey(p => p.Id);


      base.OnModelCreating(builder);
    }

    public override DbSet<TEntity> Set<TEntity>()
    {
      return base.Set<TEntity>();
    }

    public override DbSet<TEntity> Set<TEntity>(string name)
    {
      return base.Set<TEntity>(name);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

      base.OnConfiguring(optionsBuilder);
    }

    public override int SaveChanges()
    {
      return base.SaveChanges();
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
      return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
      return base.SaveChangesAsync(cancellationToken);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
      return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public override void Dispose()
    {
      base.Dispose();
    }

    public override ValueTask DisposeAsync()
    {
      return base.DisposeAsync();
    }

    public override EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
    {
      return base.Entry(entity);
    }

    public override EntityEntry Entry(object entity)
    {
      return base.Entry(entity);
    }

    public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
    {
      return base.Add(entity);
    }

    public override ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default)
    {
      return base.AddAsync(entity, cancellationToken);
    }

    public override EntityEntry<TEntity> Attach<TEntity>(TEntity entity)
    {
      return base.Attach(entity);
    }

    public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
    {
      return base.Update(entity);
    }

    public override EntityEntry<TEntity> Remove<TEntity>(TEntity entity)
    {
      return base.Remove(entity);
    }

    public override EntityEntry Add(object entity)
    {
      return base.Add(entity);
    }

    public override ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default)
    {
      return base.AddAsync(entity, cancellationToken);
    }

    public override EntityEntry Attach(object entity)
    {
      return base.Attach(entity);
    }

    public override EntityEntry Update(object entity)
    {
      return base.Update(entity);
    }

    public override EntityEntry Remove(object entity)
    {
      return base.Remove(entity);
    }

    public override void AddRange(params object[] entities)
    {
      base.AddRange(entities);
    }

    public override Task AddRangeAsync(params object[] entities)
    {
      return base.AddRangeAsync(entities);
    }

    public override void AttachRange(params object[] entities)
    {
      base.AttachRange(entities);
    }

    public override void UpdateRange(params object[] entities)
    {
      base.UpdateRange(entities);
    }

    public override void RemoveRange(params object[] entities)
    {
      base.RemoveRange(entities);
    }

    public override void AddRange(IEnumerable<object> entities)
    {
      base.AddRange(entities);
    }

    public override Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default)
    {
      return base.AddRangeAsync(entities, cancellationToken);
    }

    public override void AttachRange(IEnumerable<object> entities)
    {
      base.AttachRange(entities);
    }

    public override void UpdateRange(IEnumerable<object> entities)
    {
      base.UpdateRange(entities);
    }

    public override void RemoveRange(IEnumerable<object> entities)
    {
      base.RemoveRange(entities);
    }

    public override object Find(Type entityType, params object[] keyValues)
    {
      return base.Find(entityType, keyValues);
    }

    public override ValueTask<object> FindAsync(Type entityType, params object[] keyValues)
    {
      return base.FindAsync(entityType, keyValues);
    }

    public override ValueTask<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken)
    {
      return base.FindAsync(entityType, keyValues, cancellationToken);
    }

    public override TEntity Find<TEntity>(params object[] keyValues)
    {
      return base.Find<TEntity>(keyValues);
    }

    public override ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues)
    {
      return base.FindAsync<TEntity>(keyValues);
    }

    public override ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken)
    {
      return base.FindAsync<TEntity>(keyValues, cancellationToken);
    }

    public override IQueryable<TResult> FromExpression<TResult>(Expression<Func<IQueryable<TResult>>> expression)
    {
      return base.FromExpression(expression);
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public DbSet<User> AspNetUsers {get; set;}
    public DbSet<Role> AspNetRoles {get; set;}
    public DbSet<UserRole> AspNetUserRoles {get; set;}
    public DbSet<UserLogin> AspNetUserLogins {get; set;}
    public DbSet<UserClaim> AspNetUserClaims {get; set;}
    public DbSet<UserToken> AspNetUserTokens {get; set;}
    public DbSet<RoleClaim> AspNetRoleClaims {get; set;}

    public override DatabaseFacade Database => base.Database;

    public override ChangeTracker ChangeTracker => base.ChangeTracker;

    public override IModel Model => base.Model;

    public override DbContextId ContextId => base.ContextId;

    public override DbSet<User> Users { get => base.Users; set => base.Users = value; }
    public override DbSet<UserClaim> UserClaims { get => base.UserClaims; set => base.UserClaims = value; }
    public override DbSet<UserLogin> UserLogins { get => base.UserLogins; set => base.UserLogins = value; }
    public override DbSet<UserToken> UserTokens { get => base.UserTokens; set => base.UserTokens = value; }
    public override DbSet<UserRole> UserRoles { get => base.UserRoles; set => base.UserRoles = value; }
    public override DbSet<Role> Roles { get => base.Roles; set => base.Roles = value; }
    public override DbSet<RoleClaim> RoleClaims { get => base.RoleClaims; set => base.RoleClaims = value; }
  }

//   User,
//   Role,
//   Guid,
//   UserLogin,
//   UserRole,
//   UserClaim
//   public class GuidUserStore : UserStore<User, Role, DbContext, Guid>
//   {
//     public GuidUserStore(DbContext context, IdentityErrorDescriber describer = null)
//         : base(context)
//     {
//     }
//   }
  public class GuidRoleStore : RoleStore <Role, DbContext, Guid>
  {
    public GuidRoleStore(DbContext context, IdentityErrorDescriber describer = null)
        : base(context)
    {
    }
  }
    // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    //     protected override void OnModelCreating(ModelBuilder builder)
    //     {
    //          builder.Entity<User>().ToTable("AspNetUsers");
    //         // builder.Entity<IdentityRole<string>>().ToTable("AspNetRoles").Property(p => p.Id).ValueGeneratedOnAdd();

    //         // builder.Entity<IdentityUserClaim<string>>().ToTable("AspNetUserClaims").Property(p => p.Id).ValueGeneratedOnAdd();
    //         // builder.Entity<IdentityUserLogin<string>>().ToTable("AspNetUserLogins");
    //         // builder.Entity<IdentityUserRole<string>>().ToTable("AspNetUserRoles");
    //         // builder.Entity<IdentityUserToken<string>>().ToTable("AspNetUserTokens");
    //         // builder.Entity<IdentityRoleClaim<string>>().ToTable("AspNetRoleClaims").Property(p => p.Id).ValueGeneratedOnAdd();

    //         base.OnModelCreating(builder);
    //         // Customize the ASP.NET Identity model and override the defaults if needed.
    //         // For example, you can rename the ASP.NET Identity table names and more.
    //         // Add your customizations after calling base.OnModelCreating(builder);
    //         // builder.Entity<ApplicationUser>()
    //         // .Property(b => b.IsActive).HasColumnName("IsActive");
    //     //    builder.Entity<ApplicationUser>().HasMany(u => u.Claims).WithOne(uc => uc.User);
    //     //   builder.Entity<ApplicationUser>().HasMany(u => u.Logins).WithOne(ul => ul.User);
    //         // builder.Entity<UserClaim>().Property(uc => uc.Id).ValueGeneratedOnAdd();
    //         // builder.Entity<UserLogin>().Property(ul => ul.Id).ValueGeneratedOnAdd();
    //     }
    //     public DbSet<User> AspNetUsers { get; set; }
    //     // public DbSet<UserClaim> Claims {get; set;}
    //     // public DbSet<UserLogin> Logins {get; set;}
    // }


public class ApplicationDBContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
{
  public ApplicationDbContext CreateDbContext(string[] args) {
    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
    optionsBuilder.UseSqlServer(Helper.GetConnectionString);
    return new ApplicationDbContext(optionsBuilder.Options);
  }
}
}