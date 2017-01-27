namespace BerniesBlog.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BerniesBlog.Models.RestaurantReviewsDB>
    {
        // This class is about controlling migrations: how you want it to perform and when you want it to run.
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BerniesBlog.Models.RestaurantReviewsDB";
        }

        protected override void Seed(BerniesBlog.Models.RestaurantReviewsDB context)
        {
            // Basically where you can tell the entity framework to populate the database with some initial data
            // Every time it goes to update the database it's going  to invoke this seed method
            // static List<RestaurantReviews> _reviews = new List<RestaurantReviews>



            context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant
            {
                Name = "WokyKo", // If this already exists, AddOrUpdate does nothing, if none of the data is changed
                City = "Bristol",
                Country = "UK",
                Reviews = new List<RestaurantReviews>
                {
                    new RestaurantReviews {
                Rating = 8, Body="Bao bun heaven"}
                }
            },
            new Restaurant
            {
                Name = "Mountain Sun",
                City = "Boulder",
                Country = "US",
                Reviews = new List<RestaurantReviews>
                {
                    new RestaurantReviews {
                Rating = 7, Body="Great Nachos"}
                }
            },
             new Restaurant
             {
                 Name = "Stieglbrau",
                 City = "Salzburg",
                 Country = "Austria",
                 Reviews = new List<RestaurantReviews>
                {
                    new RestaurantReviews {
                Rating = 8, Body="Death by Stiegl Snack"}
                }
             },
             new Restaurant
             {
                 Name = "Ferdinand's",
                 City = "Prague",
                 Country = "Czech Republic",
                 Reviews = new List<RestaurantReviews>
                {
                    new RestaurantReviews {
                Rating = 9, Body="The greatest goulash"}
                }
             });

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name, new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "Kaladesh" });
            }
            
        }
    }
}