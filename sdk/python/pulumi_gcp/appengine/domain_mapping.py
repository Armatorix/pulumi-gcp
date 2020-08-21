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

__all__ = ['DomainMapping']


class DomainMapping(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 domain_name: Optional[pulumi.Input[str]] = None,
                 override_strategy: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 ssl_settings: Optional[pulumi.Input[pulumi.InputType['DomainMappingSslSettingsArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A domain serving an App Engine application.

        To get more information about DomainMapping, see:

        * [API documentation](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.domainMappings)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/appengine/docs/standard/python/mapping-custom-domains)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_name: Relative name of the domain serving the application. Example: example.com.
        :param pulumi.Input[str] override_strategy: Whether the domain creation should override any existing mappings for this domain.
               By default, overrides are rejected.
               Default value is `STRICT`.
               Possible values are `STRICT` and `OVERRIDE`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[pulumi.InputType['DomainMappingSslSettingsArgs']] ssl_settings: SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.
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

            if domain_name is None:
                raise TypeError("Missing required property 'domain_name'")
            __props__['domain_name'] = domain_name
            __props__['override_strategy'] = override_strategy
            __props__['project'] = project
            __props__['ssl_settings'] = ssl_settings
            __props__['name'] = None
            __props__['resource_records'] = None
        super(DomainMapping, __self__).__init__(
            'gcp:appengine/domainMapping:DomainMapping',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            domain_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            override_strategy: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            resource_records: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['DomainMappingResourceRecordArgs']]]]] = None,
            ssl_settings: Optional[pulumi.Input[pulumi.InputType['DomainMappingSslSettingsArgs']]] = None) -> 'DomainMapping':
        """
        Get an existing DomainMapping resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] domain_name: Relative name of the domain serving the application. Example: example.com.
        :param pulumi.Input[str] name: Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
        :param pulumi.Input[str] override_strategy: Whether the domain creation should override any existing mappings for this domain.
               By default, overrides are rejected.
               Default value is `STRICT`.
               Possible values are `STRICT` and `OVERRIDE`.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['DomainMappingResourceRecordArgs']]]] resource_records: The resource records required to configure this domain mapping. These records must be added to the domain's DNS
               configuration in order to serve the application via this domain mapping.
        :param pulumi.Input[pulumi.InputType['DomainMappingSslSettingsArgs']] ssl_settings: SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.
               Structure is documented below.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["domain_name"] = domain_name
        __props__["name"] = name
        __props__["override_strategy"] = override_strategy
        __props__["project"] = project
        __props__["resource_records"] = resource_records
        __props__["ssl_settings"] = ssl_settings
        return DomainMapping(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="domainName")
    def domain_name(self) -> str:
        """
        Relative name of the domain serving the application. Example: example.com.
        """
        return pulumi.get(self, "domain_name")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="overrideStrategy")
    def override_strategy(self) -> Optional[str]:
        """
        Whether the domain creation should override any existing mappings for this domain.
        By default, overrides are rejected.
        Default value is `STRICT`.
        Possible values are `STRICT` and `OVERRIDE`.
        """
        return pulumi.get(self, "override_strategy")

    @property
    @pulumi.getter
    def project(self) -> str:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="resourceRecords")
    def resource_records(self) -> List['outputs.DomainMappingResourceRecord']:
        """
        The resource records required to configure this domain mapping. These records must be added to the domain's DNS
        configuration in order to serve the application via this domain mapping.
        """
        return pulumi.get(self, "resource_records")

    @property
    @pulumi.getter(name="sslSettings")
    def ssl_settings(self) -> Optional['outputs.DomainMappingSslSettings']:
        """
        SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.
        Structure is documented below.
        """
        return pulumi.get(self, "ssl_settings")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

