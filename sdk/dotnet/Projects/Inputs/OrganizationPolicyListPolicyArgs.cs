// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Projects.Inputs
{

    public sealed class OrganizationPolicyListPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("allow")]
        public Input<Inputs.OrganizationPolicyListPolicyAllowArgs>? Allow { get; set; }

        [Input("deny")]
        public Input<Inputs.OrganizationPolicyListPolicyDenyArgs>? Deny { get; set; }

        /// <summary>
        /// If set to true, the values from the effective Policy of the parent resource
        /// are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.
        /// </summary>
        [Input("inheritFromParent")]
        public Input<bool>? InheritFromParent { get; set; }

        /// <summary>
        /// The Google Cloud Console will try to default to a configuration that matches the value specified in this field.
        /// </summary>
        [Input("suggestedValue")]
        public Input<string>? SuggestedValue { get; set; }

        public OrganizationPolicyListPolicyArgs()
        {
        }
    }
}
