# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['OrganizationSecurityPolicy']


class OrganizationSecurityPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a OrganizationSecurityPolicy resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A textual description for the organization security policy.
        :param pulumi.Input[str] display_name: A textual name of the security policy.
        :param pulumi.Input[str] parent: The parent of this OrganizationSecurityPolicy in the Cloud Resource Hierarchy.
               Format: organizations/{organization_id} or folders/{folder_id}
        :param pulumi.Input[str] type: The type indicates the intended use of the security policy.
               For organization security policies, the only supported type
               is "FIREWALL".
               Default value is `FIREWALL`.
               Possible values are `FIREWALL`.
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
            if display_name is None:
                raise TypeError("Missing required property 'display_name'")
            __props__['display_name'] = display_name
            if parent is None:
                raise TypeError("Missing required property 'parent'")
            __props__['parent'] = parent
            __props__['type'] = type
            __props__['fingerprint'] = None
            __props__['policy_id'] = None
        super(OrganizationSecurityPolicy, __self__).__init__(
            'gcp:compute/organizationSecurityPolicy:OrganizationSecurityPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            fingerprint: Optional[pulumi.Input[str]] = None,
            parent: Optional[pulumi.Input[str]] = None,
            policy_id: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'OrganizationSecurityPolicy':
        """
        Get an existing OrganizationSecurityPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: A textual description for the organization security policy.
        :param pulumi.Input[str] display_name: A textual name of the security policy.
        :param pulumi.Input[str] fingerprint: Fingerprint of this resource. This field is used internally during updates of this resource.
        :param pulumi.Input[str] parent: The parent of this OrganizationSecurityPolicy in the Cloud Resource Hierarchy.
               Format: organizations/{organization_id} or folders/{folder_id}
        :param pulumi.Input[str] policy_id: The unique identifier for the resource. This identifier is defined by the server.
        :param pulumi.Input[str] type: The type indicates the intended use of the security policy.
               For organization security policies, the only supported type
               is "FIREWALL".
               Default value is `FIREWALL`.
               Possible values are `FIREWALL`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["display_name"] = display_name
        __props__["fingerprint"] = fingerprint
        __props__["parent"] = parent
        __props__["policy_id"] = policy_id
        __props__["type"] = type
        return OrganizationSecurityPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        A textual description for the organization security policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        A textual name of the security policy.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def fingerprint(self) -> pulumi.Output[str]:
        """
        Fingerprint of this resource. This field is used internally during updates of this resource.
        """
        return pulumi.get(self, "fingerprint")

    @property
    @pulumi.getter
    def parent(self) -> pulumi.Output[str]:
        """
        The parent of this OrganizationSecurityPolicy in the Cloud Resource Hierarchy.
        Format: organizations/{organization_id} or folders/{folder_id}
        """
        return pulumi.get(self, "parent")

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> pulumi.Output[str]:
        """
        The unique identifier for the resource. This identifier is defined by the server.
        """
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        The type indicates the intended use of the security policy.
        For organization security policies, the only supported type
        is "FIREWALL".
        Default value is `FIREWALL`.
        Possible values are `FIREWALL`.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

