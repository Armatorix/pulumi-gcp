// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Outputs
{

    [OutputType]
    public sealed class GetClusterMaintenancePolicyResult
    {
        public readonly ImmutableArray<Outputs.GetClusterMaintenancePolicyDailyMaintenanceWindowResult> DailyMaintenanceWindows;
        public readonly ImmutableArray<Outputs.GetClusterMaintenancePolicyRecurringWindowResult> RecurringWindows;

        [OutputConstructor]
        private GetClusterMaintenancePolicyResult(
            ImmutableArray<Outputs.GetClusterMaintenancePolicyDailyMaintenanceWindowResult> dailyMaintenanceWindows,

            ImmutableArray<Outputs.GetClusterMaintenancePolicyRecurringWindowResult> recurringWindows)
        {
            DailyMaintenanceWindows = dailyMaintenanceWindows;
            RecurringWindows = recurringWindows;
        }
    }
}
