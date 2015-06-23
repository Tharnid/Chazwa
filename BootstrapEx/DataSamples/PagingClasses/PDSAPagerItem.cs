using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSamples
{
    public class PDSAPagerItemCollection : List<PDSAPagerItem>
    {
        #region Constructor
        public PDSAPagerItemCollection(int rowCount, int pageSize, int pageIndex)
        {
            // Calculate total pages based on RowCount and PageSize
            int pageCount = 0;

            pageCount = Convert.ToInt32(
                          Math.Ceiling(
                             Convert.ToDecimal(rowCount) /
                             Convert.ToDecimal(pageSize)));

            // Initialize the collection of pager items
            Init(pageCount, pageIndex);
        }
        #endregion

        #region Public Properties
        public int PageCount { get; set; }
        #endregion

        #region Init Method
        private void Init(int pageCount, int pageIndex)
        {
            int itemIndex = 0;

            PageCount = pageCount;

            Add(new PDSAPagerItem(PDSAPagerCommands.FirstText,
                                  PDSAPagerCommands.First,
                                  (pageIndex == 0), PDSAPagerCommands.FirstTooltipText));
            itemIndex++;
            Add(new PDSAPagerItem(PDSAPagerCommands.PreviousText,
                                  PDSAPagerCommands.Previous,
                                  (pageIndex == 0), PDSAPagerCommands.PreviousTooltipText));
            itemIndex++;

            for (int i = 0; i < PageCount; i++)
            {
                Add(new PDSAPagerItem(i, pageIndex,
                                      PDSAPagerCommands.PageText + " " + (i + 1).ToString()));
                itemIndex++;
            }

            Add(new PDSAPagerItem(PDSAPagerCommands.NextText,
                                  PDSAPagerCommands.Next,
                                  (PageCount - 1 == pageIndex), PDSAPagerCommands.NextTooltipText));
            itemIndex++;
            Add(new PDSAPagerItem(PDSAPagerCommands.LastText,
                                  PDSAPagerCommands.Last,
                                  (PageCount - 1 == pageIndex), PDSAPagerCommands.LastTooltipText));
        }
        #endregion
    }
}
