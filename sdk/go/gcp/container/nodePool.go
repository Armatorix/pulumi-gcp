// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package container

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a node pool in a Google Kubernetes Engine (GKE) cluster separately from
// the cluster control plane. For more information see [the official documentation](https://cloud.google.com/container-engine/docs/node-pools)
// and [the API reference](https://cloud.google.com/kubernetes-engine/docs/reference/rest/v1beta1/projects.locations.clusters.nodePools).
//
// ## Example Usage
type NodePool struct {
	pulumi.CustomResourceState

	// Configuration required by cluster autoscaler to adjust
	// the size of the node pool to the current cluster usage. Structure is documented below.
	Autoscaling NodePoolAutoscalingPtrOutput `pulumi:"autoscaling"`
	// The cluster to create the node pool for. Cluster must be present in `location` provided for zonal clusters.
	Cluster pulumi.StringOutput `pulumi:"cluster"`
	// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone.
	// Changing this will force recreation of the resource.
	InitialNodeCount pulumi.IntOutput `pulumi:"initialNodeCount"`
	// The resource URLs of the managed instance groups associated with this node pool.
	InstanceGroupUrls pulumi.StringArrayOutput `pulumi:"instanceGroupUrls"`
	// The location (region or zone) of the cluster.
	Location pulumi.StringOutput `pulumi:"location"`
	// Node management configuration, wherein auto-repair and
	// auto-upgrade is configured. Structure is documented below.
	Management NodePoolManagementOutput `pulumi:"management"`
	// The maximum number of pods per node in this node pool.
	// Note that this does not work on node pools which are "route-based" - that is, node
	// pools belonging to clusters that do not have IP Aliasing enabled.
	// See the [official documentation](https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr)
	// for more information.
	MaxPodsPerNode pulumi.IntOutput `pulumi:"maxPodsPerNode"`
	// The name of the node pool. If left blank, the provider will
	// auto-generate a unique name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Creates a unique name for the node pool beginning
	// with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringOutput `pulumi:"namePrefix"`
	// The node configuration of the pool. See
	// container.Cluster for schema.
	NodeConfig NodePoolNodeConfigOutput `pulumi:"nodeConfig"`
	// The number of nodes per instance group. This field can be used to
	// update the number of nodes per instance group but should not be used alongside `autoscaling`.
	NodeCount pulumi.IntOutput `pulumi:"nodeCount"`
	// The list of zones in which the node pool's nodes should be located. Nodes must
	// be in the region of their regional cluster or in the same region as their
	// cluster's zone for zonal clusters. If unspecified, the cluster-level
	// `nodeLocations` will be used.
	NodeLocations pulumi.StringArrayOutput `pulumi:"nodeLocations"`
	// The ID of the project in which to create the node pool. If blank,
	// the provider-configured project will be used.
	Project pulumi.StringOutput `pulumi:"project"`
	// Specify node upgrade settings to change how many nodes GKE attempts to
	// upgrade at once. The number of nodes upgraded simultaneously is the sum of `maxSurge` and `maxUnavailable`.
	// The maximum number of nodes upgraded simultaneously is limited to 20.
	UpgradeSettings NodePoolUpgradeSettingsOutput `pulumi:"upgradeSettings"`
	// The Kubernetes version for the nodes in this pool. Note that if this field
	// and `autoUpgrade` are both specified, they will fight each other for what the node version should
	// be, so setting both is highly discouraged. While a fuzzy version can be specified, it's
	// recommended that you specify explicit versions as the provider will see spurious diffs
	// when fuzzy versions are used. See the `container.getEngineVersions` data source's
	// `versionPrefix` field to approximate fuzzy versions in a provider-compatible way.
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewNodePool registers a new resource with the given unique name, arguments, and options.
func NewNodePool(ctx *pulumi.Context,
	name string, args *NodePoolArgs, opts ...pulumi.ResourceOption) (*NodePool, error) {
	if args == nil || args.Cluster == nil {
		return nil, errors.New("missing required argument 'Cluster'")
	}
	if args == nil {
		args = &NodePoolArgs{}
	}
	var resource NodePool
	err := ctx.RegisterResource("gcp:container/nodePool:NodePool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNodePool gets an existing NodePool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNodePool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NodePoolState, opts ...pulumi.ResourceOption) (*NodePool, error) {
	var resource NodePool
	err := ctx.ReadResource("gcp:container/nodePool:NodePool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NodePool resources.
type nodePoolState struct {
	// Configuration required by cluster autoscaler to adjust
	// the size of the node pool to the current cluster usage. Structure is documented below.
	Autoscaling *NodePoolAutoscaling `pulumi:"autoscaling"`
	// The cluster to create the node pool for. Cluster must be present in `location` provided for zonal clusters.
	Cluster *string `pulumi:"cluster"`
	// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone.
	// Changing this will force recreation of the resource.
	InitialNodeCount *int `pulumi:"initialNodeCount"`
	// The resource URLs of the managed instance groups associated with this node pool.
	InstanceGroupUrls []string `pulumi:"instanceGroupUrls"`
	// The location (region or zone) of the cluster.
	Location *string `pulumi:"location"`
	// Node management configuration, wherein auto-repair and
	// auto-upgrade is configured. Structure is documented below.
	Management *NodePoolManagement `pulumi:"management"`
	// The maximum number of pods per node in this node pool.
	// Note that this does not work on node pools which are "route-based" - that is, node
	// pools belonging to clusters that do not have IP Aliasing enabled.
	// See the [official documentation](https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr)
	// for more information.
	MaxPodsPerNode *int `pulumi:"maxPodsPerNode"`
	// The name of the node pool. If left blank, the provider will
	// auto-generate a unique name.
	Name *string `pulumi:"name"`
	// Creates a unique name for the node pool beginning
	// with the specified prefix. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// The node configuration of the pool. See
	// container.Cluster for schema.
	NodeConfig *NodePoolNodeConfig `pulumi:"nodeConfig"`
	// The number of nodes per instance group. This field can be used to
	// update the number of nodes per instance group but should not be used alongside `autoscaling`.
	NodeCount *int `pulumi:"nodeCount"`
	// The list of zones in which the node pool's nodes should be located. Nodes must
	// be in the region of their regional cluster or in the same region as their
	// cluster's zone for zonal clusters. If unspecified, the cluster-level
	// `nodeLocations` will be used.
	NodeLocations []string `pulumi:"nodeLocations"`
	// The ID of the project in which to create the node pool. If blank,
	// the provider-configured project will be used.
	Project *string `pulumi:"project"`
	// Specify node upgrade settings to change how many nodes GKE attempts to
	// upgrade at once. The number of nodes upgraded simultaneously is the sum of `maxSurge` and `maxUnavailable`.
	// The maximum number of nodes upgraded simultaneously is limited to 20.
	UpgradeSettings *NodePoolUpgradeSettings `pulumi:"upgradeSettings"`
	// The Kubernetes version for the nodes in this pool. Note that if this field
	// and `autoUpgrade` are both specified, they will fight each other for what the node version should
	// be, so setting both is highly discouraged. While a fuzzy version can be specified, it's
	// recommended that you specify explicit versions as the provider will see spurious diffs
	// when fuzzy versions are used. See the `container.getEngineVersions` data source's
	// `versionPrefix` field to approximate fuzzy versions in a provider-compatible way.
	Version *string `pulumi:"version"`
}

type NodePoolState struct {
	// Configuration required by cluster autoscaler to adjust
	// the size of the node pool to the current cluster usage. Structure is documented below.
	Autoscaling NodePoolAutoscalingPtrInput
	// The cluster to create the node pool for. Cluster must be present in `location` provided for zonal clusters.
	Cluster pulumi.StringPtrInput
	// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone.
	// Changing this will force recreation of the resource.
	InitialNodeCount pulumi.IntPtrInput
	// The resource URLs of the managed instance groups associated with this node pool.
	InstanceGroupUrls pulumi.StringArrayInput
	// The location (region or zone) of the cluster.
	Location pulumi.StringPtrInput
	// Node management configuration, wherein auto-repair and
	// auto-upgrade is configured. Structure is documented below.
	Management NodePoolManagementPtrInput
	// The maximum number of pods per node in this node pool.
	// Note that this does not work on node pools which are "route-based" - that is, node
	// pools belonging to clusters that do not have IP Aliasing enabled.
	// See the [official documentation](https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr)
	// for more information.
	MaxPodsPerNode pulumi.IntPtrInput
	// The name of the node pool. If left blank, the provider will
	// auto-generate a unique name.
	Name pulumi.StringPtrInput
	// Creates a unique name for the node pool beginning
	// with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// The node configuration of the pool. See
	// container.Cluster for schema.
	NodeConfig NodePoolNodeConfigPtrInput
	// The number of nodes per instance group. This field can be used to
	// update the number of nodes per instance group but should not be used alongside `autoscaling`.
	NodeCount pulumi.IntPtrInput
	// The list of zones in which the node pool's nodes should be located. Nodes must
	// be in the region of their regional cluster or in the same region as their
	// cluster's zone for zonal clusters. If unspecified, the cluster-level
	// `nodeLocations` will be used.
	NodeLocations pulumi.StringArrayInput
	// The ID of the project in which to create the node pool. If blank,
	// the provider-configured project will be used.
	Project pulumi.StringPtrInput
	// Specify node upgrade settings to change how many nodes GKE attempts to
	// upgrade at once. The number of nodes upgraded simultaneously is the sum of `maxSurge` and `maxUnavailable`.
	// The maximum number of nodes upgraded simultaneously is limited to 20.
	UpgradeSettings NodePoolUpgradeSettingsPtrInput
	// The Kubernetes version for the nodes in this pool. Note that if this field
	// and `autoUpgrade` are both specified, they will fight each other for what the node version should
	// be, so setting both is highly discouraged. While a fuzzy version can be specified, it's
	// recommended that you specify explicit versions as the provider will see spurious diffs
	// when fuzzy versions are used. See the `container.getEngineVersions` data source's
	// `versionPrefix` field to approximate fuzzy versions in a provider-compatible way.
	Version pulumi.StringPtrInput
}

func (NodePoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*nodePoolState)(nil)).Elem()
}

type nodePoolArgs struct {
	// Configuration required by cluster autoscaler to adjust
	// the size of the node pool to the current cluster usage. Structure is documented below.
	Autoscaling *NodePoolAutoscaling `pulumi:"autoscaling"`
	// The cluster to create the node pool for. Cluster must be present in `location` provided for zonal clusters.
	Cluster string `pulumi:"cluster"`
	// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone.
	// Changing this will force recreation of the resource.
	InitialNodeCount *int `pulumi:"initialNodeCount"`
	// The location (region or zone) of the cluster.
	Location *string `pulumi:"location"`
	// Node management configuration, wherein auto-repair and
	// auto-upgrade is configured. Structure is documented below.
	Management *NodePoolManagement `pulumi:"management"`
	// The maximum number of pods per node in this node pool.
	// Note that this does not work on node pools which are "route-based" - that is, node
	// pools belonging to clusters that do not have IP Aliasing enabled.
	// See the [official documentation](https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr)
	// for more information.
	MaxPodsPerNode *int `pulumi:"maxPodsPerNode"`
	// The name of the node pool. If left blank, the provider will
	// auto-generate a unique name.
	Name *string `pulumi:"name"`
	// Creates a unique name for the node pool beginning
	// with the specified prefix. Conflicts with `name`.
	NamePrefix *string `pulumi:"namePrefix"`
	// The node configuration of the pool. See
	// container.Cluster for schema.
	NodeConfig *NodePoolNodeConfig `pulumi:"nodeConfig"`
	// The number of nodes per instance group. This field can be used to
	// update the number of nodes per instance group but should not be used alongside `autoscaling`.
	NodeCount *int `pulumi:"nodeCount"`
	// The list of zones in which the node pool's nodes should be located. Nodes must
	// be in the region of their regional cluster or in the same region as their
	// cluster's zone for zonal clusters. If unspecified, the cluster-level
	// `nodeLocations` will be used.
	NodeLocations []string `pulumi:"nodeLocations"`
	// The ID of the project in which to create the node pool. If blank,
	// the provider-configured project will be used.
	Project *string `pulumi:"project"`
	// Specify node upgrade settings to change how many nodes GKE attempts to
	// upgrade at once. The number of nodes upgraded simultaneously is the sum of `maxSurge` and `maxUnavailable`.
	// The maximum number of nodes upgraded simultaneously is limited to 20.
	UpgradeSettings *NodePoolUpgradeSettings `pulumi:"upgradeSettings"`
	// The Kubernetes version for the nodes in this pool. Note that if this field
	// and `autoUpgrade` are both specified, they will fight each other for what the node version should
	// be, so setting both is highly discouraged. While a fuzzy version can be specified, it's
	// recommended that you specify explicit versions as the provider will see spurious diffs
	// when fuzzy versions are used. See the `container.getEngineVersions` data source's
	// `versionPrefix` field to approximate fuzzy versions in a provider-compatible way.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a NodePool resource.
type NodePoolArgs struct {
	// Configuration required by cluster autoscaler to adjust
	// the size of the node pool to the current cluster usage. Structure is documented below.
	Autoscaling NodePoolAutoscalingPtrInput
	// The cluster to create the node pool for. Cluster must be present in `location` provided for zonal clusters.
	Cluster pulumi.StringInput
	// The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone.
	// Changing this will force recreation of the resource.
	InitialNodeCount pulumi.IntPtrInput
	// The location (region or zone) of the cluster.
	Location pulumi.StringPtrInput
	// Node management configuration, wherein auto-repair and
	// auto-upgrade is configured. Structure is documented below.
	Management NodePoolManagementPtrInput
	// The maximum number of pods per node in this node pool.
	// Note that this does not work on node pools which are "route-based" - that is, node
	// pools belonging to clusters that do not have IP Aliasing enabled.
	// See the [official documentation](https://cloud.google.com/kubernetes-engine/docs/how-to/flexible-pod-cidr)
	// for more information.
	MaxPodsPerNode pulumi.IntPtrInput
	// The name of the node pool. If left blank, the provider will
	// auto-generate a unique name.
	Name pulumi.StringPtrInput
	// Creates a unique name for the node pool beginning
	// with the specified prefix. Conflicts with `name`.
	NamePrefix pulumi.StringPtrInput
	// The node configuration of the pool. See
	// container.Cluster for schema.
	NodeConfig NodePoolNodeConfigPtrInput
	// The number of nodes per instance group. This field can be used to
	// update the number of nodes per instance group but should not be used alongside `autoscaling`.
	NodeCount pulumi.IntPtrInput
	// The list of zones in which the node pool's nodes should be located. Nodes must
	// be in the region of their regional cluster or in the same region as their
	// cluster's zone for zonal clusters. If unspecified, the cluster-level
	// `nodeLocations` will be used.
	NodeLocations pulumi.StringArrayInput
	// The ID of the project in which to create the node pool. If blank,
	// the provider-configured project will be used.
	Project pulumi.StringPtrInput
	// Specify node upgrade settings to change how many nodes GKE attempts to
	// upgrade at once. The number of nodes upgraded simultaneously is the sum of `maxSurge` and `maxUnavailable`.
	// The maximum number of nodes upgraded simultaneously is limited to 20.
	UpgradeSettings NodePoolUpgradeSettingsPtrInput
	// The Kubernetes version for the nodes in this pool. Note that if this field
	// and `autoUpgrade` are both specified, they will fight each other for what the node version should
	// be, so setting both is highly discouraged. While a fuzzy version can be specified, it's
	// recommended that you specify explicit versions as the provider will see spurious diffs
	// when fuzzy versions are used. See the `container.getEngineVersions` data source's
	// `versionPrefix` field to approximate fuzzy versions in a provider-compatible way.
	Version pulumi.StringPtrInput
}

func (NodePoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*nodePoolArgs)(nil)).Elem()
}
