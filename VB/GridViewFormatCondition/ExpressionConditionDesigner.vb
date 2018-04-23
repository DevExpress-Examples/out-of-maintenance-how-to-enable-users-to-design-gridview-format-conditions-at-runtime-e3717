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
Imports DevExpress.XtraEditors.Design

Namespace FormatCondititonsDesigner
	Partial Public Class ExpressionConditionDesigner
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
		End Sub

		Private Sub ExpressionConditionDesigner_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Text = String.Format("Expression condition for column: [{0}]", SourceGridColumn.Name)
			LoadCondititons()
			UpdateEditors()
		End Sub

		Private Sub LoadCondititons()
			listBoxControlExpressions.Items.Clear()
			For Each item As StyleFormatCondition In SourceGridView.FormatConditions
                If item.Column.Equals(SourceGridColumn) AndAlso item.Condition = FormatConditionEnum.Expression Then
                    AddItemToListBox(item)
                End If
			Next item
		End Sub

		Private Sub listBoxControlExpressions_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControlExpressions.MouseDoubleClick
			Dim selectedItem As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			If selectedItem IsNot Nothing Then
				Using form As ExpressionEditorForm = New ConditionExpressionEditorForm(selectedItem.Condition, Nothing)
					form.StartPosition = FormStartPosition.CenterParent
					If form.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
						selectedItem.Condition.Condition = FormatConditionEnum.Expression
						selectedItem.Condition.Expression = form.Expression
					End If
				End Using
			End If
			listBoxControlExpressions.Refresh()
		End Sub

		Private Sub listBoxControlExpressions_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControlExpressions.SelectedIndexChanged
			Dim selectedItem As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			propertyGridControlAppearance.SelectedObject = If(selectedItem Is Nothing, Nothing, selectedItem.Condition.Appearance)
			checkEditApplyToRow.EditValue = If(selectedItem Is Nothing, False, CBool(selectedItem.Condition.ApplyToRow))
			UpdateEditors()
		End Sub

		Private Sub UpdateEditors()
			simpleButtonRemove.Enabled = listBoxControlExpressions.Items.Count > 0
			propertyGridControlAppearance.Enabled = listBoxControlExpressions.Items.Count > 0
			checkEditApplyToRow.Enabled = listBoxControlExpressions.Items.Count > 0
		End Sub

		Private Sub simpleButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonAdd.Click
			If SourceGridView Is Nothing Then
				Return
			End If
			listBoxControlExpressions.Items.BeginUpdate()
			CreateNewFormatCondition()
			listBoxControlExpressions.Items.EndUpdate()
		End Sub

		Private Sub CreateNewFormatCondition()
			Dim item As New StyleFormatCondition()
			item.Column = SourceGridColumn
			item.Condition = FormatConditionEnum.None
			SourceGridView.FormatConditions.Add(item)
			AddItemToListBox(item)
		End Sub

		Private Sub AddItemToListBox(ByVal item As StyleFormatCondition)
			Dim newItemCondition As New ItemCondition(item)
			listBoxControlExpressions.Items.Add(newItemCondition)
			listBoxControlExpressions.SelectedItem = newItemCondition
		End Sub

		Private Sub simpleButtonRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRemove.Click
			If SourceGridView Is Nothing Then
				Return
			End If
			RemoveFormatCondition()
		End Sub

		Private Sub RemoveFormatCondition()
			Dim condition As ItemCondition = TryCast(listBoxControlExpressions.SelectedItem, ItemCondition)
			listBoxControlExpressions.Items.Remove(listBoxControlExpressions.SelectedItem)
			SourceGridView.FormatConditions.Remove(condition.Condition)
		End Sub

		Private Sub checkEditApplyToRow_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEditApplyToRow.EditValueChanged
			If listBoxControlExpressions.SelectedItem IsNot Nothing Then
				TryCast(listBoxControlExpressions.SelectedItem, ItemCondition).Condition.ApplyToRow = CBool(checkEditApplyToRow.EditValue)
			End If
		End Sub
	End Class
End Namespace