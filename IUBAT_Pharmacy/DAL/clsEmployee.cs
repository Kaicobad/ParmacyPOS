using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IUBAT_Pharmacy.DAL
{
    class clsEmployee:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public byte[] Image { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into employee(name, phone, email, password, type, image) values(@name, @phone, @email, @password, @type, @image)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@phone", Phone);
            MyCommand.Parameters.AddWithValue("@email", Email);
            MyCommand.Parameters.AddWithValue("@password", Password);
            MyCommand.Parameters.AddWithValue("@type", Type);
            MyCommand.Parameters.AddWithValue("@image", Image);

            return ExecuteNonQuery(MyCommand);
        }
        public bool Update()
        {
            MyCommand = MyCommandBuilder("update employee set name = @name, phone = @phone, email = @email, password = @password, type = @type, image = @image where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@phone", Phone);
            MyCommand.Parameters.AddWithValue("@email", Email);
            MyCommand.Parameters.AddWithValue("@password", Password);
            MyCommand.Parameters.AddWithValue("@type", Type);
            MyCommand.Parameters.AddWithValue("@image", Image);
            return ExecuteNonQuery(MyCommand);
        }
        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from employee where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            return ExecuteNonQuery(MyCommand);
        }
        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name,phone,email, password, type, image from employee where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Phone = MyReader["phone"].ToString();
                Email = MyReader["email"].ToString();
                Password = MyReader["password"].ToString();
                Type = MyReader["type"].ToString();
                Image = (byte[])MyReader["image"];
                return true;
            }
            return false;
        }

        public DataSet Select( string extra = "")
        {
            MyCommand = MyCommandBuilder("select id, name,phone, email, password, type, image from employee where id > 0 ");

            if (Name != "")
            {
                MyCommand.CommandText += " and name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }
            if (Type != "")
            {
                MyCommand.CommandText += " and type like @type";
                MyCommand.Parameters.AddWithValue("@type", "%" + Type + "%");
            }


            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
        public bool Login()
        {
            MyCommand = MyCommandBuilder("select id, name, type, password from employee where name = @name and password = @password and type = @type and id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@password", Password);
            MyCommand.Parameters.AddWithValue("@type", Type);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Type = MyReader["type"].ToString();
                Password = MyReader["password"].ToString();
                return true;
            }
            return false;
        }
    }
}
