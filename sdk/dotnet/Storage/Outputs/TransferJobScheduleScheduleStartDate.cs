// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Outputs
{

    [OutputType]
    public sealed class TransferJobScheduleScheduleStartDate
    {
        /// <summary>
        /// Day of month. Must be from 1 to 31 and valid for the year and month.
        /// </summary>
        public readonly int Day;
        /// <summary>
        /// Month of year. Must be from 1 to 12.
        /// </summary>
        public readonly int Month;
        /// <summary>
        /// Year of date. Must be from 1 to 9999.
        /// </summary>
        public readonly int Year;

        [OutputConstructor]
        private TransferJobScheduleScheduleStartDate(
            int day,

            int month,

            int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
