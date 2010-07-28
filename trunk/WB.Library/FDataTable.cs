using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Collections;
using System.Configuration;

namespace WB.Library
{
    public class FDataTable
    {
        public static List<string> ConvertColumn2Array(DataTable tbl, string colName)
        {
            List<string> cols = new List<string>();
            tbl.DefaultView.Sort = colName;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                if (!cols.Contains(tbl.DefaultView[i].Row[colName].ToString()))
                    cols.Add(tbl.DefaultView[i].Row[colName].ToString());
            }
            return cols;
        }

        public static DataTable QueryTable(DataTable table, string sort, params string[] query)
        {
            DataView view = new DataView(table);
            for (int i = 0; i < query.Length; i++)
            {
                view = new DataView(view.ToTable(), query[i], sort, DataViewRowState.CurrentRows);
            }
            return view.ToTable();
        }

        public static DataTable QueryTable(DataTable table, string sort, List<string> query)
        {
            DataView view = new DataView(table);
            for (int i = 0; i < query.Count; i++)
            {
                view = new DataView(view.ToTable(), query[i], sort, DataViewRowState.CurrentRows);
            }
            return view.ToTable();
        }

        public static DataTable TableSchema(string tableName, string connectstring)
        {
            string strSQL = @"Select o.[Name] TableName
                                  ,c.column_name AS ColumnName
                                  ,c.is_nullable AS IsNullable
                                  ,c.data_type AS DataType
                                  ,c.character_maximum_length AS MaxLength
                                  ,(Select ep.value
	                                    From (sys.objects o2 Left JOIN sys.extended_properties ep ON o2.object_id = ep.major_id)
		                                      LEFT JOIN syscolumns c2 ON ep.minor_id = c2.colid AND c2.id=o2.object_id
	                                    Where o.[type]='U' and o.object_id=o2.object_id and c.column_name=c2.name) AS Description
                                  ,(Select 	pk.CONSTRAINT_TYPE
		                            From 	INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk ,
			                            INFORMATION_SCHEMA.KEY_COLUMN_USAGE c3
		                            Where 	pk.TABLE_NAME = o.[Name] and c3.COLUMN_NAME=c.column_name
		                            and	c3.TABLE_NAME = pk.TABLE_NAME
		                            and	c3.CONSTRAINT_NAME = pk.CONSTRAINT_NAME) ConstraintType
                              From (sys.objects o INNER JOIN information_schema.columns c ON o.name=c.table_name)
                              Where o.[type]='U' and o.[Name]=@tablename
                              Order By Description";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tablename", tableName);
            return SqlHelper.ExecuteDataTable(connectstring, CommandType.Text, strSQL, param);
        }
    }
}

namespace WB.Library.TableSchema
{
    public class DataType
    {
        public const string Int = "Int";
        public const string Double = "Double";
        public const string String = "String";
        public const string DateTime = "DateTime";
        public const string Guid = "Guid";
    }

    public class ConstraintType
    {
        public const string PRIMARY_KEY = "PRIMARY KEY";
        public const string FOREIGN_KEY = "FOREIGN KEY";
        public const string NORMAL = "";
    }

    public class EControl
    {
        public const string Input = "input";
        public const string Area = "area";
        public const string FileUpload = "fileupload";
        public const string Date = "date";
        public const string DateTime = "datetime";
        public const string Email = "email";
        public const string Numric = "numric";
        public const string Combobox = "select";
        public const string Checkbox = "checkbox";
        public const string Radio = "radio";
    }

    public class UIControl
    {
        public const string UTextbox = "textbox";
        public const string UFileUpload = "fileupload";
        public const string UDropDownlist = "select";
    }

    public class EField
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// Kieu du lieu C#
        /// </summary>
        public string SqlDataType { get; set; }
        public string SDataType { get; set; }
        public bool IsNull { get; set; }
        public int MaxLength { get; set; }
        public bool IsShow { get; set; }
        public string FieldType { get; set; }
        public string Control { get; set; }
        public string UControl { get; set; }
        public Unit Width { get; set; }
        public Guid ColumnId { get; set; }
    }

    public class FTableSchema
    {
        public Guid TableId { get; set; }
        public string TableName { get; set; }
        public string TableTitle { get; set; }
        public int ColumnCount { get; set; }
        public List<EField> Schema { get; set; }
        public string ConnectString { get; set; }

        Hashtable param = new Hashtable();

        public string TableCollection
        {
            get { return !string.IsNullOrEmpty(ConfigurationManager.AppSettings["tables"]) ? ConfigurationManager.AppSettings["tables"] : "TablesCollection"; }
        }

        public string ColumnCollection
        {
            get { return !string.IsNullOrEmpty(ConfigurationManager.AppSettings["columns"]) ? ConfigurationManager.AppSettings["columns"] : "ColumnsCollection"; }
        }

        public static FTableSchema CreateInstant()
        {
            return new FTableSchema();
        }

        public FTableSchema()
        {
        }

        public FTableSchema(string tableName, string connectstring)
        {
            DataTable tbl = FDataTable.TableSchema(tableName, connectstring);
            ConnectString = connectstring;
            TableName = tableName;
            
            if (tbl != null && tbl.Rows.Count > 0)
            {
                ColumnCount = tbl.Rows.Count;
                Schema = new List<EField>();
                foreach (DataRow r in tbl.Rows)
                {
                    EField field = new EField();

                    DataTable columns = FillColumnCollection(r);
                    if (columns != null && columns.Rows.Count > 0)
                    {
                        DataRow col = columns.Rows[0];

                        field.TableName = col["TableName"].ToString();
                        field.ColumnName = col["ColumnName"].ToString();
                        field.IsNull = Convert.ToBoolean(col["IsNullable"]);
                        field.SDataType = GetSysType(col["SqlDataType"].ToString());
                        field.SqlDataType = col["SqlDataType"].ToString();
                        field.Control = col["Control"].ToString();
                        field.Title = col["Title"].ToString();
                        field.ColumnId = FGuid.ToGuid(col["ColumnId"]);

                        if (string.IsNullOrEmpty(col["Width"].ToString()))
                        {
                            field.Width = new Unit(100);
                        }
                        else
                        {
                            string w = FilterRegular.GetTextByRegex("[0-9]+", col["Width"].ToString());
                            if (col["Width"].ToString().IndexOf("%") != -1)
                                field.Width = new Unit(double.Parse(w), UnitType.Percentage);
                            else
                                field.Width = new Unit(int.Parse(w));
                        }

                        field.IsShow = true;
                        if (string.IsNullOrEmpty(field.Title))
                            field.IsShow = false;

                        field.MaxLength = 0;
                        if (!Convert.IsDBNull(col["MaxLength"]))
                            field.MaxLength = int.Parse(col["MaxLength"].ToString());

                        field.FieldType = ConstraintType.NORMAL;
                        if (Convert.IsDBNull(col["KeyType"]))
                        {
                            field.FieldType = ConstraintType.NORMAL;
                        }
                        else
                        {
                            field.FieldType = col["KeyType"].ToString();
                        }
                        field.UControl = UIControl.UTextbox;
                        Schema.Add(field);
                    }
                }
            }
        }

        #region Public
        public string GetTitle()
        {
            string strSQL = "Select * " +
                            "From {0} " +
                            "Where TableName=@TableName ";
            strSQL = string.Format(strSQL, TableCollection);
            SqlParameter param = new SqlParameter("@TableName", TableName);
            DataTable tbl = SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL, param);
            if (tbl != null && tbl.Rows.Count > 0)
                return tbl.Rows[0]["TableTitle"].ToString();
            return "";
        }

        public DataTable GetDataByColumnView()
        {
            if (!string.IsNullOrEmpty(TableName) && !string.IsNullOrEmpty(ConnectString))
            {
                string strSQL = "Select {0} " +
                                "From {1} " +
                                "Where TrangThai='1' ";
                bool f = false;
                string column = "";
                for (int i = 0; i < Schema.Count; i++)
                {
                    if (Schema[i].IsShow)
                    {
                        column += Schema[i].ColumnName + ",";
                        f = true;
                    }

                    if (f)
                    {
                        column = column.TrimEnd(',');
                    }
                }

                if (f)
                {
                    strSQL = string.Format(strSQL, column, TableName);
                    return SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL);
                }
            }
            return null;
        }

        public DataTable GetDataByColumnViewWithId()
        {
            if (!string.IsNullOrEmpty(TableName) && !string.IsNullOrEmpty(ConnectString))
            {
                string strSQL = "Select {0} " +
                                "From {1} " +
                                "Where TrangThai='1' ";
                bool f = false;
                string column = "";
                for (int i = 0; i < Schema.Count; i++)
                {
                    if (Schema[i].IsShow)
                    {
                        column += Schema[i].ColumnName + ",";
                        f = true;
                    }

                    if (f)
                    {
                        column = "Id" + column.TrimEnd(',');
                    }
                }

                if (f)
                {
                    strSQL = string.Format(strSQL, column, TableName);
                    return SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL);
                }
            }
            return null;
        }

        public DataTable GetDataAll()
        {
            if (!string.IsNullOrEmpty(TableName) && !string.IsNullOrEmpty(ConnectString))
            {
                string strSQL = "Select * " +
                                "From {0} " +
                                "Where TrangThai='1' " +
                                "Order By NgayTao Desc ";
                strSQL = string.Format(strSQL, TableName);
                return SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL);
            }
            return null;
        }

        public DataTable GetDataById(Guid Id)
        {
            if (!string.IsNullOrEmpty(TableName) && !string.IsNullOrEmpty(ConnectString))
            {
                string strSQL = "Select * " +
                                "From {0} " +
                                "Where TrangThai='1' and Id=@Id";
                SqlParameter param = new SqlParameter("@Id", Id);
                strSQL = string.Format(strSQL, TableName);
                return SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL, param);
            }
            return null;
        }

        public List<string> RowToColumn(DataRowView row)
        {
            List<string> columns = new List<string>();
            string td = "<td align='{1}'>{0}</td>";
            string tdUpdate = "<td align='center'><a href='/Modules/AddEditCatalog.aspx?id={0}&t={1}'><img src='/images/button/{2}.png'/></a></td>";
            string[] tds = new string[2];
            string val = "";
            string align = "";
            for (int i = 0; i < Schema.Count; i++)
            {
                if (Schema[i].IsShow)
                {
                    align = "left";
                    val = "";
                    if (!Convert.IsDBNull(row[Schema[i].ColumnName]) && Schema[i].FieldType != ConstraintType.PRIMARY_KEY && Schema[i].FieldType != ConstraintType.FOREIGN_KEY)
                    {
                        switch (Schema[i].SDataType)
                        {
                            case DataType.DateTime:
                                val = FDateTime.FormatDate(Convert.ToDateTime(row[Schema[i].ColumnName]));
                                align = "center";
                                break;
                            case DataType.Double:
                                val = FNumber.FormatNumber(Convert.ToDouble(row[Schema[i].ColumnName]), 2);
                                align = "right";
                                break;
                            case DataType.Int:
                                val = FNumber.FormatNumber(Convert.ToInt32(row[Schema[i].ColumnName]));
                                align = "right";
                                break;
                            case DataType.String:
                                val = row[Schema[i].ColumnName].ToString();
                                break;
                            default:
                                break;
                        }

                        columns.Add(string.Format(td, val, align));
                    }
                    //columns.Add(string.Format(td, val, align));
                }
                if (Schema[i].FieldType == ConstraintType.PRIMARY_KEY)
                {
                    tds[0] = string.Format(tdUpdate, row[Schema[i].ColumnName].ToString(), TableName, "edit");
                    //tds[1] = string.Format(tdUpdate, row[Schema[i].ColumnName].ToString(), TableName, "delete");
                }
            }
            columns.Add(tds[0]);
            //columns.Add(tds[1]);

            return columns;
        }

        #region Insert
        public void AddParam(EField field, string value)
        {
            switch (field.SDataType)
            {
                case DataType.String:
                    param[field.ColumnName] = value;
                    break;
                case DataType.Int:
                    param[field.ColumnName] = FNumber.ConvertInt(value);
                    break;
                case DataType.Double:
                    param[field.ColumnName] = FNumber.ConvertDouble(value);
                    break;
                case DataType.DateTime:
                    param[field.ColumnName] = FDateTime.ConvertDate(value);
                    break;
                case DataType.Guid:
                    param[field.ColumnName] = FGuid.ToGuid(value);
                    break;
            }
        }

        public void Insert()
        {
            string strSQL = "Insert Into {0} ({1}) " +
                            "Values ({2}) ";
            string column = "";
            string values = "";

            foreach (DictionaryEntry item in param)
            {
                column += item.Key + ",";
                values += "@" + item.Key + ",";
            }
            strSQL = string.Format(strSQL, TableName, column.TrimEnd(','), values.TrimEnd(','));
            SqlHelper.ExecuteDataTable(ConnectString, param, CommandType.Text, strSQL);
        }

        public void Update(Guid Id)
        {
            string strSQL = "Update {0} Set {1} " +
                            "Where {2} ";
            string column = "";

            foreach (DictionaryEntry item in param)
            {
                column += item.Key + "=@" + item.Key + ",";
            }
            param["Id"] = Id;
            strSQL = string.Format(strSQL, TableName, column.TrimEnd(','), "Id=@Id");
            SqlHelper.ExecuteDataTable(ConnectString, param, CommandType.Text, strSQL);
        }

        public void Delete(Guid Id)
        {
            string strSQL = "Update {0} Set TrangThai=0 Where {1}";
            param["Id"] = Id;
            strSQL = string.Format(strSQL, TableName, "Id=@Id");
            SqlHelper.ExecuteDataTable(ConnectString, param, CommandType.Text, strSQL);
        }
        #endregion

        #endregion

        #region Private
        DataTable FillColumnCollection(DataRow column)
        {
            string strSQL = @"
            If (Exists (Select * 
			            From {0}
			            Where TableName=@TableName and ColumnName=@ColumnName))
	            Select * 
	            From {0}
	            Where TableName=@TableName and ColumnName=@ColumnName
            Else
            Begin
	            Insert Into {0}(TableName, ColumnName, Title, IsNullable, MaxLength, KeyType, SqlDataType, IsShow)
	            Values (@TableName, @ColumnName, @Title, @IsNullable, @MaxLength, @KeType, @SqlDataType, @IsShow)

	            Select * 
	            From {0}
	            Where TableName=@TableName and ColumnName=@ColumnName
            End";

            strSQL = string.Format(strSQL, ColumnCollection);

            string description = column["Description"].ToString();
            if (description.LastIndexOf(";") > -1)
                description = description.Substring(description.LastIndexOf(";") + 1);

            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@TableName", TableName);
            param[1] = new SqlParameter("@ColumnName", column["ColumnName"]);
            param[2] = new SqlParameter("@Title", description);
            param[3] = new SqlParameter("@IsNullable", column["IsNullable"].ToString() == "YES" ? true : false);
            param[4] = new SqlParameter("@MaxLength", !Convert.IsDBNull(column["MaxLength"]) ? column["MaxLength"] : 0);
            param[5] = new SqlParameter("@KeType", column["ConstraintType"].ToString());
            param[6] = new SqlParameter("@SqlDataType", column["DataType"]);
            param[7] = new SqlParameter("@IsShow", !string.IsNullOrEmpty(description));

            return SqlHelper.ExecuteDataTable(ConnectString, CommandType.Text, strSQL, param);
        }

        string GetSysType(string type)
        {
            string t = DataType.String;

            if (type == "varchar" || type == "nvarchar" || type == "char" || type == "nchar" || type == "text" || type == "ntext")
            {
                t = DataType.String;
            }
            else if (type == "smallint" || type == "int" || type == "bigint")
            {
                t = DataType.Int;
            }
            else if (type == "float" || type == "money" || type == "real")
            {
                t = DataType.Double;
            }
            else if (type == "uniqueidentifier")
            {
                t = DataType.Guid;
            }
            else if (type == "smalldatetime" || type == "datetime")
            {
                t = DataType.DateTime;
            }

            return t;
        }
        #endregion

        #region Static
        public static DataTable GetTableNotLevel(string connectString)
        {
            string strSQL = "Select * " +
                            "From {0} " +
                            "Where IsMultiLevel=0 " +
                            "Order By TableName ";
            strSQL = string.Format(strSQL, FTableSchema.CreateInstant().TableCollection);
            return SqlHelper.ExecuteDataTable(connectString, CommandType.Text, strSQL);
        }

        public static void Update(string tableName, List<EField> fields, string connectString)
        {
            string strSQL = "";
            for (int i = 0; i < fields.Count; i++)
            {
                strSQL += "Update {0} " +
                          "Set Title=N'" + fields[i].Title + "'," +
                          "    KeyType='" + fields[i].FieldType + "'," +
                          "    IsShow='" + fields[i].IsShow.ToString() + "'," +
                          "    IsNullable='" + fields[i].IsNull.ToString() + "'," +
                          "    Control='" + fields[i].Control + "'," +
                          "    MaxLength=" + fields[i].MaxLength.ToString() + "," +
                          "    Width='" + fields[i].Width.ToString() + "'," +
                          "    ColumnId='" + fields[i].ColumnId.ToString() + "' " +
                          "Where TableName='" + tableName + "' and ColumnName='" + fields[i].ColumnName + "' \r\n ";
            }
            if (!string.IsNullOrEmpty(strSQL))
            {
                strSQL = string.Format(strSQL, FTableSchema.CreateInstant().ColumnCollection);
                SqlHelper.ExecuteNonQuery(connectString, CommandType.Text, strSQL);
            }
        }

        public static EField GetField(Guid Id, string connectString)
        {
            string strSQL = "Select * " +
                            "From {0} " +
                            "Where Id=@Id";
            strSQL = string.Format(strSQL, FTableSchema.CreateInstant().ColumnCollection);
            SqlParameter param = new SqlParameter("@Id", Id);

            DataTable columns = SqlHelper.ExecuteDataTable(connectString, CommandType.Text, strSQL, param);
            if (columns != null && columns.Rows.Count > 0)
            {
                DataRow col = columns.Rows[0];
                EField field = new EField();

                field.TableName = col["TableName"].ToString();
                field.ColumnName = col["ColumnName"].ToString();
                field.IsNull = Convert.ToBoolean(col["IsNullable"]);
                field.SDataType = FTableSchema.CreateInstant().GetSysType(col["SqlDataType"].ToString());
                field.SqlDataType = col["SqlDataType"].ToString();
                field.Control = col["Control"].ToString();
                field.Title = col["Title"].ToString();
                field.ColumnId = FGuid.ToGuid(col["ColumnId"]);

                if (string.IsNullOrEmpty(col["Width"].ToString()))
                {
                    field.Width = new Unit(100);
                }
                else
                {
                    string w = FilterRegular.GetTextByRegex("[0-9]+", col["Width"].ToString());
                    if (col["Width"].ToString().IndexOf("%") != -1)
                        field.Width = new Unit(double.Parse(w), UnitType.Percentage);
                    else
                        field.Width = new Unit(int.Parse(w));
                }

                field.IsShow = true;
                if (string.IsNullOrEmpty(field.Title))
                    field.IsShow = false;

                field.MaxLength = 0;
                if (!Convert.IsDBNull(col["MaxLength"]))
                    field.MaxLength = int.Parse(col["MaxLength"].ToString());

                field.FieldType = ConstraintType.NORMAL;
                if (Convert.IsDBNull(col["KeyType"]))
                {
                    field.FieldType = ConstraintType.NORMAL;
                }
                else
                {
                    field.FieldType = col["KeyType"].ToString();
                }
                field.UControl = UIControl.UTextbox;
                return field;
            }
            return null;
        }

        public static DataTable GetDataForeign(EField field, string connectString, out string columnForeignKey)
        {
            string strSQL = "Select * " +
                            "From {0} " +
                            "Where TrangThai=1 " +
                            "Order By {1} ";
            EField foreign = GetField(field.ColumnId, connectString);
            columnForeignKey = "";
            if (foreign != null)
            {
                strSQL = string.Format(strSQL, foreign.TableName, foreign.ColumnName);
                columnForeignKey = foreign.ColumnName;
                return SqlHelper.ExecuteDataTable(connectString, CommandType.Text, strSQL);
            }
            return null;
        }
        #endregion
    }
}