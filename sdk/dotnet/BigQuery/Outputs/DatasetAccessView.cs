// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Outputs
{

    [OutputType]
    public sealed class DatasetAccessView
    {
        public readonly string DatasetId;
        public readonly string ProjectId;
        public readonly string TableId;

        [OutputConstructor]
        private DatasetAccessView(
            string datasetId,

            string projectId,

            string tableId)
        {
            DatasetId = datasetId;
            ProjectId = projectId;
            TableId = tableId;
        }
    }
}
