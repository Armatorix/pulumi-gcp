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

__all__ = ['InstanceGroup']


class InstanceGroup(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 instances: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 named_ports: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['InstanceGroupNamedPortArgs']]]]] = None,
                 network: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Creates a group of dissimilar Compute Engine virtual machine instances.
        For more information, see [the official documentation](https://cloud.google.com/compute/docs/instance-groups/#unmanaged_instance_groups)
        and [API](https://cloud.google.com/compute/docs/reference/latest/instanceGroups)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: An optional textual description of the instance
               group.
        :param pulumi.Input[List[pulumi.Input[str]]] instances: List of instances in the group. They should be given
               as either self_link or id. When adding instances they must all be in the same
               network and zone as the instance group.
        :param pulumi.Input[str] name: The name which the port will be mapped to.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['InstanceGroupNamedPortArgs']]]] named_ports: The named port configuration. See the section below
               for details on configuration.
        :param pulumi.Input[str] network: The URL of the network the instance group is in. If
               this is different from the network where the instances are in, the creation
               fails. Defaults to the network where the instances are in (if neither
               `network` nor `instances` is specified, this field will be blank).
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.
        :param pulumi.Input[str] zone: The zone that this instance group should be created in.
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

            __props__['description'] = description
            __props__['instances'] = instances
            __props__['name'] = name
            __props__['named_ports'] = named_ports
            __props__['network'] = network
            __props__['project'] = project
            __props__['zone'] = zone
            __props__['self_link'] = None
            __props__['size'] = None
        super(InstanceGroup, __self__).__init__(
            'gcp:compute/instanceGroup:InstanceGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            instances: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            named_ports: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['InstanceGroupNamedPortArgs']]]]] = None,
            network: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            self_link: Optional[pulumi.Input[str]] = None,
            size: Optional[pulumi.Input[float]] = None,
            zone: Optional[pulumi.Input[str]] = None) -> 'InstanceGroup':
        """
        Get an existing InstanceGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: An optional textual description of the instance
               group.
        :param pulumi.Input[List[pulumi.Input[str]]] instances: List of instances in the group. They should be given
               as either self_link or id. When adding instances they must all be in the same
               network and zone as the instance group.
        :param pulumi.Input[str] name: The name which the port will be mapped to.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['InstanceGroupNamedPortArgs']]]] named_ports: The named port configuration. See the section below
               for details on configuration.
        :param pulumi.Input[str] network: The URL of the network the instance group is in. If
               this is different from the network where the instances are in, the creation
               fails. Defaults to the network where the instances are in (if neither
               `network` nor `instances` is specified, this field will be blank).
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.
        :param pulumi.Input[float] size: The number of instances in the group.
        :param pulumi.Input[str] zone: The zone that this instance group should be created in.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["instances"] = instances
        __props__["name"] = name
        __props__["named_ports"] = named_ports
        __props__["network"] = network
        __props__["project"] = project
        __props__["self_link"] = self_link
        __props__["size"] = size
        __props__["zone"] = zone
        return InstanceGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        An optional textual description of the instance
        group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def instances(self) -> pulumi.Output[List[str]]:
        """
        List of instances in the group. They should be given
        as either self_link or id. When adding instances they must all be in the same
        network and zone as the instance group.
        """
        return pulumi.get(self, "instances")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name which the port will be mapped to.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="namedPorts")
    def named_ports(self) -> pulumi.Output[Optional[List['outputs.InstanceGroupNamedPort']]]:
        """
        The named port configuration. See the section below
        for details on configuration.
        """
        return pulumi.get(self, "named_ports")

    @property
    @pulumi.getter
    def network(self) -> pulumi.Output[str]:
        """
        The URL of the network the instance group is in. If
        this is different from the network where the instances are in, the creation
        fails. Defaults to the network where the instances are in (if neither
        `network` nor `instances` is specified, this field will be blank).
        """
        return pulumi.get(self, "network")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs. If it
        is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> pulumi.Output[str]:
        """
        The URI of the created resource.
        """
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter
    def size(self) -> pulumi.Output[float]:
        """
        The number of instances in the group.
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[str]:
        """
        The zone that this instance group should be created in.
        """
        return pulumi.get(self, "zone")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

