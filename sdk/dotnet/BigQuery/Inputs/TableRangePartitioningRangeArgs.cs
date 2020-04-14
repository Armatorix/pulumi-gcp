// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Inputs
{

    public sealed class TableRangePartitioningRangeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// End of the range partitioning, exclusive.
        /// </summary>
        [Input("end", required: true)]
        public Input<int> End { get; set; } = null!;

        /// <summary>
        /// The width of each range within the partition.
        /// </summary>
        [Input("interval", required: true)]
        public Input<int> Interval { get; set; } = null!;

        /// <summary>
        /// Start of the range partitioning, inclusive.
        /// </summary>
        [Input("start", required: true)]
        public Input<int> Start { get; set; } = null!;

        public TableRangePartitioningRangeArgs()
        {
        }
    }
}
