﻿using System.Net.Http;
using Oddity.API.Builders;
using Oddity.API.Builders.Api;

namespace Oddity.API
{
    /// <summary>
    /// Represents a set of methods to get capsules information.
    /// </summary>
    public class Api
    {
        private readonly HttpClient _httpClient;
        private readonly BuilderDelegatesContainer _builderDelegatesContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Api"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="builderDelegatesContainer">The builder delegates container.</param>
        public Api(HttpClient httpClient, BuilderDelegatesContainer builderDelegatesContainer)
        {
            _httpClient = httpClient;
            _builderDelegatesContainer = builderDelegatesContainer;
        }

        /// <summary>
        /// Gets information about the API.
        /// </summary>
        /// <returns>The API builder.</returns>
        public ApiBuilder GetInfo()
        {
            return new ApiBuilder(_httpClient, _builderDelegatesContainer);
        }
    }
}
