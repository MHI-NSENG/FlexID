using System;
using System.Collections.Generic;
using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

namespace S_Coefficient
{
    class Output
    {
        // 出力Excelテンプレートのファイルパス
        private const string OutExcel = @"lib\S-Coefficient_Tmp.xlsx";

        /// <summary>
        /// 計算結果をExcelファイルに書き出す
        /// </summary>
        /// <param name="nuclideName">計算対象となった核種名</param>
        /// <param name="sex">計算対象となった性別</param>
        /// <param name="OutTotal">計算結果</param>
        public static void WriteCalcResult(string nuclideName, Sex sex, List<double> OutTotal,
            List<double> OutP, List<double> OutE, List<double> OutB, List<double> OutA, List<double> OutN)
        {
            try
            {
                using (var Open = new XLWorkbook(OutExcel))
                {
                    int outCount = 0;
                    var SheetT = Open.Worksheet("total");
                    for (int col = 3; col < 83; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            if (col == 82)
                                SheetT.Cell(row, col).Value = 0;
                            else
                                SheetT.Cell(row, col).Value = OutTotal[outCount];
                            outCount++;
                        }
                    }

                    outCount = 0;
                    var SheetP = Open.Worksheet("photon");
                    for (int col = 3; col < 82; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            SheetP.Cell(row, col).Value = OutP[outCount];
                            outCount++;
                        }
                    }

                    outCount = 0;
                    var SheetE = Open.Worksheet("electron");
                    for (int col = 3; col < 82; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            SheetE.Cell(row, col).Value = OutE[outCount];
                            outCount++;
                        }
                    }

                    outCount = 0;
                    var SheetB = Open.Worksheet("beta");
                    for (int col = 3; col < 82; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            SheetB.Cell(row, col).Value = OutB[outCount];
                            outCount++;
                        }
                    }

                    outCount = 0;
                    var SheetA = Open.Worksheet("alpha");
                    for (int col = 3; col < 82; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            SheetA.Cell(row, col).Value = OutA[outCount];
                            outCount++;
                        }
                    }

                    outCount = 0;
                    var SheetN = Open.Worksheet("neutron");
                    for (int col = 3; col < 82; col++)
                    {
                        for (int row = 5; row < 48; row++)
                        {
                            SheetN.Cell(row, col).Value = OutN[outCount];
                            outCount++;
                        }
                    }

                    if (sex == Sex.Male)
                        Open.SaveAs(@"out\AdultMale\" + nuclideName + "_AdultMale.xlsx");
                    else
                        Open.SaveAs(@"out\AdultFemale\" + nuclideName + "_AdultFemale.xlsx");

                    // セルの値を読んでテキストに出力
                    var resultList = new List<string>();
                    for (int i = 4; i < 48; i++)
                    {
                        string line = "";
                        for (int j = 2; j < 83; j++)
                        {
                            var text = SheetT.Cell(i, j).Value.ToString();
                            if (i == 4)
                            {
                                if (j == 2)
                                {
                                    text = "  T/S";
                                    line += $"{text,-11}";
                                }
                                else
                                    line += $"{text,-15}";
                            }
                            else
                            {
                                if (j == 2)
                                    line += $"{text,-11}";
                                else
                                {
                                    var value = double.Parse(text).ToString("0.00000000E+00");
                                    line += $"{value,-15}";
                                }
                            }
                        }
                        resultList.Add(line);
                    }

                    if (sex == Sex.Male)
                        File.WriteAllLines(@"out\AdultMale\" + nuclideName + "_AdultMale.txt", resultList, System.Text.Encoding.UTF8);
                    else
                        File.WriteAllLines(@"out\AdultFemale\" + nuclideName + "_AdultFemale.txt", resultList, System.Text.Encoding.UTF8);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
