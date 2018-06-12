// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package container

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides access to available Google Container Engine versions in a zone for a given project.
// 
// ```hcl
// data "google_container_engine_versions" "central1b" {
//   zone = "us-central1-b"
// }
// 
// resource "google_container_cluster" "foo" {
//   name               = "terraform-test-cluster"
//   zone               = "us-central1-b"
//   node_version       = "${data.google_container_engine_versions.central1b.latest_node_version}"
//   initial_node_count = 1
// 
//   master_auth {
//     username = "mr.yoda"
//     password = "adoy.rm"
//   }
// }
// ```
func LookupEngineVersions(ctx *pulumi.Context, args *GetEngineVersionsArgs) (*GetEngineVersionsResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["project"] = args.Project
		inputs["zone"] = args.Zone
	}
	outputs, err := ctx.Invoke("gcp:container/getEngineVersions:getEngineVersions", inputs)
	if err != nil {
		return nil, err
	}
	return &GetEngineVersionsResult{
		DefaultClusterVersion: outputs["defaultClusterVersion"],
		LatestMasterVersion: outputs["latestMasterVersion"],
		LatestNodeVersion: outputs["latestNodeVersion"],
		ValidMasterVersions: outputs["validMasterVersions"],
		ValidNodeVersions: outputs["validNodeVersions"],
	}, nil
}

// A collection of arguments for invoking getEngineVersions.
type GetEngineVersionsArgs struct {
	// ID of the project to list available cluster versions for. Should match the project the cluster will be deployed to.
	// Defaults to the project that the provider is authenticated with.
	Project interface{}
	// Zone to list available cluster versions for. Should match the zone the cluster will be deployed in.
	Zone interface{}
}

// A collection of values returned by getEngineVersions.
type GetEngineVersionsResult struct {
	// Version of Kubernetes the service deploys by default.
	DefaultClusterVersion interface{}
	// The latest version available in the given zone for use with master instances.
	LatestMasterVersion interface{}
	// The latest version available in the given zone for use with node instances.
	LatestNodeVersion interface{}
	// A list of versions available in the given zone for use with master instances.
	ValidMasterVersions interface{}
	// A list of versions available in the given zone for use with node instances.
	ValidNodeVersions interface{}
}
