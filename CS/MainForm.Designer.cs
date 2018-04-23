namespace FormatCondititonsDesigner
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesDBDataSet = new FormatCondititonsDesigner.countriesDBDataSet();
            this.countriesTableAdapter = new FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOfficialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapital = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPopulation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLanguages = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.countriesDBDataSet;
            // 
            // countriesDBDataSet
            // 
            this.countriesDBDataSet.DataSetName = "countriesDBDataSet";
            this.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.countriesBindingSource;
            this.gridControlMain.Location = new System.Drawing.Point(10, 8);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(636, 420);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCountry,
            this.colOfficialName,
            this.colCurrency,
            this.colCapital,
            this.colArea,
            this.colPopulation,
            this.colLanguages});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 0;
            // 
            // colOfficialName
            // 
            this.colOfficialName.FieldName = "OfficialName";
            this.colOfficialName.Name = "colOfficialName";
            this.colOfficialName.Visible = true;
            this.colOfficialName.VisibleIndex = 1;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 2;
            // 
            // colCapital
            // 
            this.colCapital.FieldName = "Capital";
            this.colCapital.Name = "colCapital";
            this.colCapital.Visible = true;
            this.colCapital.VisibleIndex = 3;
            // 
            // colArea
            // 
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 4;
            // 
            // colPopulation
            // 
            this.colPopulation.FieldName = "Population";
            this.colPopulation.Name = "colPopulation";
            this.colPopulation.Visible = true;
            this.colPopulation.VisibleIndex = 5;
            // 
            // colLanguages
            // 
            this.colLanguages.FieldName = "Languages";
            this.colLanguages.Name = "colLanguages";
            this.colLanguages.Visible = true;
            this.colLanguages.VisibleIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 456);
            this.Controls.Add(this.gridControlMain);
            this.Name = "MainForm";
            this.Text = "Example main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private countriesDBDataSet countriesDBDataSet;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colOfficialName;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colCapital;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colPopulation;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguages;
    }
}

