using NorthwestLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestLab.DAL
{
    public class NorthwestDbContext: DbContext
    {
        public NorthwestDbContext() :base("DefaultConnection")
        {

        }

        public DbSet<AssayResultTypes> AssayResultTypeTable { get; set; }
        public DbSet<Assays> AssayTable { get; set; }
        public DbSet<AssayTestTypes> AssayTestTypeTable { get; set; }
        public DbSet<AssayTypes> AssayTypeTable { get; set; }
        public DbSet<Compensation> CompensationTable { get; set; }
        public DbSet<CompensationTypes> CompensationTypeTable{ get; set; }
        public DbSet<CompoundReceipts> CompoundReceiptTable { get; set; }
        public DbSet<Compounds> CompoundsTable { get; set; }
        public DbSet<ConditionalDependencies> ConditionalDependencyTable { get; set; }
        public DbSet<Customers> CustomerTable { get; set; }
        public DbSet<DependencyTypes> DependencyTypeTable { get; set; }
        public DbSet<Discounts> DicsountTable { get; set; }
        public DbSet<DiscountTypes> DiscountTypeTable { get; set; }
        public DbSet<Employees> EmployeeTable { get; set; }
        public DbSet<Invoices> InvoiceTable { get; set; }
        public DbSet<MaterialTypes> MaterialTypeTable { get; set; }
        public DbSet<PaymentCards> PaymentCardTable { get; set; }
        public DbSet<QualitativeResults> QualitativeResultTable { get; set; }
        public DbSet<QuantitativeFileTypes> QuantitativeFileTypeTable { get; set; }
        public DbSet<QuantitativeResults> QuantitativeResultTable { get; set; }
        public DbSet<Samples> SampleTable { get; set; }
        public DbSet<SampleTubes> SampleTubeTable { get; set; }
        public DbSet<Schedule> ScheduleTable { get; set; }
        public DbSet<State_Province> State_ProvinceTable { get; set; }
        public DbSet<SummaryReports> SummaryReportTable { get; set; }
        public DbSet<TestMaterialTypes> TestMaterialTypeTable { get; set; }
        public DbSet<Tests> TestTable { get; set; }
        public DbSet<TestTimeLog> TestTimeLogTable { get; set; }
        public DbSet<TestTypeMaterials> TestTypeMaterialTable { get; set; }
        public DbSet<TestTypes> TestTypeTable { get; set; }
        public DbSet<Transactions> TransactionTable { get; set; }
        public DbSet<WorkOrders> WorkOrderTable { get; set; }


    }

}