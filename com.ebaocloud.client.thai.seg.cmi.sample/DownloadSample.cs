using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebaocloud.client.thai.seg.cmi.api;
using com.ebaocloud.client.thai.seg.cmi.parameters;
using com.ebaocloud.client.thai.seg.cmi.response;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class DownloadSample
    {
        public void Download()
        {
            PolicyService service = new PolicyServiceImpl();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            
            service.Download(resp.token, "", "./");            
        }
    }
}
