// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datacatalog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Three different resources help you manage your IAM policy for Data catalog EntryGroup. Each of these resources serves a different use case:
//
// * `datacatalog.EntryGroupIamPolicy`: Authoritative. Sets the IAM policy for the entrygroup and replaces any existing policy already attached.
// * `datacatalog.EntryGroupIamBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the entrygroup are preserved.
// * `datacatalog.EntryGroupIamMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the entrygroup are preserved.
//
// > **Note:** `datacatalog.EntryGroupIamPolicy` **cannot** be used in conjunction with `datacatalog.EntryGroupIamBinding` and `datacatalog.EntryGroupIamMember` or they will fight over what your policy should be.
//
// > **Note:** `datacatalog.EntryGroupIamBinding` resources **can be** used in conjunction with `datacatalog.EntryGroupIamMember` resources **only if** they do not grant privilege to the same role.
type EntryGroupIamBinding struct {
	pulumi.CustomResourceState

	Condition EntryGroupIamBindingConditionPtrOutput `pulumi:"condition"`
	// Used to find the parent resource to bind the IAM policy to
	EntryGroup pulumi.StringOutput `pulumi:"entryGroup"`
	// (Computed) The etag of the IAM policy.
	Etag    pulumi.StringOutput      `pulumi:"etag"`
	Members pulumi.StringArrayOutput `pulumi:"members"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	Region  pulumi.StringOutput `pulumi:"region"`
	// The role that should be applied. Only one
	// `datacatalog.EntryGroupIamBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role pulumi.StringOutput `pulumi:"role"`
}

// NewEntryGroupIamBinding registers a new resource with the given unique name, arguments, and options.
func NewEntryGroupIamBinding(ctx *pulumi.Context,
	name string, args *EntryGroupIamBindingArgs, opts ...pulumi.ResourceOption) (*EntryGroupIamBinding, error) {
	if args == nil || args.EntryGroup == nil {
		return nil, errors.New("missing required argument 'EntryGroup'")
	}
	if args == nil || args.Members == nil {
		return nil, errors.New("missing required argument 'Members'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	if args == nil {
		args = &EntryGroupIamBindingArgs{}
	}
	var resource EntryGroupIamBinding
	err := ctx.RegisterResource("gcp:datacatalog/entryGroupIamBinding:EntryGroupIamBinding", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEntryGroupIamBinding gets an existing EntryGroupIamBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEntryGroupIamBinding(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EntryGroupIamBindingState, opts ...pulumi.ResourceOption) (*EntryGroupIamBinding, error) {
	var resource EntryGroupIamBinding
	err := ctx.ReadResource("gcp:datacatalog/entryGroupIamBinding:EntryGroupIamBinding", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EntryGroupIamBinding resources.
type entryGroupIamBindingState struct {
	Condition *EntryGroupIamBindingCondition `pulumi:"condition"`
	// Used to find the parent resource to bind the IAM policy to
	EntryGroup *string `pulumi:"entryGroup"`
	// (Computed) The etag of the IAM policy.
	Etag    *string  `pulumi:"etag"`
	Members []string `pulumi:"members"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
	Region  *string `pulumi:"region"`
	// The role that should be applied. Only one
	// `datacatalog.EntryGroupIamBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role *string `pulumi:"role"`
}

type EntryGroupIamBindingState struct {
	Condition EntryGroupIamBindingConditionPtrInput
	// Used to find the parent resource to bind the IAM policy to
	EntryGroup pulumi.StringPtrInput
	// (Computed) The etag of the IAM policy.
	Etag    pulumi.StringPtrInput
	Members pulumi.StringArrayInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
	Region  pulumi.StringPtrInput
	// The role that should be applied. Only one
	// `datacatalog.EntryGroupIamBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role pulumi.StringPtrInput
}

func (EntryGroupIamBindingState) ElementType() reflect.Type {
	return reflect.TypeOf((*entryGroupIamBindingState)(nil)).Elem()
}

type entryGroupIamBindingArgs struct {
	Condition *EntryGroupIamBindingCondition `pulumi:"condition"`
	// Used to find the parent resource to bind the IAM policy to
	EntryGroup string   `pulumi:"entryGroup"`
	Members    []string `pulumi:"members"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project *string `pulumi:"project"`
	Region  *string `pulumi:"region"`
	// The role that should be applied. Only one
	// `datacatalog.EntryGroupIamBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role string `pulumi:"role"`
}

// The set of arguments for constructing a EntryGroupIamBinding resource.
type EntryGroupIamBindingArgs struct {
	Condition EntryGroupIamBindingConditionPtrInput
	// Used to find the parent resource to bind the IAM policy to
	EntryGroup pulumi.StringInput
	Members    pulumi.StringArrayInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the project will be parsed from the identifier of the parent resource. If no project is provided in the parent identifier and no project is specified, the provider project is used.
	Project pulumi.StringPtrInput
	Region  pulumi.StringPtrInput
	// The role that should be applied. Only one
	// `datacatalog.EntryGroupIamBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role pulumi.StringInput
}

func (EntryGroupIamBindingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*entryGroupIamBindingArgs)(nil)).Elem()
}