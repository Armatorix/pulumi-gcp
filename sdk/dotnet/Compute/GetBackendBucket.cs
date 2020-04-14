// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    public static class GetBackendBucket
    {
        /// <summary>
        /// Get information about a BackendBucket.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBackendBucketResult> InvokeAsync(GetBackendBucketArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBackendBucketResult>("gcp:compute/getBackendBucket:getBackendBucket", args ?? new GetBackendBucketArgs(), options.WithVersion());
    }


    public sealed class GetBackendBucketArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public string? Project { get; set; }

        public GetBackendBucketArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBackendBucketResult
    {
        /// <summary>
        /// Cloud Storage bucket name.
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// Cloud CDN configuration for this Backend Bucket. Structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBackendBucketCdnPolicyResult> CdnPolicies;
        /// <summary>
        /// Creation timestamp in RFC3339 text format.
        /// </summary>
        public readonly string CreationTimestamp;
        /// <summary>
        /// An optional textual description of the resource; provided by the client when the resource is created.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Whether Cloud CDN is enabled for this BackendBucket.
        /// </summary>
        public readonly bool EnableCdn;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string? Project;
        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        public readonly string SelfLink;

        [OutputConstructor]
        private GetBackendBucketResult(
            string bucketName,

            ImmutableArray<Outputs.GetBackendBucketCdnPolicyResult> cdnPolicies,

            string creationTimestamp,

            string description,

            bool enableCdn,

            string id,

            string name,

            string? project,

            string selfLink)
        {
            BucketName = bucketName;
            CdnPolicies = cdnPolicies;
            CreationTimestamp = creationTimestamp;
            Description = description;
            EnableCdn = enableCdn;
            Id = id;
            Name = name;
            Project = project;
            SelfLink = selfLink;
        }
    }
}
