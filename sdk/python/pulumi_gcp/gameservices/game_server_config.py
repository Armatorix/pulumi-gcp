# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['GameServerConfig']


class GameServerConfig(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 config_id: Optional[pulumi.Input[str]] = None,
                 deployment_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 fleet_configs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigFleetConfigArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 scaling_configs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigScalingConfigArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A game server config resource. Configs are global and immutable.

        To get more information about GameServerConfig, see:

        * [API documentation](https://cloud.google.com/game-servers/docs/reference/rest/v1beta/projects.locations.gameServerDeployments.configs)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/game-servers/docs)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] config_id: A unique id for the deployment config.
        :param pulumi.Input[str] deployment_id: A unique id for the deployment.
        :param pulumi.Input[str] description: The description of the game server config.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigFleetConfigArgs']]]] fleet_configs: The fleet config contains list of fleet specs. In the Single Cloud, there
               will be only one.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Set of labels to group by.
        :param pulumi.Input[str] location: Location of the Deployment.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigScalingConfigArgs']]]] scaling_configs: Optional. This contains the autoscaling settings.
               Structure is documented below.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if config_id is None:
                raise TypeError("Missing required property 'config_id'")
            __props__['config_id'] = config_id
            if deployment_id is None:
                raise TypeError("Missing required property 'deployment_id'")
            __props__['deployment_id'] = deployment_id
            __props__['description'] = description
            if fleet_configs is None:
                raise TypeError("Missing required property 'fleet_configs'")
            __props__['fleet_configs'] = fleet_configs
            __props__['labels'] = labels
            __props__['location'] = location
            __props__['project'] = project
            __props__['scaling_configs'] = scaling_configs
            __props__['name'] = None
        super(GameServerConfig, __self__).__init__(
            'gcp:gameservices/gameServerConfig:GameServerConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            config_id: Optional[pulumi.Input[str]] = None,
            deployment_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            fleet_configs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigFleetConfigArgs']]]]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            location: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            scaling_configs: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigScalingConfigArgs']]]]] = None) -> 'GameServerConfig':
        """
        Get an existing GameServerConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] config_id: A unique id for the deployment config.
        :param pulumi.Input[str] deployment_id: A unique id for the deployment.
        :param pulumi.Input[str] description: The description of the game server config.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigFleetConfigArgs']]]] fleet_configs: The fleet config contains list of fleet specs. In the Single Cloud, there
               will be only one.
               Structure is documented below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Set of labels to group by.
        :param pulumi.Input[str] location: Location of the Deployment.
        :param pulumi.Input[str] name: The name of the ScalingConfig
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['GameServerConfigScalingConfigArgs']]]] scaling_configs: Optional. This contains the autoscaling settings.
               Structure is documented below.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["config_id"] = config_id
        __props__["deployment_id"] = deployment_id
        __props__["description"] = description
        __props__["fleet_configs"] = fleet_configs
        __props__["labels"] = labels
        __props__["location"] = location
        __props__["name"] = name
        __props__["project"] = project
        __props__["scaling_configs"] = scaling_configs
        return GameServerConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="configId")
    def config_id(self) -> pulumi.Output[str]:
        """
        A unique id for the deployment config.
        """
        return pulumi.get(self, "config_id")

    @property
    @pulumi.getter(name="deploymentId")
    def deployment_id(self) -> pulumi.Output[str]:
        """
        A unique id for the deployment.
        """
        return pulumi.get(self, "deployment_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        The description of the game server config.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="fleetConfigs")
    def fleet_configs(self) -> pulumi.Output[List['outputs.GameServerConfigFleetConfig']]:
        """
        The fleet config contains list of fleet specs. In the Single Cloud, there
        will be only one.
        Structure is documented below.
        """
        return pulumi.get(self, "fleet_configs")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Set of labels to group by.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        Location of the Deployment.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the ScalingConfig
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="scalingConfigs")
    def scaling_configs(self) -> pulumi.Output[Optional[List['outputs.GameServerConfigScalingConfig']]]:
        """
        Optional. This contains the autoscaling settings.
        Structure is documented below.
        """
        return pulumi.get(self, "scaling_configs")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

