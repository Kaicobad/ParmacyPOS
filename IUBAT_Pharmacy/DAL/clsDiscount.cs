using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsDiscount:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public decimal Persentage { get; set; }
        public double Persentage { get; set; }
        //public string Persentage { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into discount(name, persentage) values(@name, @persentage)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@persentage", Persentage);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update discount set name = @name, persentage = @persentage where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@persentage", Persentage);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from discount where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select id, name, persentage from discount where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                Name = MyReader["name"].ToString();
                Persentage = Convert.ToDouble(MyReader["persentage"]);
                //Persentage = MyReader["persentage"].ToString();
                //Persentage = Convert.ToDecimal(MyReader["persentage"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select()
        {
            return ExecuteDataSet("select id, name, persentage from discount");
        }
    }
}
