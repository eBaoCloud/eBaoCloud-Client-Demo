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
    public class Issue
    {
        public void IssueAction()
        {
            PolicyService service = new PolicyServiceImplement();
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            Policy policyParam = new Policy();
            List<Document> documents = new List<Document>();
            Document doc = new Document();
            doc.category = DocumentCategory.DRIVING_LICENSE;
            doc.name = "test";
            doc.file = new System.IO.FileInfo("./Main.txt");
            documents.Add(doc);
            policyParam.documents = documents;
            policyParam.effectiveDate = DateTime.Now.ToLocalTime();
            policyParam.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            policyParam.proposalDate = DateTime.Now.ToLocalTime();
            policyParam.productCode = "VMI";
            policyParam.planCode = "TIB";
            policyParam.productVersion = "v1";
            policyParam.isPayerSameAsPolicyholder = true;

            policyParam.insured = new Insured();
            policyParam.insured.vehicleChassisNo = "CN011111244425fff3451";
            policyParam.insured.vehicleColor = "white";
            policyParam.insured.vehicleCountry = "THA";
            policyParam.insured.vehicleModelDescription = "Sedan 4dr G  6sp FWD 2.5 2016";
            policyParam.insured.vehicleGarageType = VehicleGarageType.GARAGE;
            policyParam.insured.vehicleMakeName = "TOYOTA";
            policyParam.insured.vehicleProvince = "THA";
            policyParam.insured.vehicleRegistrationNo = "CN06667724424442fff345F";
            policyParam.insured.vehicleRegistrationYear = 2016;
            policyParam.insured.vehicleUsage = VehicleUsage.PRIVATE;
            policyParam.insured.vehicleModelYear = 2016;

            policyParam.payer = new Payer();
            policyParam.payer.inThaiAddress = new InThaiAddress();
            policyParam.payer.inThaiAddress.district = "1001";
            policyParam.payer.inThaiAddress.postalCode = "10200";
            policyParam.payer.inThaiAddress.province = "10";
            policyParam.payer.inThaiAddress.street = "songhu rd.";
            policyParam.payer.inThaiAddress.subDistrict = "100101";
            policyParam.payer.name = "leon luo";

            policyParam.indiPolicyholder = new IndividualPolicyholder();
            policyParam.indiPolicyholder.idNo = "123456";
            policyParam.indiPolicyholder.idType = "1";
            policyParam.indiPolicyholder.inThaiAddress = new InThaiAddress();
            policyParam.indiPolicyholder.inThaiAddress.district = "1001";
            policyParam.indiPolicyholder.inThaiAddress.postalCode = "10200";
            policyParam.indiPolicyholder.inThaiAddress.province = "10";
            policyParam.indiPolicyholder.inThaiAddress.street = "songhu rd.";
            policyParam.indiPolicyholder.inThaiAddress.subDistrict = "100101";
            policyParam.indiPolicyholder.lastName = "luo";
            policyParam.indiPolicyholder.firstName = "leon";
            policyParam.indiPolicyholder.mobile = "1234999";
            policyParam.indiPolicyholder.taxNo = "10000";
            policyParam.indiPolicyholder.title = IndividualPrefix.Khun;

            policyParam.drivers = new List<Driver>(1);
            Driver driver = new Driver();
            policyParam.drivers.Add(driver);
            driver.birthday = DateTime.Now;
            driver.firstName = "leon";
            driver.lastName = "luo";
            driver.occupation = "1233333";

            Console.WriteLine(policyParam);

            IssuedResp issuedResp = service.Issue(resp.token, policyParam);
            Console.WriteLine(issuedResp);
        }
    }
}
