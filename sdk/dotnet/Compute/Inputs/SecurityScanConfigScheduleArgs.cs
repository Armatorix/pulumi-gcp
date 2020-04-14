// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class SecurityScanConfigScheduleArgs : Pulumi.ResourceArgs
    {
        [Input("intervalDurationDays", required: true)]
        public Input<int> IntervalDurationDays { get; set; } = null!;

        [Input("scheduleTime")]
        public Input<string>? ScheduleTime { get; set; }

        public SecurityScanConfigScheduleArgs()
        {
        }
    }
}
