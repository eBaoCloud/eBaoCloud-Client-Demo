using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.api;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.response;
using com.ebao.gs.ebaocloud.sea.seg.client.vmi.parameters;

namespace com.ebao.gs.ebaocloud.sea.seg.vmi.sample
{
    public class Calculate
    {
        public void CalculateAction()
        {
            PolicyService service = new PolicyServiceImplement();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            var calculationParams = new CalculationParams();
            calculationParams.effectiveDate = DateTime.Now.ToLocalTime();
            calculationParams.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            calculationParams.proposalDate = DateTime.Now.ToLocalTime();

            calculationParams.planCode = "TIB";
            calculationParams.productCode = "VMI";
            //calculationParams.productVersion = "v1";
            calculationParams.vehicleAccessaryValue = 1000;
            //calculationParams.vehicleCapacity = 0;
            // calculationParams.vehicleClass = "";
            //calculationParams.vehicleCode = "110";
            calculationParams.vehicleGarageType = VehicleGarageType.GARAGE;
            // calculationParams.vehicleGroup = "";
            calculationParams.vehicleMakeName = "TOYOTA";
            //calculationParams.vehicleMarketValue = 1569000;
            calculationParams.vehicleModelDescription = "Sedan 4dr G  6sp FWD 2.5 2016";
            // calculationParams.vehicleModelDescription = "";
            calculationParams.vehicleModelYear = 2016;
            //calculationParams.vehicleNumOfSeats = 5;
            calculationParams.vehicleRegistrationYear = 2016;
            calculationParams.vehicleUsage = VehicleUsage.PRIVATE;
            //calculationParams.vehicleTonnage = 1;
            //calculationParams.vehicleTotalValue = 200000;
            Console.WriteLine(calculationParams);
            CalculationResp calcResp = service.Calculate(resp.token, calculationParams);
            Console.WriteLine(calcResp);
        }
    }
}
