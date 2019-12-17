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
    [FndWindowRegistration("CUS_ORDER_DETAILS", "CusOrderDetails", "", FndWindowRegistrationFlags.HomePage, false, "")]        
    public partial class frmCusOrderDetails : cMasterDetailTabFormWindow
    {
        #region Member Variables

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public frmCusOrderDetails()
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
        public new static frmCusOrderDetails FromHandle(SalWindowHandle handle)
        {
            return ((frmCusOrderDetails)SalWindow.FromHandle(handle, typeof(frmCusOrderDetails)));
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
        private void cmdPlan_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Plan").ToHandle());
            
        }

        private void cmdPlan_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Plan").ToHandle());

        }

        private void cmdRelease_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Release").ToHandle());
        }

        private void cmdRelease_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Release").ToHandle());

        }

        private void cmdCancel_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Cancel").ToHandle());

        }

        private void cmdCancel_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Cancel").ToHandle());

        }
        
        private void cmdClose_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;
            command.Enabled = this.SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, ((SalString)"Close").ToHandle());

        }

        private void cmdClose_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            SendMessage(Const.PM_DataRecordStateEvent, Ifs.Fnd.ApplicationForms.Const.METHOD_Execute, ((SalString)"Close").ToHandle());

        }
        #endregion
                
        #region Menu Event Handlers

        #endregion
    }
}
