using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepairManagementS
{
    public partial class ReserveW : Form
    {
        RepairManagementS.BaseClass.Operation ope = new RepairManagementS.BaseClass.Operation();
        string IsItRight = null;//查看机器有没有在
        public ReserveW()
        {
            InitializeComponent();
            
        }


        /// <summary>
        /// 刷新序号列表
        /// </summary>
        
        private void R_SearchList()
        {
            comboBox1.Items.Clear(); //从 ComboBox 中移除所有项
            DataSet ds = ope.QueryStandbyMachineName();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow rows in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        comboBox1.Items.Add((rows[i]).ToString().Trim()); //添加列表并且移除当前所有前导空白字符和后置空白字符
                    }
                }
            }

        }

        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveW_Load(object sender, EventArgs e)
        {
            R_SearchList();//刷新序号列表
        }

        /// <summary>
        /// 按钮-确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// comboBox选择完后触发查看备用机是否在
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string aa = "";
            string tem = comboBox1.Text;
            //ope.CheckWTSMII(tem,out aa);
            IsItRight = ope.CheckWTSMII(tem, out aa);//查看机器有没有在
            if (IsItRight=="是")//如果有则运行下面
            {
                this.pictureBox1.Image = Image.FromFile(@"..\..\picture\YES.jpg");
                label4.Text = "出库人";
                label5.Text = "借用公司";
                textBox1.Text = "出库";

            }
            else//没有则运行
            {
                this.pictureBox1.Image = Image.FromFile(@"..\..\picture\NO.jpg");
                label4.Text = "入库人";
                label5.Text = "归还公司";
                textBox1.Text = "入库";
            }
            textBox4.Text = aa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }
    }
}
