using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsUnit:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrimaryQty { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into unit(name,description,primaryQty) values(@name, @description, @primaryQty)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);
            MyCommand.Parameters.AddWithValue("primaryQty", PrimaryQty);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update unit set name = @name, description = @description, primaryQty = @primaryQty where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);
            MyCommand.Parameters.AddWithValue("@primaryQty", PrimaryQty);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from unit where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, description, primaryQty from unit where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Description = MyReader["description"].ToString();
                PrimaryQty = Convert.ToInt32(MyReader["primaryQty"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, name, description, primaryQty from unit");
        }
    }
}
