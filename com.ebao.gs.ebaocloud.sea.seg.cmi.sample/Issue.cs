using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using ebaoCloud cmi client namespace
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.api;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.parameters;
using com.ebao.gs.ebaocloud.sea.seg.cmi.client.response;

namespace com.ebao.gs.ebaocloud.sea.seg.cmi.sample
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
            doc.file = new System.IO.FileInfo("./Main.cs");
            documents.Add(doc);
            policyParam.documents = documents;
            policyParam.effectiveDate = DateTime.Now.ToLocalTime();
            policyParam.expireDate = DateTime.Now.AddYears(1).ToLocalTime();
            policyParam.proposalDate = DateTime.Now.ToLocalTime();
            policyParam.productCode = "CMI";
            policyParam.productVersion = "v1";
            policyParam.isPayerSameAsPolicyholder = true;

            policyParam.insured = new Insured();
            policyParam.insured.vehicleChassisNo = "CN098313113234265";
            policyParam.insured.vehicleType = VehicleType.Sedan;
            policyParam.insured.vehicleSubType = VehicleSubType.Car_Seat_up_to_7_people;
            policyParam.insured.vehicleColor = "white";
            policyParam.insured.vehicleCountry = "THA";
            policyParam.insured.vehicleModelDescription = "Sedan 4dr G  6sp FWD 2.5 2016";
            policyParam.insured.vehicleMakeName = "TOYOTA";
            policyParam.insured.vehicleProvince = "THA";
            policyParam.insured.vehicleRegistrationNo = "CN11116932424232552F";
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
            policyParam.payer.name = "Jacky Cheng";

            policyParam.indiPolicyholder = new IndividualPolicyholder();
            policyParam.indiPolicyholder.idNo = "123456";
            policyParam.indiPolicyholder.idType = "1";
            policyParam.indiPolicyholder.inThaiAddress = new InThaiAddress();
            policyParam.indiPolicyholder.inThaiAddress.district = "1001";
            policyParam.indiPolicyholder.inThaiAddress.postalCode = "10200";
            policyParam.indiPolicyholder.inThaiAddress.province = "10";
            policyParam.indiPolicyholder.inThaiAddress.street = "songhu rd.";
            policyParam.indiPolicyholder.inThaiAddress.subDistrict = "100101";
            policyParam.indiPolicyholder.lastName = "Cheng";
            policyParam.indiPolicyholder.firstName = "Jacky";
            policyParam.indiPolicyholder.mobile = "1234999";
            policyParam.indiPolicyholder.taxNo = "10000";
            policyParam.indiPolicyholder.title = IndividualPrefix.Khun;

            IssuedResp issueResp = service.Issue(resp.token, policyParam);
             if (issueResp.success)
            {
                Console.WriteLine("Issued succcess: true" + "\nPolicyNo:" + issueResp.policyNo);
            } else
            {
                Console.WriteLine("Issued succcess: false" + "\nMessage:" + issueResp.message);
            }
        }
    }
}
