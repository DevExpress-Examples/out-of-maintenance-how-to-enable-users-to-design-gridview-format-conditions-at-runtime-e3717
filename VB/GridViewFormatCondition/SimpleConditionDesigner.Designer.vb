Imports Microsoft.VisualBasic
Imports System
Namespace FormatCondititonsDesigner
	Partial Public Class SimpleConditionDesigner
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
			Me.simpleButtonAddCondititon = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButtonRemoveCondition = New DevExpress.XtraEditors.SimpleButton()
			Me.listBoxConditions = New DevExpress.XtraEditors.ListBoxControl()
			Me.condititonItemControlMain = New FormatCondititonsDesigner.CondititonItemControl()
			CType(Me.listBoxConditions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButtonAddCondititon
			' 
			Me.simpleButtonAddCondititon.Location = New System.Drawing.Point(2, 3)
			Me.simpleButtonAddCondititon.Name = "simpleButtonAddCondititon"
			Me.simpleButtonAddCondititon.Size = New System.Drawing.Size(151, 24)
			Me.simpleButtonAddCondititon.TabIndex = 0
			Me.simpleButtonAddCondititon.Text = "Add new condititon"
'			Me.simpleButtonAddCondititon.Click += New System.EventHandler(Me.simpleButtonAddCondititon_Click);
			' 
			' simpleButtonRemoveCondition
			' 
			Me.simpleButtonRemoveCondition.Location = New System.Drawing.Point(159, 3)
			Me.simpleButtonRemoveCondition.Name = "simpleButtonRemoveCondition"
			Me.simpleButtonRemoveCondition.Size = New System.Drawing.Size(151, 24)
			Me.simpleButtonRemoveCondition.TabIndex = 1
			Me.simpleButtonRemoveCondition.Text = "RemoveCondition"
'			Me.simpleButtonRemoveCondition.Click += New System.EventHandler(Me.simpleButtonRemoveCondition_Click);
			' 
			' listBoxConditions
			' 
			Me.listBoxConditions.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.listBoxConditions.Location = New System.Drawing.Point(6, 31)
			Me.listBoxConditions.Name = "listBoxConditions"
			Me.listBoxConditions.Size = New System.Drawing.Size(153, 302)
			Me.listBoxConditions.TabIndex = 2
			' 
			' condititonItemControlMain
			' 
			Me.condititonItemControlMain.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.condititonItemControlMain.Location = New System.Drawing.Point(169, 37)
			Me.condititonItemControlMain.Name = "condititonItemControlMain"
			Me.condititonItemControlMain.Size = New System.Drawing.Size(242, 296)
			Me.condititonItemControlMain.TabIndex = 3
'			Me.condititonItemControlMain.RefreshValues += New System.EventHandler(Me.condititonItemControlMain_RefreshValues);
			' 
			' SimpleConditionDesigner
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(423, 342)
			Me.Controls.Add(Me.condititonItemControlMain)
			Me.Controls.Add(Me.listBoxConditions)
			Me.Controls.Add(Me.simpleButtonRemoveCondition)
			Me.Controls.Add(Me.simpleButtonAddCondititon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SimpleConditionDesigner"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "SimpleConditionDesigner"
'			Me.Load += New System.EventHandler(Me.SimpleConditionDesigner_Load);
			CType(Me.listBoxConditions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents simpleButtonAddCondititon As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButtonRemoveCondition As DevExpress.XtraEditors.SimpleButton
		Private listBoxConditions As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents condititonItemControlMain As FormatCondititonsDesigner.CondititonItemControl

	End Class
End Namespace