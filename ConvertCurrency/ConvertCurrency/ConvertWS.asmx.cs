using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ConvertCurrency
{
    /// <summary>

    /// Web service này dùng chuyển đổi ngoại tệ từ tiền Việt sang USD,

    /// Euro và ngược lại

    /// </summary>

    [WebService(Namespace = "http://tempuri.org/&#8221")]

    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

    [ToolboxItem(false)]

    public class ConvertWS : System.Web.Services.WebService
    {

        private const double USD_RATE = 22255;

        private const double EUR_RATE = 24299;

        [WebMethod]

        public double VND2USD(double dong)
        {

            return dong / USD_RATE;

        }

        [WebMethod]

        public double VND2EUR(double dong)
        {

            return dong / EUR_RATE;

        }

        [WebMethod]

        public double USD2VND(double usd)
        {

            return usd * USD_RATE;

        }

        [WebMethod]

        public double EUR2VND(double eur)
        {

            return eur * EUR_RATE;

        }

    }
}
