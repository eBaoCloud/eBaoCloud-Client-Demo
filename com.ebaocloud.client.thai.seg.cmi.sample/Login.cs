using System;

// using ebaoCloud cmi client namespace
using com.ebaocloud.client.thai.seg.cmi.api;
using com.ebaocloud.client.thai.seg.cmi.parameters;
using com.ebaocloud.client.thai.seg.cmi.response;


namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class Login
    {
        public static string sampleUserName = "SEG_TIB_01";
        public static string samplePassword = "eBao1234";
        public void LoginAction()
        {
            PolicyService service = new PolicyServiceImpl();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);
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
