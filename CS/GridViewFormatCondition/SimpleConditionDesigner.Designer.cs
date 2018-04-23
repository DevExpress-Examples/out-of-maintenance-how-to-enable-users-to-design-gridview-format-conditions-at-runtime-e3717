namespace FormatCondititonsDesigner
{
    partial class SimpleConditionDesigner
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButtonAddCondititon = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRemoveCondition = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxConditions = new DevExpress.XtraEditors.ListBoxControl();
            this.condititonItemControlMain = new FormatCondititonsDesigner.CondititonItemControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonAddCondititon
            // 
            this.simpleButtonAddCondititon.Location = new System.Drawing.Point(2, 3);
            this.simpleButtonAddCondititon.Name = "simpleButtonAddCondititon";
            this.simpleButtonAddCondititon.Size = new System.Drawing.Size(151, 24);
            this.simpleButtonAddCondititon.TabIndex = 0;
            this.simpleButtonAddCondititon.Text = "Add new condititon";
            this.simpleButtonAddCondititon.Click += new System.EventHandler(this.simpleButtonAddCondititon_Click);
            // 
            // simpleButtonRemoveCondition
            // 
            this.simpleButtonRemoveCondition.Location = new System.Drawing.Point(159, 3);
            this.simpleButtonRemoveCondition.Name = "simpleButtonRemoveCondition";
            this.simpleButtonRemoveCondition.Size = new System.Drawing.Size(151, 24);
            this.simpleButtonRemoveCondition.TabIndex = 1;
            this.simpleButtonRemoveCondition.Text = "RemoveCondition";
            this.simpleButtonRemoveCondition.Click += new System.EventHandler(this.simpleButtonRemoveCondition_Click);
            // 
            // listBoxConditions
            // 
            this.listBoxConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxConditions.Location = new System.Drawing.Point(6, 31);
            this.listBoxConditions.Name = "listBoxConditions";
            this.listBoxConditions.Size = new System.Drawing.Size(153, 302);
            this.listBoxConditions.TabIndex = 2;
            // 
            // condititonItemControlMain
            // 
            this.condititonItemControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.condititonItemControlMain.Location = new System.Drawing.Point(169, 37);
            this.condititonItemControlMain.Name = "condititonItemControlMain";
            this.condititonItemControlMain.Size = new System.Drawing.Size(242, 296);
            this.condititonItemControlMain.TabIndex = 3;
            this.condititonItemControlMain.RefreshValues += new System.EventHandler(this.condititonItemControlMain_RefreshValues);
            // 
            // SimpleConditionDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 342);
            this.Controls.Add(this.condititonItemControlMain);
            this.Controls.Add(this.listBoxConditions);
            this.Controls.Add(this.simpleButtonRemoveCondition);
            this.Controls.Add(this.simpleButtonAddCondititon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleConditionDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SimpleConditionDesigner";
            this.Load += new System.EventHandler(this.SimpleConditionDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxConditions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonAddCondititon;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemoveCondition;
        private DevExpress.XtraEditors.ListBoxControl listBoxConditions;
        private FormatCondititonsDesigner.CondititonItemControl condititonItemControlMain;

    }
}