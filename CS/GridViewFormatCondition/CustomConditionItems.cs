using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;

namespace FormatCondititonsDesigner
{
    public class ItemCondition
    {
        public static string ConditionsName = "(Format Conditions)";
        StyleFormatCondition fcondition;
        public ItemCondition(StyleFormatCondition fcondition)
        {
            this.fcondition = fcondition;
        }
        public override string ToString()
        {
            if (fcondition.Condition != FormatConditionEnum.None)
                if (fcondition.Condition != FormatConditionEnum.Expression)
                    if (fcondition.Condition == FormatConditionEnum.Between || fcondition.Condition == FormatConditionEnum.NotBetween)
                        return string.Format("{0} {1}, {2}", fcondition.Condition, fcondition.Value1, fcondition.Value2);
                    else
                        return string.Format("{0} {1}", fcondition.Condition, fcondition.Value1);
                else
                    return string.Format("{0}", fcondition.Expression);
            return string.Format("Condition Item - Index {0}", Index);
        }
        public int Index { get { return fcondition.Collection.IndexOf(fcondition); } }
        public StyleFormatCondition Condition { get { return fcondition; } }
    }
}
