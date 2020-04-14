// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Projects
{
    public static class GetOrganizationPolicy
    {
        /// <summary>
        /// Allows management of Organization policies for a Google Project. For more information see
        /// [the official
        /// documentation](https://cloud.google.com/resource-manager/docs/organization-policy/overview)
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetOrganizationPolicyResult> InvokeAsync(GetOrganizationPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetOrganizationPolicyResult>("gcp:projects/getOrganizationPolicy:getOrganizationPolicy", args ?? new GetOrganizationPolicyArgs(), options.WithVersion());
    }


    public sealed class GetOrganizationPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// (Required) The name of the Constraint the Policy is configuring, for example, `serviceuser.services`. Check out the [complete list of available constraints](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-constraints#available_constraints).
        /// </summary>
        [Input("constraint", required: true)]
        public string Constraint { get; set; } = null!;

        /// <summary>
        /// The project ID.
        /// </summary>
        [Input("project", required: true)]
        public string Project { get; set; } = null!;

        public GetOrganizationPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetOrganizationPolicyResult
    {
        public readonly ImmutableArray<Outputs.GetOrganizationPolicyBooleanPolicyResult> BooleanPolicies;
        public readonly string Constraint;
        public readonly string Etag;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetOrganizationPolicyListPolicyResult> ListPolicies;
        public readonly string Project;
        public readonly ImmutableArray<Outputs.GetOrganizationPolicyRestorePolicyResult> RestorePolicies;
        public readonly string UpdateTime;
        public readonly int Version;

        [OutputConstructor]
        private GetOrganizationPolicyResult(
            ImmutableArray<Outputs.GetOrganizationPolicyBooleanPolicyResult> booleanPolicies,

            string constraint,

            string etag,

            string id,

            ImmutableArray<Outputs.GetOrganizationPolicyListPolicyResult> listPolicies,

            string project,

            ImmutableArray<Outputs.GetOrganizationPolicyRestorePolicyResult> restorePolicies,

            string updateTime,

            int version)
        {
            BooleanPolicies = booleanPolicies;
            Constraint = constraint;
            Etag = etag;
            Id = id;
            ListPolicies = listPolicies;
            Project = project;
            RestorePolicies = restorePolicies;
            UpdateTime = updateTime;
            Version = version;
        }
    }
}
