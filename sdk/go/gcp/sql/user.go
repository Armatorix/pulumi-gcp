// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sql

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Creates a new Google SQL User on a Google SQL User Instance. For more information, see the [official documentation](https://cloud.google.com/sql/), or the [JSON API](https://cloud.google.com/sql/docs/admin-api/v1beta4/users).
// 
// ~> **Note:** All arguments including the username and password will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](/docs/state/sensitive-data.html). Passwords will not be retrieved when running
// "terraform import".
type User struct {
	s *pulumi.ResourceState
}

// NewUser registers a new resource with the given unique name, arguments, and options.
func NewUser(ctx *pulumi.Context,
	name string, args *UserArgs, opts ...pulumi.ResourceOpt) (*User, error) {
	if args == nil || args.Instance == nil {
		return nil, errors.New("missing required argument 'Instance'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["host"] = nil
		inputs["instance"] = nil
		inputs["name"] = nil
		inputs["password"] = nil
		inputs["project"] = nil
	} else {
		inputs["host"] = args.Host
		inputs["instance"] = args.Instance
		inputs["name"] = args.Name
		inputs["password"] = args.Password
		inputs["project"] = args.Project
	}
	s, err := ctx.RegisterResource("gcp:sql/user:User", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &User{s: s}, nil
}

// GetUser gets an existing User resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUser(ctx *pulumi.Context,
	name string, id pulumi.ID, state *UserState, opts ...pulumi.ResourceOpt) (*User, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["host"] = state.Host
		inputs["instance"] = state.Instance
		inputs["name"] = state.Name
		inputs["password"] = state.Password
		inputs["project"] = state.Project
	}
	s, err := ctx.ReadResource("gcp:sql/user:User", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &User{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *User) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *User) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The host the user can connect from. This is only supported
// for first generation SQL instances. Don't set this field for second generation
// SQL instances. Can be an IP address. Changing this forces a new resource to be created.
func (r *User) Host() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["host"])
}

// The name of the Cloud SQL instance. Changing this
// forces a new resource to be created.
func (r *User) Instance() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["instance"])
}

// The name of the user. Changing this forces a new resource
// to be created.
func (r *User) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The password for the user. Can be updated.
func (r *User) Password() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["password"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *User) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// Input properties used for looking up and filtering User resources.
type UserState struct {
	// The host the user can connect from. This is only supported
	// for first generation SQL instances. Don't set this field for second generation
	// SQL instances. Can be an IP address. Changing this forces a new resource to be created.
	Host interface{}
	// The name of the Cloud SQL instance. Changing this
	// forces a new resource to be created.
	Instance interface{}
	// The name of the user. Changing this forces a new resource
	// to be created.
	Name interface{}
	// The password for the user. Can be updated.
	Password interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
}

// The set of arguments for constructing a User resource.
type UserArgs struct {
	// The host the user can connect from. This is only supported
	// for first generation SQL instances. Don't set this field for second generation
	// SQL instances. Can be an IP address. Changing this forces a new resource to be created.
	Host interface{}
	// The name of the Cloud SQL instance. Changing this
	// forces a new resource to be created.
	Instance interface{}
	// The name of the user. Changing this forces a new resource
	// to be created.
	Name interface{}
	// The password for the user. Can be updated.
	Password interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
}