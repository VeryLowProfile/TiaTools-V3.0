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
                    if ((row["Address"].ToString().Contains("%I") && !row["Address"].ToString().Contains("W")))
                    {                       
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["PLC Tag"]} {row["Instance Name"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["Instance Name"]}\"(Signal:= \"{row["PLC Tag"]}\",");
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
                    if ((row["Address"].ToString().Contains("%I") && !row["Address"].ToString().Contains("W")))
                    {
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["PLC Tag"]} {row["Instance Name"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Address := '{row["PLC Tag"]}';");
                            if (row["Safe"].ToString() == "YES")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.IsSafety := 1;");
                            }
                            if (row["HMI Name IT"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            }
                            if (row["HMI Name EN"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            }
                            if (row["HMI Name FR"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            }
                            if (row["HMI Name DE"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            }
                            if (row["HMI Name ES"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_ES := '{row["HMI Name ES"]}';");
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
                    if ((row["Address"].ToString().Contains("%I") && !row["Address"].ToString().Contains("W")))
                    {
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"DATA_BLOCK \"{row["Instance Name"]}\"");
                            streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                            streamWriter.WriteLine(@"VERSION : 0.1");
                            streamWriter.WriteLine(@"NON_RETAIN");
                            streamWriter.WriteLine(@"""FB_DI""");
                            streamWriter.WriteLine();
                            streamWriter.WriteLine(@"BEGIN");
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
                    if ((row["Address"].ToString().Contains("%Q") && !row["Address"].ToString().Contains("W")))
                    {
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["PLC Tag"]} {row["Instance Name"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["Instance Name"]}\"(Signal:= \"{row["PLC Tag"]}\",");
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
                    if ((row["Address"].ToString().Contains("%Q") && !row["Address"].ToString().Contains("W")))
                    {
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"	//{row["PLC Tag"]} {row["Instance Name"]}");
                            streamWriter.WriteLine(@"	//********************************************************************//");
                            streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Address := '{row["PLC Tag"]}';");
                            if (row["Safe"].ToString() == "YES")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.IsSafety := 1;");
                            }
                            if (row["HMI Name IT"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_IT := '{row["HMI Name IT"]}';");
                            }
                            if (row["HMI Name EN"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_EN := '{row["HMI Name EN"]}';");
                            }
                            if (row["HMI Name FR"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_FR := '{row["HMI Name FR"]}';");
                            }
                            if (row["HMI Name DE"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_DE := '{row["HMI Name DE"]}';");
                            }
                            if (row["HMI Name ES"].ToString() != "")
                            {
                                streamWriter.WriteLine($"	\"{row["Instance Name"]}\".CONFIG.Name_ES := '{row["HMI Name ES"]}';");
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
                    if ((row["Address"].ToString().Contains("%Q") && !row["Address"].ToString().Contains("W")))
                    {
                        if (row["Instance Name"].ToString() != "")
                        {
                            streamWriter.WriteLine($"DATA_BLOCK \"{row["Instance Name"]}\"");
                            streamWriter.WriteLine(@"{ S7_Optimized_Access := 'TRUE' }");
                            streamWriter.WriteLine(@"VERSION : 0.1");
                            streamWriter.WriteLine(@"NON_RETAIN");
                            streamWriter.WriteLine(@"""FB_DQ""");
                            streamWriter.WriteLine();
                            streamWriter.WriteLine(@"BEGIN");
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