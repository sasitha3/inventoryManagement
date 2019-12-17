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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCusOrderDetails));
            this.dfdOrderDate = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelOrderDate = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsCustomerName = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelCustomerName = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsDelAddress = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelDelAddress = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.cmbInternalCus = new Ifs.Fnd.ApplicationForms.cComboBox();
            this.labelInternalCus = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfsState = new Ifs.Fnd.ApplicationForms.cDataField();
            this.labelState = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfnOrderNo = new Ifs.Fnd.ApplicationForms.cRecListDataField();
            this.labelOrderNo = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.cmdPlan = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cmdRelease = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cmdCancel = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cmdClose = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.contextMenu = new Ifs.Fnd.Windows.Forms.FndContextMenuStrip(this.components);
            this.tsMenuItemPlan = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.tsMenuItemRelease = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.tsMenuItemCancel = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.tsMenuItemClose = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cTabManager
            // 
            resources.ApplyResources(this._cTabManager, "_cTabManager");
            // 
            // picTab
            // 
            this.picTab.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.picTab, "picTab");
            this.picTab.SelectedIndex = 1;
            // 
            // commandManager
            // 
            this.commandManager.Commands.Add(this.cmdPlan);
            this.commandManager.Commands.Add(this.cmdRelease);
            this.commandManager.Commands.Add(this.cmdCancel);
            this.commandManager.Commands.Add(this.cmdClose);
            this.commandManager.ContextMenus.Add(this.contextMenu);
            this.commandManager.ImageList = null;
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
            // dfsState
            // 
            resources.ApplyResources(this.dfsState, "dfsState");
            this.dfsState.Name = "dfsState";
            this.dfsState.NamedProperties.Put("EnumerateMethod", "");
            this.dfsState.NamedProperties.Put("FieldFlags", "288");
            this.dfsState.NamedProperties.Put("LovReference", "");
            this.dfsState.NamedProperties.Put("SqlColumn", "STATE");
            // 
            // labelState
            // 
            resources.ApplyResources(this.labelState, "labelState");
            this.labelState.Name = "labelState";
            // 
            // dfnOrderNo
            // 
            resources.ApplyResources(this.dfnOrderNo, "dfnOrderNo");
            this.dfnOrderNo.Name = "dfnOrderNo";
            this.dfnOrderNo.NamedProperties.Put("DataType", "3");
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
            // cmdPlan
            // 
            resources.ApplyResources(this.cmdPlan, "cmdPlan");
            this.cmdPlan.Name = "cmdPlan";
            this.cmdPlan.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdPlan_Execute);
            this.cmdPlan.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdPlan_Inquire);
            // 
            // cmdRelease
            // 
            resources.ApplyResources(this.cmdRelease, "cmdRelease");
            this.cmdRelease.Name = "cmdRelease";
            this.cmdRelease.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdRelease_Execute);
            this.cmdRelease.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdRelease_Inquire);
            // 
            // cmdCancel
            // 
            resources.ApplyResources(this.cmdCancel, "cmdCancel");
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdCancel_Execute);
            this.cmdCancel.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdCancel_Inquire);
            // 
            // cmdClose
            // 
            resources.ApplyResources(this.cmdClose, "cmdClose");
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdClose_Execute);
            this.cmdClose.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdClose_Inquire);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemPlan,
            this.tsMenuItemRelease,
            this.tsMenuItemCancel,
            this.tsMenuItemClose});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // tsMenuItemPlan
            // 
            this.tsMenuItemPlan.Command = this.cmdPlan;
            this.tsMenuItemPlan.Name = "tsMenuItemPlan";
            resources.ApplyResources(this.tsMenuItemPlan, "tsMenuItemPlan");
            this.tsMenuItemPlan.Text = "Plan";
            // 
            // tsMenuItemRelease
            // 
            this.tsMenuItemRelease.Command = this.cmdRelease;
            this.tsMenuItemRelease.Name = "tsMenuItemRelease";
            resources.ApplyResources(this.tsMenuItemRelease, "tsMenuItemRelease");
            this.tsMenuItemRelease.Text = "Release";
            // 
            // tsMenuItemCancel
            // 
            this.tsMenuItemCancel.Command = this.cmdCancel;
            this.tsMenuItemCancel.Name = "tsMenuItemCancel";
            resources.ApplyResources(this.tsMenuItemCancel, "tsMenuItemCancel");
            this.tsMenuItemCancel.Text = "Cancel";
            // 
            // tsMenuItemClose
            // 
            this.tsMenuItemClose.Command = this.cmdClose;
            this.tsMenuItemClose.Name = "tsMenuItemClose";
            resources.ApplyResources(this.tsMenuItemClose, "tsMenuItemClose");
            this.tsMenuItemClose.Text = "Close";
            // 
            // frmCusOrderDetails
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.dfnOrderNo);
            this.Controls.Add(this.labelOrderNo);
            this.Controls.Add(this.dfsState);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.cmbInternalCus);
            this.Controls.Add(this.labelInternalCus);
            this.Controls.Add(this.dfsDelAddress);
            this.Controls.Add(this.labelDelAddress);
            this.Controls.Add(this.dfsCustomerName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.dfdOrderDate);
            this.Controls.Add(this.labelOrderDate);
            this.Name = "frmCusOrderDetails";
            this.NamedProperties.Put("LogicalUnit", "CusOrderDetails");
            this.NamedProperties.Put("Module", "EXMCLN");
            this.NamedProperties.Put("PackageName", "CUS_ORDER_DETAILS_API");
            this.NamedProperties.Put("SourceFlags", "12737");
            this.NamedProperties.Put("ViewName", "CUS_ORDER_DETAILS");
            this.Controls.SetChildIndex(this.picTab, 0);
            this.Controls.SetChildIndex(this.labelOrderDate, 0);
            this.Controls.SetChildIndex(this.dfdOrderDate, 0);
            this.Controls.SetChildIndex(this.labelCustomerName, 0);
            this.Controls.SetChildIndex(this.dfsCustomerName, 0);
            this.Controls.SetChildIndex(this.labelDelAddress, 0);
            this.Controls.SetChildIndex(this.dfsDelAddress, 0);
            this.Controls.SetChildIndex(this.labelInternalCus, 0);
            this.Controls.SetChildIndex(this.cmbInternalCus, 0);
            this.Controls.SetChildIndex(this.labelState, 0);
            this.Controls.SetChildIndex(this.dfsState, 0);
            this.Controls.SetChildIndex(this.labelOrderNo, 0);
            this.Controls.SetChildIndex(this.dfnOrderNo, 0);
            this.contextMenu.ResumeLayout(false);
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

        protected cDataField dfdOrderDate;
        protected cBackgroundText labelOrderDate;
        protected cDataField dfsCustomerName;
        protected cBackgroundText labelCustomerName;
        protected cDataField dfsDelAddress;
        protected cBackgroundText labelDelAddress;
        protected cComboBox cmbInternalCus;
        protected cBackgroundText labelInternalCus;
        protected cDataField dfsState;
        protected cBackgroundText labelState;
        protected cRecListDataField dfnOrderNo;
        protected cBackgroundText labelOrderNo;
        protected Fnd.Windows.Forms.FndCommand cmdPlan;
        protected Fnd.Windows.Forms.FndCommand cmdRelease;
        protected Fnd.Windows.Forms.FndCommand cmdCancel;
        protected Fnd.Windows.Forms.FndCommand cmdClose;
        protected Fnd.Windows.Forms.FndContextMenuStrip contextMenu;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemPlan;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemRelease;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemCancel;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemClose;
    }
}
