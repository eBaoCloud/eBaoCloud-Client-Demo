using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud vmi client namespace
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.api;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.response;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
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
