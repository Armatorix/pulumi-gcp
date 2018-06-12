// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to get information about a Google Cloud Organization.
// 
// ```hcl
// data "google_organization" "org" {
//   domain = "example.com"
// }
// 
// resource "google_folder" "sales" {
//   display_name = "Sales"
//   parent       = "${data.google_organization.org.name}"
// }
// ```
func LookupOrganization(ctx *pulumi.Context, args *GetOrganizationArgs) (*GetOrganizationResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["domain"] = args.Domain
		inputs["organization"] = args.Organization
	}
	outputs, err := ctx.Invoke("gcp:organizations/getOrganization:getOrganization", inputs)
	if err != nil {
		return nil, err
	}
	return &GetOrganizationResult{
		CreateTime: outputs["createTime"],
		DirectoryCustomerId: outputs["directoryCustomerId"],
		Domain: outputs["domain"],
		LifecycleState: outputs["lifecycleState"],
		Name: outputs["name"],
	}, nil
}

// A collection of arguments for invoking getOrganization.
type GetOrganizationArgs struct {
	// The domain name of the Organization.
	Domain interface{}
	// The name of the Organization in the form `{organization_id}` or `organizations/{organization_id}`.
	Organization interface{}
}

// A collection of values returned by getOrganization.
type GetOrganizationResult struct {
	// Timestamp when the Organization was created. A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
	CreateTime interface{}
	// The Google for Work customer ID of the Organization.
	DirectoryCustomerId interface{}
	Domain interface{}
	// The Organization's current lifecycle state.
	LifecycleState interface{}
	// The resource name of the Organization in the form `organizations/{organization_id}`.
	Name interface{}
}
