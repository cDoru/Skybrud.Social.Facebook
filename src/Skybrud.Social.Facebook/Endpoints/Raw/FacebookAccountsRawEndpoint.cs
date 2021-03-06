﻿using System;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Accounts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {
    
    /// <summary>
    /// Class representing the raw implementation of the accounts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal FacebookAccountsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <code>/me/accounts</code>
        /// method. This call requires a user access token as well as the <code>manage_scope</code>.
        /// </summary>
        /// <returns>The raw JSON response from the API.</returns>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetAccounts() {
            return Client.DoHttpGetRequest("/me/accounts");
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <code>/me/accounts</code>
        /// method. This call requires a user access token as well as the <code>manage_scope</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>The raw JSON response from the API.</returns>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetAccounts(FacebookGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/me/accounts", options);
        }

        #endregion

    }

}