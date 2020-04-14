// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// !> **Warning:** This data source is deprecated. Use the `kms.SecretCiphertext` **resource** instead.
//
// This data source allows you to encrypt data with Google Cloud KMS and use the
// ciphertext within your resource definitions.
//
// For more information see
// [the official documentation](https://cloud.google.com/kms/docs/encrypt-decrypt).
//
// > **NOTE**: Using this data source will allow you to conceal secret data within your
// resource definitions, but it does not take care of protecting that data in the
// logging output, plan output, or state output.  Please take care to secure your secret
// data outside of resource definitions.
func GetKMSSecretCiphertext(ctx *pulumi.Context, args *GetKMSSecretCiphertextArgs, opts ...pulumi.InvokeOption) (*GetKMSSecretCiphertextResult, error) {
	var rv GetKMSSecretCiphertextResult
	err := ctx.Invoke("gcp:kms/getKMSSecretCiphertext:getKMSSecretCiphertext", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getKMSSecretCiphertext.
type GetKMSSecretCiphertextArgs struct {
	// The id of the CryptoKey that will be used to
	// encrypt the provided plaintext. This is represented by the format
	// `{projectId}/{location}/{keyRingName}/{cryptoKeyName}`.
	CryptoKey string `pulumi:"cryptoKey"`
	// The plaintext to be encrypted
	Plaintext string `pulumi:"plaintext"`
}

// A collection of values returned by getKMSSecretCiphertext.
type GetKMSSecretCiphertextResult struct {
	// Contains the result of encrypting the provided plaintext, encoded in base64.
	Ciphertext string `pulumi:"ciphertext"`
	CryptoKey  string `pulumi:"cryptoKey"`
	// id is the provider-assigned unique ID for this managed resource.
	Id        string `pulumi:"id"`
	Plaintext string `pulumi:"plaintext"`
}
