using System;

// using ebaoCloud cmi client namespace
using com.ebaocloud.client.thai.seg.cmi.api;
using com.ebaocloud.client.thai.seg.cmi.parameters;
using com.ebaocloud.client.thai.seg.cmi.response;


namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class Login
    {
        public static string sampleUserName = "TIB_01";
        public static string samplePassword = "Seg@1234";
        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImpl();
            LoginResp resp = service.Login("SEG_TIB_01", "eBao1234");
            if (resp.success)
            {
                Console.WriteLine("Login Success: true \nToken:" + resp.token);
            } else
            {
                Console.WriteLine("Login Success: false");
            }
        }
    }
}
