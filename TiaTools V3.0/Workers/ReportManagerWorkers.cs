using System;
using System.IO;
using System.Data;
using System.Xml.Linq;

namespace TiaTools_V3._0.Workers
{
    class ReportManagerWorkers
    {
        public static void PrintReportManagerAppconfig(DataTable dataTable, string filePath)
        {
            try
            {
                XDocument AppConfig = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Config"));

                XElement genConfig = new XElement("GenConfig");
                XElement sqlConnConfig = new XElement("SqlConnConfig");
                XElement sqlTableConfig = new XElement("SqlTableConfig");

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Config"].ToString() == "MainFormWidth")
                    {
                        genConfig.Add(new XElement("MainFormWidth", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "MainFormHeight")
                    {
                        genConfig.Add(new XElement("MainFormHeight", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "ChildFormWidth")
                    {
                        genConfig.Add(new XElement("ChildFormWidth", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "ChildFormHeight")
                    {
                        genConfig.Add(new XElement("ChildFormHeight", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "FullScreen")
                    {
                        genConfig.Add(new XElement("FullScreen", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "DefLenguage")
                    {
                        genConfig.Add(new XElement("DefLenguage", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "DefReportPath")
                    {
                        genConfig.Add(new XElement("DefReportPath", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "DefReportFileName")
                    {
                        genConfig.Add(new XElement("DefReportFileName", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "CsvSeparator")
                    {
                        genConfig.Add(new XElement("CsvSeparator", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "IsAlarmLog")
                    {
                        genConfig.Add(new XElement("IsAlarmLog", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "IsEventLog")
                    {
                        genConfig.Add(new XElement("IsEventLog", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "IsVirtualKeyBoard")
                    {
                        genConfig.Add(new XElement("IsVirtualKeyBoard", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlType")
                    {
                        sqlConnConfig.Add(new XElement("SqlType", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlServerIP")
                    {
                        sqlConnConfig.Add(new XElement("SqlServerIP", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlServerName")
                    {
                        sqlConnConfig.Add(new XElement("SqlServerName", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlDbName")
                    {
                        sqlConnConfig.Add(new XElement("SqlDbName", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlUserID")
                    {
                        sqlConnConfig.Add(new XElement("SqlUserID", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlUserPWD")
                    {
                        sqlConnConfig.Add(new XElement("SqlUserPWD", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "SqlDateTimeFormat")
                    {
                        sqlConnConfig.Add(new XElement("SqlDateTimeFormat", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "VarLogTable")
                    {
                        sqlTableConfig.Add(new XElement("VarLogTable", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "EventsLogTable")
                    {
                        sqlTableConfig.Add(new XElement("EventsLogTable", $"{row["Config_Value"]}"));
                    }
                    if (row["Config"].ToString() == "AlarmsLogTable")
                    {
                        sqlTableConfig.Add(new XElement("AlarmsLogTable", $"{row["Config_Value"]}"));
                    }
                }

                AppConfig.Element("Config").Add(genConfig); 
                AppConfig.Element("Config").Add(sqlConnConfig);
                AppConfig.Element("Config").Add(sqlTableConfig);

                AppConfig.Save(filePath + @"\AppConfig.xml");

            }
            catch (Exception ex)
            {
                throw new Exception("ReportManagerWorkers.PrintReportManagerAppconfig " + ex.Message);
            }
        }

        public static void PrintReportManagerMsgconfig(DataTable dataTable, string filePath)
        {
            try
            {
                XDocument alarmConfig = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Config"));

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["LogAlarm_Description_IT"].ToString() != "")
                    {
                        XElement logAlarm = new XElement("Alarm",
                        new XElement("AlarmTag", $"{row["LogAlarm_Col_Name"]}"),
                        new XElement("AlarmText_IT", $"{row["LogAlarm_Description_IT"]}".Replace("->", "-")));

                        logAlarm.Add(new XElement("AlarmText_EN", $"{row["LogAlarm_Description_EN"]}".Replace("->", "-")));

                        logAlarm.Add(new XElement("AlarmText_FR", $"{row["LogAlarm_Description_FR"]}".Replace("->", "-")));

                        logAlarm.Add(new XElement("AlarmText_DE", $"{row["LogAlarm_Description_DE"]}".Replace("->", "-")));

                        logAlarm.Add(new XElement("AlarmText_ES", $"{row["LogAlarm_Description_ES"]}".Replace("->", "-")));

                        alarmConfig.Element("Config").Add(logAlarm);
                    }
                }

                alarmConfig.Save(filePath + @"\AlarmsConfig.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("ReportManagerWorkers.PrintReportManagerMsgconfig " + ex.Message);
            }
        }

        public static void PrintReportManagerEventconfig(DataTable dataTable, string filePath)
        {
            try
            {
                XDocument eventConfig = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Config"));

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["LogEvent_Description_IT"].ToString() != "")
                    {
                        XElement logEvent = new XElement("Event",
                        new XElement("EventTag", $"{row["LogEvent_Description_IT"]}"),
                        new XElement("EventText_IT", $"{row["LogEvent_Description_IT"]}"));

                        logEvent.Add(new XElement("EventText_EN", $"{row["LogEvent_Description_EN"]}".Replace("->", "-")));

                        logEvent.Add(new XElement("EventText_FR", $"{row["LogEvent_Description_FR"]}".Replace("->", "-")));

                        logEvent.Add(new XElement("EventText_DE", $"{row["LogEvent_Description_DE"]}".Replace("->", "-")));

                        logEvent.Add(new XElement("EventText_ES", $"{row["LogEvent_Description_ES"]}".Replace("->", "-")));

                        eventConfig.Element("Config").Add(logEvent);
                    }
                }

                eventConfig.Save(filePath + @"\EventsConfig.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("ReportManagerWorkers.PrintReportManagerMsgconfig " + ex.Message);
            }
        }

        public static void PrintReportManagerLogVarconfig(DataTable dataTable, string filePath)
        {
            try
            {
                XDocument logVarConfig = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("Config"));

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["LogVar_Description_IT"].ToString() != "")
                    {
                        XElement logVar = new XElement("Var",
                        new XElement("ColName", $"{row["LogVar_Col_Name"]}"));

                        if (row["LogVar_Col_Name"].ToString() != "Bool")
                        {
                            logVar.Add(new XElement("VarType", $"Bool"));
                        }
                        else if (row["LogVar_Col_Name"].ToString() != "Real")
                        {
                            logVar.Add(new XElement("VarType", $"Real"));
                        }
                        else if (row["LogVar_Col_Name"].ToString() != "String")
                        {
                            logVar.Add(new XElement("VarType", $"String"));
                        }
                        else if (row["LogVar_Col_Name"].ToString() != "BatchID")
                        {
                            logVar.Add(new XElement("VarType", $"String"));
                        }

                        if (row["Default_Show_Data"].ToString() == "NOT_ALLOWED")
                        {
                            logVar.Add(new XElement("DefShow", $"False"));
                        }
                        else
                        {
                            logVar.Add(new XElement("DefShow", $"{row["Default_Show_Data"]}"));
                        }

                        if (row["Default_Plot"].ToString() == "NOT_ALLOWED")
                        {
                            logVar.Add(new XElement("DefPlot", $"False"));
                        }
                        else
                        {
                            logVar.Add(new XElement("DefPlot", $"{row["Default_Plot"]}"));
                        }

                        if (row["Default_Report"].ToString() == "NOT_ALLOWED")
                        {
                            logVar.Add(new XElement("DefReport", $"False"));
                        }
                        else
                        {
                            logVar.Add(new XElement("DefReport", $"{row["Default_Report"]}"));
                        }

                        if (row["Plot_Color"].ToString() == "NOT_ALLOWED")
                        {
                            logVar.Add(new XElement("PlotColor", $"None"));
                        }
                        else
                        {
                            logVar.Add(new XElement("PlotColor", $"{row["Plot_Color"]}"));
                        }

                        if (row["User_Unit"].ToString() == "NOT_ALLOWED")
                        {
                            logVar.Add(new XElement("UserUnit", $"None"));
                        }
                        else
                        {
                            logVar.Add(new XElement("UserUnit", $"{row["User_Unit"]}"));
                        }

                        logVar.Add(new XElement("VarText_IT", $"{row["LogVar_Description_IT"].ToString().Trim()}"));

                        logVar.Add(new XElement("VarText_EN", $"{row["LogVar_Description_EN"].ToString().Trim()}"));

                        logVar.Add(new XElement("VarText_FR", $"{row["LogVar_Description_FR"].ToString().Trim()}"));

                        logVar.Add(new XElement("VarText_DE", $"{row["LogVar_Description_DE"].ToString().Trim()}"));

                        logVar.Add(new XElement("VarText_ES", $"{row["LogVar_Description_ES"].ToString().Trim()}"));

                        logVarConfig.Element("Config").Add(logVar);
                    }
                }

                XElement DateTime = new XElement("Var",
                new XElement("ColName", $"DateTime"),
                new XElement("VarType", $"DateTime"),
                new XElement("DefShow", $"False"),
                new XElement("DefPlot", $"False"),
                new XElement("DefReport", $"False"), 
                new XElement("PlotColor", $"None"),
                new XElement("UserUnit", $"None"),
                new XElement("VarText_IT", $"DateTime"),
                new XElement("VarText_EN", $"DateTime"),
                new XElement("VarText_FR", $"DateTime"),
                new XElement("VarText_DE", $"DateTime"),
                new XElement("VarText_ES", $"DateTime"));

                logVarConfig.Element("Config").Add(DateTime);

                logVarConfig.Save(filePath + @"\LogVarConfig.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("ReportManagerWorkers.PrintReportManagerLogVarconfig " + ex.Message);
            }
        }

        public static void PrintFcSqlVarLink(DataTable dataTable, string filePath)
        {

            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_Sql_VarLink.scl", false);

                //Header
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine(@"//Name: FC_Sql_VarLink");
                streamWriter.WriteLine(@"//Developer: Topcast");
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine();
                streamWriter.WriteLine();

                //Body LogVar
                streamWriter.WriteLine(@"//Log Variables");
                streamWriter.WriteLine(@"//********************************************************************//");
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["LogVar_PLC_Var"].ToString() != "")
                    {
                        if (row["LogVar_Col_Name"].ToString().Contains("Bool"))
                        {
                            streamWriter.WriteLine($"DB_Sql.Sql.LogVariables.Bool.{row["LogVar_Col_Name"].ToString().Replace("_","[")}] := {row["LogVar_PLC_Var"]};");
                        }
                        if (row["LogVar_Col_Name"].ToString().Contains("Real"))
                        {
                            streamWriter.WriteLine($"DB_Sql.Sql.LogVariables.Real.{row["LogVar_Col_Name"].ToString().Replace("_", "[")}] := {row["LogVar_PLC_Var"]};");
                        }
                        if (row["LogVar_Col_Name"].ToString().Contains("String"))
                        {
                            streamWriter.WriteLine($"DB_Sql.Sql.LogVariables.String.{row["LogVar_Col_Name"].ToString().Replace("_", "[")}] := {row["LogVar_PLC_Var"]};");
                        }
                        if (row["LogVar_Col_Name"].ToString().Contains("BatchID"))
                        {
                            streamWriter.WriteLine($"DB_Sql.Sql.LogVariables.Batch.BatchID := {row["LogVar_PLC_Var"]};");
                        }
                    }
                }

                //Body Events
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"//Events");
                streamWriter.WriteLine(@"//********************************************************************//");
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["LogEvent_PLC_Var"].ToString() != "")
                    {
                        streamWriter.WriteLine($"DB_Sql.Sql.LogEvents.{row["LogEvent_Col_Name"].ToString().Replace("_", "[")}] := {row["LogEvent_PLC_Var"]};");
                    }
                }

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("ReportManagerWorkers.FC_Sql_VarLink " + ex.Message);
            }
        }
    }
}
