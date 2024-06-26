using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FlexID.Calc
{
    class CalcOut
    {
        // テンポラリファイル用
        public StreamWriter wTmp;

        // 線量係数用
        public StreamWriter dCom;

        // 線量率用
        public StreamWriter rCom;

        // テンポラリファイルに出力
        public void TemporaryOut(double outT, bool flgTime, int organId, double end, double total, double cumulative, int iter)
        {
            if (flgTime)
                wTmp.WriteLine(" {0:0.000000E+00}", outT);

            wTmp.WriteLine(" {0,3:0}  {1:0.00000000E+00}    {2:0.00000000E+00}    {3:0.00000000E+00}     {4,3:0}",
                            organId, end, total, cumulative, iter);
        }

        // 預託線量標的組織出力
        public void CommitmentTarget(List<string> Target, DataClass data)
        {
            // 線量係数
            dCom.WriteLine("{0} {1} {2}", " Effective/Equivalent_Dose ", data.TargetNuc[0], data.IntakeRoute[data.TargetNuc[0]]);
            dCom.Write("     Time    ");
            dCom.Write("     WholeBody   ");

            // 線量率
            rCom.WriteLine("{0} {1} {2}", " DoseRate ", data.TargetNuc[0], data.IntakeRoute[data.TargetNuc[0]]);
            rCom.Write("     Time    ");
            rCom.Write("     WholeBody   ");

            for (int i = 0; i < Target.Count; i++)
            {
                dCom.Write("  {0,-12:n}", Target[i]);
                rCom.Write("  {0,-12:n}", Target[i]);
            }
            dCom.WriteLine();
            dCom.Write("     [day]       ");
            dCom.Write("  [Sv/Bq]     ");
            rCom.WriteLine();
            rCom.Write("     [day]       ");
            rCom.Write("  [Sv/h]      ");
            for (int i = 0; i < Target.Count; i++)
            {
                dCom.Write("  [Sv/Bq]     ");
                rCom.Write("  [Sv/h]      ");
            }
            dCom.WriteLine();
            rCom.WriteLine();
        }

        // 預託線量計算結果出力
        public void CommitmentOut(double now, double pre, double WholeBody, double preBody, double[] Result, double[] preResult)
        {
            dCom.Write("{0,14:0.000000E+00}  ", now);
            dCom.Write("{0,13:0.000000E+00}", WholeBody);
            rCom.Write("{0,14:0.000000E+00}  ", now);
            rCom.Write("{0,13:0.000000E+00}", (WholeBody - preBody) / ((now - pre) * 24));
            for (int i = 0; i < Result.Length; i++)
            {
                dCom.Write("  {0,12:0.000000E+00}", Result[i]);
                rCom.Write("  {0,12:0.000000E+00}", (Result[i] - preResult[i]) / ((now - pre) * 24));
            }
            dCom.WriteLine();
            rCom.WriteLine();
        }

        // テンポラリファイルを並び替えて出力
        public void ActivityOut(string RetePath, string CumuPath, string TmpFile, DataClass data)
        {
            var AllLines = File.ReadAllLines(TmpFile);

            using (var r = new StreamWriter(RetePath, false, Encoding.UTF8))
            using (var c = new StreamWriter(CumuPath, false, Encoding.UTF8))
            {
                foreach (var nuc in data.TargetNuc)
                {
                    // ヘッダー出力
                    r.WriteLine(" {0} {1} {2}", "Retention ", nuc, data.IntakeRoute[nuc]);
                    r.Write("     Time      ");
                    c.WriteLine(" {0} {1} {2}", "CumulativeActivity ", nuc, data.IntakeRoute[nuc]);
                    c.Write("     Time      ");

                    foreach (var Organ in data.Organs)
                    {
                        if (nuc == Organ.Nuclide)
                        {
                            r.Write("  {0,-14:n}", Organ.Name);
                            c.Write("  {0,-14:n}", Organ.Name);
                        }
                    }
                    r.WriteLine();
                    r.Write("     [day]       ");
                    c.WriteLine();
                    c.Write("     [day]       ");

                    foreach (var Organ in data.Organs)
                    {
                        if (nuc == Organ.Nuclide)
                        {
                            r.Write("  [Bq/Bq]       ");
                            c.Write("     [Bq]       ");
                        }
                    }

                    for (int i = 0; i < AllLines.Length;)
                    {
                        var values = AllLines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                        if (values.Length == 1)
                        {
                            r.WriteLine();
                            r.Write("  {0:0.00000000E+00} ", values[0]);
                            c.WriteLine();
                            c.Write("  {0:0.00000000E+00} ", values[0]);
                            i++;
                        }
                        else if (values.Length > 4)
                        {
                            foreach (var Organ in data.Organs)
                            {
                                values = AllLines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                if (Organ.Nuclide == nuc)
                                {
                                    r.Write("  {0:0.00000000E+00}", values[1]);
                                    c.Write("  {0:0.00000000E+00}", values[3]);
                                }
                                i++;
                            }
                        }
                    }
                    r.WriteLine();
                    r.WriteLine();
                    c.WriteLine();
                    c.WriteLine();
                }
            }
        }

        public void IterOut(List<double> CalcTimeMesh, Dictionary<double, int> iterLog, string IterPath)
        {
            using (var w = new StreamWriter(IterPath, false, Encoding.UTF8))
            {
                w.WriteLine("   time(day)    Iteration");
                for (int i = 0; i < iterLog.Count; i++)
                {
                    w.WriteLine("  {0:0.00000E+00}     {1,3:0}", CalcTimeMesh[i], iterLog[CalcTimeMesh[i]]);
                }
            }
        }
    }
}
