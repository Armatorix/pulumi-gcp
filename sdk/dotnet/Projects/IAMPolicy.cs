// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Projects
{
    /// <summary>
    /// Four different resources help you manage your IAM policy for a project. Each of these resources serves a different use case:
    /// 
    /// * `gcp.projects.IAMPolicy`: Authoritative. Sets the IAM policy for the project and replaces any existing policy already attached.
    /// * `gcp.projects.IAMBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the project are preserved.
    /// * `gcp.projects.IAMMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the project are preserved.
    /// * `gcp.projects.IAMAuditConfig`: Authoritative for a given service. Updates the IAM policy to enable audit logging for the given service.
    /// 
    /// 
    /// &gt; **Note:** `gcp.projects.IAMPolicy` **cannot** be used in conjunction with `gcp.projects.IAMBinding`, `gcp.projects.IAMMember`, or `gcp.projects.IAMAuditConfig` or they will fight over what your policy should be.
    /// 
    /// &gt; **Note:** `gcp.projects.IAMBinding` resources **can be** used in conjunction with `gcp.projects.IAMMember` resources **only if** they do not grant privilege to the same role.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/project_iam_policy.html.markdown.
    /// </summary>
    public partial class IAMPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// (Computed) The etag of the project's IAM policy.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The `gcp.organizations.getIAMPolicy` data source that represents
        /// the IAM policy that will be applied to the project. The policy will be
        /// merged with any existing policy applied to the project.
        /// </summary>
        [Output("policyData")]
        public Output<string> PolicyData { get; private set; } = null!;

        /// <summary>
        /// The project ID. If not specified for `gcp.projects.IAMBinding`, `gcp.projects.IAMMember`, or `gcp.projects.IAMAuditConfig`, uses the ID of the project configured with the provider.
        /// Required for `gcp.projects.IAMPolicy` - you must explicitly set the project, and it
        /// will not be inferred from the provider.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;


        /// <summary>
        /// Create a IAMPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IAMPolicy(string name, IAMPolicyArgs args, CustomResourceOptions? options = null)
            : base("gcp:projects/iAMPolicy:IAMPolicy", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private IAMPolicy(string name, Input<string> id, IAMPolicyState? state = null, CustomResourceOptions? options = null)
            : base("gcp:projects/iAMPolicy:IAMPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IAMPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IAMPolicy Get(string name, Input<string> id, IAMPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new IAMPolicy(name, id, state, options);
        }
    }

    public sealed class IAMPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The `gcp.organizations.getIAMPolicy` data source that represents
        /// the IAM policy that will be applied to the project. The policy will be
        /// merged with any existing policy applied to the project.
        /// </summary>
        [Input("policyData", required: true)]
        public Input<string> PolicyData { get; set; } = null!;

        /// <summary>
        /// The project ID. If not specified for `gcp.projects.IAMBinding`, `gcp.projects.IAMMember`, or `gcp.projects.IAMAuditConfig`, uses the ID of the project configured with the provider.
        /// Required for `gcp.projects.IAMPolicy` - you must explicitly set the project, and it
        /// will not be inferred from the provider.
        /// </summary>
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        public IAMPolicyArgs()
        {
        }
    }

    public sealed class IAMPolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Computed) The etag of the project's IAM policy.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The `gcp.organizations.getIAMPolicy` data source that represents
        /// the IAM policy that will be applied to the project. The policy will be
        /// merged with any existing policy applied to the project.
        /// </summary>
        [Input("policyData")]
        public Input<string>? PolicyData { get; set; }

        /// <summary>
        /// The project ID. If not specified for `gcp.projects.IAMBinding`, `gcp.projects.IAMMember`, or `gcp.projects.IAMAuditConfig`, uses the ID of the project configured with the provider.
        /// Required for `gcp.projects.IAMPolicy` - you must explicitly set the project, and it
        /// will not be inferred from the provider.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public IAMPolicyState()
        {
        }
    }
}