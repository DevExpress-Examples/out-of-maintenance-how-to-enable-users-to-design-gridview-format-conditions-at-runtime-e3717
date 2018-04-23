using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;

namespace FormatCondititonsDesigner
{
    class ViewFormatDesigner
    {
        // private members
        protected GridView gridView;
        protected GridColumn gridColumn;
        protected SimpleConditionDesigner simpleConditionDesigner;
        protected ExpressionConditionDesigner expressionConditionDesigner;

        // constructors
        public ViewFormatDesigner() : this(null) { }
        public ViewFormatDesigner(GridView view)
        {
            gridView = view;
            gridView.PopupMenuShowing += new PopupMenuShowingEventHandler(gridView_PopupMenuShowing);
        }

        DXMenuCheckItem CreateFilterMenuItem(string caption, string stringForTag)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, false, null, new EventHandler(OnFilterPanelItemClick));
            item.Tag = stringForTag;
            return item;
        }

        // Menu item click handler.
        void OnFilterPanelItemClick(object sender, EventArgs e)
        {
            if (gridView != null && gridColumn != null)
            {
                string currentTag = (string)(sender as DXMenuCheckItem).Tag;
                switch (currentTag)
                {
                    case "Simple":
                        {
                            ShowSimpleCondititonDesigner();
                            break;
                        }
                    case "Expression":
                        {
                            ShowExpressionCondititonDesigner();
                            break;
                        }
                    default:
                        break;
                }                
            }
        }

        void gridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Column && e.HitInfo.Column != null)
            {
                e.Menu.Items.Add(CreateFilterMenuItem(CreateCaptionForCondition(e.HitInfo.Column, true), "Simple"));
                e.Menu.Items.Add(CreateFilterMenuItem(CreateCaptionForCondition(e.HitInfo.Column, false), "Expression"));
                gridColumn = e.HitInfo.Column;
            }
        }

        void ShowSimpleCondititonDesigner()
        {
            if (simpleConditionDesigner == null)
            {
                simpleConditionDesigner = new SimpleConditionDesigner();
            }
            simpleConditionDesigner.SourceGridView = gridView;
            simpleConditionDesigner.SourceGridColumn = gridColumn;
            simpleConditionDesigner.ShowDialog();
        }

        void ShowExpressionCondititonDesigner()
        {
            if (expressionConditionDesigner == null)
            {
                expressionConditionDesigner = new ExpressionConditionDesigner();
            }
            expressionConditionDesigner.SourceGridView = gridView;
            expressionConditionDesigner.SourceGridColumn = gridColumn;
            expressionConditionDesigner.ShowDialog();        
        }

        string CreateCaptionForCondition(GridColumn column, bool IsSimple)
        {
            int iConditionsCount = 0;
            foreach (StyleFormatCondition item in gridView.FormatConditions)
            {
                if (item.Column == column)
                {
                    if (item.Condition == FormatConditionEnum.Expression && !IsSimple) iConditionsCount++;
                    if (item.Condition != FormatConditionEnum.Expression && IsSimple) iConditionsCount++;
                }
            }
            return String.Format("{0} conditions editor ({1})", IsSimple ? "Simple" : "Expression", iConditionsCount);
        }
    }
}
