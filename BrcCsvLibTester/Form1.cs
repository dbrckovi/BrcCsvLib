using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrcCsvLib;

namespace BrcCsvLibTester
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cmbSave_Separator.SelectedIndex = 0;

      #region Create 'Save' table
      DataTable table = new DataTable();
      table.Columns.Add("Column_int", typeof(int));
      table.Columns.Add("Column_long", typeof(long));
      table.Columns.Add("Column_float", typeof(float));
      table.Columns.Add("Column_double", typeof(double));
      table.Columns.Add("Column_decimal", typeof(decimal));
      table.Columns.Add("Column_string", typeof(string));
      table.Columns.Add("Column_DateTime", typeof(DateTime));
      table.Columns.Add("Column_Bool", typeof(bool));
      
      for (int x = 0; x <= 9; x++)
      {
        DataRow row = table.NewRow();
        row["Column_int"] = x;
        row["Column_long"] = x;
        row["Column_float"] = Convert.ToSingle(x) + .2;
        row["Column_double"] = Convert.ToDouble(x) + .3;
        row["Column_decimal"] = Convert.ToDecimal(x) + Convert.ToDecimal(.4);
        row["Column_string"] = string.Format("ABC{0}", x);
        row["Column_DateTime"] = DateTime.Now;
        row["Column_Bool"] = x % 2 == 0;
        table.Rows.Add(row);
      }

      dataSave.DataSource = table;
      #endregion Create 'Save' table 
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        SaveFileDialog dlg = new SaveFileDialog();
        dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        dlg.Filter = "Csv files|*.csv";
        DialogResult res = dlg.ShowDialog(this);
        if (res == DialogResult.Cancel) return;

        DataTable table = (DataTable)dataSave.DataSource;
        SaveCsvSettings sett = new SaveCsvSettings();
        sett.AddQuotes = chkSave_AddQuotes.Checked;
        sett.SaveHeaderLine = chkSave_IncludeHeader.Checked;
        sett.Separator = ((string)cmbSave_Separator.SelectedItem).ToCharArray()[0];
        sett.ColumnSerializing += Sett_ColumnSerializing;

        table.SaveToCsv(dlg.FileName, sett);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void Sett_ColumnSerializing(SaveCsvSettings.ColumnSerializingArgs args)
    {
      args.NewValue = args.Value.ToString();
    }
  }
}
