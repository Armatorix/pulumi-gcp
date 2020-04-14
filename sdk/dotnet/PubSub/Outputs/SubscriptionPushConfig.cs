// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.PubSub.Outputs
{

    [OutputType]
    public sealed class SubscriptionPushConfig
    {
        public readonly ImmutableDictionary<string, string>? Attributes;
        public readonly Outputs.SubscriptionPushConfigOidcToken? OidcToken;
        public readonly string PushEndpoint;

        [OutputConstructor]
        private SubscriptionPushConfig(
            ImmutableDictionary<string, string>? attributes,

            Outputs.SubscriptionPushConfigOidcToken? oidcToken,

            string pushEndpoint)
        {
            Attributes = attributes;
            OidcToken = oidcToken;
            PushEndpoint = pushEndpoint;
        }
    }
}
