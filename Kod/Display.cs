using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodowanie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        public string[] system = { "rzymskiego", "dwójkowego", "trójkowego", "czwórkowego", "piątkowego", "szóstkowego", "siódemkowego", "ósemkowego",
                                   "dziewiątkowego", "dziesiątkowego", "jedenastkowego", "dwunastkowego", "trzynastkowego", "czternastkowego", 
                                   "pietnastkowego", "szesnastkowego", "siedemnastkowego", "osiemnastkowego", "dziewietnastkowego", "dwudziestkowego"};

        public string result = "";
        public string box1 = "";

        public void button1_Click(object sender, EventArgs e)
        {
            // Jeśli jest base = x to wpisane cyfry musza byc z zakresu 0-(x-1)
            // rzymskie tylko 3
            // dla systemow powyzej 10 mozliwe litery musza byc odpowiednio z tablicy 11 [a][0] 12[a][0] b[1] itd
            //box1 = ""; <----------
            String dana = "";
            dana = wpisz.Text;
            int z = comboBox1.SelectedIndex+1; 

            int[] na = new int[checkedListBox1.CheckedIndices.Count];
           
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                na[i] = checkedListBox1.CheckedIndices[i]+1;     
            }

            textBox1.Text = oblicz(dana, z, na);
            
        }



        public static string oblicz(string dana, int zPodstawa, int[] naPodstawa)
        {
            Lab lab = new Lab();
            string result="";
            int res;


            if (zPodstawa == 0)
            {
                return result = "Nie ma takiej podstawy, wybierz jedną z listy rozwijanej";
            }

            if (zPodstawa != 1 && zPodstawa != 10)  //jeśli nie rzymski i nie 10
            {
                if (Lab.sprawdzPodstawe(dana, zPodstawa))
                {
                    Form3 kod = new Form3();
                    result += "Z " + kod.system[zPodstawa-1] + " " + dana + " :\r\n"; //zastanowic sie
                    
                    for (int x = 0; x < naPodstawa.Length; x++)
                    {
                        
                        res = Lab.convertFrom(dana, zPodstawa); //ZPODSTAWA+1

                        if (naPodstawa[x] == 1) result += "Na " + "rzymską" + " = ";
                        else result += "Na " + (naPodstawa[x]).ToString() + " = ";
                        result += Lab.convertTo(res, naPodstawa[x]); //naPodstawa[x] + 1
                        result += "\r\n";
                    }
                    return result + "\r\n"; 
                }
                else return "Wprowadziłeś nieprawidłową liczbę w systemie " + zPodstawa.ToString();
            }


            if (zPodstawa == 1)
            {
                if (Lab.sprawdzRzymska(dana) == true) //sprawdza czy poprawna rzymska wpisana ale 
                // jak nic nie wpisane to tez blad wiec trzeba to naprawic
                {
                    result += "Z" + " rzymskiego " + dana + " :\r\n";
                    for (int x = 0; x < naPodstawa.Length; x++)
                    {
                        res = Lab.roman2arabic(dana);
                        if (naPodstawa[x] == 1) result += "Na " + "rzymską" + " = ";
                        else result += "Na " + (naPodstawa[x]).ToString() + " = ";
                        result += Lab.convertTo(res, naPodstawa[x]); //naPodstawa[x] + 1
                        result += "\r\n";
                    }
                    return result + "\r\n";
                }
                else return "Wprowadziłeś nieprawidłową liczbę rzymską";
            }


            if (zPodstawa == 10)
            {
                try
                {
                    if (dana != "")
                    {
                        res = int.Parse(dana);
                        result += "Z" + " dziesiętnego " + dana + " :\r\n";
                        for (int x = 0; x < naPodstawa.Length; x++)
                        {
                            if (naPodstawa[x] == 1) result += "Na " + "rzymską" + " = ";
                            else result += "Na " + (naPodstawa[x]).ToString() + " = ";
                            result += Lab.convertTo(res, naPodstawa[x]); //naPodstawa[x] + 1
                            result += "\r\n";
                        }
                        return result;
                    }
                    else return "Wprowadziłeś nieprawidłową liczbę arabską";
                }
                catch (Exception)
                {
                    return "Wprowadziłeś nieprawidłową liczbę arabską";//MessageBox.Show("Wpisana wartość jest niepoprawna!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result + "\r\n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog chs_file = new SaveFileDialog();
            chs_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (chs_file.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Zapisano plik: " + chs_file.FileName);
                Files.program2file(textBox1.Text, chs_file.FileName);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fnd_file = new OpenFileDialog();
            fnd_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fnd_file.ShowDialog() == DialogResult.OK)
            {
                
                MessageBox.Show("Wybrano plik: " + fnd_file.FileName);
                textBox1.Text = Files.file2program(fnd_file.FileName);
            }
        }

        public string _textbox
        {
            set { textBox1.Text = value; }
        }

        private void File2File_Click(object sender, EventArgs e)
        {

            String a = "";
            OpenFileDialog fnd_file = new OpenFileDialog();
            fnd_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fnd_file.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Wybrano plik: " + fnd_file.FileName);
               a = Files.file2program(fnd_file.FileName);
                //
            }

            SaveFileDialog chs_file = new SaveFileDialog();
            chs_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (chs_file.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Zapisano plik: " + chs_file.FileName);
                Files.program2file(a, chs_file.FileName);
            }
        }

        


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check;
            if (checkBox1.Checked)
            {
                check = true;
            }
            else check = false;

            for (int a = 0; a < checkedListBox1.Items.Count; a++)
            {
                checkedListBox1.SetItemChecked(a, check);
            }
        }

        private void zobaczPomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help pomoc = new Help();
            pomoc.Show();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits_ cr = new Credits_();
            cr.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void frmGlowne_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


       
    }
}
