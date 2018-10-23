// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sql

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Creates a new Google SQL Database on a Google SQL Database Instance. For more information, see
// the [official documentation](https://cloud.google.com/sql/),
// or the [JSON API](https://cloud.google.com/sql/docs/admin-api/v1beta4/databases).
type Database struct {
	s *pulumi.ResourceState
}

// NewDatabase registers a new resource with the given unique name, arguments, and options.
func NewDatabase(ctx *pulumi.Context,
	name string, args *DatabaseArgs, opts ...pulumi.ResourceOpt) (*Database, error) {
	if args == nil || args.Instance == nil {
		return nil, errors.New("missing required argument 'Instance'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["charset"] = nil
		inputs["collation"] = nil
		inputs["instance"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
	} else {
		inputs["charset"] = args.Charset
		inputs["collation"] = args.Collation
		inputs["instance"] = args.Instance
		inputs["name"] = args.Name
		inputs["project"] = args.Project
	}
	inputs["selfLink"] = nil
	s, err := ctx.RegisterResource("gcp:sql/database:Database", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Database{s: s}, nil
}

// GetDatabase gets an existing Database resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabase(ctx *pulumi.Context,
	name string, id pulumi.ID, state *DatabaseState, opts ...pulumi.ResourceOpt) (*Database, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["charset"] = state.Charset
		inputs["collation"] = state.Collation
		inputs["instance"] = state.Instance
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["selfLink"] = state.SelfLink
	}
	s, err := ctx.ReadResource("gcp:sql/database:Database", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Database{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Database) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Database) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The charset value. See MySQL's
// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
// and Postgres' [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
// for more details and supported values. Postgres databases are in beta
// and have limited `charset` support; they only support a value of `UTF8` at creation time.
func (r *Database) Charset() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["charset"])
}

// The collation value. See MySQL's
// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
// and Postgres' [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
// for more details and supported values. Postgres databases are in beta
// and have limited `collation` support; they only support a value of `en_US.UTF8` at creation time.
func (r *Database) Collation() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["collation"])
}

// The name of containing instance.
func (r *Database) Instance() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["instance"])
}

// The name of the database.
func (r *Database) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *Database) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// The URI of the created resource.
func (r *Database) SelfLink() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["selfLink"])
}

// Input properties used for looking up and filtering Database resources.
type DatabaseState struct {
	// The charset value. See MySQL's
	// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
	// and Postgres' [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
	// for more details and supported values. Postgres databases are in beta
	// and have limited `charset` support; they only support a value of `UTF8` at creation time.
	Charset interface{}
	// The collation value. See MySQL's
	// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
	// and Postgres' [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
	// for more details and supported values. Postgres databases are in beta
	// and have limited `collation` support; they only support a value of `en_US.UTF8` at creation time.
	Collation interface{}
	// The name of containing instance.
	Instance interface{}
	// The name of the database.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The URI of the created resource.
	SelfLink interface{}
}

// The set of arguments for constructing a Database resource.
type DatabaseArgs struct {
	// The charset value. See MySQL's
	// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
	// and Postgres' [Character Set Support](https://www.postgresql.org/docs/9.6/static/multibyte.html)
	// for more details and supported values. Postgres databases are in beta
	// and have limited `charset` support; they only support a value of `UTF8` at creation time.
	Charset interface{}
	// The collation value. See MySQL's
	// [Supported Character Sets and Collations](https://dev.mysql.com/doc/refman/5.7/en/charset-charsets.html)
	// and Postgres' [Collation Support](https://www.postgresql.org/docs/9.6/static/collation.html)
	// for more details and supported values. Postgres databases are in beta
	// and have limited `collation` support; they only support a value of `en_US.UTF8` at creation time.
	Collation interface{}
	// The name of containing instance.
	Instance interface{}
	// The name of the database.
	Name interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
}
