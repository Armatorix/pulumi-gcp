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

__all__ = ['MangedSslCertificate']

warnings.warn("gcp.compute.MangedSslCertificate has been deprecated in favor of gcp.compute.ManagedSslCertificate", DeprecationWarning)


class MangedSslCertificate(pulumi.CustomResource):
    warnings.warn("gcp.compute.MangedSslCertificate has been deprecated in favor of gcp.compute.ManagedSslCertificate", DeprecationWarning)

    def __init__(__self__,
                 resource_name,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificate_id: Optional[pulumi.Input[float]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 managed: Optional[pulumi.Input[pulumi.InputType['MangedSslCertificateManagedArgs']]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a MangedSslCertificate resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] certificate_id: The unique identifier for the resource.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[pulumi.InputType['MangedSslCertificateManagedArgs']] managed: Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
               of 'MANAGED' in 'type').
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
               namespace as the managed SSL certificates.
        :param pulumi.Input[str] type: Enum field whose value is always 'MANAGED' - used to signal to the API which type this is. Default value: "MANAGED"
               Possible values: ["MANAGED"]
        """
        pulumi.log.warn("MangedSslCertificate is deprecated: gcp.compute.MangedSslCertificate has been deprecated in favor of gcp.compute.ManagedSslCertificate")
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

            __props__['certificate_id'] = certificate_id
            __props__['description'] = description
            __props__['managed'] = managed
            __props__['name'] = name
            __props__['project'] = project
            __props__['type'] = type
            __props__['creation_timestamp'] = None
            __props__['expire_time'] = None
            __props__['self_link'] = None
            __props__['subject_alternative_names'] = None
        super(MangedSslCertificate, __self__).__init__(
            'gcp:compute/mangedSslCertificate:MangedSslCertificate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            certificate_id: Optional[pulumi.Input[float]] = None,
            creation_timestamp: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            expire_time: Optional[pulumi.Input[str]] = None,
            managed: Optional[pulumi.Input[pulumi.InputType['MangedSslCertificateManagedArgs']]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            self_link: Optional[pulumi.Input[str]] = None,
            subject_alternative_names: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'MangedSslCertificate':
        """
        Get an existing MangedSslCertificate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] certificate_id: The unique identifier for the resource.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[str] expire_time: Expire time of the certificate.
        :param pulumi.Input[pulumi.InputType['MangedSslCertificateManagedArgs']] managed: Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
               of 'MANAGED' in 'type').
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
               namespace as the managed SSL certificates.
        :param pulumi.Input[List[pulumi.Input[str]]] subject_alternative_names: Domains associated with the certificate via Subject Alternative Name.
        :param pulumi.Input[str] type: Enum field whose value is always 'MANAGED' - used to signal to the API which type this is. Default value: "MANAGED"
               Possible values: ["MANAGED"]
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["certificate_id"] = certificate_id
        __props__["creation_timestamp"] = creation_timestamp
        __props__["description"] = description
        __props__["expire_time"] = expire_time
        __props__["managed"] = managed
        __props__["name"] = name
        __props__["project"] = project
        __props__["self_link"] = self_link
        __props__["subject_alternative_names"] = subject_alternative_names
        __props__["type"] = type
        return MangedSslCertificate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="certificateId")
    def certificate_id(self) -> float:
        """
        The unique identifier for the resource.
        """
        return pulumi.get(self, "certificate_id")

    @property
    @pulumi.getter(name="creationTimestamp")
    def creation_timestamp(self) -> str:
        """
        Creation timestamp in RFC3339 text format.
        """
        return pulumi.get(self, "creation_timestamp")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        An optional description of this resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> str:
        """
        Expire time of the certificate.
        """
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter
    def managed(self) -> Optional['outputs.MangedSslCertificateManaged']:
        """
        Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
        of 'MANAGED' in 'type').
        """
        return pulumi.get(self, "managed")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
        comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
        '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
        must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
        namespace as the managed SSL certificates.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> str:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="selfLink")
    def self_link(self) -> str:
        return pulumi.get(self, "self_link")

    @property
    @pulumi.getter(name="subjectAlternativeNames")
    def subject_alternative_names(self) -> List[str]:
        """
        Domains associated with the certificate via Subject Alternative Name.
        """
        return pulumi.get(self, "subject_alternative_names")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Enum field whose value is always 'MANAGED' - used to signal to the API which type this is. Default value: "MANAGED"
        Possible values: ["MANAGED"]
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

