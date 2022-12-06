using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IUBAT_Pharmacy.DAL
{
    class clsCompany:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreateDateTime { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into company(name, contactPerson, contact, email, address, createDateTime) values(@name, @contactPerson, @contact, @email, @address, @createDateTime)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@contactPerson", ContactPerson);
            MyCommand.Parameters.AddWithValue("@contact", Contact);
            MyCommand.Parameters.AddWithValue("@email", Email);
            MyCommand.Parameters.AddWithValue("@address", Address);
            MyCommand.Parameters.AddWithValue("@createDateTime", CreateDateTime);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("Update company set name = @name, contactPerson = @contactPerson, contact = @contact, email = @email, address = @address, createDateTime = @createDateTime where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@contactPerson", ContactPerson);
            MyCommand.Parameters.AddWithValue("@contact", Contact);
            MyCommand.Parameters.AddWithValue("@email", Email);
            MyCommand.Parameters.AddWithValue("@address", Address);
            MyCommand.Parameters.AddWithValue("@createDateTime", CreateDateTime);
            return ExecuteNonQuery(MyCommand);
        }
        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from company where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, contactPerson, contact, email, address, createDateTime from company where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                ContactPerson = MyReader["contactPerson"].ToString();
                Contact = MyReader["contact"].ToString();
                Email = MyReader["email"].ToString();
                Address = MyReader["address"].ToString();
                CreateDateTime = Convert.ToDateTime(MyReader["createDateTime"]);
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            MyCommand = MyCommandBuilder("select id, name, contactPerson, contact, email, address, createDateTime from company");

            if (Name !="")
            {
                MyCommand.CommandText += " where name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }

            return ExecuteDataSet(MyCommand);
        }
    }
}
