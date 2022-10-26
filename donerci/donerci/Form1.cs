using System.Threading.Tasks;

namespace donerci
{
    public partial class Form1 : Form
    {
        string a;
        string b;
        string c;  
        string d;  
        string g;
        string f;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true )
            {
                a=" Turþusuz ";
            }   else 
            {
                a="";
            }
            if (checkBox15.Checked == true)
            {
                b =" Domatessiz ";
            }
            else
            {
                b ="";
            }
            if (checkBox23.Checked == true)
            {
                c =" Soðansýz ";
            }
            else
            {
                c="";
            }
            if (checkBox31.Checked == true)
            {
                d=" Patatezsiz ";
            }
            else
            {
                d="";
            }
            if (checkBox39.Checked == true)
            {
                g=" Ketçapsýz ";
            }
            else
            {
                g="";
            }
            if (checkBox47.Checked == true)
            {
                f=" Mayonezsiz ";
            }
            else
            {
                f="";
            }
            listBox1.Items.Add("Ekmek Arasý Tavuk Döner   " + a + b + c + d + g + f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                a = " Turþusuz ";
            }
            else
            {
                a = "";
            }
            if (checkBox13.Checked == true)
            {
                b = " Domatessiz ";
            }
            else
            {
                b = "";
            }
            if (checkBox21.Checked == true)
            {
                c = " Soðansýz ";
            }
            else
            {
                c = "";
            }
            if (checkBox29.Checked == true)
            {
                d = " Patatezsiz ";
            }
            else
            {
                d = "";
            }
            if (checkBox37.Checked == true)
            {
                g = " Ketçapsýz ";
            }
            else
            {
                g = "";
            }
            if (checkBox45.Checked == true)
            {
                f = " Mayonezsiz ";
            }
            else
            {
                f = "";
            }
            listBox1.Items.Add("Lavaþ Arasý Tavuk Döner   " + a + b + c + d + g + f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                a = " Turþusuz ";
            }
            else
            {
                a = "";
            }
            if (checkBox11.Checked == true)
            {
                b = " Domatessiz ";
            }
            else
            {
                b = "";
            }
            if (checkBox19.Checked == true)
            {
                c = " Soðansýz ";
            }
            else
            {
                c = "";
            }
            if (checkBox27.Checked == true)
            {
                d = " Patatezsiz ";
            }
            else
            {
                d = "";
            }
            if (checkBox35.Checked == true)
            {
                g = " Ketçapsýz ";
            }
            else
            {
                g = "";
            }
            if (checkBox43.Checked == true)
            {
                f = " Mayonezsiz ";
            }
            else
            {
                f = "";
            }
            listBox1.Items.Add("Ekmek Arasý Et Döner   " + a + b + c + d + g + f);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                a = " Turþusuz ";
            }
            else
            {
                a = "";
            }
            if (checkBox9.Checked == true)
            {
                b = " Domatessiz ";
            }
            else
            {
                b = "";
            }
            if (checkBox17.Checked == true)
            {
                c = " Soðansýz ";
            }
            else
            {
                c = "";
            }
            if (checkBox25.Checked == true)
            {
                d = " Patatezsiz ";
            }
            else
            {
                d = "";
            }
            if (checkBox33.Checked == true)
            {
                g = " Ketçapsýz ";
            }
            else
            {
                g = "";
            }
            if (checkBox41.Checked == true)
            {
                f = " Mayonezsiz ";
            }
            else
            {
                f = "";
            }
            listBox1.Items.Add("Lavaþ Arasý Et Döner   " + a + b + c + d + g + f);
        }
    }
}