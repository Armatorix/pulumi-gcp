// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Inputs
{

    public sealed class TableTimePartitioningGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of milliseconds for which to keep the
        /// storage for a partition.
        /// </summary>
        [Input("expirationMs")]
        public Input<int>? ExpirationMs { get; set; }

        /// <summary>
        /// The field used to determine how to create a range-based
        /// partition.
        /// </summary>
        [Input("field")]
        public Input<string>? Field { get; set; }

        /// <summary>
        /// If set to true, queries over this table
        /// require a partition filter that can be used for partition elimination to be
        /// specified.
        /// </summary>
        [Input("requirePartitionFilter")]
        public Input<bool>? RequirePartitionFilter { get; set; }

        /// <summary>
        /// The only type supported is DAY, which will generate
        /// one partition per day based on data loading time.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public TableTimePartitioningGetArgs()
        {
        }
    }
}
