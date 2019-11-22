// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Target Pool within GCE. This is a collection of instances used as
// target of a network load balancer (Forwarding Rule). For more information see
// [the official
// documentation](https://cloud.google.com/compute/docs/load-balancing/network/target-pools)
// and [API](https://cloud.google.com/compute/docs/reference/latest/targetPools).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_target_pool.html.markdown.
type TargetPool struct {
	s *pulumi.ResourceState
}

// NewTargetPool registers a new resource with the given unique name, arguments, and options.
func NewTargetPool(ctx *pulumi.Context,
	name string, args *TargetPoolArgs, opts ...pulumi.ResourceOpt) (*TargetPool, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["backupPool"] = nil
		inputs["description"] = nil
		inputs["failoverRatio"] = nil
		inputs["healthChecks"] = nil
		inputs["instances"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
		inputs["region"] = nil
		inputs["sessionAffinity"] = nil
	} else {
		inputs["backupPool"] = args.BackupPool
		inputs["description"] = args.Description
		inputs["failoverRatio"] = args.FailoverRatio
		inputs["healthChecks"] = args.HealthChecks
		inputs["instances"] = args.Instances
		inputs["name"] = args.Name
		inputs["project"] = args.Project
		inputs["region"] = args.Region
		inputs["sessionAffinity"] = args.SessionAffinity
	}
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:compute/targetPool:TargetPool", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TargetPool{s: s}, nil
}

// GetTargetPool gets an existing TargetPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTargetPool(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TargetPoolState, opts ...pulumi.ResourceOpt) (*TargetPool, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["backupPool"] = state.BackupPool
		inputs["description"] = state.Description
		inputs["failoverRatio"] = state.FailoverRatio
		inputs["healthChecks"] = state.HealthChecks
		inputs["instances"] = state.Instances
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["region"] = state.Region
		inputs["selfLink"] = state.SelfLink
		inputs["sessionAffinity"] = state.SessionAffinity
	}
	s, err := ctx.ReadResource("gcp:compute/targetPool:TargetPool", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &TargetPool{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *TargetPool) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *TargetPool) ID() pulumi.IDOutput {
	return r.s.ID()
}

// URL to the backup target pool. Must also set
// failover\_ratio.
func (r *TargetPool) BackupPool() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["backupPool"])
}

// Textual description field.
func (r *TargetPool) Description() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["description"])
}

// Ratio (0 to 1) of failed nodes before using the
// backup pool (which must also be set).
func (r *TargetPool) FailoverRatio() pulumi.Float64Output {
	return (pulumi.Float64Output)(r.s.State["failoverRatio"])
}

// List of zero or one health check name or self_link. Only
// legacy `compute.HttpHealthCheck` is supported.
func (r *TargetPool) HealthChecks() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["healthChecks"])
}

// List of instances in the pool. They can be given as
// URLs, or in the form of "zone/name". Note that the instances need not exist
// at the time of target pool creation, so there is no need to use
// interpolators to create a dependency on the instances from the
// target pool.
func (r *TargetPool) Instances() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["instances"])
}

// A unique name for the resource, required by GCE. Changing
// this forces a new resource to be created.
func (r *TargetPool) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *TargetPool) Project() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["project"])
}

// Where the target pool resides. Defaults to project
// region.
func (r *TargetPool) Region() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["region"])
}

// The URI of the created resource.
func (r *TargetPool) SelfLink() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["selfLink"])
}

// How to distribute load. Options are "NONE" (no
// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
func (r *TargetPool) SessionAffinity() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["sessionAffinity"])
}

// Input properties used for looking up and filtering TargetPool resources.
type TargetPoolState struct {
	// URL to the backup target pool. Must also set
	// failover\_ratio.
	BackupPool interface{}
	// Textual description field.
	Description interface{}
	// Ratio (0 to 1) of failed nodes before using the
	// backup pool (which must also be set).
	FailoverRatio interface{}
	// List of zero or one health check name or self_link. Only
	// legacy `compute.HttpHealthCheck` is supported.
	HealthChecks interface{}
	// List of instances in the pool. They can be given as
	// URLs, or in the form of "zone/name". Note that the instances need not exist
	// at the time of target pool creation, so there is no need to use
	// interpolators to create a dependency on the instances from the
	// target pool.
	Instances interface{}
	// A unique name for the resource, required by GCE. Changing
	// this forces a new resource to be created.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// Where the target pool resides. Defaults to project
	// region.
	Region interface{}
	// The URI of the created resource.
	SelfLink interface{}
	// How to distribute load. Options are "NONE" (no
	// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
	// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
	SessionAffinity interface{}
}

// The set of arguments for constructing a TargetPool resource.
type TargetPoolArgs struct {
	// URL to the backup target pool. Must also set
	// failover\_ratio.
	BackupPool interface{}
	// Textual description field.
	Description interface{}
	// Ratio (0 to 1) of failed nodes before using the
	// backup pool (which must also be set).
	FailoverRatio interface{}
	// List of zero or one health check name or self_link. Only
	// legacy `compute.HttpHealthCheck` is supported.
	HealthChecks interface{}
	// List of instances in the pool. They can be given as
	// URLs, or in the form of "zone/name". Note that the instances need not exist
	// at the time of target pool creation, so there is no need to use
	// interpolators to create a dependency on the instances from the
	// target pool.
	Instances interface{}
	// A unique name for the resource, required by GCE. Changing
	// this forces a new resource to be created.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// Where the target pool resides. Defaults to project
	// region.
	Region interface{}
	// How to distribute load. Options are "NONE" (no
	// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
	// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
	SessionAffinity interface{}
}
