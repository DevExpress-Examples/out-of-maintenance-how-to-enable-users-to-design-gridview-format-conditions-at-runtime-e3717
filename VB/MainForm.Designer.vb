Imports Microsoft.VisualBasic
Imports System
Namespace FormatCondititonsDesigner
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.countriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.countriesDBDataSet = New FormatCondititonsDesigner.countriesDBDataSet()
			Me.countriesTableAdapter = New FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter()
			Me.gridControlMain = New DevExpress.XtraGrid.GridControl()
			Me.gridViewMain = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOfficialName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCurrency = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCapital = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colArea = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPopulation = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLanguages = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' countriesBindingSource
			' 
			Me.countriesBindingSource.DataMember = "Countries"
			Me.countriesBindingSource.DataSource = Me.countriesDBDataSet
			' 
			' countriesDBDataSet
			' 
			Me.countriesDBDataSet.DataSetName = "countriesDBDataSet"
			Me.countriesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' countriesTableAdapter
			' 
			Me.countriesTableAdapter.ClearBeforeFill = True
			' 
			' gridControlMain
			' 
			Me.gridControlMain.DataSource = Me.countriesBindingSource
			Me.gridControlMain.Location = New System.Drawing.Point(10, 8)
			Me.gridControlMain.MainView = Me.gridViewMain
			Me.gridControlMain.Name = "gridControlMain"
			Me.gridControlMain.Size = New System.Drawing.Size(636, 420)
			Me.gridControlMain.TabIndex = 0
			Me.gridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewMain})
			' 
			' gridViewMain
			' 
			Me.gridViewMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCountry, Me.colOfficialName, Me.colCurrency, Me.colCapital, Me.colArea, Me.colPopulation, Me.colLanguages})
			Me.gridViewMain.GridControl = Me.gridControlMain
			Me.gridViewMain.Name = "gridViewMain"
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 0
			' 
			' colOfficialName
			' 
			Me.colOfficialName.FieldName = "OfficialName"
			Me.colOfficialName.Name = "colOfficialName"
			Me.colOfficialName.Visible = True
			Me.colOfficialName.VisibleIndex = 1
			' 
			' colCurrency
			' 
			Me.colCurrency.FieldName = "Currency"
			Me.colCurrency.Name = "colCurrency"
			Me.colCurrency.Visible = True
			Me.colCurrency.VisibleIndex = 2
			' 
			' colCapital
			' 
			Me.colCapital.FieldName = "Capital"
			Me.colCapital.Name = "colCapital"
			Me.colCapital.Visible = True
			Me.colCapital.VisibleIndex = 3
			' 
			' colArea
			' 
			Me.colArea.FieldName = "Area"
			Me.colArea.Name = "colArea"
			Me.colArea.Visible = True
			Me.colArea.VisibleIndex = 4
			' 
			' colPopulation
			' 
			Me.colPopulation.FieldName = "Population"
			Me.colPopulation.Name = "colPopulation"
			Me.colPopulation.Visible = True
			Me.colPopulation.VisibleIndex = 5
			' 
			' colLanguages
			' 
			Me.colLanguages.FieldName = "Languages"
			Me.colLanguages.Name = "colLanguages"
			Me.colLanguages.Visible = True
			Me.colLanguages.VisibleIndex = 6
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(657, 456)
			Me.Controls.Add(Me.gridControlMain)
			Me.Name = "MainForm"
			Me.Text = "Example main form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.countriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.countriesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private countriesDBDataSet As countriesDBDataSet
		Private countriesBindingSource As System.Windows.Forms.BindingSource
		Private countriesTableAdapter As FormatCondititonsDesigner.countriesDBDataSetTableAdapters.CountriesTableAdapter
		Private gridControlMain As DevExpress.XtraGrid.GridControl
		Private gridViewMain As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colOfficialName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCurrency As DevExpress.XtraGrid.Columns.GridColumn
		Private colCapital As DevExpress.XtraGrid.Columns.GridColumn
		Private colArea As DevExpress.XtraGrid.Columns.GridColumn
		Private colPopulation As DevExpress.XtraGrid.Columns.GridColumn
		Private colLanguages As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

