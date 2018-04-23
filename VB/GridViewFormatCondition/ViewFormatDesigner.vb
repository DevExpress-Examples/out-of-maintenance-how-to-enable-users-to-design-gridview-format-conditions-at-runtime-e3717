Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid

Namespace FormatCondititonsDesigner
	Friend Class ViewFormatDesigner
		' private members
		Protected gridView As GridView
		Protected gridColumn As GridColumn
		Protected simpleConditionDesigner As SimpleConditionDesigner
		Protected expressionConditionDesigner As ExpressionConditionDesigner

		' constructors
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal view As GridView)
			gridView = view
			AddHandler gridView.PopupMenuShowing, AddressOf gridView_PopupMenuShowing
		End Sub

		Private Function CreateFilterMenuItem(ByVal caption As String, ByVal stringForTag As String) As DXMenuCheckItem
			Dim item As New DXMenuCheckItem(caption, False, Nothing, New EventHandler(AddressOf OnFilterPanelItemClick))
			item.Tag = stringForTag
			Return item
		End Function

		' Menu item click handler.
		Private Sub OnFilterPanelItemClick(ByVal sender As Object, ByVal e As EventArgs)
			If gridView IsNot Nothing AndAlso gridColumn IsNot Nothing Then
				Dim currentTag As String = CStr((TryCast(sender, DXMenuCheckItem)).Tag)
				Select Case currentTag
					Case "Simple"
							ShowSimpleCondititonDesigner()
							Exit Select
					Case "Expression"
							ShowExpressionCondititonDesigner()
							Exit Select
					Case Else
				End Select
			End If
		End Sub

		Private Sub gridView_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
			If e.MenuType = GridMenuType.Column AndAlso e.HitInfo.Column IsNot Nothing Then
				e.Menu.Items.Add(CreateFilterMenuItem(CreateCaptionForCondition(e.HitInfo.Column, True), "Simple"))
				e.Menu.Items.Add(CreateFilterMenuItem(CreateCaptionForCondition(e.HitInfo.Column, False), "Expression"))
				gridColumn = e.HitInfo.Column
			End If
		End Sub

		Private Sub ShowSimpleCondititonDesigner()
			If simpleConditionDesigner Is Nothing Then
				simpleConditionDesigner = New SimpleConditionDesigner()
			End If
			simpleConditionDesigner.SourceGridView = gridView
			simpleConditionDesigner.SourceGridColumn = gridColumn
			simpleConditionDesigner.ShowDialog()
		End Sub

		Private Sub ShowExpressionCondititonDesigner()
			If expressionConditionDesigner Is Nothing Then
				expressionConditionDesigner = New ExpressionConditionDesigner()
			End If
			expressionConditionDesigner.SourceGridView = gridView
			expressionConditionDesigner.SourceGridColumn = gridColumn
			expressionConditionDesigner.ShowDialog()
		End Sub

		Private Function CreateCaptionForCondition(ByVal column As GridColumn, ByVal IsSimple As Boolean) As String
			Dim iConditionsCount As Integer = 0
			For Each item As StyleFormatCondition In gridView.FormatConditions
				If item.Column Is column Then
					If item.Condition = FormatConditionEnum.Expression AndAlso (Not IsSimple) Then
						iConditionsCount += 1
					End If
					If item.Condition <> FormatConditionEnum.Expression AndAlso IsSimple Then
						iConditionsCount += 1
					End If
				End If
			Next item
			Return String.Format("{0} conditions editor ({1})",If(IsSimple, "Simple", "Expression"), iConditionsCount)
		End Function
	End Class
End Namespace
