using RepairManagementS;
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
    public partial class Main : Form
    {

        RepairManagementS.BaseClass.Operation ope = new RepairManagementS.BaseClass.Operation();
        private int SearchListLabel = 1;//搜索列表标签


        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示返修表按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new add().Show();
        }

        /// <summary>
        /// 窗口启动项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            SearchListLabel = 1;//设置模式
            QueryAllCourse();//查询整表-返修表
            
            SearchList();//加载搜索列表
        }

        /// <summary>
        /// 搜索列表
        /// </summary>
        /// <param name="tem">1：返修表，2：备用机</param>
        private void SearchList()
        {

            comboBox1.Items.Clear(); //从 ComboBox 中移除所有项
            if (SearchListLabel == 1)//返修表
            {
                comboBox1.Text = "返修单号";
                comboBox1.Items.Add("区域");//添加
                comboBox1.Items.Add("报修公司");
                comboBox1.Items.Add("返修单号");
                comboBox1.Items.Add("类型");
                comboBox1.Items.Add("序列号");
            }

            if (SearchListLabel == 2)//备用机
            {
                comboBox1.Text = "备用机名称";
                comboBox1.Items.Add("备用机编号");//添加
                comboBox1.Items.Add("备用机名称");
                comboBox1.Items.Add("是否在库");
                comboBox1.Items.Add("借用公司");
                comboBox1.Items.Add("归还公司");
            }
            if (SearchListLabel == 3)//备用机记录表
            {
                comboBox1.Text = "编号";
                comboBox1.Items.Add("编号");//添加
                comboBox1.Items.Add("配件名称");
                comboBox1.Items.Add("入库/出库人");
                comboBox1.Items.Add("归还/借用公司");
                comboBox1.Items.Add("借用人");
                comboBox1.Items.Add("单号");

                
            }


        }




        /// <summary>
        /// 查询整表-返修表
        /// </summary>
        private void QueryAllCourse()
        {
            DataSet ds = ope.QueryTable();
            dataGridView1.DataSource = ds.Tables[0];
            BackupMachine();// 设置返修登记表表格显示属性-返修表

        }

        /// <summary>
        /// 查询条件-返修表
        /// </summary>
        private void QueryCriteria(string atem,string tem)
        {
            string WhatTable = null;//啥表
            if (SearchListLabel==1)
            {
                WhatTable = "dbo.RRForm";//返修表
            }
            if (SearchListLabel ==2)
            {
                WhatTable = "dbo.BackupMachine";//备用机表
            }
            if (SearchListLabel ==3)
            {
                WhatTable = "dbo.SpareMachineIAOR";//备用机记录表
            }
            
            DataSet ds = ope.RegionTableSQL(atem, tem, WhatTable);
            dataGridView1.DataSource = ds.Tables[0];
            BackupMachine();// 设置返修登记表表格显示属性-返修表
        }

        /// <summary>
        /// 按钮精确查询-返修表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //区域
            //报修公司
            //返修单号
            //类型
            //序列号
            string ConditionParameter = null;//数据库表名称
            string QueryBox = queryBox.Text;//参数

            if (SearchListLabel==1)
            {
                switch (comboBox1.Text)
                {
                    case "区域":
                        ConditionParameter = "R_region";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "报修公司":
                        ConditionParameter = "R_RepairCompany";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "返修单号":
                        ConditionParameter = "R_RepairNumber";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "类型":
                        ConditionParameter = "R_MachineType";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "序列号":
                        ConditionParameter = "R_SerialNumber";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    default:
                        MessageBox.Show("参数错误");
                        break;
                }
            }
            if (SearchListLabel == 2)
            {
                switch (comboBox1.Text)
                {
                    case "备用机编号":
                        ConditionParameter = "B_Number";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "备用机名称":
                        ConditionParameter = "B_NameOfStandbyMachine";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "是否在库":
                        ConditionParameter = "B_InLibraryOrNot";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "借用公司":
                        ConditionParameter = "B_BorrowingCompany";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "归还公司":
                        ConditionParameter = "B_ReturnToCompany";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    default:
                        MessageBox.Show("参数错误");
                        break;
                }

            }
            if (SearchListLabel == 3)
            {
                switch (comboBox1.Text)
                {
                    case "编号":
                        ConditionParameter = "S_number";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "配件名称":
                        ConditionParameter = "S_AccessoriesN";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "入库/出库人":
                        ConditionParameter = "S_WarehouseInWarehouseOP";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "归还/借用公司":
                        ConditionParameter = "S_ReturnBorrowC";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "借用人":
                        ConditionParameter = "S_Borrower";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;
                    case "单号":
                        ConditionParameter = "S_OddNumbers";
                        QueryCriteria(ConditionParameter, QueryBox);
                        break;

                    default:
                        MessageBox.Show("参数错误");
                        break;
                }
            }
        }
        /// <summary>
        /// 模糊查询-返修表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string QueryBox = queryBox.Text;
            FuzzyQuery(QueryBox);//查询

        }

        /// <summary>
        /// 模糊查询-返修表
        /// </summary>
        /// <param name="tem"></param>
        private void FuzzyQuery(string tem)
        {
            DataSet ds = ope.FuzzyQuerySQL(tem, SearchListLabel);
            dataGridView1.DataSource = ds.Tables[0]; ;
            BackupMachine();// 设置返修登记表表格显示属性 - 返修表

        }

        /// <summary>
        /// 设置表表格显示属性
        /// </summary>
        private void BackupMachine()
        {
            if (SearchListLabel==1)
            {
                dataGridView1.Columns[0].HeaderText = "编号";
                dataGridView1.Columns[1].HeaderText = "区域";
                dataGridView1.Columns[2].HeaderText = "报修公司";
                dataGridView1.Columns[3].HeaderText = "报修方式";
                dataGridView1.Columns[4].HeaderText = "返修单号";
                dataGridView1.Columns[5].HeaderText = "通知提货时间";
                dataGridView1.Columns[6].HeaderText = "提货时间";
                dataGridView1.Columns[7].HeaderText = "提货人";
                dataGridView1.Columns[8].HeaderText = "类型";
                dataGridView1.Columns[9].HeaderText = "维修人";
                dataGridView1.Columns[10].HeaderText = "机器型号";
                dataGridView1.Columns[11].HeaderText = "序列号";
                dataGridView1.Columns[12].HeaderText = "故障现状";
                dataGridView1.Columns[13].HeaderText = "故障原因";
                dataGridView1.Columns[14].HeaderText = "是否外修";
                dataGridView1.Columns[15].HeaderText = "维修方法";
                dataGridView1.Columns[16].HeaderText = "寄回日期";
                dataGridView1.Columns[17].HeaderText = "寄回单号";
                dataGridView1.Columns[18].HeaderText = "发货人";
                dataGridView1.Columns[19].HeaderText = "备注";
                
            }
            if (SearchListLabel==2)
            {
                dataGridView1.Columns[0].HeaderText = "编号";
                dataGridView1.Columns[1].HeaderText = "备用机编号";
                dataGridView1.Columns[2].HeaderText = "备用机名称";
                dataGridView1.Columns[3].HeaderText = "机器型号";
                dataGridView1.Columns[4].HeaderText = "序列号";
                dataGridView1.Columns[5].HeaderText = "最后出库时间";
                dataGridView1.Columns[6].HeaderText = "最后入库时间";
                dataGridView1.Columns[7].HeaderText = "是否在库";
                dataGridView1.Columns[8].HeaderText = "出库仓库";
                dataGridView1.Columns[9].HeaderText = "借用公司";
                dataGridView1.Columns[10].HeaderText = "借用人";
                dataGridView1.Columns[11].HeaderText = "出库人";
                dataGridView1.Columns[12].HeaderText = "出库日期";
                dataGridView1.Columns[13].HeaderText = "出库单号";
                dataGridView1.Columns[14].HeaderText = "入库人";
                dataGridView1.Columns[15].HeaderText = "归还公司";
                dataGridView1.Columns[16].HeaderText = "入库单号";
                dataGridView1.Columns[17].HeaderText = "入库日期";
                dataGridView1.Columns[18].HeaderText = "备注";
            }
            if (SearchListLabel == 3)
            {
                dataGridView1.Columns[0].HeaderText = "id";
                dataGridView1.Columns[1].HeaderText = "序号";
                dataGridView1.Columns[2].HeaderText = "出入库";
                dataGridView1.Columns[3].HeaderText = "日期";
                dataGridView1.Columns[4].HeaderText = "编号";
                dataGridView1.Columns[5].HeaderText = "配件名称";
                dataGridView1.Columns[6].HeaderText = "入库/出库人";
                dataGridView1.Columns[7].HeaderText = "归还/借用公司";
                dataGridView1.Columns[8].HeaderText = "借用人";
                dataGridView1.Columns[9].HeaderText = "单号";
                dataGridView1.Columns[10].HeaderText = "备注";
            }
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.MultiSelect = false;

        }

        

        
       

        /// <summary>
        /// 查询备用机整表
        /// </summary>
        private void StandbyMachineList()
        {
            DataSet ds = ope.BackupMachineSQL();
            dataGridView1.DataSource = ds.Tables[0];
            BackupMachine();//设置表格显示属性-备用机

        }

        

        /// <summary>
        /// 按钮-查看备用机出入库记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewTEAEROSM_Click(object sender, EventArgs e)
        {
            ViewT();
        }

        /// <summary>
        /// 查询备用机记录表
        /// </summary>
        private void ViewT()
        {
            DataSet ds = ope.ViewTEAEROSMSQL();
            dataGridView1.DataSource = ds.Tables[0];
            BackupMachine();//设置表格显示属性-备用机

        }

        

        /// <summary>
        /// 按钮-备用机入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveWarehousing_Click(object sender, EventArgs e)
        {
            new ReserveW().Show();
        }

        private void 查看备用机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchListLabel = 2;
            StandbyMachineList();//查询备用机整表
            
            SearchList();
        }

        private void 备用机出入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReserveW().Show();
        }

        private void 查看备用机出入库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchListLabel = 3;
            ViewT();//查询备用机
            SearchList();


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new add().Show();//显示添加返修表窗口
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            QueryAllCourse();//查询整表-返修表
            SearchListLabel = 1;
            SearchList();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗口
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex>=0)
                {
                    try
                    {
                            //若行已是选中状态就不再进行设置
                        if (dataGridView1.Rows[e.RowIndex].Selected==false)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[e.RowIndex].Selected = true;
                        }

                        //只选中一行时设置活动单元
                        if (dataGridView1.SelectedRows.Count == 1)
                        {
                        
                            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                       
                            //dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        }
                        //弹出操作菜单
                        datacontMS.Show(MousePosition.X, MousePosition.Y);
                    }
                    catch (Exception)
                    {
                       
                       
                    }
                }
            }
        }

        /// <summary>
        /// 双击鼠标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        public void modify(object sender,EventArgs e)
        {
            if (dataGridView1.RowCount>1)
            {
                RepairManagementS.modify modify = new RepairManagementS.modify();
                modify.M_str = dataGridView1.SelectedCells[0].Value.ToString();
                modify.SearchListLabel = SearchListLabel;
                modify.Show();
            }
        
        }

        private void 更改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SearchListLabel==1)
            {
                modify(sender, e);
            }
            
        }
    }
}
