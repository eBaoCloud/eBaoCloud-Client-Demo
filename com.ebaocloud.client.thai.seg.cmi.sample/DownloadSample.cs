using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebaocloud.client.thai.seg.cmi.api;
using com.ebaocloud.client.thai.seg.cmi.parameters;
using com.ebaocloud.client.thai.seg.cmi.response;

using System.IO;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class DownloadSample
    {
        public void Download()
        {
            PolicyService service = new PolicyServiceImpl();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            // issue policy before download documents
            Issue issue = new Issue();
            String policyNo = issue.IssueAction();
            service.DownloadPolicyForms(resp.token, policyNo, new DirectoryInfo("./"));
        }
    }
}
