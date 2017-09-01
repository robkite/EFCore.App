using EFCore.Domain;
using System;
using System.Collections.Generic;
using UIKit;

namespace EFCore.App {
    public partial class ViewController : UIViewController {
        public ViewController(IntPtr handle) : base(handle) {}

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            ReloadTableData();
        }

        partial void AddQuotationBtn_TouchUpInside(UIButton sender) {
            // Add a new quotation to the database
            var quotation = new Quotation {
                Users = new List<User> {
                    new User {
                        Address = new Address {
                            Postcode = "Postcode"
                        }
                    }
                }
            };

            using (var context = new DataContext(Database.DatabasePath)) {
                context.Quotations.Add(quotation);
                var recordsAdded = context.SaveChanges();
                System.Console.WriteLine($"Added {recordsAdded} records to the database");
            }

            ReloadTableData();
        }

        private void ReloadTableData() {
            QuotationTable.Source = new QuotationTableSource();
            QuotationTable.ReloadData();
        }

        partial void DeleteAll_TouchUpInside(UIButton sender) {
            Database.DeleteDatabase();
            ReloadTableData();
        }
    }
}