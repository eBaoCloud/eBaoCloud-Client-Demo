using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.api;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.response;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Login
    {
        public static string sampleUserName = "SEG_TIB_01";
        public static string samplePassword = "eBao1234";

        /// <summary>
        /// Sign in to eBaoCloud
        /// </summary>
        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImplement();
            // Response
            // succcess true / false
            // token - In order to calculate premium or issue a policy, you must hold this property.
            LoginResp resp = service.Login(sampleUserName, samplePassword);
            Console.WriteLine(resp);
        }
    }
}
