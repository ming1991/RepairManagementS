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

        public modify()
        {
            InitializeComponent();
        }

        private void modify_Load(object sender, EventArgs e)
        {
            string tem=null;
            string WhatTable = null;//啥表
            DataSet ds;
            if (SearchListLabel == 1)
            {
                WhatTable = "dbo.RRForm";//返修表
                tem = "R_id";
                ds = ope.RegionTableSQL(tem, M_str, WhatTable);
                label17.Text = ds.Tables[0].Rows[0]["R_RepairCompany"].ToString();
            }
            if (SearchListLabel == 2)
            {
                WhatTable = "dbo.BackupMachine";//备用机表
                tem = "B_id";
                ds = ope.RegionTableSQL(tem, M_str, WhatTable);
                label17.Text = ds.Tables[0].Rows[0]["B_NameOfStandbyMachine"].ToString();
            }
            if (SearchListLabel == 3)
            {
                WhatTable = "dbo.SpareMachineIAOR";//备用机记录表
                tem = "S_id";
                ds = ope.RegionTableSQL(tem, M_str, WhatTable);
                label17.Text = ds.Tables[0].Rows[0]["S_AccessoriesN"].ToString() + "   "+ WhatTable;
            }
            
            //ds = ope.RegionTableSQL(tem, M_str,WhatTable);
            //label17.Text =  ds.Tables[0].Rows[0]["R_RepairCompany"].ToString();
        }
    }
}
