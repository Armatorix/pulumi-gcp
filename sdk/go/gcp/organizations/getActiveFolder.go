// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package organizations

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Get an active folder within GCP by `displayName` and `parent`.
func GetActiveFolder(ctx *pulumi.Context, args *GetActiveFolderArgs, opts ...pulumi.InvokeOption) (*GetActiveFolderResult, error) {
	var rv GetActiveFolderResult
	err := ctx.Invoke("gcp:organizations/getActiveFolder:getActiveFolder", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getActiveFolder.
type GetActiveFolderArgs struct {
	// The folder's display name.
	DisplayName string `pulumi:"displayName"`
	// The resource name of the parent Folder or Organization.
	Parent string `pulumi:"parent"`
}

// A collection of values returned by getActiveFolder.
type GetActiveFolderResult struct {
	DisplayName string `pulumi:"displayName"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The resource name of the Folder. This uniquely identifies the folder.
	Name   string `pulumi:"name"`
	Parent string `pulumi:"parent"`
}
