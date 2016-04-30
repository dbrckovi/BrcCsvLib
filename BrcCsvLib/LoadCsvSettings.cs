using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrcCsvLib
{
  public class LoadCsvSettings
  {
    private char _separator = ';';
    private bool _removeQuotes = true;
    private bool _removeHeaderLine = false;

    #region Properties
    /// <summary>
    /// Csv column separator character
    /// </summary>
    public char Separator
    {
      get { return _separator; }
      set { _separator = value; }
    }

    /// <summary>
    /// If true, quotations around cell values will be removed (only if both, leading and trailing, quotation marks are present)
    /// </summary>
    public bool RemoveQuotes
    {
      get { return _removeQuotes; }
      set { _removeQuotes = value; }
    }

    /// <summary>
    /// If true, first line in the csv file will be removed
    /// </summary>
    public bool RemoveHeaderLine
    {
      get { return _removeHeaderLine; }
      set { _removeHeaderLine = false; }
    }
    #endregion Properties 
  }
}
