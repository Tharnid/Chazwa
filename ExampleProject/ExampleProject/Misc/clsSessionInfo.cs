//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace ExampleProject.Misc
//{
//    public class clsSessionInfo
//    {

//        public const string kSessionInfo = "SessionInfo";
//        public const string kSessionCurrentCompanyId = "CurrentCompanyId";

//        public string UserName { get; set; }
//        public string Email { get; set; }

//        public int TenantId { get; set; }
//        public string TenantName { get; set; }
//        public int CompanyId { get; set; }
//        public string CompanyName { get; set; }
//        public string CountryCode { get; set; }
//        public string CurrencyCode { get; set; }

//        public Dictionary<int, Models.Tenant> Tenants { get; set; }
//        public Dictionary<int, Models.Company> Companies { get; set; }

//        public clsSessionInfo()
//        {
//            this.Tenants = new Dictionary<int, Models.Tenant>();
//            this.Companies = new Dictionary<int, Models.Company>();
//        }


//        public static clsSessionInfo UserSessionInfo
//        {
//            get
//            {
//                clsSessionInfo oRet;
//                oRet = (clsSessionInfo)HttpContext.Current.Session[kSessionInfo];
//                if (oRet == null)
//                {
//                    oRet = new clsSessionInfo();
//                    SetUserSessionInfo(oRet);
//                }
//                return oRet;
//            }
//        }

//        public static void SetUserSessionInfo(clsSessionInfo oInfo)
//        {
//            HttpContext.Current.Session[kSessionInfo] = oInfo;
//        }

//        public string BannerText
//        {
//            get { return UserName + " - " + CompanyName; }
//        }

//        public static void UserSignedInOrOutSetAdditionalInfo(string sUsername)
//        {
//            bool bValid = true;
//            int iFirstCompany = 0;
//            clsSessionInfo oInfo = UserSessionInfo;

//            if (sUsername == "")
//            {
//                bValid = false;
//            }


//            oInfo.Email = "";
//            oInfo.UserName = "";
//            oInfo.TenantId = 0;
//            oInfo.TenantName = "";
//            oInfo.CompanyId = 0;
//            oInfo.Tenants.Clear();
//            oInfo.Companies.Clear();

//            if (bValid == true)
//            {
//                oInfo.UserName = sUsername;


//                Models.ApplicationDbContext oContext = new Models.ApplicationDbContext();

//                var UserQuery = from u in oContext.Users
//                                where u.UserName == sUsername
//                                select u.UserName;
//                foreach (string sUserName in UserQuery)
//                {
//                    // For now, username is email address
//                    oInfo.Email = sUsername;
//                }


//                var PersonQuery = from person in oContext.Person
//                                  join co in oContext.Company on person.CompanyId equals co.CompanyId
//                                  join t in oContext.Tenant on co.TenantId equals t.TenantId
//                                  //select new {PersonId = person.PersonId, CompanyId = co.CompanyId};
//                                  where person.UserName == sUsername
//                                  select new { person, Company = co, Tenant = t };

//                foreach (var result in PersonQuery)
//                {
//                    // If First Tenant we've run into, default to that Tenant/Company
//                    if (oInfo.TenantId == 0)
//                    {
//                        oInfo.TenantId = result.Tenant.TenantId;
//                        oInfo.TenantName = result.Tenant.Name;
//                        iFirstCompany = result.Company.CompanyId;
//                    }

//                    // Add Tenant Information
//                    if (!oInfo.Tenants.ContainsKey(result.Tenant.TenantId))
//                    {
//                        oInfo.Tenants.Add(result.Tenant.TenantId, result.Tenant);
//                    }

//                    // Default to First Live Company
//                    if (oInfo.CompanyId == 0 && result.Company.CompanyTypeCode == Models.Company.kCompanyType.Live)
//                    {
//                        oInfo.CompanyId = result.Company.CompanyId;
//                    }


//                    // Add Company Information
//                    if (!oInfo.Companies.ContainsKey(result.Company.CompanyId))
//                    {
//                        oInfo.Companies.Add(result.Company.CompanyId, result.Company);
//                    }

//                }  // foreach PersonQuery

//                // If no live companies, default to first company loaded
//                if (oInfo.CompanyId == 0 && iFirstCompany != 0) { oInfo.CompanyId = iFirstCompany; }

//                // Get Information from Selected Company
//                oInfo.CompanyName = "";
//                oInfo.CountryCode = "US";
//                oInfo.CurrencyCode = "USD";

//                HttpContext.Current.Session[kSessionCurrentCompanyId] = oInfo.CompanyId;
//                if (oInfo.Companies.ContainsKey(oInfo.CompanyId))
//                {
//                    Models.Company oCompany = oInfo.Companies[oInfo.CompanyId];
//                    oInfo.CompanyName = oCompany.Name;
//                    oInfo.CountryCode = oCompany.CountryCode;
//                    oInfo.CurrencyCode = oCompany.CurrencyCode;
//                }

//            }

//            SetUserSessionInfo(oInfo);

//        }



//    }
//}