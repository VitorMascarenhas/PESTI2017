using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaRPHD.Infrastructure.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class AdAuthenticationService
    {
        public class AuthenticationResult
        {
            public AuthenticationResult(string errorMessage = null)
            {
                ErrorMessage = errorMessage;
            }

            public String ErrorMessage { get; private set; }
            public Boolean IsSuccess => String.IsNullOrEmpty(ErrorMessage);
        }

        private readonly IAuthenticationManager authenticationManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdAuthenticationService"/> class.
        /// </summary>
        /// <param name="authenticationManager">The authentication manager.</param>
        public AdAuthenticationService(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;

        }

        /// <summary>
        /// Check if username and password matches existing account in AD. 
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidateCredentials(string username, string password)
        {
            string[] tokens = username.Split('\\');

            string user = "";

            if (tokens.Length == 2)
            {
                user = tokens[1];
            }
            else
            {
                user = username;
            }

            var repo = new ActiveDirectoryReadOnlyRepository();

            return repo.ValidateCredentials(user, password, ContextOptions.Negotiate);
        }

        /// <summary>
        /// Adds information to the response environment that will cause the appropriate authentication
        /// middleware to grant a claims-based identity to the recipient of the response.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public AuthenticationResult SignIn(string username, string password)
        {
            // authenticates against your Domain AD
            //ContextType authenticationType = ContextType.Domain;
            bool isAuthenticated = false;
            ActiveDirectoryUser userPrincipal = null;

            string[] tokens = username.Split('\\');

            if (tokens.Length == 2)
            {
                var repo = new ActiveDirectoryReadOnlyRepository(tokens[0], username, password);

                try
                {

                    //isAuthenticated = repo.ValidateCredentials(tokens[1], password, ContextOptions.Negotiate);
                    isAuthenticated = ValidateCredentials(tokens[1], password);
                    if (isAuthenticated)
                    {
                        //userPrincipal = UserPrincipal.FindByIdentity(principalContext, username);
                        userPrincipal = repo.GetUser(tokens[1]);
                    }
                }
                catch (Exception)
                {
                    isAuthenticated = false;
                    userPrincipal = null;
                }
            }
            else
            {
                isAuthenticated = false;
                userPrincipal = null;
            }

            if (!isAuthenticated || userPrincipal == null)
            {
                return new AuthenticationResult("Username or Password is not correct");
            }

            if (userPrincipal.IsAccountLockedOut())
            {
                // here can be a security related discussion weather it is worth 
                // revealing this information
                return new AuthenticationResult("Your account is locked.");
            }

            if (userPrincipal.Enabled.HasValue && userPrincipal.Enabled.Value == false)
            {
                // here can be a security related discussion weather it is worth 
                // revealing this information
                return new AuthenticationResult("Your account is disabled");
            }

            ClaimsIdentity identity = CreateIdentity(userPrincipal);

            authenticationManager.SignOut("ApplicationCookie");
            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = true }, identity);


            return new AuthenticationResult();
        }

        /// <summary>
        /// Adds information to the response environment that will cause the appropriate authentication
        /// middleware to grant a claims-based identity to the recipient of the response.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public AuthenticationResult SignIn(string username)
        {
            // authenticates against your Domain AD
            //ContextType authenticationType = ContextType.Domain;
            bool isAuthenticated = false;
            ActiveDirectoryUser userPrincipal = null;

            string[] tokens = username.Split('\\');

            if (tokens.Length == 2)
            {
                ActiveDirectoryReadOnlyRepository repo = new ActiveDirectoryReadOnlyRepository();

                try
                {
                    //isAuthenticated = principalContext.ValidateCredentials(username, password, ContextOptions.Negotiate);
                    isAuthenticated = true;
                    if (isAuthenticated)
                    {
                        //userPrincipal = UserPrincipal.FindByIdentity(principalContext, username);
                        userPrincipal = repo.GetUser(tokens[1]);
                    }
                }
                catch (Exception)
                {
                    isAuthenticated = false;
                    userPrincipal = null;
                }
            }
            else
            {
                isAuthenticated = false;
                userPrincipal = null;
            }

            if (!isAuthenticated || userPrincipal == null)
            {
                return new AuthenticationResult("Username or Password is not correct");
            }

            if (userPrincipal.IsAccountLockedOut())
            {
                // here can be a security related discussion weather it is worth 
                // revealing this information
                return new AuthenticationResult("Your account is locked.");
            }

            if (userPrincipal.Enabled.HasValue && userPrincipal.Enabled.Value == false)
            {
                // here can be a security related discussion weather it is worth 
                // revealing this information
                return new AuthenticationResult("Your account is disabled");
            }

            ClaimsIdentity identity = CreateIdentity(userPrincipal);

            //authenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            authenticationManager.SignOut("ApplicationCookie");
            authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = true }, identity);


            return new AuthenticationResult();
        }

        /// <summary>
        /// Creates the identity.
        /// </summary>
        /// <param name="samaccountName">Name of the samaccount.</param>
        /// <returns></returns>
        public ClaimsIdentity CreateIdentity(string samaccountName)
        {
            ActiveDirectoryUser userPrincipal = new ActiveDirectoryReadOnlyRepository().GetUser(samaccountName);

            if (userPrincipal != null)
            {
                return CreateIdentity(userPrincipal);
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Creates the identity.
        /// </summary>
        /// <param name="userPrincipal">The user principal.</param>
        /// <returns></returns>
        public ClaimsIdentity CreateIdentity(ActiveDirectoryUser userPrincipal)
        {
            var identity = new ClaimsIdentity("ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "Windows"));
            identity.AddClaim(new Claim(ClaimTypes.Name, userPrincipal.SamAccountName));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userPrincipal.SamAccountName));
            identity.AddClaim(new Claim("DisplayName", userPrincipal.DisplayName));

            if (!string.IsNullOrEmpty(userPrincipal.EmailAddress))
            {
                identity.AddClaim(new Claim(ClaimTypes.Email, userPrincipal.EmailAddress));
            }
            
            //TODO: Ir buscar os roles ao AD
            IList<string> roles = this.GetRoles(userPrincipal);
            foreach (var role in roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return identity;
        }

        public List<string> GetRoles(UserPrincipal user)
        {
            List<string> roles = new List<string>();

            var groups = user.GetGroups();

            if (groups == null)
            {
                return null;
            }

            foreach (var group in groups)
            {
                roles.Add(group.Name);
            }

            return roles;
        }
    }
}
