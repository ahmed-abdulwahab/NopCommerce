using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Linq;

namespace Nop.Web.Areas.CRM
{
    public class CrmRegistrationFilter: ActionFilterAttribute
    {
        //private readonly string _clientId = "23047e6f-c359-4cb3-8dcd-4f08373fead5";
        //private readonly string _clientSecret = "pyH8Q~fLdAZzp5S9LI46W-Ab9eSZxWl7pZHbnaay";
        //private readonly string _crmUrl = "https://tllinterviews.crm4.dynamics.com/";
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var connectionString = $@"Url={_crmUrl};AuthType=ClientSecret;ClientId={_clientId};ClientSecret={_clientSecret}";
        //    var client = new ServiceClient(connectionString);
        //    var query = new QueryExpression("contact");
        //    query.Criteria.AddCondition("emailaddress1", ConditionOperator.Equal, email);
        //    query.ColumnSet = new ColumnSet("contactid");
        //    var result =  client.RetrieveMultiple(query);
        //    var point= result.Entities.FirstOrDefault()?.Id;

        //    if (point.HasValue)
        //    {
        //        //Complete to return Error Message...
                
        //    }
        //    else
        //    {

        //        //calling the CreateContactAsync of the CrmServices Class
        //        //Make it Static
        //    }
        //}
    }
}
