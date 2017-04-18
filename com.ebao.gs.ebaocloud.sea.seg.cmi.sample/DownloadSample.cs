using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.ebao.gs.ebaocloud.sea.seg.cmi.client.api;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.parameters;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.response;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    public class DownloadSample
    {
        public void Download()
        {
            PolicyService service = new PolicyServiceImplement();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            
            service.Download(resp.token, "", "./");            
        }
    }
}
