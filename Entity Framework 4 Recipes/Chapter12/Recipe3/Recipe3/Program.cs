﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;

namespace Recipe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleanup();
            RunExample();
        }

        static void Cleanup()
        {
            using (var context = new EFRecipesEntities())
            {
                context.ExecuteStoreCommand("delete from chapter12.donation");
            }
        }

        static void RunExample()
        {
            using (var context = new EFRecipesEntities())
            {
                context.Donations.AddObject(new Donation { DonorName = "Robert Byrd", Amount = 350M });
                context.Donations.AddObject(new Donation { DonorName = "Nancy McVoid", Amount = 250M });
                context.Donations.AddObject(new Donation { DonorName = "Kim Kerns", Amount = 750M });
                Console.WriteLine("About to SaveChanges()");
                context.SaveChanges();
            }

            using (var context = new EFRecipesEntities())
            {
                var list = context.Donations.Where(o => o.Amount > 300M);
                Console.WriteLine("Donations over $300");
                foreach (var donor in list)
                {
                    Console.WriteLine("{0} gave {1}", donor.DonorName, donor.Amount.ToString("C"));
                }
            }

            Console.WriteLine("Press <enter> to continue...");            
            Console.ReadLine();
        }
    }

    public partial class EFRecipesEntities
    {
        partial void OnContextCreated()
        {
            this.Connection.StateChange += (s, e) =>
                {
                    var conn = ((EntityConnection)s).StoreConnection;
                    Console.WriteLine("{0}: Database: {1}, State: {2}, was: {3}",
                        DateTime.Now.ToShortTimeString(), conn.Database,
                        e.CurrentState, e.OriginalState);
                };
        }
    }
}
