// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class ResourcePolicySnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeekArgs : Pulumi.ResourceArgs
    {
        [Input("day", required: true)]
        public Input<string> Day { get; set; } = null!;

        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public ResourcePolicySnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeekArgs()
        {
        }
    }
}
