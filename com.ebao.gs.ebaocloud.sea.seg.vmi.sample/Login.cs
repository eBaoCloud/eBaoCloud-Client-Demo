using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.api;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.response;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Login
    {
        public static string sampleUserName = "SEG_TIB_01";
        public static string samplePassword = "eBao1234";

        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImplement();

            LoginResp resp = service.Login(sampleUserName, samplePassword);
            Console.WriteLine(resp);
        }
    }
}
