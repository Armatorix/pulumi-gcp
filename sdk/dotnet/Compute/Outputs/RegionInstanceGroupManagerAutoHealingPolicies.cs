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
    public sealed class RegionInstanceGroupManagerAutoHealingPolicies
    {
        /// <summary>
        /// The health check resource that signals autohealing.
        /// </summary>
        public readonly string HealthCheck;
        /// <summary>
        /// The number of seconds that the managed instance group waits before
        /// it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
        /// </summary>
        public readonly int InitialDelaySec;

        [OutputConstructor]
        private RegionInstanceGroupManagerAutoHealingPolicies(
            string healthCheck,

            int initialDelaySec)
        {
            HealthCheck = healthCheck;
            InitialDelaySec = initialDelaySec;
        }
    }
}
