// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sourcerepo

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Three different resources help you manage your IAM policy for Cloud Pub/Sub Topic. Each of these resources serves a different use case:
//
// * `pubsub.TopicIAMPolicy`: Authoritative. Sets the IAM policy for the topic and replaces any existing policy already attached.
// * `pubsub.TopicIAMBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the topic are preserved.
// * `pubsub.TopicIAMMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the topic are preserved.
//
// > **Note:** `pubsub.TopicIAMPolicy` **cannot** be used in conjunction with `pubsub.TopicIAMBinding` and `pubsub.TopicIAMMember` or they will fight over what your policy should be.
//
// > **Note:** `pubsub.TopicIAMBinding` resources **can be** used in conjunction with `pubsub.TopicIAMMember` resources **only if** they do not grant privilege to the same role.
type RepositoryIamPolicy struct {
	pulumi.CustomResourceState

	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringOutput `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringOutput `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project    pulumi.StringOutput `pulumi:"project"`
	Repository pulumi.StringOutput `pulumi:"repository"`
}

// NewRepositoryIamPolicy registers a new resource with the given unique name, arguments, and options.
func NewRepositoryIamPolicy(ctx *pulumi.Context,
	name string, args *RepositoryIamPolicyArgs, opts ...pulumi.ResourceOption) (*RepositoryIamPolicy, error) {
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	if args == nil || args.Repository == nil {
		return nil, errors.New("missing required argument 'Repository'")
	}
	if args == nil {
		args = &RepositoryIamPolicyArgs{}
	}
	var resource RepositoryIamPolicy
	err := ctx.RegisterResource("gcp:sourcerepo/repositoryIamPolicy:RepositoryIamPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRepositoryIamPolicy gets an existing RepositoryIamPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRepositoryIamPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RepositoryIamPolicyState, opts ...pulumi.ResourceOption) (*RepositoryIamPolicy, error) {
	var resource RepositoryIamPolicy
	err := ctx.ReadResource("gcp:sourcerepo/repositoryIamPolicy:RepositoryIamPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RepositoryIamPolicy resources.
type repositoryIamPolicyState struct {
	// (Computed) The etag of the IAM policy.
	Etag *string `pulumi:"etag"`
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData *string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project    *string `pulumi:"project"`
	Repository *string `pulumi:"repository"`
}

type RepositoryIamPolicyState struct {
	// (Computed) The etag of the IAM policy.
	Etag pulumi.StringPtrInput
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project    pulumi.StringPtrInput
	Repository pulumi.StringPtrInput
}

func (RepositoryIamPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryIamPolicyState)(nil)).Elem()
}

type repositoryIamPolicyArgs struct {
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData string `pulumi:"policyData"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project    *string `pulumi:"project"`
	Repository string  `pulumi:"repository"`
}

// The set of arguments for constructing a RepositoryIamPolicy resource.
type RepositoryIamPolicyArgs struct {
	// The policy data generated by
	// a `organizations.getIAMPolicy` data source.
	PolicyData pulumi.StringInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project    pulumi.StringPtrInput
	Repository pulumi.StringInput
}

func (RepositoryIamPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*repositoryIamPolicyArgs)(nil)).Elem()
}
