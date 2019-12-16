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

    public partial class frmCusOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCusOrderDetails));
            this.dfnOrderNo = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelOrderNo = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfdOrderDate = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelOrderDate = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsCustomerName = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelCustomerName = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsDelAddress = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelDelAddress = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.cmbInternalCus = new Ifs.Fnd.ApplicationForms.cComboBox();
            this.labelInternalCus = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.SuspendLayout();
            // 
            // _cTabManager
            // 
            resources.ApplyResources(this._cTabManager, "_cTabManager");
            // 
            // picTab
            // 
            resources.ApplyResources(this.picTab, "picTab");
            // 
            // dfnOrderNo
            // 
            this.dfnOrderNo.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnOrderNo, "dfnOrderNo");
            this.dfnOrderNo.Name = "dfnOrderNo";
            this.dfnOrderNo.NamedProperties.Put("EnumerateMethod", "");
            this.dfnOrderNo.NamedProperties.Put("FieldFlags", "160");
            this.dfnOrderNo.NamedProperties.Put("Format", "");
            this.dfnOrderNo.NamedProperties.Put("LovReference", "");
            this.dfnOrderNo.NamedProperties.Put("SqlColumn", "ORDER_NO");
            // 
            // labelOrderNo
            // 
            resources.ApplyResources(this.labelOrderNo, "labelOrderNo");
            this.labelOrderNo.Name = "labelOrderNo";
            // 
            // dfdOrderDate
            // 
            this.dfdOrderDate.DataType = PPJ.Runtime.Windows.DataType.DateTime;
            this.dfdOrderDate.Format = "d";
            resources.ApplyResources(this.dfdOrderDate, "dfdOrderDate");
            this.dfdOrderDate.Name = "dfdOrderDate";
            this.dfdOrderDate.NamedProperties.Put("EnumerateMethod", "");
            this.dfdOrderDate.NamedProperties.Put("FieldFlags", "295");
            this.dfdOrderDate.NamedProperties.Put("LovReference", "");
            this.dfdOrderDate.NamedProperties.Put("SqlColumn", "ORDER_DATE");
            // 
            // labelOrderDate
            // 
            resources.ApplyResources(this.labelOrderDate, "labelOrderDate");
            this.labelOrderDate.Name = "labelOrderDate";
            // 
            // dfsCustomerName
            // 
            resources.ApplyResources(this.dfsCustomerName, "dfsCustomerName");
            this.dfsCustomerName.Name = "dfsCustomerName";
            this.dfsCustomerName.NamedProperties.Put("EnumerateMethod", "");
            this.dfsCustomerName.NamedProperties.Put("FieldFlags", "295");
            this.dfsCustomerName.NamedProperties.Put("LovReference", "");
            this.dfsCustomerName.NamedProperties.Put("SqlColumn", "CUSTOMER_NAME");
            // 
            // labelCustomerName
            // 
            resources.ApplyResources(this.labelCustomerName, "labelCustomerName");
            this.labelCustomerName.Name = "labelCustomerName";
            // 
            // dfsDelAddress
            // 
            resources.ApplyResources(this.dfsDelAddress, "dfsDelAddress");
            this.dfsDelAddress.Name = "dfsDelAddress";
            this.dfsDelAddress.NamedProperties.Put("EnumerateMethod", "");
            this.dfsDelAddress.NamedProperties.Put("FieldFlags", "311");
            this.dfsDelAddress.NamedProperties.Put("LovReference", "");
            this.dfsDelAddress.NamedProperties.Put("SqlColumn", "DEL_ADDRESS");
            // 
            // labelDelAddress
            // 
            resources.ApplyResources(this.labelDelAddress, "labelDelAddress");
            this.labelDelAddress.Name = "labelDelAddress";
            // 
            // cmbInternalCus
            // 
            this.cmbInternalCus.FormattingEnabled = true;
            resources.ApplyResources(this.cmbInternalCus, "cmbInternalCus");
            this.cmbInternalCus.Name = "cmbInternalCus";
            this.cmbInternalCus.NamedProperties.Put("EnumerateMethod", "FND_BOOLEAN_API.Enumerate");
            this.cmbInternalCus.NamedProperties.Put("FieldFlags", "295");
            this.cmbInternalCus.NamedProperties.Put("LovReference", "");
            this.cmbInternalCus.NamedProperties.Put("SqlColumn", "INTERNAL_CUS");
            // 
            // labelInternalCus
            // 
            resources.ApplyResources(this.labelInternalCus, "labelInternalCus");
            this.labelInternalCus.Name = "labelInternalCus";
            // 
            // frmCusOrderDetails
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cmbInternalCus);
            this.Controls.Add(this.labelInternalCus);
            this.Controls.Add(this.dfsDelAddress);
            this.Controls.Add(this.labelDelAddress);
            this.Controls.Add(this.dfsCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.dfdOrderDate);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.dfnOrderNo);
            this.Controls.Add(this.labelOrderNo);
            this.Name = "frmCusOrderDetails";
            this.NamedProperties.Put("LogicalUnit", "CusOrderDetails");
            this.NamedProperties.Put("Module", "EXMCLN");
            this.NamedProperties.Put("PackageName", "CUS_ORDER_DETAILS_API");
            this.NamedProperties.Put("SourceFlags", "4545");
            this.NamedProperties.Put("ViewName", "CUS_ORDER_DETAILS");
            this.Controls.SetChildIndex(this.picTab, 0);
            this.Controls.SetChildIndex(this.labelOrderNo, 0);
            this.Controls.SetChildIndex(this.dfnOrderNo, 0);
            this.Controls.SetChildIndex(this.labelOrderDate, 0);
            this.Controls.SetChildIndex(this.dfdOrderDate, 0);
            this.Controls.SetChildIndex(this.labelCustomerName, 0);
            this.Controls.SetChildIndex(this.dfsCustomerName, 0);
            this.Controls.SetChildIndex(this.labelDelAddress, 0);
            this.Controls.SetChildIndex(this.dfsDelAddress, 0);
            this.Controls.SetChildIndex(this.labelInternalCus, 0);
            this.Controls.SetChildIndex(this.cmbInternalCus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        protected cDataField dfnOrderNo;
        protected cBackgroundText labelOrderNo;
        protected cDataField dfdOrderDate;
        protected cBackgroundText labelOrderDate;
        protected cDataField dfsCustomerName;
        protected cBackgroundText labelCustomerName;
        protected cDataField dfsDelAddress;
        protected cBackgroundText labelDelAddress;
        protected cComboBox cmbInternalCus;
        protected cBackgroundText labelInternalCus;
    }
}
