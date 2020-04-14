// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package gameservices

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// This represents the rollout state. This is part of the game server
// deployment.
//
// To get more information about GameServerDeploymentRollout, see:
//
// * [API documentation](https://cloud.google.com/game-servers/docs/reference/rest/v1beta/GameServerDeploymentRollout)
// * How-to Guides
//     * [Official Documentation](https://cloud.google.com/game-servers/docs)
type GameServerDeploymentRollout struct {
	pulumi.CustomResourceState

	// This field points to the game server config that is applied by default to all realms and clusters. For example,
	// 'projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config'.
	DefaultGameServerConfig pulumi.StringOutput `pulumi:"defaultGameServerConfig"`
	// The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
	DeploymentId pulumi.StringOutput `pulumi:"deploymentId"`
	// The game_server_config_overrides contains the per game server config overrides. The overrides are processed in the order
	// they are listed. As soon as a match is found for a cluster, the rest of the list is not processed.
	GameServerConfigOverrides GameServerDeploymentRolloutGameServerConfigOverrideArrayOutput `pulumi:"gameServerConfigOverrides"`
	// The resource id of the game server deployment eg:
	// 'projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout'.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
}

// NewGameServerDeploymentRollout registers a new resource with the given unique name, arguments, and options.
func NewGameServerDeploymentRollout(ctx *pulumi.Context,
	name string, args *GameServerDeploymentRolloutArgs, opts ...pulumi.ResourceOption) (*GameServerDeploymentRollout, error) {
	if args == nil || args.DefaultGameServerConfig == nil {
		return nil, errors.New("missing required argument 'DefaultGameServerConfig'")
	}
	if args == nil || args.DeploymentId == nil {
		return nil, errors.New("missing required argument 'DeploymentId'")
	}
	if args == nil {
		args = &GameServerDeploymentRolloutArgs{}
	}
	var resource GameServerDeploymentRollout
	err := ctx.RegisterResource("gcp:gameservices/gameServerDeploymentRollout:GameServerDeploymentRollout", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGameServerDeploymentRollout gets an existing GameServerDeploymentRollout resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGameServerDeploymentRollout(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GameServerDeploymentRolloutState, opts ...pulumi.ResourceOption) (*GameServerDeploymentRollout, error) {
	var resource GameServerDeploymentRollout
	err := ctx.ReadResource("gcp:gameservices/gameServerDeploymentRollout:GameServerDeploymentRollout", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering GameServerDeploymentRollout resources.
type gameServerDeploymentRolloutState struct {
	// This field points to the game server config that is applied by default to all realms and clusters. For example,
	// 'projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config'.
	DefaultGameServerConfig *string `pulumi:"defaultGameServerConfig"`
	// The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
	DeploymentId *string `pulumi:"deploymentId"`
	// The game_server_config_overrides contains the per game server config overrides. The overrides are processed in the order
	// they are listed. As soon as a match is found for a cluster, the rest of the list is not processed.
	GameServerConfigOverrides []GameServerDeploymentRolloutGameServerConfigOverride `pulumi:"gameServerConfigOverrides"`
	// The resource id of the game server deployment eg:
	// 'projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout'.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

type GameServerDeploymentRolloutState struct {
	// This field points to the game server config that is applied by default to all realms and clusters. For example,
	// 'projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config'.
	DefaultGameServerConfig pulumi.StringPtrInput
	// The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
	DeploymentId pulumi.StringPtrInput
	// The game_server_config_overrides contains the per game server config overrides. The overrides are processed in the order
	// they are listed. As soon as a match is found for a cluster, the rest of the list is not processed.
	GameServerConfigOverrides GameServerDeploymentRolloutGameServerConfigOverrideArrayInput
	// The resource id of the game server deployment eg:
	// 'projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout'.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (GameServerDeploymentRolloutState) ElementType() reflect.Type {
	return reflect.TypeOf((*gameServerDeploymentRolloutState)(nil)).Elem()
}

type gameServerDeploymentRolloutArgs struct {
	// This field points to the game server config that is applied by default to all realms and clusters. For example,
	// 'projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config'.
	DefaultGameServerConfig string `pulumi:"defaultGameServerConfig"`
	// The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
	DeploymentId string `pulumi:"deploymentId"`
	// The game_server_config_overrides contains the per game server config overrides. The overrides are processed in the order
	// they are listed. As soon as a match is found for a cluster, the rest of the list is not processed.
	GameServerConfigOverrides []GameServerDeploymentRolloutGameServerConfigOverride `pulumi:"gameServerConfigOverrides"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
}

// The set of arguments for constructing a GameServerDeploymentRollout resource.
type GameServerDeploymentRolloutArgs struct {
	// This field points to the game server config that is applied by default to all realms and clusters. For example,
	// 'projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config'.
	DefaultGameServerConfig pulumi.StringInput
	// The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
	DeploymentId pulumi.StringInput
	// The game_server_config_overrides contains the per game server config overrides. The overrides are processed in the order
	// they are listed. As soon as a match is found for a cluster, the rest of the list is not processed.
	GameServerConfigOverrides GameServerDeploymentRolloutGameServerConfigOverrideArrayInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
}

func (GameServerDeploymentRolloutArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gameServerDeploymentRolloutArgs)(nil)).Elem()
}
