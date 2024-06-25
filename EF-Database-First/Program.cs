using Microsoft.EntityFrameworkCore;
namespace EF_Database_First {
    internal class Program {
        public static Requestline newRequestline1;

        static void Main(string[] args) {

            var _context = new TqlprsdbContext();

            // var newRequest = from r in _context.Requests
            //                  join rl in _context.Requestlines
            //                  on r.Id equals rl.RequestId
            //                  join p in _context.Products
            //                 on rl.ProductId equals p.Id
            //                  join v in _context.Vendors
            //                  on p.VendorId equals v.Id
            //                   join u in _context.Users
            //                     on r.UserId equals u.Id
            //                  where r.Description ==" I need a ROLEX!!"
            //                     Select new {
            //                         r, rl, p, u, v
            //                          description = r.Description,
            //                          Name = p.Name,
            //                          Quantity = rl.Quantity,
            //                          Price = p.Price
            //                         }) .First();


            // var newUser = new User {
            //     Id= 0,Username = "JC", Password = "JC" , Firstname = "James" , Lastname = "Luncan" ,
            //     IsReviewer = true, IsAdmin = true, 

            //   };

            //  _context.Users.Add(newUser);

            // _context.SaveChanges();

            //  var deleteUser = _context.Users.Find(4);

            //  _context.Users.Remove(deleteUser!);

            //  _context.SaveChanges();


            var newVendor = new Vendor {
                Id = 0, Code = "Jc", Name = "James", Address = "123 Jc Street",
                City = "Cincinnati", State = "OH", Zip = "45040"



            };
            _context.Vendors.Add(newVendor);

            _context.SaveChanges();

            var newProduct = new Product {
                Id = 0, PartNbr = "Rolex", Name = "Rolex", Price = 50000, Unit = "EacH", VendorId = 3

            };
            _context.Products.Add(newProduct);

            _context.SaveChanges();

            var newRequest = new Request {
                Id = 0, Description = "I Want a Rolex", Justification = " Because", DeliveryMode = "Pickup",
                Status = "Used", Total = 0, UserId = 3

            };
            _context.Requests.Add(newRequest);

            _context.SaveChanges();

        
       
        
               
            
            _context.Requestlines.Add(newRequestline1);

            

            var newRequestLine2 = new Requestline {
                Id = 0, Quantity = 1, RequestId = 2, ProductId = 1

            };
            _context.Requestlines.Add(newRequestLine2);

            _context.SaveChanges();
        }
    }
}
