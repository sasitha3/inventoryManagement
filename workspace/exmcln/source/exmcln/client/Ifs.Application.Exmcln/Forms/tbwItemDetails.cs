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

namespace Ifs.Application.Exmcln
{

    /// <summary>
    /// </summary>
    [FndWindowRegistration("ITEM_DETAIL", "ItemDetail", "", FndWindowRegistrationFlags.HomePage, false, "")]
    public partial class tbwItemDetails : cTableWindow
    {
        #region Member Variables

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public tbwItemDetails()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }

        #endregion

        #region System Methods/Properties

        /// <summary>
        /// Returns the object instance associated with the window handle.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public new static tbwItemDetails FromHandle(SalWindowHandle handle)
        {
            return ((tbwItemDetails)SalWindow.FromHandle(handle, typeof(tbwItemDetails)));
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion

        #region Overrides

        #endregion

        #region Window Actions

        #endregion

        #region Event Handlers

        private void cmdRequire_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Require").ToHandle());
            
        }

        private void cmdRequire_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Require").ToHandle());

        }

        private void cmdDeliver_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Deliver").ToHandle());
            
        }

        private void cmdDeliver_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            
            this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Deliver").ToHandle());
            SendMessageToParent(Const.PM_DataSourceRefresh, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, 0);

        }

        private void cmdCancel_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Cancel").ToHandle());
            
        }

        private void cmdCancel_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Cancel").ToHandle());

        }
        #endregion

        #region Menu Event Handlers

        #endregion
    }
}
