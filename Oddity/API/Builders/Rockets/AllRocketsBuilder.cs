﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Oddity.API.Models.Rocket;

namespace Oddity.API.Builders.Rockets
{
    /// <summary>
    /// Represents a set of methods to filter all rockets information and download them from API.
    /// </summary>
    public class AllRocketsBuilder : BuilderBase<List<RocketInfo>>
    {
        private const string RocketInfoEndpoint = "rockets";

        /// <summary>
        /// Initializes a new instance of the <see cref="AllRocketsBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="builderDelegatesContainer">The builder delegates container.</param>
        public AllRocketsBuilder(HttpClient httpClient, BuilderDelegatesContainer builderDelegatesContainer) : base(httpClient, builderDelegatesContainer)
        {

        }

        /// <inheritdoc />
        protected override async Task<List<RocketInfo>> ExecuteBuilder()
        {
            var link = BuildLink(RocketInfoEndpoint);
            return await SendRequestToApi(link).ConfigureAwait(false);
        }
    }
}
