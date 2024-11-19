using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory = 0; //熱量(卡路里)
            double gram = 0;   //克數(脂肪重量)

            //以下作答，必須使用double.TryParse()方法
            if (double.TryParse(textBox1.Text,out calory) &&double.TryParse(textBox2.Text, out gram))
            {
                if (calory > 0 && gram > 0)
                {
                    double fatcalory = gram * 9;
                    double fatPercentage = (fatcalory / calory) * 100;
                    string result = $"脂肪卡路里數: {fatcalory}\n";
                    result += $"來自脂肪的百分比: {fatPercentage:F2}%\n";
                    if (radioButton1.Checked)
                    {
                        if (fatPercentage < 30)
                        {
                            result += "這是低脂食品。";
                        }
                        else
                        {
                            result += "這不是低脂食品。";
                        }
                    }
                    label3.Text = result;
                }
                else
                {
                    label3.Text = "請輸入大於0的數字！";
                }
            }
            else
            {
                label3.Text = "請輸入正確的數字格式！";
            }
        }
    }
}
