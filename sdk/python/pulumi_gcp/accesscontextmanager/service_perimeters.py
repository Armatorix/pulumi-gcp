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

__all__ = ['ServicePerimeters']


class ServicePerimeters(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 parent: Optional[pulumi.Input[str]] = None,
                 service_perimeters: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ServicePerimetersServicePerimeterArgs']]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Replace all existing Service Perimeters in an Access Policy with the Service Perimeters provided. This is done atomically.
        This is a bulk edit of all Service Perimeters and may override existing Service Perimeters created by `accesscontextmanager.ServicePerimeter`,
        thus causing a permadiff if used alongside `accesscontextmanager.ServicePerimeter` on the same parent.

        To get more information about ServicePerimeters, see:

        * [API documentation](https://cloud.google.com/access-context-manager/docs/reference/rest/v1/accessPolicies.servicePerimeters)
        * How-to Guides
            * [Service Perimeter Quickstart](https://cloud.google.com/vpc-service-controls/docs/quickstart)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] parent: The AccessPolicy this ServicePerimeter lives in.
               Format: accessPolicies/{policy_id}
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ServicePerimetersServicePerimeterArgs']]]] service_perimeters: The desired Service Perimeters that should replace all existing Service Perimeters in the Access Policy.
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

            if parent is None:
                raise TypeError("Missing required property 'parent'")
            __props__['parent'] = parent
            __props__['service_perimeters'] = service_perimeters
        super(ServicePerimeters, __self__).__init__(
            'gcp:accesscontextmanager/servicePerimeters:ServicePerimeters',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            parent: Optional[pulumi.Input[str]] = None,
            service_perimeters: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ServicePerimetersServicePerimeterArgs']]]]] = None) -> 'ServicePerimeters':
        """
        Get an existing ServicePerimeters resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] parent: The AccessPolicy this ServicePerimeter lives in.
               Format: accessPolicies/{policy_id}
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ServicePerimetersServicePerimeterArgs']]]] service_perimeters: The desired Service Perimeters that should replace all existing Service Perimeters in the Access Policy.
               Structure is documented below.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["parent"] = parent
        __props__["service_perimeters"] = service_perimeters
        return ServicePerimeters(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def parent(self) -> pulumi.Output[str]:
        """
        The AccessPolicy this ServicePerimeter lives in.
        Format: accessPolicies/{policy_id}
        """
        return pulumi.get(self, "parent")

    @property
    @pulumi.getter(name="servicePerimeters")
    def service_perimeters(self) -> pulumi.Output[Optional[List['outputs.ServicePerimetersServicePerimeter']]]:
        """
        The desired Service Perimeters that should replace all existing Service Perimeters in the Access Policy.
        Structure is documented below.
        """
        return pulumi.get(self, "service_perimeters")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
