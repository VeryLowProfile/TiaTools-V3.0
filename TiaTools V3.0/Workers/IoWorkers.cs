using System;
using System.IO;
using System.Data;

namespace TiaTools_V3._0.Workers
{
    public class IoWorkers
    {
        public static void PrintFcDi(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_DI.scl", false);

                //Header
                streamWriter.WriteLine(@"FUNCTION ""FC_DI"" : Void");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine(@"	//Name: FC_DI");
                streamWriter.WriteLine(@"	//Developer: Topcast");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine();

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DI") && !row["SKIP"].ToString().Contains("YES"))
                    {                       
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["ADDRESS"]} {row["INSTANCE NAME"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\"(Signal:= \"{row["PLC TAG"]}\",");
                            streamWriter.WriteLine($"	                     LenguageNb:= $LengugeNB$);");
                            streamWriter.WriteLine();
                        }
                    }
                }

                //End
                streamWriter.WriteLine(@"END_FUNCTION");

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.PrintFcDi " + ex.Message);
            }
        }

        public static void ProntFcDiConfig(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_DI_Config.scl", false);

                //Header
                streamWriter.WriteLine(@"FUNCTION ""FC_DI_Config"" : Void");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine(@"	//Name: FC_DI_Config");
                streamWriter.WriteLine(@"	//Developer: Topcast");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine();

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DI") && !row["SKIP"].ToString().Contains("YES"))
                    {
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["ADDRESS"]} {row["INSTANCE NAME"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Address := '{row["ADDRESS"]}';");
                            if (row["FILE SAFE"].ToString() == "F")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.IsSafety := 1;");
                            }
                            if (row["HMI Name IT"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            }
                            if (row["HMI Name EN"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            }
                            if (row["HMI Name FR"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            }
                            if (row["HMI Name DE"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            }
                            if (row["HMI Name ES"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_ES := '{row["HMI Name ES"]}';");
                            }
                            streamWriter.WriteLine();
                        }
                    }
                }

                //End
                streamWriter.WriteLine(@"END_FUNCTION");

                streamWriter.Close();
                streamWriter.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.ProntFcDiConfig " + ex.Message);
            }
        }

        public static void PrintDiInstances(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\DI_Instances.db", false);

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DI") && !row["SKIP"].ToString().Contains("YES"))
                    {
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"DATA_BLOCK \"{row["INSTANCE NAME"]}\"");
                            streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                            streamWriter.WriteLine(@"VERSION : 0.1");
                            streamWriter.WriteLine(@"NON_RETAIN");
                            streamWriter.WriteLine(@"""FB_DI""");
                            streamWriter.WriteLine();
                            streamWriter.WriteLine(@"BEGIN");

                            if (row["FILE SAFE"].ToString() == "F")
                            {
                                streamWriter.WriteLine($"CONFIG.IsSafety := true;");
                            } else {
                                streamWriter.WriteLine($"CONFIG.IsSafety := false;");
                            }

                            streamWriter.WriteLine($"CONFIG.DebounceTime := T#0ms;");
                            streamWriter.WriteLine($"CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_ES := '{row["HMI Name ES"]}';");
                            streamWriter.WriteLine($"CONFIG.Address := '{row["ADDRESS"]}';");
                            streamWriter.WriteLine();

                            streamWriter.WriteLine(@"END_DATA_BLOCK");
                            streamWriter.WriteLine();
                        }
                    }
                }

                streamWriter.Close();
                streamWriter.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.PrintDiInstances " + ex.Message);
            }
        }

        public static void PrintFcDq(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_DQ.scl", false);

                //Header
                streamWriter.WriteLine(@"FUNCTION ""FC_DQ"" : Void");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine(@"	//Name: FC_DQ");
                streamWriter.WriteLine(@"	//Developer: Topcast");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine();

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DQ") && !row["SKIP"].ToString().Contains("YES"))
                    {
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["ADDRESS"]} {row["INSTANCE NAME"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\"(Signal:= \"{row["PLC TAG"]}\",");
                            streamWriter.WriteLine($"	                     LenguageNb:= $LengugeNB$);");
                            streamWriter.WriteLine();
                        }
                    }
                }

                //End
                streamWriter.WriteLine(@"END_FUNCTION");

                streamWriter.Close();
                streamWriter.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.PrintFcDq " + ex.Message);
            }
        }

        public static void ProntFcDqConfig(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\FC_DQ_Config.scl", false);

                //Header
                streamWriter.WriteLine(@"FUNCTION ""FC_DQ_Config"" : Void");
                streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                streamWriter.WriteLine(@"VERSION : 0.1");
                streamWriter.WriteLine();
                streamWriter.WriteLine(@"BEGIN");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine(@"	//Name: FC_DQ_Config");
                streamWriter.WriteLine(@"	//Developer: Topcast");
                streamWriter.WriteLine(@"	//********************************************************************//");
                streamWriter.WriteLine();

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DQ") && !row["SKIP"].ToString().Contains("YES"))
                    {
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["ADDRESS"]} {row["INSTANCE NAME"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Address := '{row["ADDRESS"]}';");
                            if (row["FILE SAFE"].ToString() == "F")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.IsSafety := 1;");
                            }
                            if (row["HMI Name IT"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            }
                            if (row["HMI Name EN"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            }
                            if (row["HMI Name FR"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            }
                            if (row["HMI Name DE"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            }
                            if (row["HMI Name ES"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["INSTANCE NAME"]}\".CONFIG.Name_ES := '{row["HMI Name ES"]}';");
                            }
                            streamWriter.WriteLine();
                        }
                    }
                }

                //End
                streamWriter.WriteLine(@"END_FUNCTION");

                streamWriter.Close();
                streamWriter.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.ProntFcDqConfig " + ex.Message);
            }
        }

        public static void PrintDqInstances(DataTable dataTable, string filePath)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(filePath + @"\DQ_Instances.db", false);

                //Body
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IO-TYPE"].ToString().Contains("DQ") && !row["SKIP"].ToString().Contains("YES"))
                    {
                        if (row["INSTANCE NAME"].ToString() != "")
                        {
                            streamWriter.WriteLine($"DATA_BLOCK \"{row["INSTANCE NAME"]}\"");
                            streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                            streamWriter.WriteLine(@"VERSION : 0.1");
                            streamWriter.WriteLine(@"NON_RETAIN");
                            streamWriter.WriteLine(@"""FB_DQ""");
                            streamWriter.WriteLine();
                            streamWriter.WriteLine(@"BEGIN");

                            if (row["FILE SAFE"].ToString() == "F")
                            {
                                streamWriter.WriteLine($"CONFIG.IsSafety := true;");
                            }
                            else
                            {
                                streamWriter.WriteLine($"CONFIG.IsSafety := false;");
                            }

                            streamWriter.WriteLine($"CONFIG.OnDelay := T#0ms;");
                            streamWriter.WriteLine($"CONFIG.OFFDelay := T#0ms;");
                            streamWriter.WriteLine($"CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            streamWriter.WriteLine($"CONFIG.Name_ES := '{row["HMI Name ES"]}';");
                            streamWriter.WriteLine($"CONFIG.Address := '{row["ADDRESS"]}';");                            
                            streamWriter.WriteLine();

                            streamWriter.WriteLine(@"END_DATA_BLOCK");
                            streamWriter.WriteLine();
                        }
                    }
                }

                streamWriter.Close();
                streamWriter.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("IoWorkers.PrintDqInstances " + ex.Message);
            }
        }

    }
}