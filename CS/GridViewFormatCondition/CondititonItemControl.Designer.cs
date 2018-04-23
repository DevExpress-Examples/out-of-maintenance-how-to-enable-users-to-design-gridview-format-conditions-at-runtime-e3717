namespace FormatCondititonsDesigner
{
    partial class CondititonItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControlCondititon = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditCondititon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlValue1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlValue2 = new DevExpress.XtraEditors.LabelControl();
            this.checkEditApplyToRow = new DevExpress.XtraEditors.CheckEdit();
            this.labelControlAppearance = new DevExpress.XtraEditors.LabelControl();
            this.propertyGridControlAppearance = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCondititon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControlAppearance)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlCondititon
            // 
            this.labelControlCondititon.Location = new System.Drawing.Point(12, 10);
            this.labelControlCondititon.Name = "labelControlCondititon";
            this.labelControlCondititon.Size = new System.Drawing.Size(53, 13);
            this.labelControlCondititon.TabIndex = 0;
            this.labelControlCondititon.Text = "Condititon:";
            // 
            // comboBoxEditCondititon
            // 
            this.comboBoxEditCondititon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEditCondititon.Location = new System.Drawing.Point(106, 7);
            this.comboBoxEditCondititon.Name = "comboBoxEditCondititon";
            this.comboBoxEditCondititon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCondititon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditCondititon.Size = new System.Drawing.Size(159, 20);
            this.comboBoxEditCondititon.TabIndex = 1;
            // 
            // labelControlValue1
            // 
            this.labelControlValue1.Location = new System.Drawing.Point(12, 37);
            this.labelControlValue1.Name = "labelControlValue1";
            this.labelControlValue1.Size = new System.Drawing.Size(36, 13);
            this.labelControlValue1.TabIndex = 2;
            this.labelControlValue1.Text = "Value1:";
            // 
            // labelControlValue2
            // 
            this.labelControlValue2.Location = new System.Drawing.Point(12, 64);
            this.labelControlValue2.Name = "labelControlValue2";
            this.labelControlValue2.Size = new System.Drawing.Size(36, 13);
            this.labelControlValue2.TabIndex = 3;
            this.labelControlValue2.Text = "Value2:";
            // 
            // checkEditApplyToRow
            // 
            this.checkEditApplyToRow.Location = new System.Drawing.Point(9, 90);
            this.checkEditApplyToRow.Name = "checkEditApplyToRow";
            this.checkEditApplyToRow.Properties.Caption = "Apply to Row";
            this.checkEditApplyToRow.Size = new System.Drawing.Size(93, 19);
            this.checkEditApplyToRow.TabIndex = 4;
            // 
            // labelControlAppearance
            // 
            this.labelControlAppearance.Location = new System.Drawing.Point(12, 124);
            this.labelControlAppearance.Name = "labelControlAppearance";
            this.labelControlAppearance.Size = new System.Drawing.Size(62, 13);
            this.labelControlAppearance.TabIndex = 5;
            this.labelControlAppearance.Text = "Appearance:";
            // 
            // propertyGridControlAppearance
            // 
            this.propertyGridControlAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridControlAppearance.Location = new System.Drawing.Point(12, 147);
            this.propertyGridControlAppearance.Name = "propertyGridControlAppearance";
            this.propertyGridControlAppearance.OptionsView.ShowRootCategories = false;
            this.propertyGridControlAppearance.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowOnlyInEditor;
            this.propertyGridControlAppearance.Size = new System.Drawing.Size(253, 192);
            this.propertyGridControlAppearance.TabIndex = 6;
            // 
            // CondititonItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertyGridControlAppearance);
            this.Controls.Add(this.labelControlAppearance);
            this.Controls.Add(this.checkEditApplyToRow);
            this.Controls.Add(this.labelControlValue2);
            this.Controls.Add(this.labelControlValue1);
            this.Controls.Add(this.comboBoxEditCondititon);
            this.Controls.Add(this.labelControlCondititon);
            this.Name = "CondititonItemControl";
            this.Size = new System.Drawing.Size(277, 342);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCondititon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditApplyToRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControlAppearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlCondititon;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCondititon;
        private DevExpress.XtraEditors.LabelControl labelControlValue1;
        private DevExpress.XtraEditors.LabelControl labelControlValue2;
        private DevExpress.XtraEditors.CheckEdit checkEditApplyToRow;
        private DevExpress.XtraEditors.LabelControl labelControlAppearance;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControlAppearance;
    }
}
