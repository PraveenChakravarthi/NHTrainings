using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PraveenWebService
{
    /// <summary>
    /// Summary description for MathOperations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathOperations : System.Web.Services.WebService
    {

        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;

            return fact;
        }
        [WebMethod]
        public int Mul(int a,  int b)
        {
            return a*b;
        }
        [WebMethod]
        public int Add(int a, int b)
        {
            return a+b ;
        }
        [WebMethod]
        public int Sub(int a, int b)
        {
            return a-b;
        }
    }
}
