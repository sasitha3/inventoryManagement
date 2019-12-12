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

    public partial class tbwMainInventories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbwMainInventories));
            this.colnInventoryId = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colsAreaName = new Ifs.Fnd.ApplicationForms.cColumn();
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
            // colnInventoryId
            // 
            this.colnInventoryId.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnInventoryId.Name = "colnInventoryId";
            this.colnInventoryId.NamedProperties.Put("EnumerateMethod", "");
            this.colnInventoryId.NamedProperties.Put("FieldFlags", "163");
            this.colnInventoryId.NamedProperties.Put("Format", "");
            this.colnInventoryId.NamedProperties.Put("LovReference", "");
            this.colnInventoryId.NamedProperties.Put("SqlColumn", "INVENTORY_ID");
            this.colnInventoryId.Position = 3;
            this.colnInventoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnInventoryId, "colnInventoryId");
            // 
            // colsAreaName
            // 
            this.colsAreaName.Name = "colsAreaName";
            this.colsAreaName.NamedProperties.Put("EnumerateMethod", "");
            this.colsAreaName.NamedProperties.Put("FieldFlags", "295");
            this.colsAreaName.NamedProperties.Put("LovReference", "");
            this.colsAreaName.NamedProperties.Put("SqlColumn", "AREA_NAME");
            this.colsAreaName.Position = 4;
            resources.ApplyResources(this.colsAreaName, "colsAreaName");
            // 
            // tbwMainInventories
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.colnInventoryId);
            this.Controls.Add(this.colsAreaName);
            this.Name = "tbwMainInventories";
            this.NamedProperties.Put("LogicalUnit", "ExmInventory");
            this.NamedProperties.Put("Module", "TRNEXM");
            this.NamedProperties.Put("PackageName", "EXM_INVENTORY_API");
            this.NamedProperties.Put("ViewName", "EXM_INVENTORY");
            this.Controls.SetChildIndex(this.@__colObjversion, 0);
            this.Controls.SetChildIndex(this.colsAreaName, 0);
            this.Controls.SetChildIndex(this.colnInventoryId, 0);
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

        protected cColumn colnInventoryId;
        protected cColumn colsAreaName;
    }
}
