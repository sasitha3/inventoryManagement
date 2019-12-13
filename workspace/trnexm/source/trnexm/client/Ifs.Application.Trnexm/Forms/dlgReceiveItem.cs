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
using System.Diagnostics;
using Ifs.Fnd.ApplicationForms;
using PPJ.Runtime;
using PPJ.Runtime.Windows;

namespace Ifs.Application.Trnexm
{

    /// <summary>
    /// </summary>
    [FndWindowRegistration("", "", FndWindowRegistrationFlags.None)]
    public partial class dlgReceiveItem : cDialog
    {
        #region Member Variables
        SalWindowHandle hWndCurrentFocus = null;
        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        protected dlgReceiveItem()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }

        #endregion

        #region System Methods/Properties

        /// <summary>
        /// Shows the modal dialog.
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static SalNumber ModalDialog(Control owner)
        {
            dlgReceiveItem dlg = DialogFactory.CreateInstance<dlgReceiveItem>();
            SalNumber ret = dlg.ShowDialog(owner);
            return ret;
        }

        /// <summary>
        /// Returns the object instance associated with the window handle.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new static dlgReceiveItem FromHandle(SalWindowHandle handle)
        {
            return ((dlgReceiveItem)SalWindow.FromHandle(handle, typeof(dlgReceiveItem)));
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        private void dfnPartId_OnPM_DataItemValidate(object sender, WindowActionsEventArgs e)
        {
            e.Handled = true;
            SalNumber nReturn;
            SalBoolean bOK = false;
            SalString stmt = "";

            //Run framework valdation first, proceed if it succeeds, if set sendmessage it will be a nevr ending loop
            nReturn = Sal.SendClassMessage(Const.PM_DataItemValidate, e.WParam, e.LParam);
            if (nReturn == Sys.VALIDATE_Ok)
            {

                //call the DB function and assign the Quantity to appropriate data fied

                if (!this.dfnInventoryId.IsEmpty() && !this.dfnInventoryLocationId.IsEmpty() && !this.dfnPartId.IsEmpty())
                {

                    stmt = @":i_hWndFrame.dlgReceiveItem.dfnQtyAvailable := nvl(&AO.Exm_Inventory_Product_API.Get_Quantity(
                                                                                            :i_hWndFrame.dlgReceiveItem.dfnInventoryLocationId  IN,
                                                                                            :i_hWndFrame.dlgReceiveItem.dfnInventoryId          IN,
                                                                                            :i_hWndFrame.dlgReceiveItem.dfnPartId               IN), 0)";

                    bOK = DbPLSQLBlock(cSessionManager.c_hSql, stmt);
                    if (bOK)
                    {

                        e.Return = Sys.VALIDATE_Ok;
                    }
                    else
                    {

                        e.Return = Sys.VALIDATE_Cancel;
                    }
                }
            }
            else
            {
                e.Return = nReturn;
            }
        }
        #endregion

        #region Overrides

        #endregion

        #region Window Actions

        #endregion

        #region Event Handlers

        private void commandOk_Execute(object sender, Ifs.Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            // Dialog class have AcceptButton set to run this logic if the user ends the dialog using the Return button.
            // PPJ dialog close trough Sal.EndDialog so we set DialogResult to prevent the dialog from closing premature.
            DialogResult = DialogResult.None;
            SalBoolean bOK = false;
            SalString stmt = "";

            stmt = @"&AO.Exm_Inventory_Product_API.Add_prudct(
                                                                    :i_hWndFrame.dlgReceiveItem.dfnInventoryLocationId   IN,
                                                                    :i_hWndFrame.dlgReceiveItem.dfnInventoryId           IN,
                                                                    :i_hWndFrame.dlgReceiveItem.dfnPartId                IN,
                                                                    :i_hWndFrame.dlgReceiveItem.dfnAddQty                IN)";
            bOK = DbPLSQLTransaction(cSessionManager.c_hSql, stmt);

            Sal.EndDialog(this, Sys.IDOK);
        }

        private void commandCancel_Execute(object sender, Ifs.Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            // Dialog class have CancelButton set to run this logic even if the user close the dialog trough the esc button.
            // PPJ dialog close trough Sal.EndDialog so we set DialogResult to prevent the dialog from closing premature.
            DialogResult = DialogResult.None;

            Sal.EndDialog(this, Sys.IDCANCEL);
        }

        private void commandList_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            hWndCurrentFocus = Sal.GetFocus();
            command.Enabled = hWndCurrentFocus.SendMessage(Const.PM_DataItemLov, Const.METHOD_Inquire, 0);
        }

        private void commandList_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            hWndCurrentFocus.SendMessage(Const.PM_DataItemLov, Const.METHOD_Execute, 0);
        }

        private void commandCancel_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {

        }

        private void commandOk_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = false;
            if (!(dfnInventoryId.IsEmpty() || dfnInventoryLocationId.IsEmpty() || dfnPartId.IsEmpty()))
            {
                command.Enabled = true;
            }
        }


        private void dfnPartId_WindowActions(object sender, WindowActionsEventArgs e)
        {
            switch (e.ActionType)
            {

                case Const.PM_DataItemValidate:
                    dfnPartId_OnPM_DataItemValidate(sender, e);
                    break;
            }
        }

        #endregion

        #region Menu Event Handlers

        #endregion
    }
}
