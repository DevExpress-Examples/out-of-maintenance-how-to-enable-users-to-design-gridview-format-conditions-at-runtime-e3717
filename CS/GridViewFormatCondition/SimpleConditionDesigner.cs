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

namespace FormatCondititonsDesigner
{
    public partial class SimpleConditionDesigner : DevExpress.XtraEditors.XtraForm
    {
        protected internal GridView SourceGridView { get; set; }
        protected internal GridColumn SourceGridColumn { get; set; }

        public SimpleConditionDesigner()
        {
            InitializeComponent();
            listBoxConditions.SelectedIndexChanged += new EventHandler(listBoxConditions_SelectedIndexChanged);
        }

        void listBoxConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemCondition selectedItem = listBoxConditions.SelectedItem as ItemCondition;
            condititonItemControlMain.Init(selectedItem);
            simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0;
        }

        private void SimpleConditionDesigner_Load(object sender, EventArgs e)
        {
            Text = String.Format("Simple condition for column: [{0}]", SourceGridColumn.Name);
            LoadCondititons();
            simpleButtonRemoveCondition.Enabled = listBoxConditions.Items.Count > 0;
        }

        void LoadCondititons()
        {
            listBoxConditions.Items.Clear();
            condititonItemControlMain.Init(null);
            foreach (StyleFormatCondition item in SourceGridView.FormatConditions)
            {
                if (item.Column == SourceGridColumn && item.Condition != FormatConditionEnum.Expression)
                {
                    AddItemToListBox(item);
                }
            }
        }

        private void simpleButtonAddCondititon_Click(object sender, EventArgs e)
        {
            if (SourceGridView == null) return;
            listBoxConditions.Items.BeginUpdate();
            CreateNewFormatCondition();
            listBoxConditions.Items.EndUpdate();
        }

        private void CreateNewFormatCondition()
        {
            StyleFormatCondition item = new StyleFormatCondition();
            item.Column = SourceGridColumn;
            SourceGridView.FormatConditions.Add(item);
            AddItemToListBox(item);
        }

        private void condititonItemControlMain_RefreshValues(object sender, EventArgs e)
        {
            listBoxConditions.Refresh();
        }

        private void simpleButtonRemoveCondition_Click(object sender, EventArgs e)
        {
            if (SourceGridView == null) return;
            ItemCondition condition = listBoxConditions.SelectedItem as ItemCondition;
            listBoxConditions.Items.Remove(listBoxConditions.SelectedItem);
            SourceGridView.FormatConditions.Remove(condition.Condition);
        }

        protected void AddItemToListBox(StyleFormatCondition newItem)
        {
            ItemCondition newItemCondition = new ItemCondition(newItem);
            listBoxConditions.Items.Add(newItemCondition);
            listBoxConditions.SelectedItem = newItemCondition;        
        }
    }
}