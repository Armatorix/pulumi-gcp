// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A key for signing Cloud CDN signed URLs for Backend Services.
//
//
// To get more information about BackendServiceSignedUrlKey, see:
//
// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/backendServices)
// * How-to Guides
//     * [Using Signed URLs](https://cloud.google.com/cdn/docs/using-signed-urls/)
type BackendServiceSignedUrlKey struct {
	pulumi.CustomResourceState

	// The backend service this signed URL key belongs.
	BackendService pulumi.StringOutput `pulumi:"backendService"`
	// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
	KeyValue pulumi.StringOutput `pulumi:"keyValue"`
	// Name of the signed URL key.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
}

// NewBackendServiceSignedUrlKey registers a new resource with the given unique name, arguments, and options.
func NewBackendServiceSignedUrlKey(ctx *pulumi.Context,
	name string, args *BackendServiceSignedUrlKeyArgs, opts ...pulumi.ResourceOption) (*BackendServiceSignedUrlKey, error) {
	if args == nil || args.BackendService == nil {
		return nil, errors.New("missing required argument 'BackendService'")
	}
	if args == nil || args.KeyValue == nil {
		return nil, errors.New("missing required argument 'KeyValue'")
	}
	if args == nil {
		args = &BackendServiceSignedUrlKeyArgs{}
	}
	var resource BackendServiceSignedUrlKey
	err := ctx.RegisterResource("gcp:compute/backendServiceSignedUrlKey:BackendServiceSignedUrlKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBackendServiceSignedUrlKey gets an existing BackendServiceSignedUrlKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBackendServiceSignedUrlKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BackendServiceSignedUrlKeyState, opts ...pulumi.ResourceOption) (*BackendServiceSignedUrlKey, error) {
	var resource BackendServiceSignedUrlKey
	err := ctx.ReadResource("gcp:compute/backendServiceSignedUrlKey:BackendServiceSignedUrlKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BackendServiceSignedUrlKey resources.
type backendServiceSignedUrlKeyState struct {
	// The backend service this signed URL key belongs.
	BackendService *string `pulumi:"backendService"`
	// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
	KeyValue *string `pulumi:"keyValue"`
	// Name of the signed URL key.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

type BackendServiceSignedUrlKeyState struct {
	// The backend service this signed URL key belongs.
	BackendService pulumi.StringPtrInput
	// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
	KeyValue pulumi.StringPtrInput
	// Name of the signed URL key.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (BackendServiceSignedUrlKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*backendServiceSignedUrlKeyState)(nil)).Elem()
}

type backendServiceSignedUrlKeyArgs struct {
	// The backend service this signed URL key belongs.
	BackendService string `pulumi:"backendService"`
	// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
	KeyValue string `pulumi:"keyValue"`
	// Name of the signed URL key.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

// The set of arguments for constructing a BackendServiceSignedUrlKey resource.
type BackendServiceSignedUrlKeyArgs struct {
	// The backend service this signed URL key belongs.
	BackendService pulumi.StringInput
	// 128-bit key value used for signing the URL. The key value must be a valid RFC 4648 Section 5 base64url encoded string.
	KeyValue pulumi.StringInput
	// Name of the signed URL key.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (BackendServiceSignedUrlKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*backendServiceSignedUrlKeyArgs)(nil)).Elem()
}
