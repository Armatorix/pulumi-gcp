// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class RegionInstanceGroupManagerVersionTargetSizeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// , The number of instances which are managed for this version. Conflicts with `percent`.
        /// </summary>
        [Input("fixed")]
        public Input<int>? Fixed { get; set; }

        /// <summary>
        /// , The number of instances (calculated as percentage) which are managed for this version. Conflicts with `fixed`.
        /// Note that when using `percent`, rounding will be in favor of explicitly set `target_size` values; a managed instance group with 2 instances and 2 `version`s,
        /// one of which has a `target_size.percent` of `60` will create 2 instances of that `version`.
        /// </summary>
        [Input("percent")]
        public Input<int>? Percent { get; set; }

        public RegionInstanceGroupManagerVersionTargetSizeArgs()
        {
        }
    }
}
