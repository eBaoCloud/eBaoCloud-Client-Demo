using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud vmi client namespace
using com.ebaocloud.client.thai.seg.vmi.api;
using com.ebaocloud.client.thai.seg.vmi.response;
using com.ebaocloud.client.thai.seg.vmi.parameters;


namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Calculate
    {
        /// <summary>
        ///  Calculate policy premium
        /// </summary>
        public void CalculateAction()
        {
            PolicyService service = new PolicyServiceImpl();
            // Login request
            // You should record the TOKEN after login in order to call the other APIs.
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            // Prepare request parameters.
            var calculationParams = new CalculationParams();

            // Required properties
            calculationParams.effectiveDate = DateTime.Now.ToLocalTime();
            calculationParams.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            calculationParams.proposalDate = DateTime.Now.ToLocalTime();
            calculationParams.planCode = "SCDG";
            calculationParams.productCode = "VMI";
            calculationParams.vehicleGarageType = VehicleGarageType.DEALER;
            calculationParams.vehicleMakeName = "TOYOTA";
            calculationParams.vehicleModelName = "COROLLA";
            calculationParams.vehicleModelDescription = "TOYO20160104";
            calculationParams.vehicleModelYear = 2016;
            calculationParams.vehicleRegistrationYear = 2016;
            calculationParams.vehicleUsage = VehicleUsage.PRIVATE;
            // Optional properties
            calculationParams.vehicleAccessaryValue = 1000;

            // Invoke service method to get result.
            CalculationResp calcResp = service.Calculate(resp.token, calculationParams);

            if (calcResp.success)
            {
                Console.WriteLine(calcResp);
            }
            else
            {
                Console.WriteLine("Calculate succcess: false" + "\nMessage:" + calcResp.errorMessage);
            }
        }
    }
}
