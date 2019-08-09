# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Firewall(pulumi.CustomResource):
    allows: pulumi.Output[list]
    creation_timestamp: pulumi.Output[str]
    denies: pulumi.Output[list]
    description: pulumi.Output[str]
    destination_ranges: pulumi.Output[list]
    direction: pulumi.Output[str]
    disabled: pulumi.Output[bool]
    enable_logging: pulumi.Output[bool]
    name: pulumi.Output[str]
    network: pulumi.Output[str]
    priority: pulumi.Output[float]
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    source_ranges: pulumi.Output[list]
    source_service_accounts: pulumi.Output[list]
    source_tags: pulumi.Output[list]
    target_service_accounts: pulumi.Output[list]
    target_tags: pulumi.Output[list]
    def __init__(__self__, resource_name, opts=None, allows=None, denies=None, description=None, destination_ranges=None, direction=None, disabled=None, enable_logging=None, name=None, network=None, priority=None, project=None, source_ranges=None, source_service_accounts=None, source_tags=None, target_service_accounts=None, target_tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Each network has its own firewall controlling access to and from the
        instances.
        
        All traffic to instances, even from other instances, is blocked by the
        firewall unless firewall rules are created to allow it.
        
        The default network has automatically created firewall rules that are
        shown in default firewall rules. No manually created network has
        automatically created firewall rules except for a default "allow" rule for
        outgoing traffic and a default "deny" for incoming traffic. For all
        networks except the default network, you must create any firewall rules
        you need.
        
        
        To get more information about Firewall, see:
        
        * [API documentation](https://cloud.google.com/compute/docs/reference/v1/firewalls)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/vpc/docs/firewalls)
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_firewall.html.markdown.
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
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['allows'] = allows
            __props__['denies'] = denies
            __props__['description'] = description
            __props__['destination_ranges'] = destination_ranges
            __props__['direction'] = direction
            __props__['disabled'] = disabled
            __props__['enable_logging'] = enable_logging
            __props__['name'] = name
            if network is None:
                raise TypeError("Missing required property 'network'")
            __props__['network'] = network
            __props__['priority'] = priority
            __props__['project'] = project
            __props__['source_ranges'] = source_ranges
            __props__['source_service_accounts'] = source_service_accounts
            __props__['source_tags'] = source_tags
            __props__['target_service_accounts'] = target_service_accounts
            __props__['target_tags'] = target_tags
            __props__['creation_timestamp'] = None
            __props__['self_link'] = None
        super(Firewall, __self__).__init__(
            'gcp:compute/firewall:Firewall',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, allows=None, creation_timestamp=None, denies=None, description=None, destination_ranges=None, direction=None, disabled=None, enable_logging=None, name=None, network=None, priority=None, project=None, self_link=None, source_ranges=None, source_service_accounts=None, source_tags=None, target_service_accounts=None, target_tags=None):
        """
        Get an existing Firewall resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_firewall.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["allows"] = allows
        __props__["creation_timestamp"] = creation_timestamp
        __props__["denies"] = denies
        __props__["description"] = description
        __props__["destination_ranges"] = destination_ranges
        __props__["direction"] = direction
        __props__["disabled"] = disabled
        __props__["enable_logging"] = enable_logging
        __props__["name"] = name
        __props__["network"] = network
        __props__["priority"] = priority
        __props__["project"] = project
        __props__["self_link"] = self_link
        __props__["source_ranges"] = source_ranges
        __props__["source_service_accounts"] = source_service_accounts
        __props__["source_tags"] = source_tags
        __props__["target_service_accounts"] = target_service_accounts
        __props__["target_tags"] = target_tags
        return Firewall(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

