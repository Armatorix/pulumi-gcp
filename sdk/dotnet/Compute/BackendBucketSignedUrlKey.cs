// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// A key for signing Cloud CDN signed URLs for BackendBuckets.
    /// 
    /// 
    /// To get more information about BackendBucketSignedUrlKey, see:
    /// 
    /// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/backendBuckets)
    /// * How-to Guides
    ///     * [Using Signed URLs](https://cloud.google.com/cdn/docs/using-signed-urls/)
    /// </summary>
    public partial class BackendBucketSignedUrlKey : Pulumi.CustomResource
    {
        /// <summary>
        /// The backend bucket this signed URL key belongs.
        /// </summary>
        [Output("backendBucket")]
        public Output<string> BackendBucket { get; private set; } = null!;

        /// <summary>
        /// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
        /// </summary>
        [Output("keyValue")]
        public Output<string> KeyValue { get; private set; } = null!;

        /// <summary>
        /// Name of the signed URL key.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;


        /// <summary>
        /// Create a BackendBucketSignedUrlKey resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BackendBucketSignedUrlKey(string name, BackendBucketSignedUrlKeyArgs args, CustomResourceOptions? options = null)
            : base("gcp:compute/backendBucketSignedUrlKey:BackendBucketSignedUrlKey", name, args ?? new BackendBucketSignedUrlKeyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BackendBucketSignedUrlKey(string name, Input<string> id, BackendBucketSignedUrlKeyState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/backendBucketSignedUrlKey:BackendBucketSignedUrlKey", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing BackendBucketSignedUrlKey resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BackendBucketSignedUrlKey Get(string name, Input<string> id, BackendBucketSignedUrlKeyState? state = null, CustomResourceOptions? options = null)
        {
            return new BackendBucketSignedUrlKey(name, id, state, options);
        }
    }

    public sealed class BackendBucketSignedUrlKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The backend bucket this signed URL key belongs.
        /// </summary>
        [Input("backendBucket", required: true)]
        public Input<string> BackendBucket { get; set; } = null!;

        /// <summary>
        /// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
        /// </summary>
        [Input("keyValue", required: true)]
        public Input<string> KeyValue { get; set; } = null!;

        /// <summary>
        /// Name of the signed URL key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public BackendBucketSignedUrlKeyArgs()
        {
        }
    }

    public sealed class BackendBucketSignedUrlKeyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The backend bucket this signed URL key belongs.
        /// </summary>
        [Input("backendBucket")]
        public Input<string>? BackendBucket { get; set; }

        /// <summary>
        /// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
        /// </summary>
        [Input("keyValue")]
        public Input<string>? KeyValue { get; set; }

        /// <summary>
        /// Name of the signed URL key.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public BackendBucketSignedUrlKeyState()
        {
        }
    }
}
