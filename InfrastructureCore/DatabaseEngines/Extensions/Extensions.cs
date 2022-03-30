using InfrastructureCore.DatabaseEngines.Model;
using LinqToDB.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Extensions
{
    public static class Extensions
    {
        private static string REGEX_REPLACE_SPECIAL_CHAR = @"[\D]";

        static public string[] ToArray(this IEnumerable<string> enumerable, string prefix)
        {
            List<string> spParams = new List<string>();
            enumerable.ToList<string>().ForEach(p => spParams.Add(prefix + p));
            return spParams.ToArray();
        }

        static public object GetProp(this object mapData, string propName)
        {
            var prop = mapData.GetType().GetProperty(propName);
            return prop.GetValue(mapData);
        }

        static public Dictionary<string, object> ToKeyValueDic(this JObject formData)
        {
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            var props = formData.GetType().GetProperties();
            foreach (PropertyInfo pi in props)
            {
                keyValues.Add(pi.Name, pi.GetValue(formData));
            }

            return keyValues;
        }

        public static IEnumerable<T> parseCellDataByTypefromExcel<T>(this DataSet dataSet)
        {
            List<T> results = new List<T>();
            DataTable dtnew = new DataTable();
            DataTable dtAlldata = dataSet.Tables[0];
            //New dataTable
            dtnew = dataSet.Tables[0].Clone();
            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                //Get list Model from(T)
                var ins = Activator.CreateInstance(typeof(T));

                foreach (DataColumn dataColumn in dtnew.Columns)
                //foreach (DataColumn dataColumn in dataSet.Tables[0].Columns)
                {

                    //Get type Column
                    var prop = typeof(T).GetProperty(dataColumn.ColumnName);
                    var typeFullName = "System.String";

                    if (prop != null)
                    {
                        //Get type Column
                        var a = typeof(T).Name.GetType();
                        var tyle = prop.GetType();
                        var GetMemberType = prop.GetMemberType();

                        typeFullName = GetMemberType.FullName;
                        if (typeFullName.Contains("System.DateTime"))
                        {
                            dataColumn.DataType = System.Type.GetType("System.DateTime");

                        }
                        else
                        {
                            dataColumn.DataType = System.Type.GetType(typeFullName);

                        }
                    }
                }
            }

            foreach (DataRow dataRow1 in dataSet.Tables[0].Rows)
            {
                int i = 0;
                int column = 0;
                DataRow drInsert = dtnew.NewRow();
                foreach (DataColumn dataColumn1 in dataSet.Tables[0].Columns)
                {
                    var namecl = dataColumn1.ColumnName;
                    var typerow = dataRow1[namecl].GetType();

                    var drType = drInsert.Table.Columns[namecl].DataType;

                    drInsert[i] = ConvertDynamicType(dataRow1[namecl].ToString(), drType);

                    //if (dataColumn1.DataType.FullName == "System.Int32" && dataRow1[namecl] == "")
                    //{
                    //    if (dtAlldata.Rows[i][namecl] != "" && dtAlldata.Rows[i][namecl] != null)
                    //    {
                    //        drInsert[i] = dataRow1[namecl];
                    //    }
                    //}
                    //else
                    //{
                    //    if (dtAlldata.Rows[column][namecl] != "" && dtAlldata.Rows[column][namecl] != null)
                    //    {
                    //        drInsert[i] = dataRow1[namecl];
                    //    }
                    //}

                    i++;

                }
                column++;
                dtnew.Rows.Add(drInsert);
            }

            if (dataSet.Tables.Count == 0)
            {
                return results;
            }

            foreach (DataRow dataRow in dtnew.Rows)
            {
                //Get list Model from (T)
                var ins = Activator.CreateInstance(typeof(T));

                foreach (DataColumn dataColumn in dtnew.Columns)
                //foreach (DataColumn dataColumn in dataSet.Tables[0].Columns)
                {

                    //Get type Column
                    var prop = typeof(T).GetProperty(dataColumn.ColumnName);
                    var typeFullName = "System.String";

                    if (prop == null)
                    {
                        var field = typeof(T).GetField(dataColumn.ColumnName);
                        if (field == null)
                        {
                            continue;
                        }
                        else
                        {
                            field.SetValue(ins, dataRow[dataColumn.ColumnName]);
                        }
                        continue;
                    }
                    try
                    {
                        switch (dataColumn.DataType.Name)
                        {
                            case "String":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? string.Empty : dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int16":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int16)0 : (Int16)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int32":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int32)0 : (Int32)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int64":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int32)0 : (Int32)(long)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Double":
                            case "Float":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? 0 : dataRow[dataColumn.ColumnName]);
                                break;
                            case "Boolean":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? false : dataRow[dataColumn.ColumnName]);
                                break;
                            case "DateTime":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (DateTime?)null : dataRow[dataColumn.ColumnName]);
                                break;
                            case "Decimal":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (decimal?)null : dataRow[dataColumn.ColumnName]);
                                break;
                            default:
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName]);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write(dataColumn);
                        throw ex;
                    }

                }

                results.Add((T)ins);
            }

            return results;
        }

        private static string ReplaceSpecialCharacter(string input)
        {
            return Regex.Replace(input, REGEX_REPLACE_SPECIAL_CHAR, "");
        }

        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || c == '-')
                {
                    sb.Append(c);
                }
                else if (c == '.')
                {
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }

        private static object ConvertDynamicType(string input, Type type)
        {
            switch (type.Name)
            {
                case "Int32":
                    if (string.IsNullOrEmpty(input)) input = "0";
                    //input = ReplaceSpecialCharacter(input);
                    input = RemoveSpecialCharacters(input);
                    return Int32.Parse(input);
                case "Int64":
                    if (string.IsNullOrEmpty(input)) input = "0";
                    //input = ReplaceSpecialCharacter(input);
                    input = RemoveSpecialCharacters(input);
                    return Int64.Parse(input);
                case "DateTime":
                    if (string.IsNullOrEmpty(input)) return DateTime.Now;
                    return DateTime.Parse(input);
                case "Double":
                    if (string.IsNullOrEmpty(input)) input = "0";
                    //input = ReplaceSpecialCharacter(input);
                    input = RemoveSpecialCharacters(input);
                    return float.Parse(input);
                case "Float":
                    if (string.IsNullOrEmpty(input)) input = "0";
                    //input = ReplaceSpecialCharacter(input);
                    input = RemoveSpecialCharacters(input);
                    return float.Parse(input);
                case "Decimal":
                    if (string.IsNullOrEmpty(input)) input = "0";
                    //input = ReplaceSpecialCharacter(input);
                    input = RemoveSpecialCharacters(input);
                    return Decimal.Parse(input);
                default:
                    return input;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static IEnumerable<T> FromDataSet<T>(this DataSet dataSet)
        {
            List<T> results = new List<T>();
            if (dataSet.Tables.Count == 0)
            {
                return results;
            }

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var ins = Activator.CreateInstance(typeof(T));
                foreach (DataColumn dataColumn in dataSet.Tables[0].Columns)
                {
                    var prop = typeof(T).GetProperty(dataColumn.ColumnName);
                    if (prop == null)
                    {
                        var field = typeof(T).GetField(dataColumn.ColumnName);
                        if (field == null)
                        {
                            continue;
                        }
                        else
                        {
                            field.SetValue(ins, dataRow[dataColumn.ColumnName]);
                        }
                        continue;
                    }
                    try
                    {
                        switch (dataColumn.DataType.Name)
                        {
                            case "String":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? string.Empty : dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int16":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int16)0 : (Int16)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int32":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int32)0 : (Int32)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Int64":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (Int32)0 : (Int32)(long)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Double":
                            case "Float":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? 0 : (Double)dataRow[dataColumn.ColumnName]);
                                break;
                            case "Boolean":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? false : dataRow[dataColumn.ColumnName]);
                                break;
                            case "DateTime":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (DateTime?)null : dataRow[dataColumn.ColumnName]);
                                break;
                            case "Decimal":
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (decimal?)null : dataRow[dataColumn.ColumnName]);
                                break;
                            default:
                                prop.SetValue(ins, dataRow[dataColumn.ColumnName]);
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write(dataColumn);
                        throw ex;
                    }

                    //prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? string.Empty : dataRow[dataColumn.ColumnName]);
                }

                results.Add((T)ins);
            }

            return results;
        }

        public static List<List<MapFieldDBModel>> FromDataSet(this DataSet dataSet)
        {

            //List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();
            List<List<MapFieldDBModel>> results = new List<List<MapFieldDBModel>>();
            if (dataSet.Tables.Count == 0)
            {
                return results;
            }

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                List<MapFieldDBModel> rows = new List<MapFieldDBModel>();
                foreach (DataColumn dataColumn in dataSet.Tables[0].Columns)
                {

                    object val = new object();
                    try
                    {
                        switch (dataColumn.DataType.Name)
                        {
                            case "String":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? string.Empty : dataRow[dataColumn.ColumnName], type = typeof(string) };
                                break;
                            case "Int16":
                            case "Int32":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? null : dataRow[dataColumn.ColumnName], type = typeof(int) };
                                break;
                            case "Int64":
                            case "Double":
                            case "Float":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? null : dataRow[dataColumn.ColumnName], type = typeof(float) };
                                break;
                            case "Decimal":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? null : dataRow[dataColumn.ColumnName], type = typeof(decimal) };
                                break;
                            case "Boolean":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? false : dataRow[dataColumn.ColumnName], type = typeof(bool) };
                                break;
                            case "DateTime":
                                val = new { value = dataRow[dataColumn.ColumnName] == DBNull.Value ? (DateTime?)null : dataRow[dataColumn.ColumnName], type = typeof(DateTime?) };
                                break;
                            default:
                                val = new { value = dataRow[dataColumn.ColumnName] };
                                break;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write(dataColumn);
                        throw ex;
                    }
                    MapFieldDBModel mapFieldDBModel = new MapFieldDBModel
                    {
                        Key = dataColumn.ColumnName,
                        Value = val.GetProp("value"),
                        Type = (Type)val.GetProp("type")
                    };
                    rows.Add(mapFieldDBModel);
                }
                results.Add(rows);
            }

            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public static T FromDataRow<T>(this DataRow dataRow)
        {
            if (dataRow == null)
            {
                return default(T);
            }
            var ins = Activator.CreateInstance(typeof(T));
            foreach (DataColumn dataColumn in dataRow.Table.Columns)
            {
                var prop = typeof(T).GetProperty(dataColumn.ColumnName);
                if (prop == null)
                {
                    var field = typeof(T).GetField(dataColumn.ColumnName);
                    if (field == null)
                    {
                        continue;
                    }
                    else
                    {
                        field.SetValue(ins, dataRow[dataColumn.ColumnName]);
                    }
                    continue;
                }

                try
                {
                    switch (dataColumn.DataType.Name)
                    {
                        case "String":
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? string.Empty : dataRow[dataColumn.ColumnName]);
                            break;
                        case "Int16":
                        case "Int32":
                        case "Int64":
                        case "Double":
                        case "Float":
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? 0 : dataRow[dataColumn.ColumnName]);
                            break;
                        case "Boolean":
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? false : dataRow[dataColumn.ColumnName]);
                            break;
                        case "DateTime":
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (DateTime?)null : dataRow[dataColumn.ColumnName]);
                            break;
                        case "Decimal":
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName] == DBNull.Value ? (decimal?)null : dataRow[dataColumn.ColumnName]);
                            break;
                        default:
                            prop.SetValue(ins, dataRow[dataColumn.ColumnName]);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(dataColumn);
                    throw ex;
                }
                //prop.SetValue(ins, dataRow[dataColumn.ColumnName]);
            }

            return (T)ins;
        }
    }
}
