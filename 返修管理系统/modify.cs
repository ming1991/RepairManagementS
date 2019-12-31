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
    public partial class modify : Form
    {
        RepairManagementS.BaseClass.Operation ope = new RepairManagementS.BaseClass.Operation();
        public string M_str = "";
        public int SearchListLabel = 0;
        public string tem = null;

        public modify()
        {
            InitializeComponent();
        }

        private void modify_Load(object sender, EventArgs e)
        {


            
            string WhatTable = null;//啥表
            DataSet ds;
            
            WhatTable = "dbo.RRForm";//返修表
            tem = "R_id";
            ds = ope.RegionTableSQL(tem, M_str, WhatTable);
                //label17.Text = ds.Tables[0].Rows[0]["R_region"].ToString();
            label1.Text = "区域";
            label2.Text = "报修公司";
            label3.Text = "报修方式";
            label4.Text = "返修单号";
            label5.Text = "通知提货时间";
            label6.Text = "提货时间";
            label7.Text = "提货人";
            label8.Text = "类型";
            label9.Text = "维修人";
            label10.Text = "机器型号";
            label11.Text = "序列号";
            label12.Text = "故障现状";
            label13.Text = "故障原因";
            label14.Text = "是否外修";
            label15.Text = "维修方法";
            label16.Text = "寄回日期";
            label17.Text = "寄回单号";
            label18.Text = "发货人";
            label19.Text = "备注";

            try
            {
                TextBox1.Text= ds.Tables[0].Rows[0]["R_region"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["R_RepairCompany"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["R_RepairMethod"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["R_RepairNumber"].ToString();

                try
                {
                    A_NotificationOTOD.Value = (DateTime)ds.Tables[0].Rows[0]["R_NotificationOTOD"];
                }
                catch (Exception)
                {

                }
                try
                {
                    A_DeliveryTime.Value = (DateTime)ds.Tables[0].Rows[0]["R_DeliveryTime"];
                }
                catch (Exception)
                {

                }


                
                TextBox7.Text = ds.Tables[0].Rows[0]["R_Consignee"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["R_MachineType"].ToString();
                TextBox9.Text = ds.Tables[0].Rows[0]["R_Repairman"].ToString();
                TextBox10.Text = ds.Tables[0].Rows[0]["R_MachineModel"].ToString();
                TextBox11.Text = ds.Tables[0].Rows[0]["R_SerialNumber"].ToString();
                TextBox12.Text = ds.Tables[0].Rows[0]["R_FaultStatus"].ToString();
                TextBox13.Text = ds.Tables[0].Rows[0]["R_CauseOfFailure"].ToString();
                TextBox14.Text = ds.Tables[0].Rows[0]["R_ExternalRepair"].ToString();
                TextBox15.Text = ds.Tables[0].Rows[0]["R_MaintenanceMethod"].ToString();

                try
                {
                    r_dateOfReturn.Value = (DateTime)ds.Tables[0].Rows[0]["R_DateOfReturn"];
                }
                catch (Exception)
                {
                    
                }
                



                TextBox17.Text = ds.Tables[0].Rows[0]["R_ReturnTheOddNumber"].ToString();
                TextBox18.Text = ds.Tables[0].Rows[0]["R_Consignor"].ToString();
                TextBox19.Text = ds.Tables[0].Rows[0]["R_Remarks"].ToString();
            }
            catch (Exception)
            {

                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }

        /// <summary>
        /// 按钮-更改修改返修表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string region = TextBox1.Text;
            string RepairCompany = TextBox2.Text;
            string RepairMethod = TextBox3.Text;
            string RepairNumber = TextBox4.Text;
            string Consignee = TextBox7.Text;
            string MachineType = TextBox8.Text;
            string Repairman = TextBox9.Text;
            string MachineModel = TextBox10.Text;
            string SerialNumber = TextBox11.Text;
            string FaultStatus = TextBox12.Text;
            string CauseOfFailure = TextBox13.Text;
            string ExternalRepair = TextBox14.Text;
            string MaintenanceMethod = TextBox15.Text;
            string DateOfReturn = r_dateOfReturn.Value.ToString();
            string ReturnTheOddNumber = TextBox17.Text;
            string Consignor = TextBox18.Text;
            string Remarks = TextBox19.Text;
            ope.ModifyTheRepairFormSQL(M_str,  region,  RepairCompany,  RepairMethod,  RepairNumber,  Consignee,  MachineType,  Repairman,  MachineModel,  SerialNumber,  FaultStatus,  CauseOfFailure,  ExternalRepair,  MaintenanceMethod,  DateOfReturn,  ReturnTheOddNumber,Consignor,Remarks);
            MessageBox.Show("更改成功");

        }
    }
}
