﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace SamplesData
{
  public class ViewModelBaseSimple
  {
    #region Constructor
    public ViewModelBaseSimple()
    {
      Init();
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set the Pager object
    /// </summary>
    public PDSAPager Pager { get; set; }
    /// <summary>
    /// Get/Set whether or not the pager is visible
    /// </summary>
    public bool IsPagerVisible { get; set; }
    /// <summary>
    /// Get/Set the page collection
    /// </summary>
    public PDSAPagerItemCollection Pages { get; set; }
     /// <summary>
    /// Get/Set the current sort direction
    /// </summary>
    public SortDirection SortDirection { get; set; }
    /// <summary>
    /// Get/Set the new sort direction
    /// </summary>
    public SortDirection SortDirectionNew { get; set; }
    /// <summary>
    /// Get/Set the current column you wish to sort on
    /// </summary>
    public string SortExpression { get; set; }
    /// <summary>
    /// Get/Set the last column you sorted on
    /// </summary>
    public string LastSortExpression { get; set; }
    /// <summary>
    /// Get/Set the current command executed on the client-side
    /// </summary>
    public string EventCommand { get; set; }
    /// <summary>
    /// Get/Set any parameters for the current command executed. This could be a page number for paging, etc.
    /// </summary>
    public string EventArgument { get; set; }
    #endregion

    #region Init Method
    public void Init()
    {
      EventCommand = string.Empty;
      EventArgument = string.Empty;
      
      SortExpression = string.Empty;
      LastSortExpression = string.Empty;
      SortDirection = SamplesData.SortDirection.Ascending;
      SortDirectionNew = SamplesData.SortDirection.Ascending;

      Pager = new PDSAPager();
      IsPagerVisible = true;
    }
    #endregion
        
    #region SetSortDirection Method
    protected virtual void SetSortDirection()
    {
      if (SortExpression == LastSortExpression)
      {
        if (SortDirection == SamplesData.SortDirection.Ascending)
          SortDirection = SamplesData.SortDirection.Descending;
        else
          SortDirection = SamplesData.SortDirection.Ascending;
      }
      else
      {
        SortDirection = SortDirectionNew;
      }
    }
    #endregion
    
    #region Sort Method
    protected virtual List<T> Sort<T>(IQueryable<T> list)
    {
      string orderby = SortExpression;

      // NOTE: Using System.Linq.Dynamic DLL
      list = list.OrderBy(SortExpression +
        (SortDirection == SamplesData.SortDirection.Ascending ? " ASC" : " DESC"));

      return list.ToList();
    }
    #endregion

    #region HandleRequest Method
    public virtual void HandleRequest()
    {
    }
    #endregion

    #region SetPagerObject Method
    protected virtual void SetPagerObject(int totalRecords)
    {
      // Set Pager Information
      Pager.TotalRecords = totalRecords;
      Pager.SetPagerProperties(EventArgument);

      // Build paging collection
      Pages = new PDSAPagerItemCollection(Pager.TotalRecords, Pager.PageSize, Pager.PageIndex);
      // Set total pages
      Pager.TotalPages = Pages.PageCount;
    }
    #endregion
  }
}
