using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDU.CMS2.DataModels;

namespace TDU.CMS2.DataBase
{
    public partial class CMSDbContext : System.Data.Entity.DbContext
    {
        //public CMSDbContext() : base(CreateConnection(), true) { } 
        public CMSDbContext() : base("TDUCMSConnectionString") { }
        public CMSDbContext(string connectionString) : base(connectionString) { }
        public CMSDbContext(DbConnection dbConnection) : base(dbConnection, true) { }
        
        public DbSet<CardRequest> CardRequests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ChangeLog> ChangeLogs { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CardInfo> CardInfos { get; set; }


        static DbConnection CreateConnection()
        {
            //var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            var connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "NSERVER2K8",
                InitialCatalog = "TDUCMS2",
                UserID = "sa",
                Password = "sasasa@123456"
            };
            connection.ConnectionString = connectionStringBuilder.ConnectionString;
            //MessageBox.Show(connection.ConnectionString);
            return connection;}
    }
}
