using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RepairManagementS.BaseClass
{
    class SQL
    {
        private SqlConnection con;  //创建连接对象

        /// <summary>
        /// 打开数据库连接.
        /// </summary>
        private void Open()
        {
            // 打开数据库连接
            if (con == null)
            {

                
                try
                {
                    con = new SqlConnection("Data Source=192.168.0.107;DataBase=my_Repair_db;Integrated Security=false;Uid=sa;Pwd=123456789;");
                }
                catch (Exception)
                {

                    MessageBox.Show("数据库连接错误");
                }
                //con = new SqlConnection(" Data Source = .\\SqlExpress;DataBase = db_EquipmentMS;Integrated Security =True");
            }
            if (con.State == System.Data.ConnectionState.Closed)//状态关闭
            {
                //MessageBox.Show("数据库连接错误2");
                //System.Environment.Exit(0);//关闭窗体
                con.Open();

            }  
                

        }
      

    
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (con != null)
                con.Close();
        }
        

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            // 确认连接是否已经关闭
            if (con != null)
            {
                con.Dispose();
                con = null;
            }
        }
        


        /// <summary>
        /// 直接执行SQL语句
        /// </summary>
        /// <param name="procName">命令文本</param>
        /// <returns></returns>
        public int RunProc(string procName)
        {
            this.Open();
            SqlCommand cmd = new SqlCommand(procName, con);
            cmd.ExecuteNonQuery();
            this.Close();
            return 1;
        }

        
        /// <summary>
        /// 创建一个SqlDataAdapter对象以此来执行命令文本
        /// </summary>
        /// <param name="procName">命令文本</param>
        /// <param name="prams">参数对象</param>
        /// <returns></returns>
        private SqlDataAdapter CreateDataAdaper(string procName, SqlParameter[] prams)
        {
            this.Open();
            SqlDataAdapter dap = new SqlDataAdapter(procName, con);
            dap.SelectCommand.CommandType = CommandType.Text;  //执行类型：命令文本
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                    dap.SelectCommand.Parameters.Add(parameter);
            }
            //加入返回参数
            dap.SelectCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                ParameterDirection.ReturnValue, false, 0, 0,
                string.Empty, DataRowVersion.Default, null));

            return dap;
        }


        /// <summary>
        /// 执行命令文本，并且返回DataSet数据集
        /// </summary>
        /// <param name="procName">命令文本</param>
        /// <param name="tbName">数据表名称</param>
        /// <returns>DataSet</returns>
        public DataSet RunProcReturn(string procName, string tbName)
        {
            SqlDataAdapter dap = CreateDataAdaper(procName, null);
            DataSet ds = new DataSet();
            dap.Fill(ds, tbName);
            this.Close();
            //得到执行成功返回值
            return ds;
        }
    }
}