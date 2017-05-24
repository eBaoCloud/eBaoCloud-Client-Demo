using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud vmi client namespace
using com.ebaocloud.client.thai.seg.vmi.api;
using com.ebaocloud.client.thai.seg.vmi.response;
using com.ebaocloud.client.thai.seg.vmi.parameters;
using System.IO;
namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class DownloadSample
    {
        public void Download()
        {
            PolicyService service = new PolicyServiceImpl();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            Issue issue = new Issue();
            String policyNo =issue.IssueAction();
            service.DownloadPolicyForms(resp.token, policyNo, new DirectoryInfo("C:/OutputFiles"));
        }
    }
}
