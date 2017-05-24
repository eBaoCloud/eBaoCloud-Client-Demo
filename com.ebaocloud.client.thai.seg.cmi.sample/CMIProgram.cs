using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
{
    class CMIProgram
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.LoginAction();

            Calculate calculate = new Calculate();
            calculate.CalculateAction();

            Issue issue = new Issue();
            issue.IssueAction();


            DownloadSample downloadSample = new DownloadSample();
            downloadSample.Download();

            Console.ReadKey();
        }
    }
}
