﻿using System.Net.Http;
using System.Threading.Tasks;
using Oddity.API.Models.Launchpad;
using Oddity.Helpers;

namespace Oddity.API.Builders.Launchpads
{
    /// <summary>
    /// Represents a set of methods to filter launchpad information and download them from API.
    /// </summary>
    public class LaunchpadBuilder : BuilderBase<LaunchpadInfo>
    {
        private LaunchpadId? _launchpadType;
        private const string RocketInfoEndpoint = "launchpads";

        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchpadBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="builderDelegatesContainer">The builder delegates container.</param>
        public LaunchpadBuilder(HttpClient httpClient, BuilderDelegatesContainer builderDelegatesContainer) : base(httpClient, builderDelegatesContainer)
        {

        }

        /// <summary>
        /// Filters launchpad information by the specified launchpad type. Note that you have to call <see cref="BuilderBase{TReturn}.Execute"/> or
        /// <see cref="BuilderBase{TReturn}.ExecuteAsync"/> to get result from the API. Every next call of this method will override previously saved launchpad type filter.
        /// </summary>
        /// <param name="type">The launchpad type (CcafsLc13, Stls, etc).</param>
        /// <returns>The launchpad builder.</returns>
        public LaunchpadBuilder WithType(LaunchpadId type)
        {
            _launchpadType = type;
            return this;
        }

        /// <inheritdoc />
        protected override async Task<LaunchpadInfo> ExecuteBuilder()
        {
            var link = BuildLink(RocketInfoEndpoint);
            if (_launchpadType.HasValue)
            {
                var launchpadName = _launchpadType.GetEnumMemberAttributeValue(_launchpadType);
                link += $"/{launchpadName.ToLower()}";
            }

            return await SendRequestToApi(link).ConfigureAwait(false);
        }
    }
}
