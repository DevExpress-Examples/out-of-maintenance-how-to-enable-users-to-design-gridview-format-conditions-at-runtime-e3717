Imports Microsoft.VisualBasic
Imports System
Namespace FormatCondititonsDesigner
	Partial Public Class CondititonItemControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControlCondititon = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditCondititon = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControlValue1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControlValue2 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditApplyToRow = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControlAppearance = New DevExpress.XtraEditors.LabelControl()
			Me.propertyGridControlAppearance = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.comboBoxEditCondititon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditApplyToRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControlAppearance, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControlCondititon
			' 
			Me.labelControlCondititon.Location = New System.Drawing.Point(12, 10)
			Me.labelControlCondititon.Name = "labelControlCondititon"
			Me.labelControlCondititon.Size = New System.Drawing.Size(53, 13)
			Me.labelControlCondititon.TabIndex = 0
			Me.labelControlCondititon.Text = "Condititon:"
			' 
			' comboBoxEditCondititon
			' 
			Me.comboBoxEditCondititon.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.comboBoxEditCondititon.Location = New System.Drawing.Point(106, 7)
			Me.comboBoxEditCondititon.Name = "comboBoxEditCondititon"
			Me.comboBoxEditCondititon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditCondititon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditCondititon.Size = New System.Drawing.Size(159, 20)
			Me.comboBoxEditCondititon.TabIndex = 1
			' 
			' labelControlValue1
			' 
			Me.labelControlValue1.Location = New System.Drawing.Point(12, 37)
			Me.labelControlValue1.Name = "labelControlValue1"
			Me.labelControlValue1.Size = New System.Drawing.Size(36, 13)
			Me.labelControlValue1.TabIndex = 2
			Me.labelControlValue1.Text = "Value1:"
			' 
			' labelControlValue2
			' 
			Me.labelControlValue2.Location = New System.Drawing.Point(12, 64)
			Me.labelControlValue2.Name = "labelControlValue2"
			Me.labelControlValue2.Size = New System.Drawing.Size(36, 13)
			Me.labelControlValue2.TabIndex = 3
			Me.labelControlValue2.Text = "Value2:"
			' 
			' checkEditApplyToRow
			' 
			Me.checkEditApplyToRow.Location = New System.Drawing.Point(9, 90)
			Me.checkEditApplyToRow.Name = "checkEditApplyToRow"
			Me.checkEditApplyToRow.Properties.Caption = "Apply to Row"
			Me.checkEditApplyToRow.Size = New System.Drawing.Size(93, 19)
			Me.checkEditApplyToRow.TabIndex = 4
			' 
			' labelControlAppearance
			' 
			Me.labelControlAppearance.Location = New System.Drawing.Point(12, 124)
			Me.labelControlAppearance.Name = "labelControlAppearance"
			Me.labelControlAppearance.Size = New System.Drawing.Size(62, 13)
			Me.labelControlAppearance.TabIndex = 5
			Me.labelControlAppearance.Text = "Appearance:"
			' 
			' propertyGridControlAppearance
			' 
			Me.propertyGridControlAppearance.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.propertyGridControlAppearance.Location = New System.Drawing.Point(12, 147)
			Me.propertyGridControlAppearance.Name = "propertyGridControlAppearance"
			Me.propertyGridControlAppearance.OptionsView.ShowRootCategories = False
			Me.propertyGridControlAppearance.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowOnlyInEditor
			Me.propertyGridControlAppearance.Size = New System.Drawing.Size(253, 192)
			Me.propertyGridControlAppearance.TabIndex = 6
			' 
			' CondititonItemControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.propertyGridControlAppearance)
			Me.Controls.Add(Me.labelControlAppearance)
			Me.Controls.Add(Me.checkEditApplyToRow)
			Me.Controls.Add(Me.labelControlValue2)
			Me.Controls.Add(Me.labelControlValue1)
			Me.Controls.Add(Me.comboBoxEditCondititon)
			Me.Controls.Add(Me.labelControlCondititon)
			Me.Name = "CondititonItemControl"
			Me.Size = New System.Drawing.Size(277, 342)
			CType(Me.comboBoxEditCondititon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditApplyToRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControlAppearance, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControlCondititon As DevExpress.XtraEditors.LabelControl
		Private comboBoxEditCondititon As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControlValue1 As DevExpress.XtraEditors.LabelControl
		Private labelControlValue2 As DevExpress.XtraEditors.LabelControl
		Private checkEditApplyToRow As DevExpress.XtraEditors.CheckEdit
		Private labelControlAppearance As DevExpress.XtraEditors.LabelControl
		Private propertyGridControlAppearance As DevExpress.XtraVerticalGrid.PropertyGridControl
	End Class
End Namespace
