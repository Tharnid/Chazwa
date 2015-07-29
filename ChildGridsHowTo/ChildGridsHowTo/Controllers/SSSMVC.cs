using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kendo.Mvc.UI;

namespace ChildGridsHowTo.Controllers
{
    public static class SSSMVC
    {

        public static Kendo.Mvc.UI.Fluent.GridBuilder<T> SSSGridReadOnly<T>
            (this System.Web.Mvc.HtmlHelper helper
            , string name
            , string height
            )
                    where T : class
        {
            return helper.Kendo().Grid<T>()
                .Name(name)
                .Pageable(pager => pager.Enabled(true).Refresh(false).PageSizes(true).Input(true).Numeric(false).PageSizes(new[] { 10, 25, 50, 100, 250, 500, 1000 }))
                .Filterable(f => f.Enabled(true).Mode(GridFilterMode.Menu))
                .ColumnMenu()
                //.Excel(excel => excel.AllPages(true).Filterable(true))
                //        //.Groupable()
                .Mobile()
                .Navigatable()
                //.Pdf(pdf => pdf.AllPages().Landscape())
                //.Reorderable()
                .Resizable(resize => resize.Columns(true))
                //.Selectable()
                .Sortable(o => o.SortMode(GridSortMode.SingleColumn))
                .Editable(e => e.Enabled(true))
                //.HtmlAttributes(new { style = "height: 400px;" })c
                .DataSource(dataSource => dataSource
                    .Ajax()
                    .PageSize(10)
                    .Batch(true)
                    )
                .Scrollable(s => s.Height(height))  //Auto=no scrolbars make as tall as necessary

                .ToolBar(toolbar =>
                {
                    //toolbar.Create();
                    //toolbar.Save();
                    //toolbar.Excel();
                    //toolbar.Pdf();
                    //toolbar.Template(//Lots of other options....)
                });
        }


    }
}