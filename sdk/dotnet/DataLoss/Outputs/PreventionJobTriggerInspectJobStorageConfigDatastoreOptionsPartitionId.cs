// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DataLoss.Outputs
{

    [OutputType]
    public sealed class PreventionJobTriggerInspectJobStorageConfigDatastoreOptionsPartitionId
    {
        /// <summary>
        /// If not empty, the ID of the namespace to which the entities belong.
        /// </summary>
        public readonly string? NamespaceId;
        /// <summary>
        /// The Google Cloud Platform project ID of the project containing the table.
        /// </summary>
        public readonly string ProjectId;

        [OutputConstructor]
        private PreventionJobTriggerInspectJobStorageConfigDatastoreOptionsPartitionId(
            string? namespaceId,

            string projectId)
        {
            NamespaceId = namespaceId;
            ProjectId = projectId;
        }
    }
}
