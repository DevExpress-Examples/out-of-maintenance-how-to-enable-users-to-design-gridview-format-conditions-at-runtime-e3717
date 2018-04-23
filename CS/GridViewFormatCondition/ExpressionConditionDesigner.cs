using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Design;

namespace FormatCondititonsDesigner
{
    public partial class ExpressionConditionDesigner : DevExpress.XtraEditors.XtraForm
    {
        protected internal GridView SourceGridView { get; set; }
        protected internal GridColumn SourceGridColumn { get; set; }

        public ExpressionConditionDesigner()
        {
            InitializeComponent();
        }

        private void ExpressionConditionDesigner_Load(object sender, EventArgs e)
        {
            Text = String.Format("Expression condition for column: [{0}]", SourceGridColumn.Name);
            LoadCondititons();
            UpdateEditors();
        }

        void LoadCondititons()
        {
            listBoxControlExpressions.Items.Clear();
            foreach (StyleFormatCondition item in SourceGridView.FormatConditions)
            {
                if (item.Column == SourceGridColumn && item.Condition == FormatConditionEnum.Expression)
                {
                    AddItemToListBox(item);
                }
            }        
        }

        private void listBoxControlExpressions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ItemCondition selectedItem = listBoxControlExpressions.SelectedItem as ItemCondition;
            if (selectedItem != null)
            {
                using (ExpressionEditorForm form = new ConditionExpressionEditorForm(selectedItem.Condition, null))
                {
                    form.StartPosition = FormStartPosition.CenterParent;
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        selectedItem.Condition.Condition = FormatConditionEnum.Expression;
                        selectedItem.Condition.Expression = form.Expression;
                    }
                }
            }
            listBoxControlExpressions.Refresh();
        }

        private void listBoxControlExpressions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCondition selectedItem = listBoxControlExpressions.SelectedItem as ItemCondition;
            propertyGridControlAppearance.SelectedObject =  selectedItem == null ? null : selectedItem.Condition.Appearance;
            checkEditApplyToRow.EditValue = selectedItem == null ? false :(bool)selectedItem.Condition.ApplyToRow;
            UpdateEditors();
        }

        private void UpdateEditors()
        {
            simpleButtonRemove.Enabled = listBoxControlExpressions.Items.Count > 0;
            propertyGridControlAppearance.Enabled = listBoxControlExpressions.Items.Count > 0;
            checkEditApplyToRow.Enabled = listBoxControlExpressions.Items.Count > 0;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (SourceGridView == null) return;
            listBoxControlExpressions.Items.BeginUpdate();
            CreateNewFormatCondition();
            listBoxControlExpressions.Items.EndUpdate();
        }

        private void CreateNewFormatCondition()
        {
            StyleFormatCondition item = new StyleFormatCondition();
            item.Column = SourceGridColumn;
            item.Condition = FormatConditionEnum.None;
            SourceGridView.FormatConditions.Add(item);
            AddItemToListBox(item);
        }

        private void AddItemToListBox(StyleFormatCondition item)
        {
            ItemCondition newItemCondition = new ItemCondition(item);
            listBoxControlExpressions.Items.Add(newItemCondition);
            listBoxControlExpressions.SelectedItem = newItemCondition;
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            if (SourceGridView == null) return;
            RemoveFormatCondition();
        }

        private void RemoveFormatCondition()
        {
            ItemCondition condition = listBoxControlExpressions.SelectedItem as ItemCondition;
            listBoxControlExpressions.Items.Remove(listBoxControlExpressions.SelectedItem);
            SourceGridView.FormatConditions.Remove(condition.Condition);
        }

        private void checkEditApplyToRow_EditValueChanged(object sender, EventArgs e)
        {
            if (listBoxControlExpressions.SelectedItem != null)
            {
                (listBoxControlExpressions.SelectedItem as ItemCondition).Condition.ApplyToRow = (bool)checkEditApplyToRow.EditValue;
            }
        }
    }
}