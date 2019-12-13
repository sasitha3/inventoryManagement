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

    public partial class dlgReceiveItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgReceiveItem));
            this.cCommandButtonOK = new Ifs.Fnd.ApplicationForms.cCommandButton();
            this.commandOk = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cCommandButtonCancel = new Ifs.Fnd.ApplicationForms.cCommandButton();
            this.commandCancel = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.cCommandButtonList = new Ifs.Fnd.ApplicationForms.cCommandButton();
            this.commandList = new Ifs.Fnd.Windows.Forms.FndCommand(this.components);
            this.labelInventoryId = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.labelInventoryLocationId = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.labelPartId = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.labelAvailableQty = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.labelAddQty = new Ifs.Fnd.ApplicationForms.cBackgroundText();
            this.dfnInventoryId = new Ifs.Fnd.ApplicationForms.cDataField();
            this.dfnInventoryLocationId = new Ifs.Fnd.ApplicationForms.cDataField();
            this.dfnPartId = new Ifs.Fnd.ApplicationForms.cDataField();
            this.dfnQtyAvailable = new Ifs.Fnd.ApplicationForms.cDataField();
            this.dfnAddQty = new Ifs.Fnd.ApplicationForms.cDataField();
            this.SuspendLayout();
            // 
            // commandManager
            // 
            this.commandManager.Commands.Add(this.commandOk);
            this.commandManager.Commands.Add(this.commandCancel);
            this.commandManager.Commands.Add(this.commandList);
            this.commandManager.Components.Add(this.cCommandButtonOK);
            this.commandManager.Components.Add(this.cCommandButtonCancel);
            this.commandManager.Components.Add(this.cCommandButtonList);
            this.commandManager.ImageList = null;
            // 
            // cCommandButtonOK
            // 
            resources.ApplyResources(this.cCommandButtonOK, "cCommandButtonOK");
            this.cCommandButtonOK.Command = this.commandOk;
            this.cCommandButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cCommandButtonOK.Name = "cCommandButtonOK";
            this.cCommandButtonOK.NamedProperties.Put("MethodIdStr", "");
            this.cCommandButtonOK.NamedProperties.Put("MethodParameterType", "String");
            // 
            // commandOk
            // 
            resources.ApplyResources(this.commandOk, "commandOk");
            this.commandOk.Enabled = false;
            this.commandOk.EventCategory = Ifs.Fnd.Windows.Forms.CommandEventCategory.Focus;
            this.commandOk.Name = "commandOk";
            this.commandOk.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.commandOk_Execute);
            this.commandOk.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.commandOk_Inquire);
            // 
            // cCommandButtonCancel
            // 
            resources.ApplyResources(this.cCommandButtonCancel, "cCommandButtonCancel");
            this.cCommandButtonCancel.Command = this.commandCancel;
            this.cCommandButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cCommandButtonCancel.Name = "cCommandButtonCancel";
            this.cCommandButtonCancel.NamedProperties.Put("MethodIdStr", "");
            this.cCommandButtonCancel.NamedProperties.Put("MethodParameterType", "String");
            // 
            // commandCancel
            // 
            resources.ApplyResources(this.commandCancel, "commandCancel");
            this.commandCancel.Name = "commandCancel";
            this.commandCancel.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.commandCancel_Execute);
            this.commandCancel.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.commandCancel_Inquire);
            // 
            // cCommandButtonList
            // 
            this.cCommandButtonList.Command = this.commandList;
            resources.ApplyResources(this.cCommandButtonList, "cCommandButtonList");
            this.cCommandButtonList.Name = "cCommandButtonList";
            // 
            // commandList
            // 
            resources.ApplyResources(this.commandList, "commandList");
            this.commandList.Enabled = false;
            this.commandList.EventCategory = Ifs.Fnd.Windows.Forms.CommandEventCategory.Focus;
            this.commandList.Name = "commandList";
            this.commandList.Execute += new Ifs.Fnd.Windows.Forms.FndCommandExecuteHandler(this.commandList_Execute);
            this.commandList.Inquire += new Ifs.Fnd.Windows.Forms.FndCommandInquireHandler(this.commandList_Inquire);
            // 
            // labelInventoryId
            // 
            resources.ApplyResources(this.labelInventoryId, "labelInventoryId");
            this.labelInventoryId.Name = "labelInventoryId";
            // 
            // labelInventoryLocationId
            // 
            resources.ApplyResources(this.labelInventoryLocationId, "labelInventoryLocationId");
            this.labelInventoryLocationId.Name = "labelInventoryLocationId";
            // 
            // labelPartId
            // 
            resources.ApplyResources(this.labelPartId, "labelPartId");
            this.labelPartId.Name = "labelPartId";
            // 
            // labelAvailableQty
            // 
            resources.ApplyResources(this.labelAvailableQty, "labelAvailableQty");
            this.labelAvailableQty.Name = "labelAvailableQty";
            // 
            // labelAddQty
            // 
            resources.ApplyResources(this.labelAddQty, "labelAddQty");
            this.labelAddQty.Name = "labelAddQty";
            // 
            // dfnInventoryId
            // 
            this.dfnInventoryId.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnInventoryId, "dfnInventoryId");
            this.dfnInventoryId.Name = "dfnInventoryId";
            this.dfnInventoryId.NamedProperties.Put("FieldFlags", "260");
            this.dfnInventoryId.NamedProperties.Put("LovReference", "EXM_INVENTORY");
            // 
            // dfnInventoryLocationId
            // 
            this.dfnInventoryLocationId.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnInventoryLocationId, "dfnInventoryLocationId");
            this.dfnInventoryLocationId.Name = "dfnInventoryLocationId";
            this.dfnInventoryLocationId.NamedProperties.Put("FieldFlags", "260");
            this.dfnInventoryLocationId.NamedProperties.Put("LovReference", "EXM_INVENTORY_LOCATION");
            // 
            // dfnPartId
            // 
            this.dfnPartId.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnPartId, "dfnPartId");
            this.dfnPartId.Name = "dfnPartId";
            this.dfnPartId.NamedProperties.Put("FieldFlags", "260");
            this.dfnPartId.NamedProperties.Put("LovReference", "EXM_PART");
            this.dfnPartId.WindowActions += new PPJ.Runtime.Windows.WindowActionsEventHandler(this.dfnPartId_WindowActions);
            // 
            // dfnQtyAvailable
            // 
            this.dfnQtyAvailable.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnQtyAvailable, "dfnQtyAvailable");
            this.dfnQtyAvailable.Name = "dfnQtyAvailable";
            this.dfnQtyAvailable.NamedProperties.Put("FieldFlags", "260");
            // 
            // dfnAddQty
            // 
            this.dfnAddQty.DataType = PPJ.Runtime.Windows.DataType.Number;
            resources.ApplyResources(this.dfnAddQty, "dfnAddQty");
            this.dfnAddQty.Name = "dfnAddQty";
            this.dfnAddQty.NamedProperties.Put("FieldFlags", "260");
            // 
            // dlgReceiveItem
            // 
            this.AcceptButton = this.cCommandButtonOK;
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            this.CancelButton = this.cCommandButtonCancel;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dfnAddQty);
            this.Controls.Add(this.dfnQtyAvailable);
            this.Controls.Add(this.dfnPartId);
            this.Controls.Add(this.dfnInventoryLocationId);
            this.Controls.Add(this.dfnInventoryId);
            this.Controls.Add(this.labelAddQty);
            this.Controls.Add(this.labelAvailableQty);
            this.Controls.Add(this.labelPartId);
            this.Controls.Add(this.labelInventoryLocationId);
            this.Controls.Add(this.labelInventoryId);
            this.Controls.Add(this.cCommandButtonList);
            this.Controls.Add(this.cCommandButtonOK);
            this.Controls.Add(this.cCommandButtonCancel);
            this.Name = "dlgReceiveItem";
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

        private cCommandButton cCommandButtonOK;
        private cCommandButton cCommandButtonCancel;
        private Ifs.Fnd.Windows.Forms.FndCommand commandOk;
        private Ifs.Fnd.Windows.Forms.FndCommand commandCancel;
        private cCommandButton cCommandButtonList;
        protected Fnd.Windows.Forms.FndCommand commandList;
        private cBackgroundText labelInventoryId;
        private cBackgroundText labelInventoryLocationId;
        private cBackgroundText labelPartId;
        private cBackgroundText labelAvailableQty;
        private cBackgroundText labelAddQty;
        private cDataField dfnInventoryId;
        private cDataField dfnInventoryLocationId;
        private cDataField dfnPartId;
        private cDataField dfnQtyAvailable;
        private cDataField dfnAddQty;

    }
}
