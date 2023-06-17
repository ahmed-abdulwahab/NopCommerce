using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System.Threading.Tasks;
using System;
using Microsoft.PowerPlatform.Dataverse.Client;
using System.Linq;

namespace Nop.Web.Areas.CRM
{
    public class CrmService:ICrmService
    {
        private readonly string _clientId = "23047e6f-c359-4cb3-8dcd-4f08373fead5";
        private readonly string _clientSecret = "pyH8Q~fLdAZzp5S9LI46W-Ab9eSZxWl7pZHbnaay";
        private readonly string _crmUrl = "https://tllinterviews.crm4.dynamics.com/";

        public async Task<Guid?> GetContactIdByEmailAsync(string email)
        {
            var connectionString = $@"Url={_crmUrl};AuthType=ClientSecret;ClientId={_clientId};ClientSecret={_clientSecret}";
            var client = new ServiceClient(connectionString);
            var query = new QueryExpression("contact");
            query.Criteria.AddCondition("emailaddress1", ConditionOperator.Equal, email);
            query.ColumnSet = new ColumnSet("contactid");
            var result = await client.RetrieveMultipleAsync(query);
            return result.Entities.FirstOrDefault()?.Id;
        }

        public async Task<Guid> CreateContactAsync(string firstName, string lastName, string email)
        {
            var connectionString = $@"Url={_crmUrl};AuthType=ClientSecret;ClientId={_clientId};ClientSecret={_clientSecret}";
            var client = new ServiceClient(connectionString);
            var contact = new Entity("contact");
            contact["firstname"] = firstName;
            contact["lastname"] = lastName;
            contact["emailaddress1"] = email;
            return await client.CreateAsync(contact);
        }



    }
}
