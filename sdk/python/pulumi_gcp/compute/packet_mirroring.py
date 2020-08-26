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

__all__ = ['PacketMirroring']


class PacketMirroring(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 collector_ilb: Optional[pulumi.Input[pulumi.InputType['PacketMirroringCollectorIlbArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 filter: Optional[pulumi.Input[pulumi.InputType['PacketMirroringFilterArgs']]] = None,
                 mirrored_resources: Optional[pulumi.Input[pulumi.InputType['PacketMirroringMirroredResourcesArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network: Optional[pulumi.Input[pulumi.InputType['PacketMirroringNetworkArgs']]] = None,
                 priority: Optional[pulumi.Input[float]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Packet Mirroring mirrors traffic to and from particular VM instances.
        You can use the collected traffic to help you detect security threats
        and monitor application performance.

        To get more information about PacketMirroring, see:

        * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/packetMirroring)
        * How-to Guides
            * [Using Packet Mirroring](https://cloud.google.com/vpc/docs/using-packet-mirroring#creating)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['PacketMirroringCollectorIlbArgs']] collector_ilb: The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
               that will be used as collector for mirrored traffic. The
               specified forwarding rule must have is_mirroring_collector
               set to true.
               Structure is documented below.
        :param pulumi.Input[str] description: A human-readable description of the rule.
        :param pulumi.Input[pulumi.InputType['PacketMirroringFilterArgs']] filter: A filter for mirrored traffic.  If unset, all traffic is mirrored.
               Structure is documented below.
        :param pulumi.Input[pulumi.InputType['PacketMirroringMirroredResourcesArgs']] mirrored_resources: A means of specifying which resources to mirror.
               Structure is documented below.
        :param pulumi.Input[str] name: The name of the packet mirroring rule
        :param pulumi.Input[pulumi.InputType['PacketMirroringNetworkArgs']] network: Specifies the mirrored VPC network. Only packets in this network
               will be mirrored. All mirrored VMs should have a NIC in the given
               network. All mirrored subnetworks should belong to the given network.
               Structure is documented below.
        :param pulumi.Input[float] priority: Since only one rule can be active at a time, priority is
               used to break ties in the case of two rules that apply to
               the same instances.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: The Region in which the created address should reside.
               If it is not provided, the provider region is used.
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

            if collector_ilb is None:
                raise TypeError("Missing required property 'collector_ilb'")
            __props__['collector_ilb'] = collector_ilb
            __props__['description'] = description
            __props__['filter'] = filter
            if mirrored_resources is None:
                raise TypeError("Missing required property 'mirrored_resources'")
            __props__['mirrored_resources'] = mirrored_resources
            __props__['name'] = name
            if network is None:
                raise TypeError("Missing required property 'network'")
            __props__['network'] = network
            __props__['priority'] = priority
            __props__['project'] = project
            __props__['region'] = region
        super(PacketMirroring, __self__).__init__(
            'gcp:compute/packetMirroring:PacketMirroring',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            collector_ilb: Optional[pulumi.Input[pulumi.InputType['PacketMirroringCollectorIlbArgs']]] = None,
            description: Optional[pulumi.Input[str]] = None,
            filter: Optional[pulumi.Input[pulumi.InputType['PacketMirroringFilterArgs']]] = None,
            mirrored_resources: Optional[pulumi.Input[pulumi.InputType['PacketMirroringMirroredResourcesArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network: Optional[pulumi.Input[pulumi.InputType['PacketMirroringNetworkArgs']]] = None,
            priority: Optional[pulumi.Input[float]] = None,
            project: Optional[pulumi.Input[str]] = None,
            region: Optional[pulumi.Input[str]] = None) -> 'PacketMirroring':
        """
        Get an existing PacketMirroring resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['PacketMirroringCollectorIlbArgs']] collector_ilb: The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
               that will be used as collector for mirrored traffic. The
               specified forwarding rule must have is_mirroring_collector
               set to true.
               Structure is documented below.
        :param pulumi.Input[str] description: A human-readable description of the rule.
        :param pulumi.Input[pulumi.InputType['PacketMirroringFilterArgs']] filter: A filter for mirrored traffic.  If unset, all traffic is mirrored.
               Structure is documented below.
        :param pulumi.Input[pulumi.InputType['PacketMirroringMirroredResourcesArgs']] mirrored_resources: A means of specifying which resources to mirror.
               Structure is documented below.
        :param pulumi.Input[str] name: The name of the packet mirroring rule
        :param pulumi.Input[pulumi.InputType['PacketMirroringNetworkArgs']] network: Specifies the mirrored VPC network. Only packets in this network
               will be mirrored. All mirrored VMs should have a NIC in the given
               network. All mirrored subnetworks should belong to the given network.
               Structure is documented below.
        :param pulumi.Input[float] priority: Since only one rule can be active at a time, priority is
               used to break ties in the case of two rules that apply to
               the same instances.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] region: The Region in which the created address should reside.
               If it is not provided, the provider region is used.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["collector_ilb"] = collector_ilb
        __props__["description"] = description
        __props__["filter"] = filter
        __props__["mirrored_resources"] = mirrored_resources
        __props__["name"] = name
        __props__["network"] = network
        __props__["priority"] = priority
        __props__["project"] = project
        __props__["region"] = region
        return PacketMirroring(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="collectorIlb")
    def collector_ilb(self) -> pulumi.Output['outputs.PacketMirroringCollectorIlb']:
        """
        The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL)
        that will be used as collector for mirrored traffic. The
        specified forwarding rule must have is_mirroring_collector
        set to true.
        Structure is documented below.
        """
        return pulumi.get(self, "collector_ilb")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        A human-readable description of the rule.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def filter(self) -> pulumi.Output[Optional['outputs.PacketMirroringFilter']]:
        """
        A filter for mirrored traffic.  If unset, all traffic is mirrored.
        Structure is documented below.
        """
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter(name="mirroredResources")
    def mirrored_resources(self) -> pulumi.Output['outputs.PacketMirroringMirroredResources']:
        """
        A means of specifying which resources to mirror.
        Structure is documented below.
        """
        return pulumi.get(self, "mirrored_resources")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the packet mirroring rule
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def network(self) -> pulumi.Output['outputs.PacketMirroringNetwork']:
        """
        Specifies the mirrored VPC network. Only packets in this network
        will be mirrored. All mirrored VMs should have a NIC in the given
        network. All mirrored subnetworks should belong to the given network.
        Structure is documented below.
        """
        return pulumi.get(self, "network")

    @property
    @pulumi.getter
    def priority(self) -> pulumi.Output[float]:
        """
        Since only one rule can be active at a time, priority is
        used to break ties in the case of two rules that apply to
        the same instances.
        """
        return pulumi.get(self, "priority")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def region(self) -> pulumi.Output[str]:
        """
        The Region in which the created address should reside.
        If it is not provided, the provider region is used.
        """
        return pulumi.get(self, "region")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

