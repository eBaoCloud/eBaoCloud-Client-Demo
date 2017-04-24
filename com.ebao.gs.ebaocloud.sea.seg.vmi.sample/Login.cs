using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud vmi client namespace
using com.ebaocloud.client.thai.seg.vmi.api;
using com.ebaocloud.client.thai.seg.vmi.response;
using com.ebaocloud.client.thai.seg.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Login
    {
        public static string sampleUserName = "TIB_01";
        public static string samplePassword = "Seg@1234";

        /// <summary>
        /// Sign in to eBaoCloud
        /// </summary>
        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImpl();
            // Response
            // succcess true / false
            // token - In order to calculate premium or issue a policy, you must hold this property. 
            // 
            LoginResp resp = service.Login(sampleUserName, samplePassword);
            Console.WriteLine(resp);
        }
    }
}
