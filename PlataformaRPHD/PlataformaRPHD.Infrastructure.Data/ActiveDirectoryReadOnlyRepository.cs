using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace PlataformaRPHD.Infrastructure.Data
{
    /// <summary>
    /// Read only repository to query Active Directory user data
    /// </summary>
    public class ActiveDirectoryReadOnlyRepository
    {
        private readonly string domainName;
        private readonly string username;
        private readonly string password;
        private readonly PrincipalContext principalContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryReadOnlyRepository"/> class with default values.
        /// </summary>
        public ActiveDirectoryReadOnlyRepository()
        {
            
            this.password = ConfigurationManager.AppSettings["passwordAD"];
            this.username = ConfigurationManager.AppSettings["usernameAD"];
            this.domainName = ConfigurationManager.AppSettings["Domain"];
            this.principalContext = new PrincipalContext(ContextType.Domain, domainName, username, password);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryReadOnlyRepository"/> class.
        /// </summary>
        /// <param name="domainName">The domain connection string.</param>
        /// <param name="username">The domain user username.</param>
        /// <param name="password">The domain user password.</param>
        public ActiveDirectoryReadOnlyRepository(string domainName, string username, string password)
        {
            this.domainName = domainName;
            this.username = username;
            this.password = password;

            this.principalContext = new PrincipalContext(ContextType.Domain, domainName, username, password);
        }

        /// <summary>
        /// Gets an user with the supplied Sam Account Name
        /// </summary>
        /// <param name="samaccountname">samaccountname</param>
        /// <returns></returns>
        public ActiveDirectoryUser GetUser(string samaccountname)
        {
            ActiveDirectoryUser user = ActiveDirectoryUser.FindByIdentity(principalContext, samaccountname);

            return user;

        }

        /// <summary>
        /// Gets an user with the supplied Sam Account Name
        /// </summary>
        /// <param name="samaccountname">samaccountname</param>
        /// /// <param name="identityType">samaccountname</param>
        /// <returns></returns>
        public ActiveDirectoryUser GetUser(string samaccountname, IdentityType identityType)
        {
            ActiveDirectoryUser user = ActiveDirectoryUser.FindByIdentity(principalContext, identityType, samaccountname);

            return user;

        }

        /// <summary>
        /// Gets and user with the supplied distinguished name
        /// </summary>
        /// <param name="distinguishedName">distinguished name</param>
        /// <returns></returns>
        public ActiveDirectoryUser GetUserByDistinguishedName(string distinguishedName)
        {
            ActiveDirectoryUser user = ActiveDirectoryUser.FindByIdentity(principalContext, IdentityType.DistinguishedName, distinguishedName);

            return user;

        }

        public bool ValidateCredentials(string username, string password, ContextOptions options)
        {
            return this.principalContext.ValidateCredentials(username, password, options);
        }

        /* TODO:Verificar estes metodos de pesquisa de utilizadores

                /// <summary>
                /// Returns a list of users that match the seachevalue, with contains.
                /// </summary>
                /// <param name="type">The type.</param>
                /// <param name="searchValue">The search value.</param>
                /// <returns></returns>
                public IReadOnlyCollection<ActiveDirectoryUser> GetUsers(SearchTypes type, string searchValue)
                {
                    using (DirectoryEntry entry = new DirectoryEntry("LDAP://mch.moc.sgps/dc=mch,dc=moc,dc=sgps", this.username, this.password))
                    {
                        var searcher = new DirectorySearcher(entry);

                        searcher.PropertiesToLoad.Add("distinguishedname");

                        SearchResultCollection searchresultcollection;

                        string propertyToSearchBy = "";

                        switch (type)
                        {
                            case SearchTypes.Mail:
                                propertyToSearchBy = "mail";
                                break;
                            case SearchTypes.Manager:
                                propertyToSearchBy = "manager";
                                break;
                            case SearchTypes.DistinguishedName:
                                propertyToSearchBy = "distinguishedname";
                                break;
                            case SearchTypes.DisplayName:
                                propertyToSearchBy = "displayname";
                                break;
                        }

                        searcher.Filter = ("(&(objectClass=user)(" + propertyToSearchBy + "=" + searchValue + "*))");
                        searchresultcollection = searcher.FindAll();

                        var result = new List<ActiveDirectoryUser>();

                        foreach (SearchResult searchresult in searchresultcollection)
                        {
                            string sam = searchresult.Properties["distinguishedname"][0].ToString();
                            ActiveDirectoryUser user = this.GetUser(sam, IdentityType.DistinguishedName);

                            if (user.Enabled.HasValue && user.Enabled.Value)
                            {
                                result.Add(user);
                            }
                        }


                        return result;
                    }

                }

                /// <summary>
                /// Returns a list of users that match the seachevalue, with contains.
                /// </summary>
                /// <param name="type">The type.</param>
                /// <param name="searchValue">The search value.</param>
                /// <returns></returns>
                public IReadOnlyCollection<ActiveDirectoryUser> GetUsersByEntry(SearchTypes type, string searchValue)
                {
                    using (DirectoryEntry entry = new DirectoryEntry("LDAP://PESTI.DOM", this.username, this.password))
                    {
                        var searcher = new DirectorySearcher(entry);

                        searcher.PropertiesToLoad.Add("distinguishedname");

                        SearchResultCollection searchresultcollection;

                        searcher.Filter = ("(&(objectClass=user)(|(" + "samaccountname" + "=" + searchValue + "*)(" + "displayname" + "=" + searchValue + "*)(" + "mail" + "=" + searchValue + "*))(!userAccountControl:1.2.840.113556.1.4.803:=2))");
                        searchresultcollection = searcher.FindAll();

                        var result = new List<ActiveDirectoryUser>();

                        foreach (SearchResult searchresult in searchresultcollection)
                        {
                            string sam = searchresult.Properties["distinguishedname"][0].ToString();
                            ActiveDirectoryUser user = this.GetUser(sam, IdentityType.DistinguishedName);

                            if (user.Enabled.HasValue && user.Enabled.Value)
                            {
                                result.Add(user);
                            }
                        }


                        return result;
                    }
                }
                /// <summary>
                /// Returns a list of users that match the seachevalue, with contains.
                /// </summary>
                /// <param name="type">The type.</param>
                /// <param name="searchValue">The search value.</param>
                /// <returns></returns>
                public IReadOnlyCollection<ActiveDirectoryUser> GetUsers(string searchValue)
                {
                    using (DirectoryEntry entry = new DirectoryEntry("LDAP://mch.moc.sgps/dc=mch,dc=moc,dc=sgps", this.username, this.password))
                    {
                        var searcher = new DirectorySearcher(entry);

                        searcher.PropertiesToLoad.Add("distinguishedname");

                        SearchResultCollection searchresultcollection;

                        searcher.Filter = ("(&(objectClass=user)(|(" + "samaccountname" + "=" + searchValue + "*)(" + "displayname" + "=" + searchValue + "*)(" + "mail" + "=" + searchValue + "*)))");
                        searchresultcollection = searcher.FindAll();

                        var result = new List<ActiveDirectoryUser>();

                        foreach (SearchResult searchresult in searchresultcollection)
                        {
                            string sam = searchresult.Properties["distinguishedname"][0].ToString();
                            ActiveDirectoryUser user = this.GetUser(sam, IdentityType.DistinguishedName);

                            if (user.Enabled.HasValue && user.Enabled.Value)
                            {
                                result.Add(user);
                            }
                        }

                        return result;
                    }

                }

                private IReadOnlyCollection<string> Find(SearchTypes type, string searchValue)
                {
                    using (DirectoryEntry entry = new DirectoryEntry("LDAP://mch.moc.sgps/dc=mch,dc=moc,dc=sgps", this.username, this.password))
                    {
                        DirectorySearcher searcher = new DirectorySearcher(entry);

                        searcher.PropertiesToLoad.Add("samaccountname");

                        SearchResultCollection searchresultcollection;

                        string propertyToSearchBy = "";

                        switch (type)
                        {
                            case SearchTypes.Mail:
                                propertyToSearchBy = "mail";
                                break;
                            case SearchTypes.Manager:
                                propertyToSearchBy = "manager";
                                break;
                            case SearchTypes.DistinguishedName:
                                propertyToSearchBy = "distinguishedname";
                                break;
                            case SearchTypes.DisplayName:
                                propertyToSearchBy = "displayname";
                                break;
                        }

                        searcher.Filter = ("(&(objectClass=user)( " + propertyToSearchBy + "=" + searchValue + "))");
                        searchresultcollection = searcher.FindAll();

                        List<string> result = new List<string>();

                        foreach (SearchResult searchresult in searchresultcollection)
                        {
                            result.Add(searchresult.Properties["samaccountname"][0].ToString());
                        }


                        return result;
                    }

                }

            */
    }
}
