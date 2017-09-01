using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFCore.Console {
    public class Program {
        public static void Main(string[] args) {
            var databasePath = @"C:\EFCore.db";

            System.Console.WriteLine($"Using {databasePath} to save out the SQLite database");

            var quotation = new Quotation {
                Users = new List<User> {
                    new User {
                        Address = new Address {
                            Postcode = "Postcode"
                        }
                    }
                }
            };

            using (var context = new DataContext(databasePath)) {
                context.Quotations.Add(quotation);
                var recordsAdded = context.SaveChanges();
                System.Console.WriteLine($"Added {recordsAdded} records to the database");
            }


            System.Console.WriteLine(Environment.NewLine + "About to print all entries in database..." + Environment.NewLine);

            using (var context = new DataContext(databasePath)) {
                // No lazy loading in EFCore, so include all navigation properties
                var allQuotations = context.Quotations
                    .Include(q => q.Users)
                    .ThenInclude(u => u.Address)
                    .ToListAsync()
                    .Result;

                foreach (var q in allQuotations) {
                    System.Console.WriteLine($"Quote Id: {q.Id}");
                    foreach (var u in q.Users) {
                        System.Console.WriteLine($" - User Id: {u.Id}, Postcode: {u.Address.Postcode}");
                    }
                }
            }

            System.Console.ReadKey();
        }
    }
}
