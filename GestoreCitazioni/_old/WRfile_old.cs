using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreCitazioni
{
    internal static class WRfile
    {
        public const string FILENAME = "Citazioni.txt";
        public static List<Citazione> readfile(string filename = FILENAME)
        {
            List<Citazione> citazioni = new List<Citazione>();
            if(!File.Exists(filename)) File.Create(filename).Close();
            StreamReader sr = new StreamReader(filename);
            String strLine;
            while((strLine = sr.ReadLine()) != null)
            {
                if(strLine != "") // Skip the first line
                {
                    citazioni.Add(new Citazione(
                        int.Parse(strLine.Split('~')[0]),
                        strLine.Split('~')[1],
                        strLine.Split('~')[2].Replace('σ', '\n'),
                        ((long.Parse(strLine.Split('~')[3]))),
                        strLine.Split('~')[4])
                    );
                }
            }
            sr.Close();
            citazioni.Reverse();
            return citazioni;
        }

        public static void saveNewCit(Citazione c, string filename = FILENAME)
        {
            // Made this shit cause I dont have to iterate all the file to take the new Id,
            // I can simply take the first position and copi the rest
            StreamReader sr = new StreamReader(filename);
            String s = "\n" + c.Id + "~" + 
                    c.Titolo + "~" + 
                    c.Cit.Replace('\n', 'σ') + "~" + 
                    c.dataTicks + "~" + 
                    c.Author + 
                    sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(filename, false);
            sw.WriteLine(s);
            sw.Close();
        }

    }
}
