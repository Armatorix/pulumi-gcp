// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Inputs
{

    public sealed class TableViewGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A query that BigQuery executes when the view is referenced.
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        /// <summary>
        /// Specifies whether to use BigQuery's legacy SQL for this view.
        /// The default value is true. If set to false, the view will use BigQuery's standard SQL.
        /// </summary>
        [Input("useLegacySql")]
        public Input<bool>? UseLegacySql { get; set; }

        public TableViewGetArgs()
        {
        }
    }
}
