using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BrcCsvLib
{
  public static class DatatableExtensions
  {
    /// <summary>
    /// Fills the DataTable from csv file, using rules defined in LoadCsvSettings
    /// </summary>
    /// <param name="table"></param>
    /// <param name="settings"></param>
    public static void LoadFromCsv(this DataTable table, string csvPath, LoadCsvSettings settings)
    {
      if (settings == null) throw new InvalidOperationException("LoadCsvSettings parameter is not defined");
      if (table.Columns.Count == 0) throw new InvalidOperationException("Parent DataTable has no columns defined");
    }

    /// <summary>
    /// Saves the DataTable to csv file, using rules defined in SaveCsvSettings
    /// </summary>
    /// <param name="table"></param>
    /// <param name="settings"></param>
    public static void SaveToCsv(this DataTable table, string csvPath, SaveCsvSettings settings)
    {
      if (settings == null) throw new InvalidOperationException("SaveCsvSettings parameter is not defined");
      if (table.Columns.Count == 0) throw new InvalidOperationException("Parent DataTable has no columns defined");

      StringBuilder sb = new StringBuilder();

      #region Header
      if (settings.SaveHeaderLine)
      {
        List<string> values = new List<string>();
        foreach (DataColumn column in table.Columns)
        {
          if (settings.AddQuotes) values.Add(string.Format("\"{0}\"", column.ColumnName));
          else values.Add(column.ColumnName);
        }
        sb.AppendLine(String.Join(settings.Separator.ToString(), values.ToArray()));
      }
      #endregion Header 

      #region Lines
      foreach (DataRow row in table.Rows)
      {
        List<string> values = new List<string>();

        for (int x = 0; x < table.Columns.Count; x++)
        {
          SaveCsvSettings.ColumnSerializingArgs args = new SaveCsvSettings.ColumnSerializingArgs();
          args.Column = table.Columns[x];
          args.Value = row[x];
          args.NewValue = row[x].ToString();
          settings.RequestColumnSerialization(args);
          if (string.IsNullOrEmpty(args.NewValue)) args.NewValue = "";
          if (settings.AddQuotes) args.NewValue = string.Format("\"{0}\"", args.NewValue);
          values.Add(args.NewValue);
        }
        sb.AppendLine(String.Join(settings.Separator.ToString(), values.ToArray()));
      }
      #endregion Lines 

      using (StreamWriter sw = File.CreateText(csvPath))
      {
        sw.Write(sb.ToString());
      }
    }
  }
}
