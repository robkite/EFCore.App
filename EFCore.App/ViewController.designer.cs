// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace EFCore.App
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddQuotationBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteAll { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView QuotationTable { get; set; }

        [Action ("AddQuotationBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddQuotationBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("DeleteAll_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DeleteAll_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddQuotationBtn != null) {
                AddQuotationBtn.Dispose ();
                AddQuotationBtn = null;
            }

            if (DeleteAll != null) {
                DeleteAll.Dispose ();
                DeleteAll = null;
            }

            if (QuotationTable != null) {
                QuotationTable.Dispose ();
                QuotationTable = null;
            }
        }
    }
}