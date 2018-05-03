using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuaBuilder
{
    class Builder
    {
        internal static void Build(string seedFile, string libDir, string outputDir, bool isClip)
        {
            var fileInfo = new FileInfo(seedFile);
            var outputFile = Path.Combine(outputDir, fileInfo.Name);
            var lines = new List<string>();
            var retry = 0;
            while (retry < 10)
            {
                try
                {
                    using (var sr = new StreamReader(seedFile))
                    {
                        while (sr.Peek() != -1)
                        {
                            lines.Add(sr.ReadLine());
                        }
                    }
                    break;
                }
                catch (Exception)
                {
                    retry++;
                    System.Threading.Thread.Sleep(1000);

                }
            }

            using (var sw = new StreamWriter(outputFile))
            {
                var rowCount = 0;

                foreach (var line in lines)
                {
                    if (line.Trim().StartsWith("--{@"))
                    {
                        var req = line.Trim().Substring(4, line.Trim().Length - 5);
                        var reqFile = Path.Combine(libDir, req);

                        var retry2 = 0;
                        var s = "";
                        var rc = 0;
                        while (retry < 10)
                        {
                            try
                            {
                                using (var sr = new StreamReader(reqFile))
                                {
                                    s = sr.ReadToEnd();
                                    rc = s.Split('\n').Length;
                                }
                                break;
                            }
                            catch (Exception)
                            {
                                retry2++;
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                        rowCount++;
                        sw.WriteLine("--" + req + " offset " + rowCount + " rows ");
                        sw.Write(s);
                        sw.WriteLine("");
                        rowCount += rc;
                    }
                    else
                    {
                        rowCount++;
                        sw.WriteLine(line);
                    }
                }
            }

            if (isClip)
            {
                using (var sr = new StreamReader(outputFile))
                {
                    var s = sr.ReadToEnd();
                    Clipboard.SetDataObject(s, true);
                }
            }



        }
    }
}
