 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsSaleStatus:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into saleStatus(name,description) values(@name, @description)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update saleStatus set name = @name, description = @description where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from saleStatus where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, description from saleStatus where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Description = MyReader["description"].ToString();
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, name, description from saleStatus");
        }
    }
}
