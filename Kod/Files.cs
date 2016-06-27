using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Kodowanie
{
    class Files 
    {
       
        public static void program2file (String program, String zrodlo)
        {
            FileStream fs = new FileStream(zrodlo, FileMode.OpenOrCreate, FileAccess.Write);
            
            try
            {
                Form3 kod = new Form3();
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(program);
                sw.Close();
            }
            catch (Exception) 
                {
                    System.Console.WriteLine("Błąd");
                }
         }

        public static string file2program(String zrodlo)
        {
            FileStream fa = new FileStream(zrodlo, FileMode.Open, FileAccess.Read); // tworzenie obiektu otwierania pliku
            String result = ""; // string do którego dodamy kolejne linie tekstu z pliku
            String program = "";
            List <string> list = new List <string>(); //tworzenie listy elementów typu string 
           
            
            try
            {
                StreamReader sr = new StreamReader(fa);
                
                while ( (program = sr.ReadLine()) != null)
                {
                    list.Add(program);
                    if (program.Equals("")) continue;
                    program = program.ToUpper(); 
                    program = program.Trim();
                    program = sprCiag(program);

                    if (program.Equals("?"))
                    {
                        result += "Wczytane dane nie są poprawne w lini: " + list.Count.ToString() + "\r\n";
                        continue;
                    }

                    string[] alfa = findWrite(program);
                    string dana = "";
                    int z;

                 
                        int[] beta = new int[alfa.Length-2];
                        try
                        {
                            
                            
                            z = int.Parse(alfa[0]);
                            dana = alfa[1];
                            for(int v=2; v<alfa.Length; v++)
                            {
                                beta[v - 2] = int.Parse(alfa[v]);
                            }

                            result += Form3.oblicz(dana, z, beta);
                                          
                        }
                        catch (Exception)
                        {
                            result += "Wczytane dane nie są poprawne w lini: " + list.Count.ToString() + "\r\n"; 
                        }  
                }
                sr.Close();
                return result;
            }
            catch (Exception)
            {
                return "Wystąpił błąd proszę spróbuj jeszcze raz.";
            }
        }

        public static string sprCiag(String ciag)
        {
            int czy = 0;

            for (int i = 0; i < ciag.Length; i++)
            {
                if (ciag[i] == ':' || ciag[i] == ';') czy++;   // sprawdza czy poprawny tekst

                if ((ciag[i] > '\u002F' && ciag[i] < '\u003C') || (ciag[i] > '\u0040' && ciag[i] < '\u005B') || ciag[i] == '\u002C' || ciag[i] == '\u002E')
                { } // wybiera jakie są dozwolone znaki
                else
                {
                 ciag = ciag.Remove(i,1); // jeśli nie jest dozwolony to usuwa go 
                 --i;
                }
            }

            if (czy != 2)
            {
               ciag = "?";
            }
           
            return ciag;
        }

        public static String[] findWrite(String linia)
        {
              
            char[] b_l = { ':', ';', ',' , '.' };
            string[] dane = linia.Split(b_l);
            for (int i = 0; i < dane.Length; i++)
            {
                dane[i] = dane[i].ToUpper();
                if(dane[i].StartsWith("RZYM"))
                {
                    dane[i] = "1";
                }

            }
            return dane;  
        }
    }
}
