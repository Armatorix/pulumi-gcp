# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class SubnetworkIAMPolicy(pulumi.CustomResource):
    etag: pulumi.Output[str]
    """
    (Computed) The etag of the subnetwork's IAM policy.
    """
    policy_data: pulumi.Output[str]
    """
    The policy data generated by
    a `organizations.getIAMPolicy` data source.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs. If it
    is not provided, the provider project is used.
    """
    region: pulumi.Output[str]
    """
    The region of the subnetwork. If
    unspecified, this defaults to the region configured in the provider.
    """
    subnetwork: pulumi.Output[str]
    """
    The name of the subnetwork.
    """
    def __init__(__self__, resource_name, opts=None, policy_data=None, project=None, region=None, subnetwork=None, __props__=None, __name__=None, __opts__=None):
        """
        Create a SubnetworkIAMPolicy resource with the given unique name, props, and options.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] policy_data: The policy data generated by
               a `organizations.getIAMPolicy` data source.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.
        :param pulumi.Input[str] region: The region of the subnetwork. If
               unspecified, this defaults to the region configured in the provider.
        :param pulumi.Input[str] subnetwork: The name of the subnetwork.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_subnetwork_iam_policy.html.markdown.
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

            if policy_data is None:
                raise TypeError("Missing required property 'policy_data'")
            __props__['policy_data'] = policy_data
            __props__['project'] = project
            __props__['region'] = region
            if subnetwork is None:
                raise TypeError("Missing required property 'subnetwork'")
            __props__['subnetwork'] = subnetwork
            __props__['etag'] = None
        super(SubnetworkIAMPolicy, __self__).__init__(
            'gcp:compute/subnetworkIAMPolicy:SubnetworkIAMPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, etag=None, policy_data=None, project=None, region=None, subnetwork=None):
        """
        Get an existing SubnetworkIAMPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] etag: (Computed) The etag of the subnetwork's IAM policy.
        :param pulumi.Input[str] policy_data: The policy data generated by
               a `organizations.getIAMPolicy` data source.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs. If it
               is not provided, the provider project is used.
        :param pulumi.Input[str] region: The region of the subnetwork. If
               unspecified, this defaults to the region configured in the provider.
        :param pulumi.Input[str] subnetwork: The name of the subnetwork.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_subnetwork_iam_policy.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["etag"] = etag
        __props__["policy_data"] = policy_data
        __props__["project"] = project
        __props__["region"] = region
        __props__["subnetwork"] = subnetwork
        return SubnetworkIAMPolicy(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

