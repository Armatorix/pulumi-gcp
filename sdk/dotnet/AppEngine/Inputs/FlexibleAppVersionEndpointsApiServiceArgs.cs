// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class FlexibleAppVersionEndpointsApiServiceArgs : Pulumi.ResourceArgs
    {
        [Input("configId")]
        public Input<string>? ConfigId { get; set; }

        [Input("disableTraceSampling")]
        public Input<bool>? DisableTraceSampling { get; set; }

        /// <summary>
        /// The identifier for this object. Format specified above.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("rolloutStrategy")]
        public Input<string>? RolloutStrategy { get; set; }

        public FlexibleAppVersionEndpointsApiServiceArgs()
        {
        }
    }
}
