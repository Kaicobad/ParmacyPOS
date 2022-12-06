using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IUBAT_Pharmacy.DAL
{
    class clsMyBase
    {
        public int Identity { get; set; }

        protected string _Error;

        public string Error
        {
            get
            {
                return _Error;
            }
        }

        protected SqlConnection cn = new SqlConnection();

        protected bool Connection()
        {
            if (MyReader != null && !MyReader.IsClosed)
                MyReader.Close();

            if (cn.State == ConnectionState.Open)
                return true;
            cn.ConnectionString = IUBAT_Pharmacy.Properties.Settings.Default.Connection;
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                _Error = ex.Message;
            }
            return false;
        }

        protected SqlCommand MyCommand;

        protected SqlDataReader MyReader;

        protected SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            if (Connection())
                return cmd.ExecuteReader();
            return null;
        }

        protected SqlCommand MyCommandBuilder(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            return cmd;
        }
        protected bool ExecuteNonQuery(SqlCommand cmd)
        {
            if (!Connection())
                return false;

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                _Error = ex.Message;
            }
            return false;
        }

        protected bool ExecuteScaler(SqlCommand cmd)
        {
            if (!Connection())
                return false;

            try
            {
                Identity = Convert.ToInt32(cmd.ExecuteScalar());
                return true;
            }
            catch (Exception ex)
            {
                _Error = ex.Message;
            }
            return false;
        }

        protected DataSet ExecuteDataSet(string sql)
        {
            DataSet ds = new DataSet();

            if (!Connection())
                return null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        protected DataSet ExecuteDataSet(SqlCommand cmd)
        {
            DataSet ds = new DataSet();

            if (!Connection())
                return null;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

    }
}
