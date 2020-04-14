// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql.Inputs
{

    public sealed class DatabaseInstanceSettingsIpConfigurationAuthorizedNetworkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// formatted date time string indicating when this whitelist expires.
        /// </summary>
        [Input("expirationTime")]
        public Input<string>? ExpirationTime { get; set; }

        /// <summary>
        /// A name for this whitelist entry.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A CIDR notation IPv4 or IPv6 address that is allowed to
        /// access this instance. Must be set even if other two attributes are not for
        /// the whitelist to become active.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public DatabaseInstanceSettingsIpConfigurationAuthorizedNetworkArgs()
        {
        }
    }
}
