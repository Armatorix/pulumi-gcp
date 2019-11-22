// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package accesscontextmanager

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// AccessPolicy is a container for AccessLevels (which define the necessary
// attributes to use GCP services) and ServicePerimeters (which define
// regions of services able to freely pass data within a perimeter). An
// access policy is globally visible within an organization, and the
// restrictions it specifies apply to all projects within an organization.
// 
// 
// To get more information about AccessPolicy, see:
// 
// * [API documentation](https://cloud.google.com/access-context-manager/docs/reference/rest/v1/accessPolicies)
// * How-to Guides
//     * [Access Policy Quickstart](https://cloud.google.com/access-context-manager/docs/quickstart)
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/access_context_manager_access_policy.html.markdown.
type AccessPolicy struct {
	s *pulumi.ResourceState
}

// NewAccessPolicy registers a new resource with the given unique name, arguments, and options.
func NewAccessPolicy(ctx *pulumi.Context,
	name string, args *AccessPolicyArgs, opts ...pulumi.ResourceOpt) (*AccessPolicy, error) {
	if args == nil || args.Parent == nil {
		return nil, errors.New("missing required argument 'Parent'")
	}
	if args == nil || args.Title == nil {
		return nil, errors.New("missing required argument 'Title'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["parent"] = nil
		inputs["title"] = nil
	} else {
		inputs["parent"] = args.Parent
		inputs["title"] = args.Title
	}
	inputs["createTime"] = nil
	inputs["name"] = nil
	inputs["updateTime"] = nil
	s, err := ctx.RegisterResource("gcp:accesscontextmanager/accessPolicy:AccessPolicy", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &AccessPolicy{s: s}, nil
}

// GetAccessPolicy gets an existing AccessPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccessPolicy(ctx *pulumi.Context,
	name string, id pulumi.ID, state *AccessPolicyState, opts ...pulumi.ResourceOpt) (*AccessPolicy, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["createTime"] = state.CreateTime
		inputs["name"] = state.Name
		inputs["parent"] = state.Parent
		inputs["title"] = state.Title
		inputs["updateTime"] = state.UpdateTime
	}
	s, err := ctx.ReadResource("gcp:accesscontextmanager/accessPolicy:AccessPolicy", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &AccessPolicy{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *AccessPolicy) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *AccessPolicy) ID() pulumi.IDOutput {
	return r.s.ID()
}

// Time the AccessPolicy was created in UTC.
func (r *AccessPolicy) CreateTime() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["createTime"])
}

// Resource name of the AccessPolicy. Format: {policy_id}
func (r *AccessPolicy) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// The parent of this AccessPolicy in the Cloud Resource Hierarchy. Format: organizations/{organization_id}
func (r *AccessPolicy) Parent() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["parent"])
}

// Human readable title. Does not affect behavior.
func (r *AccessPolicy) Title() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["title"])
}

// Time the AccessPolicy was updated in UTC.
func (r *AccessPolicy) UpdateTime() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["updateTime"])
}

// Input properties used for looking up and filtering AccessPolicy resources.
type AccessPolicyState struct {
	// Time the AccessPolicy was created in UTC.
	CreateTime interface{}
	// Resource name of the AccessPolicy. Format: {policy_id}
	Name interface{}
	// The parent of this AccessPolicy in the Cloud Resource Hierarchy. Format: organizations/{organization_id}
	Parent interface{}
	// Human readable title. Does not affect behavior.
	Title interface{}
	// Time the AccessPolicy was updated in UTC.
	UpdateTime interface{}
}

// The set of arguments for constructing a AccessPolicy resource.
type AccessPolicyArgs struct {
	// The parent of this AccessPolicy in the Cloud Resource Hierarchy. Format: organizations/{organization_id}
	Parent interface{}
	// Human readable title. Does not affect behavior.
	Title interface{}
}
