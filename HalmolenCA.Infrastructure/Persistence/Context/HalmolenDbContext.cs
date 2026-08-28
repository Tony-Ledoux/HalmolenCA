using HalmolenCA.Application.Interfaces;
using HalmolenCA.Domain.Entities.Facilities;
using Microsoft.EntityFrameworkCore;

namespace HalmolenCA.Infrastructure.Persistence.Context;

public class HalmolenDbContext(DbContextOptions<HalmolenDbContext> options) : DbContext(options), IUnitOfWork
{

    public DbSet<Floor> Floors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HalmolenDbContext).Assembly);
    }

    void IUnitOfWork.Add<TEntity>(TEntity entity)
    {
        Set<TEntity>().Add(entity);
    }

    void IUnitOfWork.Remove<TEntity>(TEntity entity)
    {
        Set<TEntity>().Remove(entity);
    }
}