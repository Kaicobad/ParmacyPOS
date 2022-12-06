using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPower:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into power(name) values(@name)");
            MyCommand.Parameters.AddWithValue("@name", Name);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update power set name = @name where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from power where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name from power where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            MyCommand = MyCommandBuilder("select id, name from power");

            if (Name !="")
            {
                MyCommand.CommandText += " where name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }

            return ExecuteDataSet(MyCommand);
        }
    }
}
