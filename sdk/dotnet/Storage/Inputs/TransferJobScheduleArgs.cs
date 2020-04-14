// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Inputs
{

    public sealed class TransferJobScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The last day the recurring transfer will be run. If `schedule_end_date` is the same as `schedule_start_date`, the transfer will be executed only once. Structure documented below.
        /// </summary>
        [Input("scheduleEndDate")]
        public Input<Inputs.TransferJobScheduleScheduleEndDateArgs>? ScheduleEndDate { get; set; }

        /// <summary>
        /// The first day the recurring transfer is scheduled to run. If `schedule_start_date` is in the past, the transfer will run for the first time on the following day. Structure documented below.
        /// </summary>
        [Input("scheduleStartDate", required: true)]
        public Input<Inputs.TransferJobScheduleScheduleStartDateArgs> ScheduleStartDate { get; set; } = null!;

        /// <summary>
        /// The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer's start time in a day is specified in your local timezone. Structure documented below.
        /// </summary>
        [Input("startTimeOfDay")]
        public Input<Inputs.TransferJobScheduleStartTimeOfDayArgs>? StartTimeOfDay { get; set; }

        public TransferJobScheduleArgs()
        {
        }
    }
}
