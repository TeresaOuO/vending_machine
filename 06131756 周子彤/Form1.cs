using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06131756_周子彤
{
    public partial class Form1 : Form
    {
        SellMachine sm;
        OneDollar o1;
        FiveDollar f;
        TenDollar t;
        FiftyDollar ff;
        HundredNotes h;
        public Form1()
        {
            InitializeComponent();
        }
        // Form1_Load 
        private void Form1_Load(object sender, EventArgs e)
        {
            sm = new SellMachine();
            textBox1.Text = Convert.ToString(StaticNumber.pocarinumber);
            textBox2.Text = Convert.ToString(StaticNumber.heysongnumber);
            textBox3.Text = Convert.ToString(StaticNumber.applecidernumber);
            textBox4.Text = Convert.ToString(StaticNumber.oolongteanumber);
            textBox5.Text = Convert.ToString(StaticNumber.onecoinnumber);
            textBox6.Text = Convert.ToString(StaticNumber.fivecoinnumber);
            textBox7.Text = Convert.ToString(StaticNumber.tencoinnumber);
            textBox8.Text = Convert.ToString(StaticNumber.fiftycoinnumber);
            textBox9.Text = Convert.ToString(StaticNumber.hundrednotesnumber);
        }

        // 1,5,10,50,100 button add
        private void button3_Click(object sender, EventArgs e)
        {
            o1 = new OneDollar();
            textBox5.Text = Convert.ToString(StaticNumber.onecoinnumber);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            f = new FiveDollar();
            textBox6.Text = Convert.ToString(StaticNumber.fivecoinnumber);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            t = new TenDollar();
            textBox7.Text = Convert.ToString(StaticNumber.tencoinnumber);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ff = new FiftyDollar();
            textBox8.Text = Convert.ToString(StaticNumber.fiftycoinnumber);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            h = new HundredNotes();
            textBox9.Text = Convert.ToString(StaticNumber.hundrednotesnumber);
        }


        // finish pay
        private void button8_Click(object sender, EventArgs e)
        {
            sm.Sell(o1);
            sm.Sell(t);
            sm.Sell(f);
            sm.Sell(ff);
            sm.Sell(h);

            label7.Text = "顯示購買軟性飲料類型數量金額 ： " + "\r\n\r\n"
             + "一元硬幣：" + new String(' ', 10) + StaticNumber.onecoinnumber + " 個" + "\r\n"
             + "五元硬幣：" + new String(' ', 10) + StaticNumber.fivecoinnumber + " 個" + "\r\n"
             + "十元硬幣：" + new String(' ', 10) + StaticNumber.tencoinnumber + " 個" + "\r\n"
             + "五十元硬幣：" + new String(' ', 6) + StaticNumber.fiftycoinnumber + " 個" + "\r\n\r\n"
             + "一百元紙幣：" + new String(' ', 6) + StaticNumber.hundrednotesnumber + " 個" + "\r\n\r\n"
             + sm.Display();

            

            button8.Enabled = false;
        }

        // Select drinks show
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "本次購買軟性飲料類型,瓶數及總價 ： " + "\r\n\r\n"
             + "寶礦力運動飲料"+ StaticNumber.pocarinumber +"罐計：" + new String(' ', 10) + StaticNumber.pocarinumber*20 + " 元" + "\r\n"
             + "黑松沙士" + StaticNumber.heysongnumber + "瓶計：" + new String(' ', 10) + StaticNumber.heysongnumber * 18 + " 元" + "\r\n"
             + "蘋果西打" + StaticNumber.applecidernumber + "瓶計：" + new String(' ', 10) + StaticNumber.applecidernumber * 40 + " 元" + "\r\n"
             + "烏龍茶" + StaticNumber.oolongteanumber + "瓶計：" + new String(' ', 10) + StaticNumber.oolongteanumber * 22 + " 元" + "\r\n"
             + "總價:"+ (StaticNumber.pocarinumber * 20 + StaticNumber.heysongnumber * 18 + StaticNumber.applecidernumber * 40+ StaticNumber.oolongteanumber * 22) + "元";
        }


        //close button

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }


        // clear
        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1 = null;
            checkBox2 = null;
            checkBox3 = null;
            checkBox4 = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
