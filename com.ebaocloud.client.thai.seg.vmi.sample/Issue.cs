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
    public class Issue
    {
        /// <summary>
        /// Issue Policy
        /// </summary>
        public String IssueAction()
        {
            PolicyService service = new PolicyServiceImpl();
            // Login request
            // You should record the TOKEN after login in order to call the other APIs. 
            LoginResp resp = service.Login(Login.sampleUserName, Login.samplePassword);

            Policy policyParam = new Policy();

            // Document(List) Upload
            List<Document> documents = new List<Document>();
            Document doc = new Document();
            doc.documentType = "2";
            doc.name = "test";
            doc.file = new System.IO.FileInfo("../../UploadSample.txt");
            documents.Add(doc);
            policyParam.documents = documents;

            policyParam.effectiveDate = DateTime.Now.ToLocalTime();
            policyParam.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            policyParam.proposalDate = DateTime.Now.ToLocalTime();
            policyParam.productCode = "VMI";
            policyParam.planCode = "SCGG";
            //policyParam.productVersion = "v1";
            // isPayerSameAsPolicyholder 
            // category - true / false
            // if yes, the payer address will be consistance with policyHolder.
            policyParam.isPayerSameAsPolicyholder = true;

            String randomStr = new Random(DateTime.Now.Millisecond).Next().ToString();
            policyParam.insured = new Insured();
            policyParam.insured.vehicleChassisNo = "CN" + randomStr;
            policyParam.insured.vehicleColor = "white";
            policyParam.insured.vehicleCountry = "THA";
            policyParam.insured.vehicleModelDescription = "TOYO20160104";
            policyParam.insured.vehicleRegistrationNo = "CN" + randomStr;
            policyParam.insured.vehicleMakeName = "TOYOTA";
            policyParam.insured.vehicleProvince = "THA";
            policyParam.insured.vehicleModelName = "COROLLA";
            policyParam.insured.vehicleRegistrationYear = 2016;
            policyParam.insured.vehicleModelYear = 2016;

            MasterDataService masterDataService = new MasterDataServiceImpl();
            List<KeyValue> garageTypes = masterDataService.GetVehicleGarageType();
            List<KeyValue> vehicleType = masterDataService.GetVehicleType();
            List<KeyValue> usages = masterDataService.GetVehicleUsage(vehicleType[0].key);
            policyParam.insured.vehicleUsage = usages[0].key;
            policyParam.insured.vehicleGarageType = garageTypes[0].key;

            policyParam.payer = new Payer();
            // Address
            // Category - InThaiAddress / OutThaiAddress
            policyParam.payer.inThaiAddress = new InThaiAddress();
            policyParam.payer.inThaiAddress.district = "1001";
            policyParam.payer.inThaiAddress.postalCode = "10200";
            policyParam.payer.inThaiAddress.province = "10";
            policyParam.payer.inThaiAddress.street = "songhu rd.";
            policyParam.payer.inThaiAddress.subDistrict = "100101";
            policyParam.payer.name = "leon luo";

            // PolicyHolder 
            // Category - IndiPolicyholder / OrgPolicyHolder
            // For Example: policyParam.orgPolicyhodler = new OrganizationPolicyholder();
            policyParam.indiPolicyholder = new IndividualPolicyholder();
            policyParam.indiPolicyholder.idNo = "123456";
            policyParam.indiPolicyholder.idType = "1";
            policyParam.indiPolicyholder.inThaiAddress = new InThaiAddress();
            policyParam.indiPolicyholder.inThaiAddress.fullAddress = "24 (318 เดิม) ซ.อุดมสุข30 แยก2 ถ.อุดมสุข แขวงบางนา เขตบางนา กทม. 10260";
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

            // Driver List
            policyParam.drivers = new List<Driver>(1);
            Driver driver = new Driver();
            policyParam.drivers.Add(driver);
            driver.birthday = DateTime.Now;
            driver.firstName = "leon";
            driver.lastName = "luo";
            driver.occupation = "1233333";

            // Invoke service method to get issue result.
            // Response
            // Success true / false
            // errorMessage
            // policyNo 
            IssuedResp issuedResp = service.Issue(resp.token, policyParam);
            Console.WriteLine(issuedResp);

            return issuedResp.policyNo;
        }
    }
}
