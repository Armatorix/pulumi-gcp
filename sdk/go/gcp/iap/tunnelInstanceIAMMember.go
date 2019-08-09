// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package iap

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/iap_tunnel_instance_iam_member.html.markdown.
type TunnelInstanceIAMMember struct {
	s *pulumi.ResourceState
}

// NewTunnelInstanceIAMMember registers a new resource with the given unique name, arguments, and options.
func NewTunnelInstanceIAMMember(ctx *pulumi.Context,
	name string, args *TunnelInstanceIAMMemberArgs, opts ...pulumi.ResourceOpt) (*TunnelInstanceIAMMember, error) {
	if args == nil || args.Instance == nil {
		return nil, errors.New("missing required argument 'Instance'")
	}
	if args == nil || args.Member == nil {
		return nil, errors.New("missing required argument 'Member'")
	}
	if args == nil || args.Role == nil {
		return nil, errors.New("missing required argument 'Role'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["instance"] = nil
		inputs["member"] = nil
		inputs["project"] = nil
		inputs["role"] = nil
		inputs["zone"] = nil
	} else {
		inputs["instance"] = args.Instance
		inputs["member"] = args.Member
		inputs["project"] = args.Project
		inputs["role"] = args.Role
		inputs["zone"] = args.Zone
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:iap/tunnelInstanceIAMMember:TunnelInstanceIAMMember", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TunnelInstanceIAMMember{s: s}, nil
}

// GetTunnelInstanceIAMMember gets an existing TunnelInstanceIAMMember resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTunnelInstanceIAMMember(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TunnelInstanceIAMMemberState, opts ...pulumi.ResourceOpt) (*TunnelInstanceIAMMember, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["etag"] = state.Etag
		inputs["instance"] = state.Instance
		inputs["member"] = state.Member
		inputs["project"] = state.Project
		inputs["role"] = state.Role
		inputs["zone"] = state.Zone
	}
	s, err := ctx.ReadResource("gcp:iap/tunnelInstanceIAMMember:TunnelInstanceIAMMember", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TunnelInstanceIAMMember{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *TunnelInstanceIAMMember) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *TunnelInstanceIAMMember) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// (Computed) The etag of the instance's IAM policy.
func (r *TunnelInstanceIAMMember) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The name of the instance.
func (r *TunnelInstanceIAMMember) Instance() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["instance"])
}

func (r *TunnelInstanceIAMMember) Member() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["member"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *TunnelInstanceIAMMember) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The role that should be applied. Only one
// `iap.TunnelInstanceIAMBinding` can be used per role. Note that custom roles must be of the format
// `[projects|organizations]/{parent-name}/roles/{role-name}`.
func (r *TunnelInstanceIAMMember) Role() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["role"])
}

// The zone of the instance. If
// unspecified, this defaults to the zone configured in the provider.
func (r *TunnelInstanceIAMMember) Zone() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["zone"])
}

// Input properties used for looking up and filtering TunnelInstanceIAMMember resources.
type TunnelInstanceIAMMemberState struct {
	// (Computed) The etag of the instance's IAM policy.
	Etag interface{}
	// The name of the instance.
	Instance interface{}
	Member interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The role that should be applied. Only one
	// `iap.TunnelInstanceIAMBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
	// The zone of the instance. If
	// unspecified, this defaults to the zone configured in the provider.
	Zone interface{}
}

// The set of arguments for constructing a TunnelInstanceIAMMember resource.
type TunnelInstanceIAMMemberArgs struct {
	// The name of the instance.
	Instance interface{}
	Member interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The role that should be applied. Only one
	// `iap.TunnelInstanceIAMBinding` can be used per role. Note that custom roles must be of the format
	// `[projects|organizations]/{parent-name}/roles/{role-name}`.
	Role interface{}
	// The zone of the instance. If
	// unspecified, this defaults to the zone configured in the provider.
	Zone interface{}
}
