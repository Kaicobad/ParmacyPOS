using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsRack:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into rack(name,productId) values(@name, @productId)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update rack set name = @name, productId= @productId where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from rack where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, productId from rack where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                ProductId = Convert.ToInt32(MyReader["productId"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select(string extra ="")
        {
            MyCommand = MyCommandBuilder("select r.id, r.name, p.name as product from rack as r, product as p where r.productId = p.id");

            if (Name != "")
            {
                MyCommand.CommandText += " and r.name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }
            if (ProductId > 0)
            {
                MyCommand.CommandText += " and r.productId = @productId";
                MyCommand.Parameters.AddWithValue("@productId", ProductId);
            }

            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
