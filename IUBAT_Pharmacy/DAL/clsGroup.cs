using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IUBAT_Pharmacy.DAL
{
    class clsGroup:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into [group](name, description) values(@name, @description)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update [group] set name = @name, description = @description where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@description", Description);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from [group] where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, description from [group] where Id = @id");
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

        public System.Data.DataSet Select( string extra = "")
        {
            MyCommand = MyCommandBuilder("select g.id, g.name, g.description, (select count(id) from product where groupId = g.id) as products from [group] as g where g.id > 0");

            if (Name !="")
            {
                MyCommand.CommandText += " and g.name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }
            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
