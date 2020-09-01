// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterNodePoolNodeConfigKubeletConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, enables CPU CFS quota enforcement for
        /// containers that specify CPU limits.
        /// </summary>
        [Input("cpuCfsQuota")]
        public Input<bool>? CpuCfsQuota { get; set; }

        /// <summary>
        /// The CPU CFS quota period value. Specified
        /// as a sequence of decimal numbers, each with optional fraction and a unit suffix,
        /// such as `"300ms"`. Valid time units are "ns", "us" (or "µs"), "ms", "s", "m",
        /// "h". The value must be a positive duration.
        /// </summary>
        [Input("cpuCfsQuotaPeriod")]
        public Input<string>? CpuCfsQuotaPeriod { get; set; }

        /// <summary>
        /// The CPU management policy on the node. See
        /// [K8S CPU Management Policies](https://kubernetes.io/docs/tasks/administer-cluster/cpu-management-policies/).
        /// One of `"none"` or `"static"`. Defaults to `none` when `kubelet_config` is unset.
        /// </summary>
        [Input("cpuManagerPolicy", required: true)]
        public Input<string> CpuManagerPolicy { get; set; } = null!;

        public ClusterNodePoolNodeConfigKubeletConfigGetArgs()
        {
        }
    }
}
