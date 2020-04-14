// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package container

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// This data source fetches the project name, and provides the appropriate URLs to use for container registry for this project.
//
// The URLs are computed entirely offline - as long as the project exists, they will be valid, but this data source does not contact Google Container Registry (GCR) at any point.
func GetRegistryRepository(ctx *pulumi.Context, args *GetRegistryRepositoryArgs, opts ...pulumi.InvokeOption) (*GetRegistryRepositoryResult, error) {
	var rv GetRegistryRepositoryResult
	err := ctx.Invoke("gcp:container/getRegistryRepository:getRegistryRepository", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRegistryRepository.
type GetRegistryRepositoryArgs struct {
	Project *string `pulumi:"project"`
	Region  *string `pulumi:"region"`
}

// A collection of values returned by getRegistryRepository.
type GetRegistryRepositoryResult struct {
	// id is the provider-assigned unique ID for this managed resource.
	Id            string  `pulumi:"id"`
	Project       string  `pulumi:"project"`
	Region        *string `pulumi:"region"`
	RepositoryUrl string  `pulumi:"repositoryUrl"`
}
