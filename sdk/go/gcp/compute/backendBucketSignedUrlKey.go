// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// A key for signing Cloud CDN signed URLs for BackendBuckets.
// 
// 
// To get more information about BackendBucketSignedUrlKey, see:
// 
// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/backendBuckets)
// * How-to Guides
//     * [Using Signed URLs](https://cloud.google.com/cdn/docs/using-signed-urls/)
// 
// > **Warning:** All arguments including the key's value will be stored in the raw
// state as plain-text. [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
// Because the API does not return the sensitive key value,
// we cannot confirm or reverse changes to a key outside of this provider.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_backend_bucket_signed_url_key.html.markdown.
type BackendBucketSignedUrlKey struct {
	s *pulumi.ResourceState
}

// NewBackendBucketSignedUrlKey registers a new resource with the given unique name, arguments, and options.
func NewBackendBucketSignedUrlKey(ctx *pulumi.Context,
	name string, args *BackendBucketSignedUrlKeyArgs, opts ...pulumi.ResourceOpt) (*BackendBucketSignedUrlKey, error) {
	if args == nil || args.BackendBucket == nil {
		return nil, errors.New("missing required argument 'BackendBucket'")
	}
	if args == nil || args.KeyValue == nil {
		return nil, errors.New("missing required argument 'KeyValue'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["backendBucket"] = nil
		inputs["keyValue"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
	} else {
		inputs["backendBucket"] = args.BackendBucket
		inputs["keyValue"] = args.KeyValue
		inputs["name"] = args.Name
		inputs["project"] = args.Project
	}
	s, err := ctx.RegisterResource("gcp:compute/backendBucketSignedUrlKey:BackendBucketSignedUrlKey", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BackendBucketSignedUrlKey{s: s}, nil
}

// GetBackendBucketSignedUrlKey gets an existing BackendBucketSignedUrlKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBackendBucketSignedUrlKey(ctx *pulumi.Context,
	name string, id pulumi.ID, state *BackendBucketSignedUrlKeyState, opts ...pulumi.ResourceOpt) (*BackendBucketSignedUrlKey, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["backendBucket"] = state.BackendBucket
		inputs["keyValue"] = state.KeyValue
		inputs["name"] = state.Name
		inputs["project"] = state.Project
	}
	s, err := ctx.ReadResource("gcp:compute/backendBucketSignedUrlKey:BackendBucketSignedUrlKey", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &BackendBucketSignedUrlKey{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *BackendBucketSignedUrlKey) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *BackendBucketSignedUrlKey) ID() *pulumi.IDOutput {
	return r.s.ID()
}

func (r *BackendBucketSignedUrlKey) BackendBucket() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["backendBucket"])
}

func (r *BackendBucketSignedUrlKey) KeyValue() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["keyValue"])
}

func (r *BackendBucketSignedUrlKey) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The ID of the project in which the resource belongs.
// If it is not provided, the provider project is used.
func (r *BackendBucketSignedUrlKey) Project() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["project"])
}

// Input properties used for looking up and filtering BackendBucketSignedUrlKey resources.
type BackendBucketSignedUrlKeyState struct {
	BackendBucket interface{}
	KeyValue interface{}
	Name interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
}

// The set of arguments for constructing a BackendBucketSignedUrlKey resource.
type BackendBucketSignedUrlKeyArgs struct {
	BackendBucket interface{}
	KeyValue interface{}
	Name interface{}
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project interface{}
}