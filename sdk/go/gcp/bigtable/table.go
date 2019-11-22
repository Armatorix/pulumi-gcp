// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package bigtable

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Creates a Google Cloud Bigtable table inside an instance. For more information see
// [the official documentation](https://cloud.google.com/bigtable/) and
// [API](https://cloud.google.com/bigtable/docs/go/reference).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/bigtable_table.html.markdown.
type Table struct {
	s *pulumi.ResourceState
}

// NewTable registers a new resource with the given unique name, arguments, and options.
func NewTable(ctx *pulumi.Context,
	name string, args *TableArgs, opts ...pulumi.ResourceOpt) (*Table, error) {
	if args == nil || args.InstanceName == nil {
		return nil, errors.New("missing required argument 'InstanceName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["columnFamilies"] = nil
		inputs["instanceName"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
		inputs["splitKeys"] = nil
	} else {
		inputs["columnFamilies"] = args.ColumnFamilies
		inputs["instanceName"] = args.InstanceName
		inputs["name"] = args.Name
		inputs["project"] = args.Project
		inputs["splitKeys"] = args.SplitKeys
	}
	s, err := ctx.RegisterResource("gcp:bigtable/table:Table", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Table{s: s}, nil
}

// GetTable gets an existing Table resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTable(ctx *pulumi.Context,
	name string, id pulumi.ID, state *TableState, opts ...pulumi.ResourceOpt) (*Table, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["columnFamilies"] = state.ColumnFamilies
		inputs["instanceName"] = state.InstanceName
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["splitKeys"] = state.SplitKeys
	}
	s, err := ctx.ReadResource("gcp:bigtable/table:Table", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Table{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Table) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Table) ID() pulumi.IDOutput {
	return r.s.ID()
}

// A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.
func (r *Table) ColumnFamilies() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["columnFamilies"])
}

// The name of the Bigtable instance.
func (r *Table) InstanceName() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["instanceName"])
}

// The name of the table.
func (r *Table) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *Table) Project() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["project"])
}

// A list of predefined keys to split the table on.
func (r *Table) SplitKeys() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["splitKeys"])
}

// Input properties used for looking up and filtering Table resources.
type TableState struct {
	// A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.
	ColumnFamilies interface{}
	// The name of the Bigtable instance.
	InstanceName interface{}
	// The name of the table.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// A list of predefined keys to split the table on.
	SplitKeys interface{}
}

// The set of arguments for constructing a Table resource.
type TableArgs struct {
	// A group of columns within a table which share a common configuration. This can be specified multiple times. Structure is documented below.
	ColumnFamilies interface{}
	// The name of the Bigtable instance.
	InstanceName interface{}
	// The name of the table.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// A list of predefined keys to split the table on.
	SplitKeys interface{}
}
