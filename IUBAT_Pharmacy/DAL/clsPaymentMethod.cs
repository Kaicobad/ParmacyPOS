using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPaymentMethod:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
       
        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into paymentMethod(name,company) values(@name, @company)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@company", Company);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update paymentMethod set name = @name, company = @company where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@company", Company);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from paymentMethod where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, company from paymentMethod where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Company = MyReader["company"].ToString();
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, name, company from paymentMethod");
        }
    }
}
