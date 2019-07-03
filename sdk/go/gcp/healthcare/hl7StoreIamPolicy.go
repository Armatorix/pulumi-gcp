// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package healthcare

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > **Warning:** These resources are in beta, and should be used with the terraform-provider-google-beta provider.
// See [Provider Versions](https://terraform.io/docs/providers/google/provider_versions.html) for more details on beta resources.
// 
// Three different resources help you manage your IAM policy for Healthcare HL7v2 store. Each of these resources serves a different use case:
// 
// * `google_healthcare_hl7_v2_store_iam_policy`: Authoritative. Sets the IAM policy for the HL7v2 store and replaces any existing policy already attached.
// * `google_healthcare_hl7_v2_store_iam_binding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the HL7v2 store are preserved.
// * `google_healthcare_hl7_v2_store_iam_member`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the HL7v2 store are preserved.
// 
// > **Note:** `google_healthcare_hl7_v2_store_iam_policy` **cannot** be used in conjunction with `google_healthcare_hl7_v2_store_iam_binding` and `google_healthcare_hl7_v2_store_iam_member` or they will fight over what your policy should be.
// 
// > **Note:** `google_healthcare_hl7_v2_store_iam_binding` resources **can be** used in conjunction with `google_healthcare_hl7_v2_store_iam_member` resources **only if** they do not grant privilege to the same role.
type Hl7StoreIamPolicy struct {
	s *pulumi.ResourceState
}

// NewHl7StoreIamPolicy registers a new resource with the given unique name, arguments, and options.
func NewHl7StoreIamPolicy(ctx *pulumi.Context,
	name string, args *Hl7StoreIamPolicyArgs, opts ...pulumi.ResourceOpt) (*Hl7StoreIamPolicy, error) {
	if args == nil || args.Hl7V2StoreId == nil {
		return nil, errors.New("missing required argument 'Hl7V2StoreId'")
	}
	if args == nil || args.PolicyData == nil {
		return nil, errors.New("missing required argument 'PolicyData'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["hl7V2StoreId"] = nil
		inputs["policyData"] = nil
	} else {
		inputs["hl7V2StoreId"] = args.Hl7V2StoreId
		inputs["policyData"] = args.PolicyData
	}
	inputs["etag"] = nil
	s, err := ctx.RegisterResource("gcp:healthcare/hl7StoreIamPolicy:Hl7StoreIamPolicy", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Hl7StoreIamPolicy{s: s}, nil
}

// GetHl7StoreIamPolicy gets an existing Hl7StoreIamPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetHl7StoreIamPolicy(ctx *pulumi.Context,
	name string, id pulumi.ID, state *Hl7StoreIamPolicyState, opts ...pulumi.ResourceOpt) (*Hl7StoreIamPolicy, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["etag"] = state.Etag
		inputs["hl7V2StoreId"] = state.Hl7V2StoreId
		inputs["policyData"] = state.PolicyData
	}
	s, err := ctx.ReadResource("gcp:healthcare/hl7StoreIamPolicy:Hl7StoreIamPolicy", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Hl7StoreIamPolicy{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Hl7StoreIamPolicy) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Hl7StoreIamPolicy) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// (Computed) The etag of the HL7v2 store's IAM policy.
func (r *Hl7StoreIamPolicy) Etag() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["etag"])
}

// The HL7v2 store ID, in the form
// `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
// `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
// project setting will be used as a fallback.
func (r *Hl7StoreIamPolicy) Hl7V2StoreId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["hl7V2StoreId"])
}

// The policy data generated by
// a `google_iam_policy` data source.
func (r *Hl7StoreIamPolicy) PolicyData() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["policyData"])
}

// Input properties used for looking up and filtering Hl7StoreIamPolicy resources.
type Hl7StoreIamPolicyState struct {
	// (Computed) The etag of the HL7v2 store's IAM policy.
	Etag interface{}
	// The HL7v2 store ID, in the form
	// `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
	// `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
	// project setting will be used as a fallback.
	Hl7V2StoreId interface{}
	// The policy data generated by
	// a `google_iam_policy` data source.
	PolicyData interface{}
}

// The set of arguments for constructing a Hl7StoreIamPolicy resource.
type Hl7StoreIamPolicyArgs struct {
	// The HL7v2 store ID, in the form
	// `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
	// `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
	// project setting will be used as a fallback.
	Hl7V2StoreId interface{}
	// The policy data generated by
	// a `google_iam_policy` data source.
	PolicyData interface{}
}
