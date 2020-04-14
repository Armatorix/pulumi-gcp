// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package identityplatform

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// OIDC IdP configuration for a Identity Toolkit project.
//
// You must enable the
// [Google Identity Platform](https://console.cloud.google.com/marketplace/details/google-cloud-platform/customer-identity) in
// the marketplace prior to using this resource.
type OauthIdpConfig struct {
	pulumi.CustomResourceState

	// The client id of an OAuth client.
	ClientId pulumi.StringOutput `pulumi:"clientId"`
	// The client secret of the OAuth client, to enable OIDC code flow.
	ClientSecret pulumi.StringPtrOutput `pulumi:"clientSecret"`
	// Human friendly display name.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// For OIDC Idps, the issuer identifier.
	Issuer pulumi.StringOutput `pulumi:"issuer"`
	// The name of the OauthIdpConfig. Must start with 'oidc.'.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
}

// NewOauthIdpConfig registers a new resource with the given unique name, arguments, and options.
func NewOauthIdpConfig(ctx *pulumi.Context,
	name string, args *OauthIdpConfigArgs, opts ...pulumi.ResourceOption) (*OauthIdpConfig, error) {
	if args == nil || args.ClientId == nil {
		return nil, errors.New("missing required argument 'ClientId'")
	}
	if args == nil || args.Issuer == nil {
		return nil, errors.New("missing required argument 'Issuer'")
	}
	if args == nil {
		args = &OauthIdpConfigArgs{}
	}
	var resource OauthIdpConfig
	err := ctx.RegisterResource("gcp:identityplatform/oauthIdpConfig:OauthIdpConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOauthIdpConfig gets an existing OauthIdpConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOauthIdpConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OauthIdpConfigState, opts ...pulumi.ResourceOption) (*OauthIdpConfig, error) {
	var resource OauthIdpConfig
	err := ctx.ReadResource("gcp:identityplatform/oauthIdpConfig:OauthIdpConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OauthIdpConfig resources.
type oauthIdpConfigState struct {
	// The client id of an OAuth client.
	ClientId *string `pulumi:"clientId"`
	// The client secret of the OAuth client, to enable OIDC code flow.
	ClientSecret *string `pulumi:"clientSecret"`
	// Human friendly display name.
	DisplayName *string `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled *bool `pulumi:"enabled"`
	// For OIDC Idps, the issuer identifier.
	Issuer *string `pulumi:"issuer"`
	// The name of the OauthIdpConfig. Must start with 'oidc.'.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

type OauthIdpConfigState struct {
	// The client id of an OAuth client.
	ClientId pulumi.StringPtrInput
	// The client secret of the OAuth client, to enable OIDC code flow.
	ClientSecret pulumi.StringPtrInput
	// Human friendly display name.
	DisplayName pulumi.StringPtrInput
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrInput
	// For OIDC Idps, the issuer identifier.
	Issuer pulumi.StringPtrInput
	// The name of the OauthIdpConfig. Must start with 'oidc.'.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (OauthIdpConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*oauthIdpConfigState)(nil)).Elem()
}

type oauthIdpConfigArgs struct {
	// The client id of an OAuth client.
	ClientId string `pulumi:"clientId"`
	// The client secret of the OAuth client, to enable OIDC code flow.
	ClientSecret *string `pulumi:"clientSecret"`
	// Human friendly display name.
	DisplayName *string `pulumi:"displayName"`
	// If this config allows users to sign in with the provider.
	Enabled *bool `pulumi:"enabled"`
	// For OIDC Idps, the issuer identifier.
	Issuer string `pulumi:"issuer"`
	// The name of the OauthIdpConfig. Must start with 'oidc.'.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

// The set of arguments for constructing a OauthIdpConfig resource.
type OauthIdpConfigArgs struct {
	// The client id of an OAuth client.
	ClientId pulumi.StringInput
	// The client secret of the OAuth client, to enable OIDC code flow.
	ClientSecret pulumi.StringPtrInput
	// Human friendly display name.
	DisplayName pulumi.StringPtrInput
	// If this config allows users to sign in with the provider.
	Enabled pulumi.BoolPtrInput
	// For OIDC Idps, the issuer identifier.
	Issuer pulumi.StringInput
	// The name of the OauthIdpConfig. Must start with 'oidc.'.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (OauthIdpConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*oauthIdpConfigArgs)(nil)).Elem()
}
