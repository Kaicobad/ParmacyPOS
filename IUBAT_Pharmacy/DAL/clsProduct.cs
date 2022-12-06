using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUBAT_Pharmacy.DAL
{
    class clsProduct:clsMyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int GroupId { get; set; }
        public int PowerId { get; set; }
        public int CompanyId { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        public int DiscountId { get; set; }
        public int SaleStatusId { get; set; }
        public double ListPrice { get; set; }
        public double Vat { get; set; }
        public string Remarks { get; set; }
        public string _discount { get; set; }
        public string _rate { get; set; }
        public string _vat { get; set; }
        public string _code { get; set; }
        public string _company { get; set; }

        public bool Insert()
        {
            MyCommand = MyCommandBuilder("insert into product(name, code, groupId, powerId, companyId, categoryId, unitId, discountId, saleStatusId, listPrice, vat, remarks) values(@name, @code, @groupId, @powerId, @companyId, @categoryId, @unitId, @discountId, @saleStatusId, @listPrice, @vat, @remarks)");
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@code", Code);
            MyCommand.Parameters.AddWithValue("@groupId", GroupId);
            MyCommand.Parameters.AddWithValue("@powerId", PowerId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@categoryId", CategoryId);
            MyCommand.Parameters.AddWithValue("@unitId", UnitId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@listPrice", ListPrice);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@remarks", Remarks);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Update()
        {
            MyCommand = MyCommandBuilder("update product set name = @name, code = @code, group = @groupId, powerId = @powerId, companyId = @companyId, categoryId = @categoryId, unitId = @unitId, discountId = @discountId, saleStatusId = @saleStatusId, listPrice = @listPrice, vat = @vat, remarks = @remarks where Id = @id ");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            MyCommand.Parameters.AddWithValue("@code", Code);
            MyCommand.Parameters.AddWithValue("@groupId", GroupId);
            MyCommand.Parameters.AddWithValue("@powerId", PowerId);
            MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            MyCommand.Parameters.AddWithValue("@categoryId", CategoryId);
            MyCommand.Parameters.AddWithValue("@unitId", UnitId);
            MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            MyCommand.Parameters.AddWithValue("@listPrice", ListPrice);
            MyCommand.Parameters.AddWithValue("@vat", Vat);
            MyCommand.Parameters.AddWithValue("@remarks", Remarks);

            return ExecuteNonQuery(MyCommand);
        }

        public bool Delete()
        {
            MyCommand = MyCommandBuilder("delete from product where Id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);

            return ExecuteNonQuery(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = MyCommandBuilder(@"select p.id, p.name,c.name as company, c.Id as companyId, p.listPrice as rate, p.listPrice, p.code, p.code as code,
                                            p.vat as vat, p.vat, ds.Persentage as discount, ds.Id as discountId from product as p
                                            left join discount as ds on p.DiscountId = ds.Id 
                                            left join company as c on p.companyId = c.Id  where p.id = @id");

//            MyCommand = MyCommandBuilder(@"select p.id, p.name, ds.Persentage as discount from product as p 
//                                           left join discount as ds on p.discountId = ds.Id where p.id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);


            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                //Id = Convert.ToInt32(MyReader["id"]);
                //Name = MyReader["name"].ToString();
                Code = MyReader["code"].ToString();
                //GroupId = Convert.ToInt32(MyReader["groupId"]);
                //PowerId = Convert.ToInt32(MyReader["powerId"]);
                CompanyId = Convert.ToInt32(MyReader["companyId"]);
                //CategoryId = Convert.ToInt32(MyReader["categoryId"]);
                //UnitId = Convert.ToInt32(MyReader["unitId"]);
                DiscountId = Convert.ToInt32(MyReader["discountId"]);
                //SaleStatusId = Convert.ToInt32(MyReader["saleStatusId"]);
                ListPrice = Convert.ToDouble(MyReader["listPrice"]);
                Vat = Convert.ToDouble(MyReader["vat"]);
                //Remarks = MyReader["remarks"].ToString();
                _discount = MyReader["discount"].ToString();
                _rate = MyReader["rate"].ToString();
                //_code = MyReader["code"].ToString();
                _vat = MyReader["vat"].ToString();
                _company = MyReader["company"].ToString();
                
                return true;
            }
            return false;
        }

        public System.Data.DataSet Select(string extra ="")
        {
            MyCommand = MyCommandBuilder(@"select p.id, p.name, p.code, gr.name as [group], pr.name as power, 
                                        cp.name as company, ctg.name as category, u.primaryQty as unit, 
                                        ds.persentage as discount, st.name as saleStatus, p.listPrice,
                                        p.vat, p.remarks from product as p 
                                        left join [group] as gr on p.groupId = gr.id 
                                        left join power as pr on p.powerId = pr.id 
                                        left join company as cp on p.companyId = cp.id 
                                        left join category as ctg on p.categoryId = ctg.id
                                        left join unit as u on p.unitId = u.id
                                        left join discount as ds on p.discountId = ds.id
                                        left join saleStatus as st on p.saleStatusId = st.id where p.id > 0");

            if (Name != "")
            {
                MyCommand.CommandText += " and p.name like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Name + "%");
            }
            if (GroupId > 0)
            {
                MyCommand.CommandText += " and p.groupId = @groupId";
                MyCommand.Parameters.AddWithValue("@groupId", GroupId);
            }
            if (PowerId > 0)
            {
                MyCommand.CommandText += " and p.powerId = @powerId";
                MyCommand.Parameters.AddWithValue("@powerId", PowerId);
            }
            if (CompanyId > 0)
            {
                MyCommand.CommandText += " and p.companyId = @companyId";
                MyCommand.Parameters.AddWithValue("@companyId", CompanyId);
            }
            if (CategoryId > 0)
            {
                MyCommand.CommandText += " and p.categoryId = @categoryId";
                MyCommand.Parameters.AddWithValue("@categoryId", CategoryId);
            }
            if (UnitId > 0)
            {
                MyCommand.CommandText += " and p.unitId = @unitId";
                MyCommand.Parameters.AddWithValue("@unitId", UnitId);
            }
            if (DiscountId > 0)
            {
                MyCommand.CommandText += " and p.discountId = @discountId";
                MyCommand.Parameters.AddWithValue("@discountId", DiscountId);
            }
            if (SaleStatusId > 0)
            {
                MyCommand.CommandText += " and p.saleStatusId = @saleStatusId";
                MyCommand.Parameters.AddWithValue("@saleStatusId", SaleStatusId);
            }

            MyCommand.CommandText += extra;

            return ExecuteDataSet(MyCommand);
        }
    }
}
