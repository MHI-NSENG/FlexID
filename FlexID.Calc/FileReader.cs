using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlexID.Calc
{
    public class FileReader
    {
        // 核種情報取得
        public List<string> InfoReader(string NucInfo)
        {
            return File.ReadLines(NucInfo).ToList();
        }

        // 計算時間メッシュ取得
        public List<double> MeshReader(string TimeMesh)
        {
            var timeMeshValues =
                File.ReadLines(TimeMesh)
                .SelectMany(x => x.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)))
                .Select(x => double.Parse(x));

            var time = new List<double>();
            if (timeMeshValues.First() != 0) // タイムステップのスタートを0日目にするために、0を入れる
                time.Add(0);
            time.AddRange(timeMeshValues);

            return time;
        }

        // 出力時間メッシュ取得
        public List<double> OutReader(string OutTime)
        {
            var timeMeshValues =
                File.ReadLines(OutTime)
                .SelectMany(x => x.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)))
                .Select(x => double.Parse(x));

            var time = new List<double>();
            if (timeMeshValues.First() != 0) // 出力タイムメッシュの最初に経過時間0の出力を行うために、0を入れる
                time.Add(0);
            time.AddRange(timeMeshValues);

            return time;
        }
    }
}
