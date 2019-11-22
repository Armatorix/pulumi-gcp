// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Three different resources help you manage your IAM policy for storage bucket. Each of these resources serves a different use case:
// 
// * `storage.BucketIAMBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the storage bucket are preserved.
// * `storage.BucketIAMMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the storage bucket are preserved.
// * `storage.BucketIAMPolicy`: Setting a policy removes all other permissions on the bucket, and if done incorrectly, there's a real chance you will lock yourself out of the bucket. If possible for your use case, using multiple storage.BucketIAMBinding resources will be much safer. See the usage example on how to work with policy correctly.
// 
// 
// > **Note:** `storage.BucketIAMBinding` resources **can be** used in conjunction with `storage.BucketIAMMember` resources **only if** they do not grant privilege to the same role.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/storage_bucket_iam_binding.html.markdown.
type BucketIAMBinding struct {
	s *pulumi.ResourceState
}

// NewBucketIAMBinding registers a new resource with the given unique name, arguments, and options.
func NewBucketIAMBinding(ctx *pulumi.Context,
	name string, args *BucketIAMBindingArgs, opts ...pulumi.ResourceOpt) (*BucketIAMBinding, error) {
	if args == nil || args.Bucket == nil {
		return nil, errors.New("missing required argument 'Bucket'")
	}
	if args == nil || args.Members == nil {
		return nil, errors.New("missing required argument 'Members'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["bucket"] = nil
		inputs["condition"] = nil
		inputs["members"] = nil
		inputs["role"] = nil
	} else {
		inputs["bucket"] = args.Bucket
		inputs["condition"] = args.Condition
		inputs["members"] = args.Members
		inputs["role"] = args.Role
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:storage/bucketIAMBinding:BucketIAMBinding", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketIAMBinding{s: s}, nil
}

// GetBucketIAMBinding gets an existing BucketIAMBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucketIAMBinding(ctx *pulumi.Context,
	name string, id pulumi.ID, state *BucketIAMBindingState, opts ...pulumi.ResourceOpt) (*BucketIAMBinding, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["bucket"] = state.Bucket
		inputs["condition"] = state.Condition
		inputs["etag"] = state.Etag
		inputs["members"] = state.Members
		inputs["role"] = state.Role
	}
	s, err := ctx.ReadResource("gcp:storage/bucketIAMBinding:BucketIAMBinding", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BucketIAMBinding{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *BucketIAMBinding) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *BucketIAMBinding) ID() pulumi.IDOutput {
	return r.s.ID()
}

// The name of the bucket it applies to.
func (r *BucketIAMBinding) Bucket() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["bucket"])
}

func (r *BucketIAMBinding) Condition() pulumi.Output {
	return r.s.State["condition"]
}

// (Computed) The etag of the storage bucket's IAM policy.
func (r *BucketIAMBinding) Etag() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["etag"])
}

func (r *BucketIAMBinding) Members() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["members"])
}

// The role that should be applied. Note that custom roles must be of the format
// `[projects|organizations]/{parent-name}/roles/{role-name}`.
func (r *BucketIAMBinding) Role() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["role"])
}

// Input properties used for looking up and filtering BucketIAMBinding resources.
type BucketIAMBindingState struct {
	// The name of the bucket it applies to.
	Bucket interface{}
	Condition interface{}
	// (Computed) The etag of the storage bucket's IAM policy.
	Etag interface{}
	Members interface{}
	// The role that should be applied. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}

// The set of arguments for constructing a BucketIAMBinding resource.
type BucketIAMBindingArgs struct {
	// The name of the bucket it applies to.
	Bucket interface{}
	Condition interface{}
	Members interface{}
	// The role that should be applied. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
}
