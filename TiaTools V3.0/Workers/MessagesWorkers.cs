using System;
using System.IO;
using System.Data;
namespace TiaTools_V3._0.Workers
{
    public class MessagesWorkers
    {
        public static DataTable ProcessedMessagesToDataTable(DataTable dataTable)
        {
            DataTable processedDataTable = new DataTable();

            processedDataTable.Columns.Add("Nb");
            processedDataTable.Columns.Add("Msg Class");
            processedDataTable.Columns.Add("Message Text IT");
            processedDataTable.Columns.Add("Message Text EN");
            processedDataTable.Columns.Add("Message Text FR");
            processedDataTable.Columns.Add("Message Text DE");
            processedDataTable.Columns.Add("Message Text ES");
            processedDataTable.Columns.Add("Message Info IT");
            processedDataTable.Columns.Add("Message Info EN");
            processedDataTable.Columns.Add("Message Info FR");
            processedDataTable.Columns.Add("Message Info DE");
            processedDataTable.Columns.Add("Message Info ES");
            processedDataTable.Columns.Add("Msg Reaction SM 1");
            processedDataTable.Columns.Add("Msg Reaction SM 2");
            processedDataTable.Columns.Add("Msg Reaction SM 3");
            processedDataTable.Columns.Add("Msg Reaction SM 4");
            processedDataTable.Columns.Add("Msg Reaction SM 5");
            processedDataTable.Columns.Add("Msg Reaction SM 6");
            processedDataTable.Columns.Add("Msg Reaction SM 7");
            processedDataTable.Columns.Add("Msg Reaction SM 8");
            processedDataTable.Columns.Add("Msg Reaction SM 9");
            processedDataTable.Columns.Add("Msg Reaction SM 10");

            try
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    DataRow processedDataRow;
                    processedDataRow = processedDataTable.NewRow();
                    processedDataRow["Nb"] = dataRow["Nb"];
                    processedDataRow["Msg Class"] = dataRow["Msg Class"];
                    processedDataRow["Message Text IT"] = dataRow["Device IT"] + " -> " + dataRow["Msg Text IT"];
                    processedDataRow["Message Text EN"] = dataRow["Device EN"] + " -> " + dataRow["Msg Text EN"];
                    processedDataRow["Message Text FR"] = dataRow["Device FR"] + " -> " + dataRow["Msg Text FR"];
                    processedDataRow["Message Text DE"] = dataRow["Device DE"] + " -> " + dataRow["Msg Text DE"];
                    processedDataRow["Message Text ES"] = dataRow["Device ES"] + " -> " + dataRow["Msg Text ES"];
                    processedDataRow["Message Info IT"] = "Info : " + dataRow["Info Text IT"];
                    processedDataRow["Message Info EN"] = "Info : " + dataRow["Info Text EN"];
                    processedDataRow["Message Info FR"] = "Info : " + dataRow["Info Text FR"];
                    processedDataRow["Message Info DE"] = "Info : " + dataRow["Info Text DE"];
                    processedDataRow["Message Info ES"] = "Info : " + dataRow["Info Text ES"];
                    processedDataRow["Msg Reaction SM 1"] = dataRow["Msg Reaction SM 1"];
                    processedDataRow["Msg Reaction SM 2"] = dataRow["Msg Reaction SM 2"];
                    processedDataRow["Msg Reaction SM 3"] = dataRow["Msg Reaction SM 3"];
                    processedDataRow["Msg Reaction SM 4"] = dataRow["Msg Reaction SM 4"];
                    processedDataRow["Msg Reaction SM 5"] = dataRow["Msg Reaction SM 5"];
                    processedDataRow["Msg Reaction SM 6"] = dataRow["Msg Reaction SM 6"];
                    processedDataRow["Msg Reaction SM 7"] = dataRow["Msg Reaction SM 7"];
                    processedDataRow["Msg Reaction SM 8"] = dataRow["Msg Reaction SM 8"];
                    processedDataRow["Msg Reaction SM 9"] = dataRow["Msg Reaction SM 9"];
                    processedDataRow["Msg Reaction SM 10"] = dataRow["Msg Reaction SM 10"];
                    processedDataTable.Rows.Add(processedDataRow);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MessagesWorkers.ProcessMessagesToDataTable " + ex.Message);
            }

            return processedDataTable;

        }

        public static void PrintFcMessageTrigger(DataTable dataTable, string filePath)
        {

            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_Msg_Trigger.scl", false);

                //Header
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine(@"//Name: FC_Msg_Trigger");
                streamWriter.WriteLine(@"//Developer: Topcast");
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine();
                streamWriter.WriteLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (!row["Message Text IT"].ToString().Contains("SPARE"))
                    {
                        streamWriter.WriteLine($"//{row["Nb"]} {row["Message Text IT"]}");
                        streamWriter.WriteLine($"//**********************************************************************************");
                        streamWriter.WriteLine($"DB_Msg.Msg.Msg[{row["Nb"]}].trigger := FALSE;");
                        streamWriter.WriteLine();
                    }
                }

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("MessagesWorkers.PrintFcMessageTrigger " + ex.Message);
            }

        }

        public static void PrintFcMessageConfig(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_Msg_Config.scl", false);

                //Header
                streamWriter.WriteLine(@"FUNCTION ""FC_Msg_Config"" : Void");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine(@"//Name: FC_Msg_Config");
                streamWriter.WriteLine(@"//Developer: Topcast");
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine();
                streamWriter.WriteLine();

                //General Configuration
                streamWriter.WriteLine(@"//General Configuration");
                streamWriter.WriteLine(@"//********************************************************************//");
                streamWriter.WriteLine($"\"DB_Msg\".Msg.CONFIG.MsgMaxNb := {dataTable.Rows.Count - 1};");
                streamWriter.WriteLine($"\"DB_Msg\".Msg.CONFIG.MsgHmiWordNb := @HMI_WORD_NUMBER@;");
                streamWriter.WriteLine($"\"DB_Msg\".Msg.CONFIG.MsgMaxSMNumber := @SM_NUMBER@;");
                streamWriter.WriteLine();
                streamWriter.WriteLine();

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!row["Message Text IT"].ToString().Contains("SPARE"))
                    {
                        streamWriter.WriteLine($"//{row["Nb"]} {row["Message Text IT"]}");
                        streamWriter.WriteLine($"//**********************************************************************************");
                        streamWriter.WriteLine($"DB_Msg.Msg.Msg[{row["Nb"]}].Config.Class := {row["Msg Class"]};");
                        for (int i = 1; i < 10; i++)
                        {
                            if (row[$"Msg Reaction SM {i}"].ToString() != "NONE")
                            {
                                streamWriter.WriteLine($"DB_Msg.Msg.MSG[{row["Nb"]}].Config.Reaction.SM[{i}] := " + row[$"Msg Reaction SM {i}"].ToString() + ";");
                            }
                        }
                        streamWriter.WriteLine();
                    }
                }

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("MessagesWorkers.PrintFcMessageConfig " + ex.Message);
            }
        }

        public static void PrintDB_Msg(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\DB_Msg.db", false);

                //Header
                streamWriter.WriteLine(@"DATA_BLOCK ""DB_Msg""");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine(@"NON_RETAIN");
                streamWriter.WriteLine(@"   VAR");
                streamWriter.WriteLine(@"      Msg : ""MSG"";");
                streamWriter.WriteLine(@"   END_VAR");
                streamWriter.WriteLine();
                streamWriter.WriteLine();

                //General Configuration
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine($"Msg.CONFIG.MsgMaxNb := 511;");
                streamWriter.WriteLine($"Msg.CONFIG.MsgHmiWordNb := 31;");
                streamWriter.WriteLine($"Msg.CONFIG.MsgMaxSMNumber := 10;");

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!row["Message Text IT"].ToString().Contains("SPARE"))
                    {
                        //Message class
                        switch (row[$"Msg Class"].ToString())
                        {
                            case "NONE":
                                streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Class := 0;");
                                break;

                            case "SAFETY":
                                streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Class := 1;");
                                break;

                            case "PROCESS":
                                streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Class := 2;");
                                break;

                            case "WARNING":
                                streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Class := 3;");
                                break;

                            case "WARNING_NO_ACK":
                                streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Class := 4;");
                                break;
                        }

                        //Message reaction for each SM
                        for (int i = 1; i < 10; i++)
                        {
                            if (row[$"Msg Reaction SM {i}"].ToString() != "NONE")
                            {
                                switch (row[$"Msg Reaction SM {i}"].ToString())
                                {
                                    case "PAUSE":
                                        streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Reaction.SM[{i}] := 1;");
                                        break;

                                    case "STOP":
                                        streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Reaction.SM[{i}] := 2;");
                                        break;

                                    default:
                                        streamWriter.WriteLine($"Msg.MSG[{row["Nb"]}].Config.Reaction.SM[{i}] := @UNKNOWN@;");
                                        break;
                                }
                            }
                        }
                    }
                }
                streamWriter.WriteLine($"END_DATA_BLOCK");

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("MessagesWorkers.PrintFcMessageConfig " + ex.Message);
            }
        }
    }
}
