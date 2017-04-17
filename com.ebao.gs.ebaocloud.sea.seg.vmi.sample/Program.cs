using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Login login = new Login();
            login.LoginAction();

            Calculate calculate = new Calculate();
            calculate.CalculateAction();

            Issue issue = new Issue();
            issue.IssueAction();
            

            Console.ReadKey();
        }

    }
}
