Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid

Namespace FormatCondititonsDesigner
	Public Class ItemCondition
		Public Shared ConditionsName As String = "(Format Conditions)"
		Private fcondition As StyleFormatCondition
		Public Sub New(ByVal fcondition As StyleFormatCondition)
			Me.fcondition = fcondition
		End Sub
		Public Overrides Function ToString() As String
			If fcondition.Condition <> FormatConditionEnum.None Then
				If fcondition.Condition <> FormatConditionEnum.Expression Then
					If fcondition.Condition = FormatConditionEnum.Between OrElse fcondition.Condition = FormatConditionEnum.NotBetween Then
						Return String.Format("{0} {1}, {2}", fcondition.Condition, fcondition.Value1, fcondition.Value2)
					Else
						Return String.Format("{0} {1}", fcondition.Condition, fcondition.Value1)
					End If
				Else
					Return String.Format("{0}", fcondition.Expression)
				End If
			End If
			Return String.Format("Condition Item - Index {0}", Index)
		End Function
		Public ReadOnly Property Index() As Integer
			Get
				Return fcondition.Collection.IndexOf(fcondition)
			End Get
		End Property
		Public ReadOnly Property Condition() As StyleFormatCondition
			Get
				Return fcondition
			End Get
		End Property
	End Class
End Namespace
