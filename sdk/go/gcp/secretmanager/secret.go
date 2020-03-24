// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package secretmanager

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type Secret struct {
	pulumi.CustomResourceState

	// The time at which the Secret was created.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
	// maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to
	// the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be assigned to a given
	// resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3"
	// }.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'
	Name pulumi.StringOutput `pulumi:"name"`
	Project pulumi.StringOutput `pulumi:"project"`
	// The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been
	// created.
	Replication SecretReplicationOutput `pulumi:"replication"`
	// This must be unique within the project.
	SecretId pulumi.StringOutput `pulumi:"secretId"`
}

// NewSecret registers a new resource with the given unique name, arguments, and options.
func NewSecret(ctx *pulumi.Context,
	name string, args *SecretArgs, opts ...pulumi.ResourceOption) (*Secret, error) {
	if args == nil || args.Replication == nil {
		return nil, errors.New("missing required argument 'Replication'")
	}
	if args == nil || args.SecretId == nil {
		return nil, errors.New("missing required argument 'SecretId'")
	}
	if args == nil {
		args = &SecretArgs{}
	}
	var resource Secret
	err := ctx.RegisterResource("gcp:secretmanager/secret:Secret", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecret gets an existing Secret resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecret(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecretState, opts ...pulumi.ResourceOption) (*Secret, error) {
	var resource Secret
	err := ctx.ReadResource("gcp:secretmanager/secret:Secret", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Secret resources.
type secretState struct {
	// The time at which the Secret was created.
	CreateTime *string `pulumi:"createTime"`
	// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
	// maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to
	// the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be assigned to a given
	// resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3"
	// }.
	Labels map[string]string `pulumi:"labels"`
	// The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'
	Name *string `pulumi:"name"`
	Project *string `pulumi:"project"`
	// The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been
	// created.
	Replication *SecretReplication `pulumi:"replication"`
	// This must be unique within the project.
	SecretId *string `pulumi:"secretId"`
}

type SecretState struct {
	// The time at which the Secret was created.
	CreateTime pulumi.StringPtrInput
	// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
	// maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to
	// the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be assigned to a given
	// resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3"
	// }.
	Labels pulumi.StringMapInput
	// The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'
	Name pulumi.StringPtrInput
	Project pulumi.StringPtrInput
	// The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been
	// created.
	Replication SecretReplicationPtrInput
	// This must be unique within the project.
	SecretId pulumi.StringPtrInput
}

func (SecretState) ElementType() reflect.Type {
	return reflect.TypeOf((*secretState)(nil)).Elem()
}

type secretArgs struct {
	// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
	// maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to
	// the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be assigned to a given
	// resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3"
	// }.
	Labels map[string]string `pulumi:"labels"`
	Project *string `pulumi:"project"`
	// The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been
	// created.
	Replication SecretReplication `pulumi:"replication"`
	// This must be unique within the project.
	SecretId string `pulumi:"secretId"`
}

// The set of arguments for constructing a Secret resource.
type SecretArgs struct {
	// The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of
	// maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
	// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to
	// the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be assigned to a given
	// resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3"
	// }.
	Labels pulumi.StringMapInput
	Project pulumi.StringPtrInput
	// The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been
	// created.
	Replication SecretReplicationInput
	// This must be unique within the project.
	SecretId pulumi.StringInput
}

func (SecretArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*secretArgs)(nil)).Elem()
}
