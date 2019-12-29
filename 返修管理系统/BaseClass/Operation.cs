using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace RepairManagementS.BaseClass
{
    class Operation
    {
        SQL data = new SQL();

        /// <summary>
        /// 维修添加
        /// </summary>
        /// <param name="reg"></param>
        /// <param name="RepairC"></param>
        /// <param name="RepairM"></param>
        /// <param name="RepairN"></param>
        /// <param name="NotificationO"></param>
        /// <param name="DeliveryT"></param>
        /// <param name="Con"></param>
        /// <param name="MachineT"></param>
        /// <param name="Repairman"></param>
        /// <param name="MachineM"></param>
        /// <param name="SerialN"></param>
        /// <param name="FaultS"></param>
        /// <param name="CauseOfF"></param>
        /// <param name="ExternalR"></param>
        /// <param name="MaintenanceM"></param>
        /// <param name="Remarks"></param>
        /// <returns></returns>
        public int add(string reg, string RepairC, string RepairM, string RepairN, DateTime NotificationO, DateTime DeliveryT, string Con, string MachineT, string Repairman, string MachineM, string SerialN, string FaultS, string CauseOfF, string ExternalR, string MaintenanceM, string Remarks)
            {
            return (data.RunProc("INSERT INTO RRForm(R_region,R_RepairCompany,R_RepairMethod,R_RepairNumber,R_NotificationOTOD,R_DeliveryTime,R_Consignee,R_MachineType,R_Repairman,R_MachineModel,R_SerialNumber,R_FaultStatus,R_CauseOfFailure ,R_ExternalRepair ,R_MaintenanceMethod ,R_Remarks)" +
                "VALUES(\'" + reg + "\',\'" + RepairC + "\',\'" + RepairM + "\',\'" + RepairN + "\',\'" + NotificationO + "\',\'" + DeliveryT + "\',\'" + Con + "\',\'" + MachineT + "\',\'" + Repairman + "\',\'" + MachineM + "\',\'" + SerialN + "\',\'" + FaultS + "\',\'" + CauseOfF + "\',\'" + ExternalR + "\',\'" + MaintenanceM + "\',\'" + Remarks + "\')"));

            }

        

        /// <summary>
        /// 查询整表
        /// </summary>
        /// <returns></returns>
        public DataSet QueryTable()
        {
            return (data.RunProcReturn("select * from dbo.RRForm", "dbo.RRForm"));

        }


        /// <summary>
        /// /// <summary>
        /// 精确返修查询SQL
        /// </summary>
        /// <param name="querytem"></param>列表名  
        /// <param name="variable"></param>变量
        /// <param name="TableName"></param>表名称
        /// <returns></returns>
        public DataSet RegionTableSQL(string querytem, string variable,string TableName)
        {
            return (data.RunProcReturn("select * from "+ TableName + " WHERE " + querytem + " LIKE '%" + variable + "%'", TableName));


        }


        /// <summary>
        /// 模糊查询-返修表
        /// </summary>
        /// <param name="querytem"></param>
        /// <param name="tem"></param>
        /// <returns></returns>
        public DataSet FuzzyQuerySQL(string tem,int SearchListLabel)
        {
            if (SearchListLabel==1)
            {
                return (data.RunProcReturn("select * from dbo.RRForm where R_region LIKE '%" + tem + "%' OR R_RepairCompany LIKE'%" + tem + "%' or R_RepairMethod LIKE'%" + tem + "%' or R_RepairNumber LIKE'%" + tem + "%' or R_Consignee LIKE'%" + tem + "%' or R_MachineType LIKE'%" + tem + "%' or R_Repairman LIKE'%" + tem + "%' or R_MachineModel LIKE'%" + tem + "%' or R_SerialNumber LIKE'%" + tem + "%' ", "dbo.RRForm"));
                //select * from dbo.RRForm where R_region LIKE '%" + tem + "%' OR R_RepairCompany LIKE'%" + tem + "%' or R_RepairMethod LIKE'%" + tem + "%' or R_RepairNumber LIKE'%" + tem + "%' or R_Consignee LIKE'%" + tem + "%' or R_MachineType LIKE'%" + tem + "%' or R_Repairman LIKE'%" + tem + "%' or R_MachineModel LIKE'%" + tem + "%' or R_SerialNumber LIKE'%" + tem + "%' 

            }
            if (SearchListLabel ==2)
            {
                return (data.RunProcReturn(" select * from dbo.BackupMachine where B_Number LIKE '%" + tem + "%' OR B_NameOfStandbyMachine LIKE '%" + tem + "%' OR B_InLibraryOrNot LIKE '%" + tem + "%' OR B_BorrowingCompany LIKE '%" + tem + "%' OR B_ReturnToCompany LIKE '%" + tem + "%' ", "dbo.BackupMachine"));

            }
            if (SearchListLabel == 3)
            {
                return (data.RunProcReturn(" select * from dbo.SpareMachineIAOR where S_number LIKE '%" + tem + "%' OR S_AccessoriesN LIKE '%" + tem + "%' OR S_WarehouseInWarehouseOP LIKE '%" + tem + "%' OR S_ReturnBorrowC LIKE '%" + tem + "%' OR S_Borrower LIKE '%" + tem + "%' OR S_OddNumbers LIKE '%" + tem + "%' ", "dbo.SpareMachineIAOR"));

            }
            return null;
        }

        /// <summary>
        /// 查询备用机整表SQL
        /// </summary>
        /// <returns></returns>
        public DataSet BackupMachineSQL()
        {
            return (data.RunProcReturn("select * from BackupMachine", "BackupMachine"));

        }

        /// <summary>
        /// 查询备用机记录表SQL
        /// </summary>
        /// <returns></returns>
        public DataSet ViewTEAEROSMSQL()
        {

            return (data.RunProcReturn("select * from dbo.SpareMachineIAOR", "dbo.SpareMachineIAOR"));
        }

        /// <summary>
        /// 查询备用机名称列
        /// </summary>
        /// <returns></returns>
        public DataSet QueryStandbyMachineName()
        {
            return (data.RunProcReturn("select B_Number from dbo.BackupMachine", "dbo.BackupMachine"));
            //select B_Number from dbo.BackupMachine
        }

        /// <summary>
        /// 查备用机是否在
        /// </summary>
        /// <returns></returns>
        public string CheckWTSMII(string tem )
        {
            DataSet ds = (data.RunProcReturn("select B_InLibraryOrNot FROM dbo.BackupMachine WHERE B_Number='"+ tem + "'", "dbo.BackupMachine"));
            
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow rows in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        return ((rows[i]).ToString().Trim()); //添加列表并且移除当前所有前导空白字符和后置空白字符
                    }
                    return null;
                }
            }
            return null;
        }
    }
}
