using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.api;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.parameters;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.response;


namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class Login
    {
        public static string sampleUserName = "SEG_TIB_01";
        public static string samplePassword = "eBao1234";
        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImplement();
            LoginResp resp = service.Login("SEG_TIB_01", "eBao1234");
            Console.WriteLine(resp);
        }
    }
}
