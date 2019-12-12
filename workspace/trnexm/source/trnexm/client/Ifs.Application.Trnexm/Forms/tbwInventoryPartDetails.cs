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
    [FndWindowRegistration("EXM_INVENTORY_PRODUCT", "ExmInventoryProduct", "", FndWindowRegistrationFlags.HomePage, false, "")]        
    public partial class tbwInventoryPartDetails : cTableWindow
    {
        #region Member Variables

        #endregion

        #region Constructors/Destructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public tbwInventoryPartDetails()
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
        public new static tbwInventoryPartDetails FromHandle(SalWindowHandle handle)
        {
            return ((tbwInventoryPartDetails)SalWindow.FromHandle(handle, typeof(tbwInventoryPartDetails)));
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

        #endregion

        #region Menu Event Handlers

        private void cmdAddQty_Inquire(object sender, Fnd.Windows.Forms.FndCommandInquireEventArgs e)
        {
            Ifs.Fnd.Windows.Forms.FndCommand command = (Ifs.Fnd.Windows.Forms.FndCommand)sender;

            command.Enabled = false;

            command.Enabled = DataSourceCreateWindow(Ifs.Fnd.ApplicationForms.Const.METHOD_Inquire, (SalString)"dlgReceiveItem"); 

        }

        private void cmdAddQty_Execute(object sender, Fnd.Windows.Forms.FndCommandExecuteEventArgs e)
        {
            if (dlgReceiveItem.ModalDialog(Ifs.Fnd.ApplicationForms.Int.ExplorerForm) == Sys.IDOK)
            {
                DataSourceRefresh(Const.METHOD_Execute);
            }
        }
        #endregion
    }
}
