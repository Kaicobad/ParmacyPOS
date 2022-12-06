using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsPurchase:clsMyBase
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into purchase(dateTime,employeeId) values( @dateTime, @employeeId ) select @@Identity");
            //MyCommand = MyCommandBuilder("insert into purchase(dateTime,employeeId) values( @dateTime, @employeeId )");
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);

            return ExecuteScaler(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update purchase set dateTime= @dateTime, employeeId = @employeeId where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
 
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);


            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from purchase where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select dateTime,employeeId from purchase where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
            DateTime = Convert.ToDateTime(MyReader["dateTime"]);
                EmployeeId = Convert.ToInt32(MyReader["employeeId"]);
               
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select(string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select pr.Id, p.name as Product, prc.qty, prc.rate,
                                            prc.vat as Vat, p.Code as Number,prc.subTotal, prc.Id as DetailsId, 
                                            ds.persentage as discount ,pr.dateTime , em.name as Employee, 
                                            Pr.employeeId as EmployeeId, Prc.DiscountId as DiscountId, prc.ProductId as ProductId
                                            from Purchase as pr
 
                                            left join purchasedetails as prc on prc.purchaseId = pr.Id
                                            left join product as p  on prc.ProductId= p.id 
                                            left join discount as ds on prc.DiscountId = ds.Id
                                            left join employee as em on pr.employeeId = em.Id where pr.id > 0 ");

            if (Id > 0)
            {
                MyCommand.CommandText += (" where pr.id = @id");
                MyCommand.Parameters.AddWithValue("@id", Id);
            }

            MyCommand.CommandText += extra;
            return ExecuteDataSet(MyCommand);
        }
        public System.Data.DataSet CustomerPurchaseReport(int Pid = 0)
        {
            MyCommand = MyCommandBuilder("select * from vwPurchaseSingle");

            if (Pid > 0)
            {
                MyCommand.CommandText += (" where id = @pid");
                MyCommand.Parameters.AddWithValue("@pid", Pid);
            }

            return ExecuteDataSet(MyCommand);
        }

    }
}
