using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace PostProcessing
{
    public class Program
    {
        static void Main()
        {
            var exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fileDir = Path.Combine(exeDir, "file");
            if (!Directory.Exists(fileDir))
                return;
            var targetFiles = Directory.GetFiles(fileDir, "*.txt");

            foreach (var targetFile in targetFiles)
            {
                var sourceLines = File.ReadAllLines(targetFile);

                var resultLines = FormatFile(sourceLines);

                // タブ区切りの行が見つからなかった場合は、対象ファイルを書き換えずそのまま残す。
                if (resultLines is null)
                    continue;

                // 入力ファイルを直接上書きする。
                using (var w = new StreamWriter(targetFile))
                {
                    foreach (var line in resultLines)
                    {
                        w.WriteLine(line);
                    }
                }
            }
        }

        public static string[] FormatFile(string[] lines)
        {
            var cells = lines.Select(line => line.Split('\t').Select(cell => cell.Trim()).ToArray()).ToArray();

            var nrow = cells.Length;
            var ncol = cells.Max(row => row.Length);

            // タブ区切りの行が見つからなかった。
            if (ncol == 1)
                return null;

            // 1行目のヘッダ行について調整。
            if (nrow > 0)
            {
                var row = cells[0];
                var topleft = cells[0].FirstOrDefault() ?? "";
                if (Regex.IsMatch(topleft, @"^ *T +S *$"))
                    cells[0][0] = "  T/S";
                for (int c = 1; c < row.Length; c++)
                    cells[0][c] = " " + cells[0][c];
            }

            string GetCell(int r, int c)
            {
                var row = cells[r];
                return row.Length < nrow ? row[c] : "";
            }

            // 各列に割り当てる文字数を計算。
            var widths = Enumerable.Range(0, ncol)
                .Select(c => cells.Select(row => row[c]).Max(cell => cell.Length))
                .ToArray();

            // 結果ファイルへの各行を列挙。
            var resultLines = new List<string>(nrow);
            var lineBuilder = new StringBuilder();
            var lastCol = ncol - 1;
            for (int r = 0; r < nrow; r++)
            {
                lineBuilder.Clear();

                for (int c = 0; c < ncol; c++)
                {
                    var cell = GetCell(r, c);
                    var width = widths[c];
                    if (c != lastCol)
                        cell = cell.PadRight(width + 1);
                    lineBuilder.Append(cell);
                }

                resultLines.Add(lineBuilder.ToString());
            }
            return resultLines.ToArray();
        }
    }
}
