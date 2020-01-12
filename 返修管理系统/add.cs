using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 返修管理系统
{



    public partial class add : Form
    {
        RepairManagementS.BaseClass.Operation ope =new RepairManagementS.BaseClass.Operation();
        public add()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            A_region.Text = "";
            A_RepairCompany.Text = "";
            A_RepairMethod.Text = "";
            A_RepairNumber.Text = "";
            //A_NotificationOTOD.Text = "";
            //A_DeliveryTime.Text = "";
            A_Consignee.Text = "";
            A_MachineType.Text = "";
            A_Repairman.Text = "";
            A_MachineModel.Text = "";
            A_SerialNumber.Text = "";
            A_FaultStatus.Text = "";
            A_CauseOfFailure.Text = "";
            A_ExternalRepair.Text = "否";
            A_MaintenanceMethod.Text = "";
            A_Remarks.Text = "";
        }

        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (A_region.Text == " " | A_region.Text == "")//区域
            {
                MessageBox.Show("区域不能空白");
                return;
                }
            if (A_RepairCompany.Text == " " | A_RepairCompany.Text == "")//报修公司
            {
                MessageBox.Show("报修公司不能空白");
                return;
            }


            if (A_RepairMethod.Text == "自带" | A_RepairMethod.Text == "" | A_RepairMethod.Text == " ")//报修方式
            {
                MessageBox.Show("报修方式不能空白");
                return;
            }

            
            if (A_RepairNumber.Text == "" | A_RepairNumber.Text == " ")
            {
                MessageBox.Show("返修单号不能空白");
                return;
            }
            if (A_RepairNumber.Text.Length != 9)
            {
                MessageBox.Show("返修单号不够9位");
                return;
            }

            if (A_Consignee.Text == "" | A_Consignee.Text == " ")//提货人
            {
                MessageBox.Show("提货人不能空白");
                return;
            }
            
            if (A_MachineType.Text == "" | A_MachineType.Text == " ")//类型
            {
                MessageBox.Show("类型不能空白");
                return;
            }


            string reg= A_region.Text;//区域
            string RepairC = A_RepairCompany.Text;//报修公司
            string RepairM = A_RepairMethod.Text;//报修方式
            string RepairN = A_RepairNumber.Text;//返修单号
            DateTime NotificationO = A_NotificationOTOD.Value;//通知提货时间
            DateTime DeliveryT = A_DeliveryTime.Value;//提货时间
            string Con = A_Consignee.Text;//提货人
            string MachineT = A_MachineType.Text;//类型
            string Repairman = A_Repairman.Text;//维修人
            string MachineM = A_MachineModel.Text;//机器型号
            string SerialN = A_SerialNumber.Text;//序列号
            string FaultS = A_FaultStatus.Text;//故障现状
            string CauseOfF = A_CauseOfFailure.Text;//故障原因
            string ExternalR = A_ExternalRepair.Text;//是否外修
            string MaintenanceM = A_MaintenanceMethod.Text;//维修方法
            string Remarks = A_Remarks.Text;//备注
            
            ope.add(reg, RepairC, RepairM,RepairN, NotificationO, DeliveryT,Con, MachineT,Repairman,MachineM,SerialN,FaultS,CauseOfF,ExternalR, MaintenanceM,Remarks);//添加到数据库
            MessageBox.Show("添加成功");
        }
    }
}
