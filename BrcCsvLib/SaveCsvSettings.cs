using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BrcCsvLib
{
  public class SaveCsvSettings
  {
    private char _separator = ';';
    private bool _addQuotes = false;
    private bool _saveHeaderLine = false;

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
    /// If true, column values will be surrounded with quotes (")
    /// </summary>
    public bool AddQuotes
    {
      get { return _addQuotes; }
      set { _addQuotes = value; }
    }

    /// <summary>
    /// If true, first line of csv file will contain column names from the parent DataTable
    /// </summary>
    public bool SaveHeaderLine
    {
      get { return _saveHeaderLine; }
      set { _saveHeaderLine = value; }
    }
    #endregion Properties 

    #region Classes
    public class ColumnSerializingArgs
    {
      private object _value = null;
      private DataColumn _column = null;
      private string _newValue = null;

      /// <summary>
      /// Original value from the datatable. Column.DataType holds the data type
      /// </summary>
      public object Value
      {
        get { return _value; }
        set { _value = value; }
      }

      /// <summary>
      /// Column information
      /// </summary>
      public DataColumn Column
      {
        get { return _column; }
        set { _column = value; }
      }

      /// <summary>
      /// Value which will be saved to the csv files. Already contains the value for data types which could be automatically serialized.
      /// </summary>
      public string NewValue
      {
        get { return _newValue; }
        set { _newValue = value; }
      }
    }
    #endregion Classes 

    #region Events
    public delegate void ColumnSerializingDelegate(ColumnSerializingArgs args);
    public event ColumnSerializingDelegate ColumnSerializing;
    internal void RequestColumnSerialization(ColumnSerializingArgs args)
    {
      if (ColumnSerializing != null) ColumnSerializing(args);
    }
    #endregion Events 

  }
}
