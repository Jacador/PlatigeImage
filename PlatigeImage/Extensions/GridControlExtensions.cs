using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Grid;

namespace PlatigeImage.View.WinForms.Extensions
{
    public static class GridControlExtensions
    {
        public static int GetCurrentRowId(this GridView gridView)
        {
            int id = -1;
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                var rowId = gridView.GetRowCellValue(rowHandle, "Id");

                if (rowId != null)
                    id = Convert.ToInt32(rowId);
            }
            return id;
        }

        public static object? GetCurrentItem(this GridView gridView)
        {
            object? item = null;
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                item = gridView.GetRow(rowHandle);
            }

            return item;
        }
    }
}
