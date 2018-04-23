Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Namespace FormatCondititonsDesigner
	Partial Public Class SimpleConditionDesigner
		Inherits DevExpress.XtraEditors.XtraForm
		Private privateSourceGridView As GridView
		Protected Friend Property SourceGridView() As GridView
			Get
				Return privateSourceGridView
			End Get
			Set(ByVal value As GridView)
				privateSourceGridView = value
			End Set
		End Property
		Private privateSourceGridColumn As GridColumn
		Protected Friend Property SourceGridColumn() As GridColumn
			Get
				Return privateSourceGridColumn
			End Get
			Set(ByVal value As GridColumn)
				privateSourceGridColumn = value
			End Set
		End Property

		Public Sub New()
			InitializeComponent()
			AddHandler listBoxConditions.SelectedIndexChanged, AddressOf listBoxConditions_SelectedIndexChanged
		End Sub

		Private Sub listBoxConditions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim selectedItem As ItemCondition = TryCast(listBoxConditions.SelectedItem, ItemCondition)
			condititonItemControlMain.Init(selectedItem)
			simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0
		End Sub

		Private Sub SimpleConditionDesigner_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Text = String.Format("Simple condition for column: [{0}]", SourceGridColumn.Name)
			LoadCondititons()
			simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0
		End Sub

		Private Sub LoadCondititons()
			listBoxConditions.Items.Clear()
			condititonItemControlMain.Init(Nothing)
			For Each item As StyleFormatCondition In SourceGridView.FormatConditions
                If item.Column.Equals(SourceGridColumn) AndAlso item.Condition <> FormatConditionEnum.Expression Then
                    AddItemToListBox(item)
                End If
			Next item
		End Sub

		Private Sub simpleButtonAddCondititon_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonAddCondititon.Click
			If SourceGridView Is Nothing Then
				Return
			End If
			listBoxConditions.Items.BeginUpdate()
			CreateNewFormatCondition()
			listBoxConditions.Items.EndUpdate()
		End Sub

		Private Sub CreateNewFormatCondition()
			Dim item As New StyleFormatCondition()
			item.Column = SourceGridColumn
			SourceGridView.FormatConditions.Add(item)
			AddItemToListBox(item)
		End Sub

		Private Sub condititonItemControlMain_RefreshValues(ByVal sender As Object, ByVal e As EventArgs) Handles condititonItemControlMain.RefreshValues
			listBoxConditions.Refresh()
		End Sub

		Private Sub simpleButtonRemoveCondition_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRemoveCondition.Click
			If SourceGridView Is Nothing Then
				Return
			End If
			Dim condition As ItemCondition = TryCast(listBoxConditions.SelectedItem, ItemCondition)
			listBoxConditions.Items.Remove(listBoxConditions.SelectedItem)
			SourceGridView.FormatConditions.Remove(condition.Condition)
		End Sub

		Protected Sub AddItemToListBox(ByVal newItem As StyleFormatCondition)
			Dim newItemCondition As New ItemCondition(newItem)
			listBoxConditions.Items.Add(newItemCondition)
			listBoxConditions.SelectedItem = newItemCondition
		End Sub
	End Class
End Namespace