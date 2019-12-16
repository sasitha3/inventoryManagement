#region Copyright (c) IFS Research & Development
//
//                 IFS Research & Development
//
//  This program is protected by copyright law and by international
//  conventions. All licensing, renting, lending or copying (including
//  for private use), and all other use of the program, which is not
//  explicitly permitted by IFS, is a violation of the rights
//  of IFS. Such violations will be reported to the
//  appropriate authorities.
//
//  VIOLATIONS OF ANY COPYRIGHT IS PUNISHABLE BY LAW AND CAN LEAD
//  TO UP TO TWO YEARS OF IMPRISONMENT AND LIABILITY TO PAY DAMAGES.
#endregion
#region History
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ifs.Fnd.ApplicationForms;
using PPJ.Runtime;
using PPJ.Runtime.Windows;

namespace Ifs.Application.Exmcln
{

    public partial class tbwItemDetails
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbwItemDetails));
            this.colnOrderNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnItemNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnPrice = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnQuantity = new Ifs.Fnd.ApplicationForms.cColumn();
            this.SuspendLayout();
            // 
            // __colObjid
            // 
            resources.ApplyResources(this.@__colObjid, "__colObjid");
            // 
            // __colObjversion
            // 
            resources.ApplyResources(this.@__colObjversion, "__colObjversion");
            // 
            // colnOrderNo
            // 
            this.colnOrderNo.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnOrderNo.Name = "colnOrderNo";
            this.colnOrderNo.NamedProperties.Put("EnumerateMethod", "");
            this.colnOrderNo.NamedProperties.Put("FieldFlags", "99");
            this.colnOrderNo.NamedProperties.Put("Format", "");
            this.colnOrderNo.NamedProperties.Put("LovReference", "CUS_ORDER_DETAILS");
            this.colnOrderNo.NamedProperties.Put("SqlColumn", "ORDER_NO");
            this.colnOrderNo.Position = 3;
            this.colnOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnOrderNo, "colnOrderNo");
            // 
            // colnItemNo
            // 
            this.colnItemNo.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnItemNo.Name = "colnItemNo";
            this.colnItemNo.NamedProperties.Put("EnumerateMethod", "");
            this.colnItemNo.NamedProperties.Put("FieldFlags", "163");
            this.colnItemNo.NamedProperties.Put("Format", "");
            this.colnItemNo.NamedProperties.Put("LovReference", "EXM_PART");
            this.colnItemNo.NamedProperties.Put("SqlColumn", "ITEM_NO");
            this.colnItemNo.Position = 4;
            this.colnItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnItemNo, "colnItemNo");
            // 
            // colnPrice
            // 
            this.colnPrice.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnPrice.Name = "colnPrice";
            this.colnPrice.NamedProperties.Put("EnumerateMethod", "");
            this.colnPrice.NamedProperties.Put("FieldFlags", "295");
            this.colnPrice.NamedProperties.Put("Format", "");
            this.colnPrice.NamedProperties.Put("LovReference", "");
            this.colnPrice.NamedProperties.Put("SqlColumn", "PRICE");
            this.colnPrice.Position = 5;
            this.colnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnPrice, "colnPrice");
            // 
            // colnQuantity
            // 
            this.colnQuantity.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnQuantity.Name = "colnQuantity";
            this.colnQuantity.NamedProperties.Put("EnumerateMethod", "");
            this.colnQuantity.NamedProperties.Put("FieldFlags", "295");
            this.colnQuantity.NamedProperties.Put("Format", "");
            this.colnQuantity.NamedProperties.Put("LovReference", "");
            this.colnQuantity.NamedProperties.Put("SqlColumn", "QUANTITY");
            this.colnQuantity.Position = 6;
            this.colnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnQuantity, "colnQuantity");
            // 
            // tbwItemDetails
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.colnOrderNo);
            this.Controls.Add(this.colnItemNo);
            this.Controls.Add(this.colnPrice);
            this.Controls.Add(this.colnQuantity);
            this.Name = "tbwItemDetails";
            this.NamedProperties.Put("LogicalUnit", "ItemDetail");
            this.NamedProperties.Put("Module", "EXMCLN");
            this.NamedProperties.Put("PackageName", "ITEM_DETAIL_API");
            this.NamedProperties.Put("ViewName", "ITEM_DETAIL");
            this.Controls.SetChildIndex(this.@__colObjversion, 0);
            this.Controls.SetChildIndex(this.colnQuantity, 0);
            this.Controls.SetChildIndex(this.colnPrice, 0);
            this.Controls.SetChildIndex(this.colnItemNo, 0);
            this.Controls.SetChildIndex(this.colnOrderNo, 0);
            this.Controls.SetChildIndex(this.@__colObjid, 0);
            this.ResumeLayout(false);

        }
        #endregion

        #region System Methods/Properties

        /// <summary>
        /// Release global reference.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        protected cColumn colnOrderNo;
        protected cColumn colnItemNo;
        protected cColumn colnPrice;
        protected cColumn colnQuantity;
    }
}
