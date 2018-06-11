using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SamplePageCSharp
{
    public partial class SqlBulkInsertWithEPPlus1 : System.Web.UI.Page
    {
        /// <summary>
        /// Download EPPlus Nuget Package
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Stored procedure needs to be added so with every upload a new table is created in database
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (uploader.HasFile)
                {
                    if (Path.GetExtension(uploader.FileName).Equals(".xlsx"))
                    {
                        var excelFile = new ExcelPackage(uploader.FileContent);
                        var datatable = excelFile.ToDataTable();
                        var table = "SampleTable";
                        using (var conn = new SqlConnection(GlobalConnection.Connection("SQLConnectorTester")))
                        {
                            var bulkCopy = new SqlBulkCopy(conn);
                            bulkCopy.DestinationTableName = table;
                            conn.Open();
                            var schema = conn.GetSchema("Columns", new[] { null, null, table, null });
                            foreach (DataColumn sourceColumn in datatable.Columns)
                            {
                                foreach (DataRow row in schema.Rows)
                                {
                                    if (string.Equals(sourceColumn.ColumnName, (string)row["COLUMN_NAME"], StringComparison.OrdinalIgnoreCase))
                                    {
                                        bulkCopy.ColumnMappings.Add(sourceColumn.ColumnName, (string)row["COLUMN_NAME"]);
                                        break;
                                    }
                                }
                            }
                            bulkCopy.WriteToServer(datatable);
                            lblShow.Text = "Check database.";
                    }
                }
            }
        }
    }
}