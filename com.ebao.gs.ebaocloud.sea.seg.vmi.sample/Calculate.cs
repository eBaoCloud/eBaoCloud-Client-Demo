using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.api;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.response;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Calculate
    {
        /// <summary>
        ///  calculate policy premium
        /// </summary>
        public void CalculateAction()
        {
            PolicyService service = new PolicyServiceImplement();
            // Login request
            // You should record the TOKEN after login in order to call the other APIs.
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            // Prepare request parameters.
            var calculationParams = new CalculationParams();

            // Maa
            calculationParams.effectiveDate = DateTime.Now.ToLocalTime();
            calculationParams.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            calculationParams.proposalDate = DateTime.Now.ToLocalTime();
            calculationParams.planCode = "TIB";
            calculationParams.productCode = "VMI";
            calculationParams.vehicleAccessaryValue = 1000;
            calculationParams.vehicleGarageType = VehicleGarageType.GARAGE;
            calculationParams.vehicleMakeName = "TOYOTA";
            calculationParams.vehicleModelDescription = "Sedan 4dr G  6sp FWD 2.5 2016";
            calculationParams.vehicleModelYear = 2016;
            calculationParams.vehicleRegistrationYear = 2016;
            calculationParams.vehicleUsage = VehicleUsage.PRIVATE;

            // Invoke service method to get result.
            CalculationResp calcResp = service.Calculate(resp.token, calculationParams);

            Console.WriteLine(calculationParams);
            Console.WriteLine(calcResp);
        }
    }
}
