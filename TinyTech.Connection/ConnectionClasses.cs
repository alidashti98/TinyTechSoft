using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Encoding = System.Text.Encoding;

namespace TinyTech.Connection
{
    public class ConnectionClasses
    {
        #region Region

        TinyTechEntities DB_Connection = new TinyTechEntities();

        #endregion

        //====================================================================================//

        #region List Classes

        #region FiscalYearList

        public List<FiscalYear> GetFiscalYear()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.FiscalYear.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region PathList

        public List<Path> GetPath()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.Path.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankAccountTypeList

        public List<BankAccountType> GetBankAccountType()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.BankAccountType.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region RegionList

        public List<Region> GetRegion()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.Region.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region ProvinceList

        public List<Province> GetProvince()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.Province.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region CityList

        public List<City> GetCity()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.City.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region CustomerGroupList

        public List<CustomerGroup> GetCustomerGroup()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.CustomerGroup.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region GoodsUnitList

        public List<GoodsUnit> GetGoodsUnit()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.GoodsUnit.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankNameList

        public List<BankName> GetBankName()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.BankName.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region GoodsGroupList

        public List<GoodsGroup> GetGoodsGroup()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.GoodsGroup.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankAccountList

        public List<BankAccount> GetBankAccount()
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                return DB_Connection.BankAccount.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        //#region BankAccountActivityList
        //public class BankAccountActivityList
        //{
        //    public int ID { get; set; }
        //    public int AccountID { get; set; }
        //    public string Description { get; set; }
        //    public bool Active { get; set; }
        //    public string ClientDate { get; set; }
        //    public string ServerDate { get; set; }
        //    public string ClientTime { get; set; }
        //    public string ServerTime { get; set; }
        //    public int UserID { get; set; }
        //    public decimal Debtor { get; set; }
        //    public decimal Creditor { get; set; }

        //    public BankAccountActivityList()
        //    {

        //    }
        //}

        //public List<BankAccountActivity> GetBankAccountActivity()
        //{
        //    try
        //    {
        //        DB_Connection = new TinyTechEntities();
        //        var bankAccountActivity = (from i in DB_Connection.BankAccountActivity.AsNoTracking().ToList()
        //                                   select new BankAccountActivity
        //                                   {
        //                                       ID = i.ID,
        //                                       AccountID = i.AccountID,
        //                                       Active = i.Active,
        //                                       Description = i.Description,
        //                                       ClientDate = i.ClientDate,
        //                                       ServerDate = i.ServerDate,
        //                                       ClientTime = i.ClientTime,
        //                                       ServerTime = i.ServerTime,
        //                                       UserID = i.UserID,
        //                                       Debtor = i.Debtor,
        //                                       Creditor = i.Creditor,

        //                                   }).Distinct().ToList();

        //        return bankAccountActivity;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException?.ToString());
        //        return null;
        //    }
        //}
        //#endregion

        //#region CustomerActivityList
        //public class CustomerActivityList
        //{
        //    public int ID { get; set; }
        //    public int CustomerID { get; set; }
        //    public string Description { get; set; }
        //    public bool Active { get; set; }
        //    public string ClientDate { get; set; }
        //    public string ServerDate { get; set; }
        //    public string ClientTime { get; set; }
        //    public string ServerTime { get; set; }
        //    public int UserID { get; set; }
        //    public decimal Debtor { get; set; }
        //    public decimal Creditor { get; set; }

        //    public CustomerActivityList()
        //    {

        //    }
        //}

        //public List<CustomerActivity> GetCustomerActivity()
        //{
        //    try
        //    {
        //        DB_Connection = new TinyTechEntities();
        //        var customerActivity = (from i in DB_Connection.CustomerActivity.AsNoTracking().ToList()
        //                                select new CustomerActivity
        //                                {
        //                                    ID = i.ID,
        //                                    CustomerID = i.CustomerID,
        //                                    Active = i.Active,
        //                                    Description = i.Description,
        //                                    ClientDate = i.ClientDate,
        //                                    ServerDate = i.ServerDate,
        //                                    ClientTime = i.ClientTime,
        //                                    ServerTime = i.ServerTime,
        //                                    UserID = i.UserID,
        //                                    Debtor = i.Debtor,
        //                                    Creditor = i.Creditor,

        //                                }).Distinct().ToList();

        //        return customerActivity;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException?.ToString());
        //        return null;
        //    }
        //}
        //#endregion

        //#region PersonnelActivityList
        //public class PersonnelActivityList
        //{
        //    public int ID { get; set; }
        //    public int PersonnelID { get; set; }
        //    public string Description { get; set; }
        //    public bool Active { get; set; }
        //    public string ClientDate { get; set; }
        //    public string ServerDate { get; set; }
        //    public string ClientTime { get; set; }
        //    public string ServerTime { get; set; }
        //    public int UserID { get; set; }
        //    public decimal Debtor { get; set; }
        //    public decimal Creditor { get; set; }

        //    public PersonnelActivityList()
        //    {

        //    }
        //}

        //public List<PersonnelActivity> GetPersonnelActivity()
        //{
        //    try
        //    {
        //        DB_Connection = new TinyTechEntities();
        //        var personnelActivity = (from i in DB_Connection.PersonnelActivity.AsNoTracking().ToList()
        //                                 select new PersonnelActivity
        //                                 {
        //                                     ID = i.ID,
        //                                     PersonnelID = i.PersonnelID,
        //                                     Active = i.Active,
        //                                     Description = i.Description,
        //                                     ClientDate = i.ClientDate,
        //                                     ServerDate = i.ServerDate,
        //                                     ClientTime = i.ClientTime,
        //                                     ServerTime = i.ServerTime,
        //                                     UserID = i.UserID,
        //                                     Debtor = i.Debtor,
        //                                     Creditor = i.Creditor,

        //                                 }).Distinct().ToList();

        //        return personnelActivity;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.InnerException?.ToString());
        //        return null;
        //    }
        //}
        //#endregion

        #region UserList
        public List<User> GetUserInfo(int userId)
        {
            DB_Connection = new TinyTechEntities();

            try
            {
                return userId > 0
                    ? DB_Connection.User.AsNoTracking().Where(i => i.ID == userId).ToList()
                    : DB_Connection.User.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
            }

            return null;
        }
        #endregion

        #endregion

        //====================================================================================//

        #region Operating Classes

        public static class DateServer
        {
            public static string ReturnDateServer()
            {
                var serverTime = ServerTime();
                var conn = new SqlConnection { ConnectionString = ConnectionInfo.BuildConnectionStringOld() };
                conn.Open();
                var c1 = new SqlCommand
                {
                    Connection = conn,
                    CommandText = string.Compare(serverTime, "12:00:00.0", StringComparison.Ordinal) > 0
                        ? $"select dbo.[UDF_Gregorian_To_Persian](GETDATE()-1)"
                        : $"select dbo.[UDF_Gregorian_To_Persian](GETDATE())"
                };
                var result = c1.ExecuteScalar();
                conn.Close();
                return result.ToString();
            }

            public static string ReturnDateServer(string diff)
            {
                var serverTime = ServerTime();
                var conn = new SqlConnection { ConnectionString = ConnectionInfo.BuildConnectionStringOld() };
                conn.Open();
                var c1 = new SqlCommand
                {
                    Connection = conn,
                    CommandText = string.Compare(serverTime, "12:00:00.0", StringComparison.Ordinal) > 0
                        ? $"select dbo.[UDF_Gregorian_To_Persian](GETDATE()-{diff}-1)"
                        : $"select dbo.[UDF_Gregorian_To_Persian](GETDATE()-{diff})"
                };
                var result = c1.ExecuteScalar();
                conn.Close();
                return result.ToString();
            }

            public static string ServerTime()
            {
                var conn = new SqlConnection { ConnectionString = ConnectionInfo.BuildConnectionStringOld() };
                conn.Open();
                var c1 = new SqlCommand
                {
                    Connection = conn,
                    CommandText = $"SELECT CONVERT (time, GETDATE())"
                };
                var result = c1.ExecuteScalar();
                conn.Close();
                return result.ToString().Substring(0,8);
            }
        }

        public static string ClientTime()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            var clientTime = $"{DateTime.Now:HH:mm:ss}";
            return clientTime;
        }

        public int CheckLoginInfo(string username,
                string password) //Correct UserName And Password => 0 , Invalid UserName => 1 , Invalid Password => 2
        {
            var userInfo = GetUserInfo(0).FirstOrDefault(i => i.UserName == username);
            if (userInfo == null)
            {
                return 1;
            }

            if (Encoding.UTF8.GetString(userInfo.Password) != password)
            {
                return 2;
            }

            ConnectionInfo.LoggedInUserName = userInfo.UserName;
            ConnectionInfo.LoggedInUserId = userInfo.ID;
            return 0;
        }

        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string CurrentVersion()
        {
            //var fileVersionInfo = FileVersionInfo.GetVersionInfo("TinyTech.Main.exe");
            var version = "0.0.1 beta";//fileVersionInfo.ProductVersion;
            return version;
        }

        public int GoodsGroupDefinition(string name, bool canNegative, string description, string clientDate,
            string serverDate, int userID, bool isParrent = false, int parrentID = 0) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var goodsGroup = new GoodsGroup()
                            {
                                Name = name,
                                CanNegative = canNegative,
                                Description = description,
                                Active = true,
                                IsParrent = isParrent,
                                ParrentID = parrentID,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID,
                            };
                            dbConnection.GoodsGroup.Add(goodsGroup);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return goodsGroup.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int GoodsUnitDefinition(string name, string description, string clientDate, string serverDate,
            int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var goodsUnit = new GoodsUnit()
                            {
                                Name = name,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID
                            };
                            dbConnection.GoodsUnit.Add(goodsUnit);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return goodsUnit.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int BankNameDefinition(string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var bankName = new BankName()
                            {
                                Name = name,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.BankName.Add(bankName);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return bankName.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int CustomerGroupDefinition(string name, int defaultSailPrice, string description, string clientDate,
            string serverDate, int userID, bool isParrent = false, int parrentID = 0) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var customerGroup = new CustomerGroup()
                            {
                                Name = name,
                                DefaultSailPrice = defaultSailPrice,
                                Description = description,
                                Active = true,
                                IsParrent = isParrent,
                                ParrentID = parrentID,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID
                            };
                            dbConnection.CustomerGroup.Add(customerGroup);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return customerGroup.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int ProvinceDefinition(string name, string description, string clientDate, string serverDate,
            int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var province = new Province()
                            {
                                Name = name,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID,
                            };
                            dbConnection.Province.Add(province);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return province.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int BankAccountDefinition(string bankAccountNumber, string description, string clientDate,
            string serverDate, int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var bankAccount = new BankAccount()
                            {
                                AccountNumber = bankAccountNumber,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID,
                            };
                            dbConnection.BankAccount.Add(bankAccount);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return bankAccount.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int CityDefinition(string name, int provinceId, string description, string clientDate, string serverDate,
            int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var city = new City()
                            {
                                Name = name,
                                ProvinceID = provinceId,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID,
                            };
                            dbConnection.City.Add(city);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return city.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int RegionDefinition(string name, int cityId, string description, string clientDate, string serverDate,
            int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var region = new Region()
                            {
                                Name = name,
                                CityID = cityId,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID,
                            };
                            dbConnection.Region.Add(region);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return region.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        public int PathDefinition(string name, int regionId, string description, string clientDate, string serverDate,
            int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var path = new Path()
                            {
                                Name = name,
                                RegionID = regionId,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                UserID = userID
                            };
                            dbConnection.Path.Add(path);

                            dbConnection.SaveChanges();
                            dbTran.Commit();
                            return path.ID;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return 0;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return 0;
            }
        }

        #endregion

    }
}