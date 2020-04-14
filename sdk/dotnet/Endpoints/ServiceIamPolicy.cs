// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Endpoints
{
    /// <summary>
    /// Three different resources help you manage your IAM policy for Service Management Service. Each of these resources serves a different use case:
    /// 
    /// * `gcp.endpoints.ServiceIamPolicy`: Authoritative. Sets the IAM policy for the service and replaces any existing policy already attached.
    /// * `gcp.endpoints.ServiceIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the service are preserved.
    /// * `gcp.endpoints.ServiceIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the service are preserved.
    /// 
    /// &gt; **Note:** `gcp.endpoints.ServiceIamPolicy` **cannot** be used in conjunction with `gcp.endpoints.ServiceIamBinding` and `gcp.endpoints.ServiceIamMember` or they will fight over what your policy should be.
    /// 
    /// &gt; **Note:** `gcp.endpoints.ServiceIamBinding` resources **can be** used in conjunction with `gcp.endpoints.ServiceIamMember` resources **only if** they do not grant privilege to the same role.
    /// </summary>
    public partial class ServiceIamPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// (Computed) The etag of the IAM policy.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Output("policyData")]
        public Output<string> PolicyData { get; private set; } = null!;

        /// <summary>
        /// The name of the service. Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceIamPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceIamPolicy(string name, ServiceIamPolicyArgs args, CustomResourceOptions? options = null)
            : base("gcp:endpoints/serviceIamPolicy:ServiceIamPolicy", name, args ?? new ServiceIamPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceIamPolicy(string name, Input<string> id, ServiceIamPolicyState? state = null, CustomResourceOptions? options = null)
            : base("gcp:endpoints/serviceIamPolicy:ServiceIamPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ServiceIamPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceIamPolicy Get(string name, Input<string> id, ServiceIamPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new ServiceIamPolicy(name, id, state, options);
        }
    }

    public sealed class ServiceIamPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Input("policyData", required: true)]
        public Input<string> PolicyData { get; set; } = null!;

        /// <summary>
        /// The name of the service. Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ServiceIamPolicyArgs()
        {
        }
    }

    public sealed class ServiceIamPolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Computed) The etag of the IAM policy.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The policy data generated by
        /// a `gcp.organizations.getIAMPolicy` data source.
        /// </summary>
        [Input("policyData")]
        public Input<string>? PolicyData { get; set; }

        /// <summary>
        /// The name of the service. Used to find the parent resource to bind the IAM policy to
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public ServiceIamPolicyState()
        {
        }
    }
}
