using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsSaleDetails:clsMyBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string Number { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double Vat { get; set; }
        public int DiscountId { get; set; }
        public int SaleStatusId { get; set; }
        public int SaleId { get; set; }
        public int PaymentMethodId { get; set; }
        public double SubTotal { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into saledetails(productId, companyId, Number, qty, rate,vat, discountId, saleStatusId, saleId, paymentMethodId, subTotal) values(@productId, @companyId, @Number, @qty, @rate, @vat, @discountId, @saleStatusId, @saleId, @paymentMethodId, @subTotal)");
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@Number", Number);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@saleId", SaleId);
            MyCommand.Parameters.AddWithValue("@paymentMethodId", PaymentMethodId);
            MyCommand.Parameters.AddWithValue("@subTotal", SubTotal);


            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update saleDetails set productId = @productId, companyId = @companyId, serialNumbe0 = @serialNumber, qty = @qty, rate = @rate, vat = @vat, discountId = @discountId, saleStatusId = @saleStatusId, saleId = @saleId, paymentMethodId = @paymentMethodId , subTotal = @subTotal where Id = !id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@Number", Number);
            MyCommand.Parameters.AddWithValue("@qty", Qty);
            MyCommand.Parameters.AddWithValue("@rate", Rate);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@saleId", SaleId);
            MyCommand.Parameters.AddWithValue("@paymentMethodId", PaymentMethodId);
            MyCommand.Parameters.AddWithValue("@subTotal", SubTotal);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from saleDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder("select productId, companyId, serialNumber, qty, rate,vat, discountId, saleStatusId, saleId, paymentMethodId, subTotal from saleDetails where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            MyReader = MyCommand.ExecuteReader();

            while (MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"]);
                ProductId = Convert.ToInt32(MyReader["productId"]);
                CompanyId = Convert.ToInt32(MyReader["companyId"]);
                Number = MyReader["Number"].ToString();
                Qty = Convert.ToInt32(MyReader["qty"]);
                Rate = Convert.ToDouble(MyReader["rate"]);
                Vat = Convert.ToDouble(MyReader["vat"]);
                DiscountId = Convert.ToInt32(MyReader["discountId"]);
                SaleStatusId = Convert.ToInt32(MyReader["saleStatusId"]);
                SaleId = Convert.ToInt32(MyReader["saleId"]);
                PaymentMethodId = Convert.ToInt32(MyReader["paymentMethodId"]);
                SubTotal = Convert.ToDouble(MyReader["subTotal"]);
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select( string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select sld.id as DetailsId, p.name as Product, cp.name as Company, 
                                            p.code as Code, sld.qty, sld.rate, sld.vat, 
                                            ds.persentage as discount, slt.name as saleStatus, 
                                            sl.Id as SaleId, pm.name as PaymentMethod, 
                                            sld.subTotal, sl.dateTime, em.name as Employee, 
                                            sld.ProductId as ProductId,sld.CompanyId as CompanyId,
                                            sld.SaleStatusId as SaleStatusId,sld.paymentMethodId as paymentMethodId,
                                            sld.DiscountId as DiscountId
                                            from saleDetails as sld 

                                            left join sale as sl on sl.id = sld.SaleId
                                            left join product as p on sld.productId = p.id
                                            left join company as cp on sld.companyId = cp.id
                                            left join discount as ds on sld.discountId = ds.id
                                            left join saleStatus as slt on sld.saleStatusId = slt.id
                                            left join paymentMethod as pm on sld.paymentMethodId = pm.id
                                            left join employee as em on sl.employeeId = em.Id where sld.id > 0 ");
            if (SaleId > 0)
            {
                MyCommand.CommandText += " and sld.saleId = @saleId";
                MyCommand.Parameters.AddWithValue("@saleId", SaleId);
            }

            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }

        public System.Data.DataSet SelectProductCount(string extra = "")
        {
            MyCommand = MyCommandBuilder(@"select p.name as Product, sum(sld.Qty) as Quantity from SaleDetails as sld 

                                            left join product as p on sld.ProductId = p.id where sld.id > 0

                                            group by p.Name ");
           
            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
