using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;

namespace PlataformaRPHD.Infrastructure.Data
{
    /// <summary>
    /// Represents an object with objectclass=user from active directory
    /// </summary>
    [DirectoryRdnPrefix("ULSM")]
    [DirectoryObjectClass("person")]
    public class ActiveDirectoryUser : UserPrincipal
    {
        public ActiveDirectoryUser(PrincipalContext context) : base(context)
        {
        }

        public static new ActiveDirectoryUser FindByIdentity(PrincipalContext context, string identityValue)
        {
            return (ActiveDirectoryUser)FindByIdentityWithType(context, typeof(ActiveDirectoryUser), identityValue);
        }

        public static new ActiveDirectoryUser FindByIdentity(PrincipalContext context, IdentityType identityType, string identityValue)
        {
            return (ActiveDirectoryUser)FindByIdentityWithType(context, typeof(ActiveDirectoryUser), identityType, identityValue);
        }
    }
}
