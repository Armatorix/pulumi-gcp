// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to get project details.
// For more information see
// [API](https://cloud.google.com/resource-manager/reference/rest/v1/projects#Project)
func LookupProject(ctx *pulumi.Context, args *LookupProjectArgs, opts ...pulumi.InvokeOption) (*LookupProjectResult, error) {
	var rv LookupProjectResult
	err := ctx.Invoke("gcp:organizations/getProject:getProject", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getProject.
type LookupProjectArgs struct {
	// The project ID. If it is not provided, the provider project is used.
	ProjectId *string `pulumi:"projectId"`
}

// A collection of values returned by getProject.
type LookupProjectResult struct {
	AutoCreateNetwork bool   `pulumi:"autoCreateNetwork"`
	BillingAccount    string `pulumi:"billingAccount"`
	FolderId          string `pulumi:"folderId"`
	// id is the provider-assigned unique ID for this managed resource.
	Id         string            `pulumi:"id"`
	Labels     map[string]string `pulumi:"labels"`
	Name       string            `pulumi:"name"`
	Number     string            `pulumi:"number"`
	OrgId      string            `pulumi:"orgId"`
	ProjectId  *string           `pulumi:"projectId"`
	SkipDelete bool              `pulumi:"skipDelete"`
}
