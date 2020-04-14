// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package projects

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Allows management of Organization policies for a Google Project. For more information see
// [the official
// documentation](https://cloud.google.com/resource-manager/docs/organization-policy/overview)
func LookupOrganizationPolicy(ctx *pulumi.Context, args *LookupOrganizationPolicyArgs, opts ...pulumi.InvokeOption) (*LookupOrganizationPolicyResult, error) {
	var rv LookupOrganizationPolicyResult
	err := ctx.Invoke("gcp:projects/getOrganizationPolicy:getOrganizationPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOrganizationPolicy.
type LookupOrganizationPolicyArgs struct {
	// (Required) The name of the Constraint the Policy is configuring, for example, `serviceuser.services`. Check out the [complete list of available constraints](https://cloud.google.com/resource-manager/docs/organization-policy/understanding-constraints#available_constraints).
	Constraint string `pulumi:"constraint"`
	// The project ID.
	Project string `pulumi:"project"`
}

// A collection of values returned by getOrganizationPolicy.
type LookupOrganizationPolicyResult struct {
	BooleanPolicies []GetOrganizationPolicyBooleanPolicy `pulumi:"booleanPolicies"`
	Constraint      string                               `pulumi:"constraint"`
	Etag            string                               `pulumi:"etag"`
	// id is the provider-assigned unique ID for this managed resource.
	Id              string                               `pulumi:"id"`
	ListPolicies    []GetOrganizationPolicyListPolicy    `pulumi:"listPolicies"`
	Project         string                               `pulumi:"project"`
	RestorePolicies []GetOrganizationPolicyRestorePolicy `pulumi:"restorePolicies"`
	UpdateTime      string                               `pulumi:"updateTime"`
	Version         int                                  `pulumi:"version"`
}
