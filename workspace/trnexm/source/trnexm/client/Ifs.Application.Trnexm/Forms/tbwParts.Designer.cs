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

    public partial class tbwParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbwParts));
            this.colnPartNo = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colsPartDescrption = new Ifs.Fnd.ApplicationForms.cColumn();
            this.colsType = new Ifs.Fnd.ApplicationForms.cLookupColumn();
            this.SuspendLayout();
            // 
            // commandManager
            // 
            this.commandManager.ImageList = null;
            // 
            // __colObjid
            // 
            resources.ApplyResources(this.@__colObjid, "__colObjid");
            // 
            // __colObjversion
            // 
            resources.ApplyResources(this.@__colObjversion, "__colObjversion");
            // 
            // colnPartNo
            // 
            this.colnPartNo.DataType = PPJ.Runtime.Windows.DataType.Number;
            this.colnPartNo.Name = "colnPartNo";
            this.colnPartNo.NamedProperties.Put("EnumerateMethod", "");
            this.colnPartNo.NamedProperties.Put("FieldFlags", "163");
            this.colnPartNo.NamedProperties.Put("Format", "");
            this.colnPartNo.NamedProperties.Put("LovReference", "");
            this.colnPartNo.NamedProperties.Put("SqlColumn", "PART_NO");
            this.colnPartNo.Position = 3;
            this.colnPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            resources.ApplyResources(this.colnPartNo, "colnPartNo");
            // 
            // colsPartDescrption
            // 
            this.colsPartDescrption.MaxLength = 200;
            this.colsPartDescrption.Name = "colsPartDescrption";
            this.colsPartDescrption.NamedProperties.Put("EnumerateMethod", "");
            this.colsPartDescrption.NamedProperties.Put("FieldFlags", "295");
            this.colsPartDescrption.NamedProperties.Put("LovReference", "");
            this.colsPartDescrption.NamedProperties.Put("SqlColumn", "PART_DESCRPTION");
            this.colsPartDescrption.Position = 4;
            resources.ApplyResources(this.colsPartDescrption, "colsPartDescrption");
            // 
            // colsType
            // 
            this.colsType.MaxLength = 200;
            this.colsType.Name = "colsType";
            this.colsType.NamedProperties.Put("EnumerateMethod", "PARTY_TYPE_API.Enumerate");
            this.colsType.NamedProperties.Put("FieldFlags", "295");
            this.colsType.NamedProperties.Put("LovReference", "");
            this.colsType.NamedProperties.Put("SqlColumn", "TYPE");
            this.colsType.Position = 5;
            resources.ApplyResources(this.colsType, "colsType");
            // 
            // tbwParts
            // 
            this.AutoScaleBaseDpi = new System.Drawing.Size(120, 120);
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.colnPartNo);
            this.Controls.Add(this.colsPartDescrption);
            this.Controls.Add(this.colsType);
            this.Name = "tbwParts";
            this.NamedProperties.Put("LogicalUnit", "ExmPart");
            this.NamedProperties.Put("Module", "TRNEXM");
            this.NamedProperties.Put("PackageName", "EXM_PART_API");
            this.NamedProperties.Put("ViewName", "EXM_PART");
            this.Controls.SetChildIndex(this.@__colObjversion, 0);
            this.Controls.SetChildIndex(this.colsType, 0);
            this.Controls.SetChildIndex(this.colsPartDescrption, 0);
            this.Controls.SetChildIndex(this.colnPartNo, 0);
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

        protected cColumn colnPartNo;
        protected cColumn colsPartDescrption;
        protected cLookupColumn colsType;
    }
}
