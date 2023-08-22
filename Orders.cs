using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_8
{
    internal class Orders
    {
        static AdvancedDbEntities db;
        public void EFRead()
        {
            try
            {
                db = new AdvancedDbEntities();
                foreach (Order o in db.Orders)
                {
                    Console.WriteLine("Order ID: " + o.OrderId);
                    Console.WriteLine("Order Date: " + o.OrderDate);
                    Console.WriteLine("Quantity: " + o.Quantity);
                    Console.WriteLine("Discount: " + o.Discount);
                    Console.WriteLine("Shipped : " + o.isShipped);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void EFInsert()
        {
            try
            {
                db = new AdvancedDbEntities();
                Order Order = new Order();

                Console.WriteLine("Enter ID: ");
                Order.OrderId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Date: ");
                Order.OrderDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Quantity: ");
                Order.Quantity = short.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order Discount: ");
                Order.Discount = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Order is Shipped or Not: ");
                Order.isShipped = bool.Parse(Console.ReadLine());

                db.Orders.Add(Order);
                db.SaveChanges();

                Console.WriteLine("Order Record Inserted");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        public void EFUpdate()
        {
            try
            {
                db = new AdvancedDbEntities();
                Order Order = new Order();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.OrderId == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    Console.WriteLine("Enter Order Date: ");
                    Order.OrderDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Quantity: ");
                    Order.Quantity = short.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order Discount: ");
                    Order.Discount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Order is Shipped or Not: ");
                    Order.isShipped = bool.Parse(Console.ReadLine());

                    db.SaveChanges();

                    Console.WriteLine("Order Record Updated");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }

        public void EFDelete()
        {
            try
            {
                db = new AdvancedDbEntities();
                Order Order = new Order();

                Console.WriteLine("Enter ID to Update the details ");
                int id = int.Parse(Console.ReadLine());
                Order = db.Orders.SingleOrDefault(e => e.OrderId == id);

                if (Order == null)
                {
                    Console.WriteLine($"No such ID {id} exist in Day8DB");
                }
                else
                {
                    db.Orders.Remove(Order);
                    db.SaveChanges();

                    Console.WriteLine("Order Record Deleted");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
