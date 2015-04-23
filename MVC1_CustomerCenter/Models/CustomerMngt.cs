using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1_CustomerCenter.Models
{
    public class CustomerMngt
    {
        CustomerEntities db = new CustomerEntities();

        /// <summary>
        /// 同一個客戶下的聯絡人，其 Email 不能重複
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Boolean checkCustomerMailAddressExisted(客戶聯絡人 customerInfo)
        {

                var result = db.客戶聯絡人.Where(q => q.Email == customerInfo.Email.Trim() && q.客戶Id== customerInfo.客戶Id);

                if (result.Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}