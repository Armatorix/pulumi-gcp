// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package pubsub

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Three different resources help you manage your IAM policy for pubsub subscription. Each of these resources serves a different use case:
// 
// * `pubsub.SubscriptionIAMPolicy`: Authoritative. Sets the IAM policy for the subscription and replaces any existing policy already attached.
// * `pubsub.SubscriptionIAMBinding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the subscription are preserved.
// * `pubsub.SubscriptionIAMMember`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the subscription are preserved.
// 
// > **Note:** `pubsub.SubscriptionIAMPolicy` **cannot** be used in conjunction with `pubsub.SubscriptionIAMBinding` and `pubsub.SubscriptionIAMMember` or they will fight over what your policy should be.
// 
// > **Note:** `pubsub.SubscriptionIAMBinding` resources **can be** used in conjunction with `pubsub.SubscriptionIAMMember` resources **only if** they do not grant privilege to the same role.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/pubsub_subscription_iam_binding.html.markdown.
type SubscriptionIAMBinding struct {
	s *pulumi.ResourceState
}

// NewSubscriptionIAMBinding registers a new resource with the given unique name, arguments, and options.
func NewSubscriptionIAMBinding(ctx *pulumi.Context,
	name string, args *SubscriptionIAMBindingArgs, opts ...pulumi.ResourceOpt) (*SubscriptionIAMBinding, error) {
	if args == nil || args.Members == nil {
		return nil, errors.New("missing required argument 'Members'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	if args == nil || args.Subscription == nil {
		return nil, errors.New("missing required argument 'Subscription'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["condition"] = nil
		inputs["members"] = nil
		inputs["project"] = nil
		inputs["role"] = nil
		inputs["subscription"] = nil
	} else {
		inputs["condition"] = args.Condition
		inputs["members"] = args.Members
		inputs["project"] = args.Project
		inputs["role"] = args.Role
		inputs["subscription"] = args.Subscription
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:pubsub/subscriptionIAMBinding:SubscriptionIAMBinding", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SubscriptionIAMBinding{s: s}, nil
}

// GetSubscriptionIAMBinding gets an existing SubscriptionIAMBinding resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubscriptionIAMBinding(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SubscriptionIAMBindingState, opts ...pulumi.ResourceOpt) (*SubscriptionIAMBinding, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["condition"] = state.Condition
		inputs["etag"] = state.Etag
		inputs["members"] = state.Members
		inputs["project"] = state.Project
		inputs["role"] = state.Role
		inputs["subscription"] = state.Subscription
	}
	s, err := ctx.ReadResource("gcp:pubsub/subscriptionIAMBinding:SubscriptionIAMBinding", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SubscriptionIAMBinding{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *SubscriptionIAMBinding) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *SubscriptionIAMBinding) ID() pulumi.IDOutput {
	return r.s.ID()
}

func (r *SubscriptionIAMBinding) Condition() pulumi.Output {
	return r.s.State["condition"]
}

// (Computed) The etag of the subscription's IAM policy.
func (r *SubscriptionIAMBinding) Etag() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["etag"])
}

func (r *SubscriptionIAMBinding) Members() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["members"])
}

// The project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *SubscriptionIAMBinding) Project() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["project"])
}

// The role that should be applied. Only one
// `pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
// `[projects|organizations]/{parent-name}/roles/{role-name}`.
func (r *SubscriptionIAMBinding) Role() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["role"])
}

// The subscription name or id to bind to attach IAM policy to.
func (r *SubscriptionIAMBinding) Subscription() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["subscription"])
}

// Input properties used for looking up and filtering SubscriptionIAMBinding resources.
type SubscriptionIAMBindingState struct {
	Condition interface{}
	// (Computed) The etag of the subscription's IAM policy.
	Etag interface{}
	Members interface{}
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The role that should be applied. Only one
	// `pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
	// The subscription name or id to bind to attach IAM policy to.
	Subscription interface{}
}

// The set of arguments for constructing a SubscriptionIAMBinding resource.
type SubscriptionIAMBindingArgs struct {
	Condition interface{}
	Members interface{}
	// The project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The role that should be applied. Only one
	// `pubsub.SubscriptionIAMBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
	// The subscription name or id to bind to attach IAM policy to.
	Subscription interface{}
}
