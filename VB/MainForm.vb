Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid

Namespace FormatCondititonsDesigner
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'countriesDBDataSet.Countries' table. You can move, or remove it, as needed.
			Me.countriesTableAdapter.Fill(Me.countriesDBDataSet.Countries)
			Dim newFormatDesigner As New ViewFormatDesigner(gridViewMain)
		End Sub
	End Class
End Namespace
