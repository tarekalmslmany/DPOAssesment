using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DPOAssesment.Models;

namespace DPOAssesment.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var Orders = new List<Order>
            {
                new Order
                {
                    Status = Status.Open,Price = 0 , SubTotal=0 
                }
            };
            Orders.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();

            var Comments = new List<Comment>
            {
                new Comment
                {
                    CommntText= "test message", OrderStatus = OrderStatus.Open , SourceApplication = SourceApplication.DMS , UserName= "Tarek", OrderId= 1
                }
            };
            Comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}