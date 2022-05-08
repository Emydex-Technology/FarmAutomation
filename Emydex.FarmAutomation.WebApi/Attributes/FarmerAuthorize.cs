using Microsoft.AspNetCore.Authorization;

namespace Emydex.FarmAutomation.WebApi.Attributes
{
    /// <summary>
    /// Attribute to rest access to certain endpoints to only authorised user (farmers) in this case
    /// </summary>
    public class FarmerAuthorize : AuthorizeAttribute
    {

        
    }
}