// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Encrypts secret data with Google Cloud KMS and provides access to the ciphertext.
//
//
// > **NOTE**: Using this resource will allow you to conceal secret data within your
// resource definitions, but it does not take care of protecting that data in the
// logging output, plan output, or state output.  Please take care to secure your secret
// data outside of resource definitions.
//
//
// To get more information about SecretCiphertext, see:
//
// * [API documentation](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyRings.cryptoKeys/encrypt)
// * How-to Guides
//     * [Encrypting and decrypting data with a symmetric key](https://cloud.google.com/kms/docs/encrypt-decrypt)
type SecretCiphertext struct {
	pulumi.CustomResourceState

	// The additional authenticated data used for integrity checks during encryption and decryption.
	AdditionalAuthenticatedData pulumi.StringPtrOutput `pulumi:"additionalAuthenticatedData"`
	// Contains the result of encrypting the provided plaintext, encoded in base64.
	Ciphertext pulumi.StringOutput `pulumi:"ciphertext"`
	// The full name of the CryptoKey that will be used to encrypt the provided plaintext. Format:
	// ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}''
	CryptoKey pulumi.StringOutput `pulumi:"cryptoKey"`
	// The plaintext to be encrypted.
	Plaintext pulumi.StringOutput `pulumi:"plaintext"`
}

// NewSecretCiphertext registers a new resource with the given unique name, arguments, and options.
func NewSecretCiphertext(ctx *pulumi.Context,
	name string, args *SecretCiphertextArgs, opts ...pulumi.ResourceOption) (*SecretCiphertext, error) {
	if args == nil || args.CryptoKey == nil {
		return nil, errors.New("missing required argument 'CryptoKey'")
	}
	if args == nil || args.Plaintext == nil {
		return nil, errors.New("missing required argument 'Plaintext'")
	}
	if args == nil {
		args = &SecretCiphertextArgs{}
	}
	var resource SecretCiphertext
	err := ctx.RegisterResource("gcp:kms/secretCiphertext:SecretCiphertext", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSecretCiphertext gets an existing SecretCiphertext resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSecretCiphertext(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SecretCiphertextState, opts ...pulumi.ResourceOption) (*SecretCiphertext, error) {
	var resource SecretCiphertext
	err := ctx.ReadResource("gcp:kms/secretCiphertext:SecretCiphertext", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SecretCiphertext resources.
type secretCiphertextState struct {
	// The additional authenticated data used for integrity checks during encryption and decryption.
	AdditionalAuthenticatedData *string `pulumi:"additionalAuthenticatedData"`
	// Contains the result of encrypting the provided plaintext, encoded in base64.
	Ciphertext *string `pulumi:"ciphertext"`
	// The full name of the CryptoKey that will be used to encrypt the provided plaintext. Format:
	// ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}''
	CryptoKey *string `pulumi:"cryptoKey"`
	// The plaintext to be encrypted.
	Plaintext *string `pulumi:"plaintext"`
}

type SecretCiphertextState struct {
	// The additional authenticated data used for integrity checks during encryption and decryption.
	AdditionalAuthenticatedData pulumi.StringPtrInput
	// Contains the result of encrypting the provided plaintext, encoded in base64.
	Ciphertext pulumi.StringPtrInput
	// The full name of the CryptoKey that will be used to encrypt the provided plaintext. Format:
	// ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}''
	CryptoKey pulumi.StringPtrInput
	// The plaintext to be encrypted.
	Plaintext pulumi.StringPtrInput
}

func (SecretCiphertextState) ElementType() reflect.Type {
	return reflect.TypeOf((*secretCiphertextState)(nil)).Elem()
}

type secretCiphertextArgs struct {
	// The additional authenticated data used for integrity checks during encryption and decryption.
	AdditionalAuthenticatedData *string `pulumi:"additionalAuthenticatedData"`
	// The full name of the CryptoKey that will be used to encrypt the provided plaintext. Format:
	// ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}''
	CryptoKey string `pulumi:"cryptoKey"`
	// The plaintext to be encrypted.
	Plaintext string `pulumi:"plaintext"`
}

// The set of arguments for constructing a SecretCiphertext resource.
type SecretCiphertextArgs struct {
	// The additional authenticated data used for integrity checks during encryption and decryption.
	AdditionalAuthenticatedData pulumi.StringPtrInput
	// The full name of the CryptoKey that will be used to encrypt the provided plaintext. Format:
	// ''projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}/cryptoKeys/{{cryptoKey}}''
	CryptoKey pulumi.StringInput
	// The plaintext to be encrypted.
	Plaintext pulumi.StringInput
}

func (SecretCiphertextArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*secretCiphertextArgs)(nil)).Elem()
}
