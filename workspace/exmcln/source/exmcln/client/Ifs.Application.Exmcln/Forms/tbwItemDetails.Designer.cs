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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbwItemDetails));
            this.colnOrderNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnItemNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnPrice = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnQuantity = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colsState = new Ifs.Fnd.ApplicationForms.cColumn();
            this.cmdRequire = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cmdDeliver = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cmdCancel = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.contextMenu = new Ifs.Fnd.Windows.Forms.FndContextMenuStrip(this.components);
            this.tsMenuItemRequire = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.tsMenuItemDeliver = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.tsMenuItemCancel = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.@__colObjstate = new Ifs.Fnd.ApplicationForms.cStateMachineColumn();
            this.@__colObjevents = new Ifs.Fnd.ApplicationForms.cStateMachineColumn();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandManager
            // 
            this.commandManager.Commands.Add(this.cmdRequire);
            this.commandManager.Commands.Add(this.cmdDeliver);
            this.commandManager.Commands.Add(this.cmdCancel);
            this.commandManager.ContextMenus.Add(this.contextMenu);
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
            // colsState
            // 
            this.colsState.MaxLength = 20;
            this.colsState.Name = "colsState";
            this.colsState.NamedProperties.Put("EnumerateMethod", "");
            this.colsState.NamedProperties.Put("FieldFlags", "288");
            this.colsState.NamedProperties.Put("LovReference", "");
            this.colsState.NamedProperties.Put("SqlColumn", "STATE");
            this.colsState.Position = 7;
            resources.ApplyResources(this.colsState, "colsState");
            // 
            // cmdRequire
            // 
            resources.ApplyResources(this.cmdRequire, "cmdRequire");
            this.cmdRequire.Name = "cmdRequire";
            this.cmdRequire.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdRequire_Execute);
            this.cmdRequire.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdRequire_Inquire);
            // 
            // cmdDeliver
            // 
            resources.ApplyResources(this.cmdDeliver, "cmdDeliver");
            this.cmdDeliver.Name = "cmdDeliver";
            this.cmdDeliver.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdDeliver_Execute);
            this.cmdDeliver.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdDeliver_Inquire);
            // 
            // cmdCancel
            // 
            resources.ApplyResources(this.cmdCancel, "cmdCancel");
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdCancel_Execute);
            this.cmdCancel.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdCancel_Inquire);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemRequire,
            this.tsMenuItemDeliver,
            this.tsMenuItemCancel});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // tsMenuItemRequire
            // 
            this.tsMenuItemRequire.Command = this.cmdRequire;
            this.tsMenuItemRequire.Name = "tsMenuItemRequire";
            resources.ApplyResources(this.tsMenuItemRequire, "tsMenuItemRequire");
            this.tsMenuItemRequire.Text = "Require";
            // 
            // tsMenuItemDeliver
            // 
            this.tsMenuItemDeliver.Command = this.cmdDeliver;
            this.tsMenuItemDeliver.Name = "tsMenuItemDeliver";
            resources.ApplyResources(this.tsMenuItemDeliver, "tsMenuItemDeliver");
            this.tsMenuItemDeliver.Text = "Deliver";
            // 
            // tsMenuItemCancel
            // 
            this.tsMenuItemCancel.Command = this.cmdCancel;
            this.tsMenuItemCancel.Name = "tsMenuItemCancel";
            resources.ApplyResources(this.tsMenuItemCancel, "tsMenuItemCancel");
            this.tsMenuItemCancel.Text = "Cancel";
            // 
            // __colObjstate
            // 
            this.@__colObjstate.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.@__colObjstate, "__colObjstate");
            this.@__colObjstate.Name = "__colObjstate";
            this.@__colObjstate.Position = 8;
            this.@__colObjstate.StateColumnType = Ifs.Fnd.ApplicationForms.Design.StateMachineColumnType.ObjState;
            // 
            // __colObjevents
            // 
            this.@__colObjevents.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.@__colObjevents, "__colObjevents");
            this.@__colObjevents.Name = "__colObjevents";
            this.@__colObjevents.Position = 9;
            this.@__colObjevents.StateColumnType = Ifs.Fnd.ApplicationForms.Design.StateMachineColumnType.ObjEvents;
            // 
            // tbwItemDetails
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.colnOrderNo);
            this.Controls.Add(this.colnItemNo);
            this.Controls.Add(this.colnPrice);
            this.Controls.Add(this.colnQuantity);
            this.Controls.Add(this.colsState);
            this.Controls.Add(this.@__colObjstate);
            this.Controls.Add(this.@__colObjevents);
            this.Name = "tbwItemDetails";
            this.NamedProperties.Put("LogicalUnit", "ItemDetail");
            this.NamedProperties.Put("Module", "EXMCLN");
            this.NamedProperties.Put("PackageName", "ITEM_DETAIL_API");
            this.NamedProperties.Put("SourceFlags", "25025");
            this.NamedProperties.Put("ViewName", "ITEM_DETAIL");
            this.Controls.SetChildIndex(this.@__colObjevents, 0);
            this.Controls.SetChildIndex(this.@__colObjstate, 0);
            this.Controls.SetChildIndex(this.@__colObjversion, 0);
            this.Controls.SetChildIndex(this.colsState, 0);
            this.Controls.SetChildIndex(this.colnQuantity, 0);
            this.Controls.SetChildIndex(this.colnPrice, 0);
            this.Controls.SetChildIndex(this.colnItemNo, 0);
            this.Controls.SetChildIndex(this.colnOrderNo, 0);
            this.Controls.SetChildIndex(this.@__colObjid, 0);
            this.contextMenu.ResumeLayout(false);
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
        protected cColumn colsState;
        protected Fnd.Windows.Forms.FndCommand cmdRequire;
        protected Fnd.Windows.Forms.FndCommand cmdDeliver;
        protected Fnd.Windows.Forms.FndCommand cmdCancel;
        protected Fnd.Windows.Forms.FndContextMenuStrip contextMenu;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemRequire;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemDeliver;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemCancel;
        private cStateMachineColumn __colObjstate;
        private cStateMachineColumn __colObjevents;
    }
}
