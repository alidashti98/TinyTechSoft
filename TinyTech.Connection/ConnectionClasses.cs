using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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

        #region ConvertNumbers
        public string ConvertNumberToString(string Number, bool Moneysymbol = false)
        {
            string Result = string.Empty;
            string Symbol = string.Empty;
            var currencyList = GetCurrency(true).FirstOrDefault(i => i.IsDefault);
            if (Moneysymbol && currencyList.Name.Count() > 0)
            {
                Symbol = currencyList.Name;
            }
            else
            {
                Symbol = string.Empty;
            }

            try
            {
                Result = $"{CEWorld.Convert.NumberToWord.PersianConvertNumberToWord(decimal.Parse(Number).ToString())} {Symbol}";
                return Result;
            }
            catch
            {
                Result = "طول عدد وارد شده بيش از حد مجاز است";
                return Result;
            }
        }
        #endregion

        #region FiscalYearList

        public List<FiscalYear> GetFiscalYear(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();

                if (Active)
                {
                    return DB_Connection.FiscalYear.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.FiscalYear.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException.ToString().Contains("0x80131904"))
                {
                    throw;
                    //MessageBox.Show("خطا در ارتباط با پايگاه داده\n\nلطفا وضعيت سرويس هاي پايگاه داده و نام سرور را بررسي كنيد","GetFiscalYear Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                }
                else
                {
                    MessageBox.Show($"GetFiscalYear\n\n{ex.InnerException}");
                }
                return null;
            }
        }

        #endregion

        #region PathList

        public List<Path> GetPath(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.Path.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.Path.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankAccountTypeList

        public List<BankAccountType> GetBankAccountType(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.BankAccountType.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.BankAccountType.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region RegionList

        public List<Region> GetRegion(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.Region.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.Region.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region ProvinceList

        public List<Province> GetProvince(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.Province.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.Province.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region CityList

        public List<City> GetCity(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.City.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.City.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"GetCity\n\n{ex.Message}");
                return null;
            }
        }

        #endregion

        #region PeopleGroupList
        public List<PeopleGroup> GetPeopleGroup(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.PeopleGroup.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.PeopleGroup.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region GoodsUnitList

        public List<GoodsUnit> GetGoodsUnit(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.GoodsUnit.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.GoodsUnit.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankNameList

        public List<BankName> GetBankName(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.BankName.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.BankName.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region GoodsGroupList

        public List<GoodsGroup> GetGoodsGroup(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.GoodsGroup.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.GoodsGroup.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
        }

        #endregion

        #region BankAccountList

        public class BankAccountList
        {
            public int ID { get; set; }
            public string AccountNumber { get; set; }
            public string AccountOwner { get; set; }
            public int BankNameID { get; set; }
            public string Description { get; set; }
            public bool Active { get; set; }
            public decimal Balance { get; set; }
            public string CLientDate { get; set; }
            public string ServerDate { get; set; }
            public string CLientTime { get; set; }
            public string ServerTime { get; set; }
            public int UserID { get; set; }
            public string Address { get; set; }
            public string Branch { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }
            public int AccountTypeID { get; set; }
            public string BankNameName { get; set; }
            public string AccountTypeName { get; set; }

            public BankAccountList()
            {

            }
        }

        public List<BankAccountList> GetBankAccount(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    var bankAccountList = (from i in DB_Connection.BankAccount.AsNoTracking().Where(i => i.Active).ToList()
                                           select new BankAccountList
                                           {
                                               ID = i.ID,
                                               AccountNumber = i.AccountNumber,
                                               AccountOwner = i.AccountOwner,
                                               BankNameID = i.BankNameID,
                                               Description = i.Description,
                                               Active = i.Active,
                                               Balance = i.Balance,
                                               CLientDate = i.ClientDate,
                                               ServerDate = i.ServerDate,
                                               CLientTime = i.ClientTime,
                                               ServerTime = i.ServerTime,
                                               UserID = i.UserID,
                                               Address = i.Address,
                                               Branch = i.Branch,
                                               Phone1 = i.Phone1,
                                               Phone2 = i.Phone2,
                                               AccountTypeID = i.AccountTypeID,
                                               BankNameName = i.BankName.Name,
                                               AccountTypeName = i.BankAccountType.Name,

                                           }).Distinct().ToList();

                    return bankAccountList;
                }
                else
                {
                    var bankAccountList = (from i in DB_Connection.BankAccount.AsNoTracking().ToList()
                                           select new BankAccountList
                                           {
                                               ID = i.ID,
                                               AccountNumber = i.AccountNumber,
                                               AccountOwner = i.AccountOwner,
                                               BankNameID = i.BankNameID,
                                               Description = i.Description,
                                               Active = i.Active,
                                               Balance = i.Balance,
                                               CLientDate = i.ClientDate,
                                               ServerDate = i.ServerDate,
                                               CLientTime = i.ClientTime,
                                               ServerTime = i.ServerTime,
                                               UserID = i.UserID,
                                               Address = i.Address,
                                               Branch = i.Branch,
                                               Phone1 = i.Phone1,
                                               Phone2 = i.Phone2,
                                               AccountTypeID = i.AccountTypeID,
                                               BankNameName = i.BankName.Name,
                                               AccountTypeName = i.BankAccountType.Name,

                                           }).Distinct().ToList();

                    return bankAccountList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BankAccount Error\n\n" + ex.Message);
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

        //#region PeopleActivityList
        //public class PeopleActivityList
        //{
        //    public int ID { get; set; }
        //    public int PeopleID { get; set; }
        //    public string Description { get; set; }
        //    public bool Active { get; set; }
        //    public string ClientDate { get; set; }
        //    public string ServerDate { get; set; }
        //    public string ClientTime { get; set; }
        //    public string ServerTime { get; set; }
        //    public int UserID { get; set; }
        //    public decimal Debtor { get; set; }
        //    public decimal Creditor { get; set; }

        //    public PeopleActivityList()
        //    {

        //    }
        //}

        //public List<PeopleActivity> GetPeopleActivity()
        //{
        //    try
        //    {
        //        DB_Connection = new TinyTechEntities();
        //        var PeopleActivity = (from i in DB_Connection.PeopleActivity.AsNoTracking().ToList()
        //                                select new PeopleActivity
        //                                {
        //                                    ID = i.ID,
        //                                    PeopleID = i.PeopleID,
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

        //        return PeopleActivity;
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
        public List<User> GetUserInfo(int userId, bool Active = false)
        {
            DB_Connection = new TinyTechEntities();

            try
            {
                if (Active)
                {
                    return userId > 0
                        ? DB_Connection.User.AsNoTracking().Where(i => i.ID == userId).ToList()
                        : DB_Connection.User.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return userId > 0
                        ? DB_Connection.User.AsNoTracking().Where(i => i.ID == userId).ToList()
                        : DB_Connection.User.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
            }

            return null;
        }
        #endregion

        #region ‍CurrencyList

        public List<Currency> GetCurrency(bool Active = false)
        {
            try
            {
                DB_Connection = new TinyTechEntities();
                if (Active)
                {
                    return DB_Connection.Currency.AsNoTracking().Where(i => i.Active).ToList();
                }
                else
                {
                    return DB_Connection.Currency.AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.ToString());
                return null;
            }
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
                return result.ToString().Substring(0, 8);
            }
        }

        public int CheckLoginInfo(string username, string password) //Correct UserName And Password => 0 , Invalid UserName => 1 , Invalid Password => 2
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

        public int GoodsGroupDefinition(string name, bool canNegative, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID, bool isParrent = false, int parrentID = 0) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.GoodsGroup.Add(goodsGroup);
                            dbConnection.BulkSaveChanges();
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

        public int GoodsUnitDefinition(string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID
                            };
                            dbConnection.GoodsUnit.Add(goodsUnit);

                            dbConnection.BulkSaveChanges();
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

                            dbConnection.BulkSaveChanges();
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

        public bool BankNameModify(int ID, string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID)
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
                                ID = ID,
                                Name = name,
                                Description = description,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.BankName.AddOrUpdateExtension(bankName);
                            dbConnection.BulkSaveChanges();
                            dbTran.Commit();
                            return true;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return false;
            }
        }

        public bool BankNameDelete(int ID, string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID)
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
                                ID = ID,
                                Name = name,
                                Description = description,
                                Active = false,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.BankName.AddOrUpdateExtension(bankName);
                            dbConnection.BulkSaveChanges();
                            dbTran.Commit();
                            return true;
                        }
                        catch (Exception e)
                        {
                            dbTran.Rollback();
                            MessageBox.Show(e.InnerException?.ToString());
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException?.ToString());
                return false;
            }
        }

        public int PeopleGroupDefinition(string name, int defaultSailPrice, string description, int parrentID, string clientDate, string serverDate, string clientTime, string serverTime, int userID, bool isParrent = false) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var PeopleGroup = new PeopleGroup()
                            {
                                Name = name,
                                DefaultSailPrice = defaultSailPrice,
                                Description = description,
                                Active = true,
                                IsParrent = isParrent,
                                ParrentID = parrentID,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID
                            };
                            dbConnection.PeopleGroup.Add(PeopleGroup);

                            dbConnection.BulkSaveChanges();
                            dbTran.Commit();
                            return PeopleGroup.ID;
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

        public int ProvinceDefinition(string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };

                            var city = new City()
                            {
                                Name = $"شهر پيش فرض",
                                ProvinceID = province.ID,
                                Description = $"شهر پيش فرض در استان {name}",
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };

                            var region = new Region()
                            {
                                Name = $"منطقه پيش فرض",
                                CityID = city.ID,
                                Description = $"منطقه پيش فرض در استان {name} »»» شهر پيش فرض",
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };

                            var path = new Path()
                            {
                                Name = $"مسير پيش فرض",
                                RegionID = region.ID,
                                Description = $"مسير پيش فرض در استان {name} »»» شهر پيش فرض »»» مسير پيش فرض",
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID
                            };

                            dbConnection.Province.Add(province);
                            dbConnection.City.Add(city);
                            dbConnection.Region.Add(region);
                            dbConnection.Path.Add(path);

                            dbConnection.BulkSaveChanges();
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

        public int BankAccountDefinition(string bankAccountNumber, string bankAccountOwner, int bankNameID, string description, decimal debt, decimal crediting, string clientDate, string serverDate, string clientTime, string serverTime, int userID, string address, string branch, string phone1, string phone2, int accountTypeID) //Save Error => 0
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
                                AccountOwner = bankAccountOwner,
                                BankNameID = bankNameID,
                                Description = description,
                                Active = true,
                                Balance = debt - crediting,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                                Address = address,
                                Branch = branch,
                                Phone1 = phone1,
                                Phone2 = phone2,
                                AccountTypeID = accountTypeID,
                            };
                            dbConnection.BankAccount.Add(bankAccount);

                            dbConnection.BulkSaveChanges();
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

        public int BankAccountTypeDefinition(string name, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            var bankAccountType = new BankAccountType()
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
                            dbConnection.BankAccountType.Add(bankAccountType);

                            dbConnection.BulkSaveChanges();
                            dbTran.Commit();
                            return bankAccountType.ID;
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

        public int CityDefinition(string name, int provinceId, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.City.Add(city);

                            dbConnection.BulkSaveChanges();
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

        public int RegionDefinition(string name, int cityId, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.Region.Add(region);

                            dbConnection.BulkSaveChanges();
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

        public int PathDefinition(string name, int regionId, string description, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
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
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID
                            };
                            dbConnection.Path.Add(path);

                            dbConnection.BulkSaveChanges();
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

        public int CurrencyDefinition(string name, string description, bool isDefault, string clientDate, string serverDate, string clientTime, string serverTime, int userID) //Save Error => 0
        {
            try
            {
                using (var dbConnection = new TinyTechEntities())
                {
                    using (var dbTran = dbConnection.Database.BeginTransaction())
                    {
                        try
                        {
                            if (isDefault)
                            {
                                var crList =
            from cr in DB_Connection.Currency
            where cr.IsDefault
            select cr;

                                foreach (Currency cr in crList)
                                {
                                    cr.IsDefault = false;
                                }
                                DB_Connection.BulkSaveChanges();
                            }

                            var currency = new Currency()
                            {
                                Name = name,
                                Description = description,
                                IsDefault = isDefault,
                                Active = true,
                                ClientDate = clientDate,
                                ServerDate = serverDate,
                                ClientTime = clientTime,
                                ServerTime = serverTime,
                                UserID = userID,
                            };
                            dbConnection.Currency.Add(currency);

                            dbConnection.BulkSaveChanges();
                            dbTran.Commit();
                            return currency.ID;
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

        public static bool CheckBeforeDelete(string FormName, int ID)
        {
            return true;
        }

        public static bool CheckUserPermission(int UserID, int FieldID)
        {
            return true;
        }

        #endregion

    }
}