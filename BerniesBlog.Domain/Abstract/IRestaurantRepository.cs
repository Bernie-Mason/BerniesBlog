using BerniesBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerniesBlog.Domain.Abstract
{
    public interface IRestaurantRepository : IDisposable
    {

        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<RestaurantReviews> Reviews { get; set; }
        DbSet Set(Type entityType);
        int SaveChanges();
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
         

        //string ConnectionString { get; set; }
        //bool AutoDetectChangedEnabled { get; set; }
        //void ExecuteSqlCommand(string p, params object[] o);
        //void ExecuteSqlCommand(string p);
        //IEnumerable<Restaurant> Restaurants { get; }
        /*This is the interface maintains a degree of
         * separation between the data model entities
         * and the storage and retrieval logic. 
         * 
         */
    }
}
