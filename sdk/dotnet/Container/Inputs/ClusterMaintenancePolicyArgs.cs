// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterMaintenancePolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time window specified for daily maintenance operations.
        /// Specify `start_time` in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) format "HH:MM”,
        /// where HH : \[00-23\] and MM : \[00-59\] GMT. For example:
        /// </summary>
        [Input("dailyMaintenanceWindow")]
        public Input<Inputs.ClusterMaintenancePolicyDailyMaintenanceWindowArgs>? DailyMaintenanceWindow { get; set; }

        /// <summary>
        /// Time window for
        /// recurring maintenance operations.
        /// </summary>
        [Input("recurringWindow")]
        public Input<Inputs.ClusterMaintenancePolicyRecurringWindowArgs>? RecurringWindow { get; set; }

        public ClusterMaintenancePolicyArgs()
        {
        }
    }
}
