// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Organizations.Inputs
{

    public sealed class PolicyRestorePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// May only be set to true. If set, then the default Policy is restored.
        /// </summary>
        [Input("default", required: true)]
        public Input<bool> Default { get; set; } = null!;

        public PolicyRestorePolicyArgs()
        {
        }
    }
}
