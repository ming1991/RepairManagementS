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

        public DataSet GetDataSetZC()
        {
            return data.RunProcReturn("select * from RRForm ORDER BY ID", "RRForm");
        }

    }
}
