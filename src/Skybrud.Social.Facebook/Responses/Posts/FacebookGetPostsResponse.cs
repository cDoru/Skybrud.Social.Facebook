using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing a response of a call to get a collection of Facebook posts.
    /// </summary>
    public class FacebookGetPostsResponse : FacebookResponse<FacebookPostsCollection> {

        #region Constructors

        private FacebookGetPostsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetPostsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public static FacebookGetPostsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPostsResponse(response);
        }

        #endregion

    }

}