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

namespace Ifs.Application.Trnexm
{

    public partial class tbwInventoryPartDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbwInventoryPartDetails));
            this.colnInventoryId = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnLocationNumber = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnPartNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colnQuantity = new Ifs.Fnd.ApplicationForms.cColumn();
            this.cmdAddQty = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.contextMenu = new Ifs.Fnd.Windows.Forms.FndContextMenuStrip(this.components);
            this.tsMenuItemAddQty = new Ifs.Fnd.Windows.Forms.FndToolStripMenuItem(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandManager
            // 
            this.commandManager.Commands.Add(this.cmdAddQty);
            this.commandManager.ContextMenus.Add(this.contextMenu);
            // 
            // __colObjid
            // 
            resources.ApplyResources(this.@__colObjid, "__colObjid");
            // 
            // __colObjversion
            // 
            this.@__colObjversion.Position = 4;
            resources.ApplyResources(this.@__colObjversion, "__colObjversion");
            // 
            // colnInventoryId
            // 
            this.colnInventoryId.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnInventoryId.Name = "colnInventoryId";
            this.colnInventoryId.NamedProperties.Put("EnumerateMethod", "");
            this.colnInventoryId.NamedProperties.Put("FieldFlags", "99");
            this.colnInventoryId.NamedProperties.Put("Format", "");
            this.colnInventoryId.NamedProperties.Put("LovReference", "EXM_INVENTORY_LOCATION()");
            this.colnInventoryId.NamedProperties.Put("SqlColumn", "INVENTORY_ID");
            this.colnInventoryId.Position = 2;
            this.colnInventoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnInventoryId, "colnInventoryId");
            // 
            // colnLocationNumber
            // 
            this.colnLocationNumber.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnLocationNumber.Name = "colnLocationNumber";
            this.colnLocationNumber.NamedProperties.Put("EnumerateMethod", "");
            this.colnLocationNumber.NamedProperties.Put("FieldFlags", "99");
            this.colnLocationNumber.NamedProperties.Put("Format", "");
            this.colnLocationNumber.NamedProperties.Put("LovReference", "EXM_INVENTORY_LOCATION(INVENTORY_ID)");
            this.colnLocationNumber.NamedProperties.Put("SqlColumn", "LOCATION_NUMBER");
            this.colnLocationNumber.Position = 3;
            this.colnLocationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnLocationNumber, "colnLocationNumber");
            // 
            // colnPartNo
            // 
            this.colnPartNo.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnPartNo.Name = "colnPartNo";
            this.colnPartNo.NamedProperties.Put("EnumerateMethod", "");
            this.colnPartNo.NamedProperties.Put("FieldFlags", "99");
            this.colnPartNo.NamedProperties.Put("Format", "");
            this.colnPartNo.NamedProperties.Put("LovReference", "EXM_PART");
            this.colnPartNo.NamedProperties.Put("SqlColumn", "PART_NO");
            this.colnPartNo.Position = 5;
            this.colnPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnPartNo, "colnPartNo");
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
            // cmdAddQty
            // 
            resources.ApplyResources(this.cmdAddQty, "cmdAddQty");
            this.cmdAddQty.Name = "cmdAddQty";
            this.cmdAddQty.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.cmdAddQty_Execute);
            this.cmdAddQty.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.cmdAddQty_Inquire);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemAddQty});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // tsMenuItemAddQty
            // 
            this.tsMenuItemAddQty.Command = this.cmdAddQty;
            this.tsMenuItemAddQty.Name = "tsMenuItemAddQty";
            resources.ApplyResources(this.tsMenuItemAddQty, "tsMenuItemAddQty");
            this.tsMenuItemAddQty.Text = "Add Quantities..";
            // 
            // tbwInventoryPartDetails
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.colnInventoryId);
            this.Controls.Add(this.colnLocationNumber);
            this.Controls.Add(this.colnPartNo);
            this.Controls.Add(this.colnQuantity);
            this.Name = "tbwInventoryPartDetails";
            this.NamedProperties.Put("LogicalUnit", "ExmInventoryProduct");
            this.NamedProperties.Put("Module", "TRNEXM");
            this.NamedProperties.Put("PackageName", "EXM_INVENTORY_PRODUCT_API");
            this.NamedProperties.Put("ViewName", "EXM_INVENTORY_PRODUCT");
            this.Controls.SetChildIndex(this.colnQuantity, 0);
            this.Controls.SetChildIndex(this.colnPartNo, 0);
            this.Controls.SetChildIndex(this.@__colObjversion, 0);
            this.Controls.SetChildIndex(this.colnLocationNumber, 0);
            this.Controls.SetChildIndex(this.colnInventoryId, 0);
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

        protected cColumn colnInventoryId;
        protected cColumn colnLocationNumber;
        protected cColumn colnPartNo;
        protected cColumn colnQuantity;
        protected Fnd.Windows.Forms.FndCommand cmdAddQty;
        protected Fnd.Windows.Forms.FndContextMenuStrip contextMenu;
        protected Fnd.Windows.Forms.FndToolStripMenuItem tsMenuItemAddQty;
    }
}
