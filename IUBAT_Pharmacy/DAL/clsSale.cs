using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsSale:clsMyBase
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeId { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into sale(dateTime,employeeId) values(@dateTime,@employeeId) select @@Identity");
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);

            return ExecuteScaler(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update slae set dateTime = @dateTime, employeeId = @employeeId where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@dateTime", DateTime);
            MyCommand.Parameters.AddWithValue("@employeeId", EmployeeId);
            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from sale where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select  dateTime,employeeId from sale where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                DateTime = Convert.ToDateTime(MyReader["dateTime"]);
                EmployeeId = Convert.ToInt32(MyReader["employeeId"]);
            }
            return false;
        }

        public System.Data.DataSet Select(string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select sl.id as SaleId, p.name as Product, cp.name as Company, 
                                    p.code as Code, sld.qty, sld.rate, sld.vat, 
                                    ds.persentage as discount, slt.name as saleStatus, 
                                    sld.Id as DetailsId, pm.name as PaymentMethod, 
                                    sld.subTotal, sl.dateTime, em.name as Employee, 
                                    sld.ProductId as ProductId,sld.CompanyId as CompanyId,
                                    sld.SaleStatusId as SaleStatusId,sld.paymentMethodId as paymentMethodId,
                                    sld.DiscountId as DiscountId
                                    from sale as sl

                                    left join employee as em on sl.employeeId = em.Id
                                    left join SaleDetails as sld on sld.SaleId = sl.Id
                                    left join product as p on sld.productId = p.id
                                    left join company as cp on sld.companyId = cp.id
                                    left join discount as ds on sld.discountId = ds.id
                                    left join saleStatus as slt on sld.saleStatusId = slt.id
                                    left join paymentMethod as pm on sld.paymentMethodId = pm.id");

            if (Id > 0)
            {
                MyCommand.CommandText += (" where sl.id = @id");
                MyCommand.Parameters.AddWithValue("@id", Id);
            }

            MyCommand.CommandText += extra;
            return ExecuteDataSet(MyCommand);
        }


        public System.Data.DataSet CustomerPurchaseReport(int Sid = 0)
        {
            MyCommand = MyCommandBuilder("select * from vwSaleSingle");

            if (Sid > 0)
            {
                MyCommand.CommandText += (" where SaleId = @pid");
                MyCommand.Parameters.AddWithValue("@pid", Sid);
            }

            return ExecuteDataSet(MyCommand);
        }

    }
}
