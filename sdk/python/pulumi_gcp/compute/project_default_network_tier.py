# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class ProjectDefaultNetworkTier(pulumi.CustomResource):
    network_tier: pulumi.Output[str]
    """
    The default network tier to be configured for the project.
    This field can take the following values: `PREMIUM` or `STANDARD`.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs. If it
    is not provided, the provider project is used.
    """
    def __init__(__self__, resource_name, opts=None, network_tier=None, project=None, __props__=None, __name__=None, __opts__=None):
        """
        Configures the Google Compute Engine
        [Default Network Tier](https://cloud.google.com/network-tiers/docs/using-network-service-tiers#setting_the_tier_for_all_resources_in_a_project)
        for a project.
        
        For more information, see,
        [the Project API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/projects/setDefaultNetworkTier).
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] network_tier: The default network tier to be configured for the project.
               This field can take the following values: `PREMIUM` or `STANDARD`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_project_default_network_tier.html.markdown.
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

            if network_tier is None:
                raise TypeError("Missing required property 'network_tier'")
            __props__['network_tier'] = network_tier
            __props__['project'] = project
        super(ProjectDefaultNetworkTier, __self__).__init__(
            'gcp:compute/projectDefaultNetworkTier:ProjectDefaultNetworkTier',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, network_tier=None, project=None):
        """
        Get an existing ProjectDefaultNetworkTier resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] network_tier: The default network tier to be configured for the project.
               This field can take the following values: `PREMIUM` or `STANDARD`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_project_default_network_tier.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["network_tier"] = network_tier
        __props__["project"] = project
        return ProjectDefaultNetworkTier(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

