using System;
using System.Collections.Generic;

using Foundation;
using UIKit;
using EFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCore.App {
    public class QuotationTableSource : UITableViewSource {
        private const string cellIdentifier = "TableCell";

        public QuotationTableSource() {
            using (var context = new DataContext(Database.DatabasePath)) {
                // No lazy loading in EFCore, so include all navigation properties
                var allQuotations = context.Quotations
                    .Include(q => q.Users)
                    .ThenInclude(u => u.Address)
                    .ToListAsync()
                    .Result;

                Quotations = allQuotations;
            }
        }

        private List<Quotation> Quotations { get; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath) {
            var cell = tableView.DequeueReusableCell(cellIdentifier) ?? new UITableViewCell(UITableViewCellStyle.Subtitle, cellIdentifier);
            var quotation = Quotations[(int)indexPath.Row];
            cell.TextLabel.Text = string.Format("Quote #{0}", quotation.Id);
            cell.DetailTextLabel.Text = string.Format("{0} users", quotation.Users.Count);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section) {
            return Quotations.Count;
        }
    }
}