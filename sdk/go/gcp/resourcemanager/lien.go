// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package resourcemanager

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A Lien represents an encumbrance on the actions that can be performed on a resource.
type Lien struct {
	pulumi.CustomResourceState

	// Time of creation
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// A system-generated unique identifier for this Lien.
	Name pulumi.StringOutput `pulumi:"name"`
	// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected programmatically.
	// Maximum length of 200 characters.
	Origin pulumi.StringOutput `pulumi:"origin"`
	// A reference to the resource this Lien is attached to. The server will validate the parent against those for which Liens
	// are supported. Since a variety of objects can have Liens against them, you must provide the type prefix (e.g.
	// "projects/my-project-name").
	Parent pulumi.StringOutput `pulumi:"parent"`
	// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of 200
	// characters.
	Reason pulumi.StringOutput `pulumi:"reason"`
	// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an IAM
	// permission. The server will validate the permissions against those for which Liens are supported. An empty list is
	// meaningless and will be rejected. e.g. ['resourcemanager.projects.delete']
	Restrictions pulumi.StringArrayOutput `pulumi:"restrictions"`
}

// NewLien registers a new resource with the given unique name, arguments, and options.
func NewLien(ctx *pulumi.Context,
	name string, args *LienArgs, opts ...pulumi.ResourceOption) (*Lien, error) {
	if args == nil || args.Origin == nil {
		return nil, errors.New("missing required argument 'Origin'")
	}
	if args == nil || args.Parent == nil {
		return nil, errors.New("missing required argument 'Parent'")
	}
	if args == nil || args.Reason == nil {
		return nil, errors.New("missing required argument 'Reason'")
	}
	if args == nil || args.Restrictions == nil {
		return nil, errors.New("missing required argument 'Restrictions'")
	}
	if args == nil {
		args = &LienArgs{}
	}
	var resource Lien
	err := ctx.RegisterResource("gcp:resourcemanager/lien:Lien", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLien gets an existing Lien resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLien(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LienState, opts ...pulumi.ResourceOption) (*Lien, error) {
	var resource Lien
	err := ctx.ReadResource("gcp:resourcemanager/lien:Lien", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Lien resources.
type lienState struct {
	// Time of creation
	CreateTime *string `pulumi:"createTime"`
	// A system-generated unique identifier for this Lien.
	Name *string `pulumi:"name"`
	// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected programmatically.
	// Maximum length of 200 characters.
	Origin *string `pulumi:"origin"`
	// A reference to the resource this Lien is attached to. The server will validate the parent against those for which Liens
	// are supported. Since a variety of objects can have Liens against them, you must provide the type prefix (e.g.
	// "projects/my-project-name").
	Parent *string `pulumi:"parent"`
	// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of 200
	// characters.
	Reason *string `pulumi:"reason"`
	// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an IAM
	// permission. The server will validate the permissions against those for which Liens are supported. An empty list is
	// meaningless and will be rejected. e.g. ['resourcemanager.projects.delete']
	Restrictions []string `pulumi:"restrictions"`
}

type LienState struct {
	// Time of creation
	CreateTime pulumi.StringPtrInput
	// A system-generated unique identifier for this Lien.
	Name pulumi.StringPtrInput
	// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected programmatically.
	// Maximum length of 200 characters.
	Origin pulumi.StringPtrInput
	// A reference to the resource this Lien is attached to. The server will validate the parent against those for which Liens
	// are supported. Since a variety of objects can have Liens against them, you must provide the type prefix (e.g.
	// "projects/my-project-name").
	Parent pulumi.StringPtrInput
	// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of 200
	// characters.
	Reason pulumi.StringPtrInput
	// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an IAM
	// permission. The server will validate the permissions against those for which Liens are supported. An empty list is
	// meaningless and will be rejected. e.g. ['resourcemanager.projects.delete']
	Restrictions pulumi.StringArrayInput
}

func (LienState) ElementType() reflect.Type {
	return reflect.TypeOf((*lienState)(nil)).Elem()
}

type lienArgs struct {
	// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected programmatically.
	// Maximum length of 200 characters.
	Origin string `pulumi:"origin"`
	// A reference to the resource this Lien is attached to. The server will validate the parent against those for which Liens
	// are supported. Since a variety of objects can have Liens against them, you must provide the type prefix (e.g.
	// "projects/my-project-name").
	Parent string `pulumi:"parent"`
	// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of 200
	// characters.
	Reason string `pulumi:"reason"`
	// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an IAM
	// permission. The server will validate the permissions against those for which Liens are supported. An empty list is
	// meaningless and will be rejected. e.g. ['resourcemanager.projects.delete']
	Restrictions []string `pulumi:"restrictions"`
}

// The set of arguments for constructing a Lien resource.
type LienArgs struct {
	// A stable, user-visible/meaningful string identifying the origin of the Lien, intended to be inspected programmatically.
	// Maximum length of 200 characters.
	Origin pulumi.StringInput
	// A reference to the resource this Lien is attached to. The server will validate the parent against those for which Liens
	// are supported. Since a variety of objects can have Liens against them, you must provide the type prefix (e.g.
	// "projects/my-project-name").
	Parent pulumi.StringInput
	// Concise user-visible strings indicating why an action cannot be performed on a resource. Maximum length of 200
	// characters.
	Reason pulumi.StringInput
	// The types of operations which should be blocked as a result of this Lien. Each value should correspond to an IAM
	// permission. The server will validate the permissions against those for which Liens are supported. An empty list is
	// meaningless and will be rejected. e.g. ['resourcemanager.projects.delete']
	Restrictions pulumi.StringArrayInput
}

func (LienArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*lienArgs)(nil)).Elem()
}
