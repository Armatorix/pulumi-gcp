// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Projects.Outputs
{

    [OutputType]
    public sealed class OrganizationPolicyListPolicyDeny
    {
        /// <summary>
        /// The policy allows or denies all values.
        /// </summary>
        public readonly bool? All;
        /// <summary>
        /// The policy can define specific values that are allowed or denied.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private OrganizationPolicyListPolicyDeny(
            bool? all,

            ImmutableArray<string> values)
        {
            All = all;
            Values = values;
        }
    }
}
