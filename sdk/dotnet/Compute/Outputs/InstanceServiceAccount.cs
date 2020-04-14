// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class InstanceServiceAccount
    {
        /// <summary>
        /// The service account e-mail address. If not given, the
        /// default Google Compute Engine service account is used.
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        public readonly string? Email;
        /// <summary>
        /// A list of service scopes. Both OAuth2 URLs and gcloud
        /// short names are supported. To allow full access to all Cloud APIs, use the
        /// `cloud-platform` scope. See a complete list of scopes [here](https://cloud.google.com/sdk/gcloud/reference/alpha/compute/instances/set-scopes#--scopes).
        /// **Note**: `allow_stopping_for_update` must be set to true or your instance must have a `desired_status` of `TERMINATED` in order to update this field.
        /// </summary>
        public readonly ImmutableArray<string> Scopes;

        [OutputConstructor]
        private InstanceServiceAccount(
            string? email,

            ImmutableArray<string> scopes)
        {
            Email = email;
            Scopes = scopes;
        }
    }
}
