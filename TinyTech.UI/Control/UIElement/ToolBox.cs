using System.Collections.Generic;
using System.Data;
using FastMember;

namespace TinyTech.UI.Control.UIElement
{
    public class ToolBox<T>
    {
        public static DataTable GetDataTable(List<T> list)
        {
            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(list))
            {
                dt.Load(reader);
                return dt;
            }
        }
    }
}