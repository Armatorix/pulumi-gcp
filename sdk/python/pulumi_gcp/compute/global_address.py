# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class GlobalAddress(pulumi.CustomResource):
    def __init__(__self__, __name__, __opts__=None, address_type=None, description=None, ip_version=None, labels=None, name=None, network=None, prefix_length=None, project=None, purpose=None):
        """Create a GlobalAddress resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if address_type and not isinstance(address_type, basestring):
            raise TypeError('Expected property address_type to be a basestring')
        __self__.address_type = address_type
        __props__['addressType'] = address_type

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        __props__['description'] = description

        if ip_version and not isinstance(ip_version, basestring):
            raise TypeError('Expected property ip_version to be a basestring')
        __self__.ip_version = ip_version
        __props__['ipVersion'] = ip_version

        if labels and not isinstance(labels, dict):
            raise TypeError('Expected property labels to be a dict')
        __self__.labels = labels
        __props__['labels'] = labels

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        __props__['name'] = name

        if network and not isinstance(network, basestring):
            raise TypeError('Expected property network to be a basestring')
        __self__.network = network
        __props__['network'] = network

        if prefix_length and not isinstance(prefix_length, int):
            raise TypeError('Expected property prefix_length to be a int')
        __self__.prefix_length = prefix_length
        __props__['prefixLength'] = prefix_length

        if project and not isinstance(project, basestring):
            raise TypeError('Expected property project to be a basestring')
        __self__.project = project
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        __props__['project'] = project

        if purpose and not isinstance(purpose, basestring):
            raise TypeError('Expected property purpose to be a basestring')
        __self__.purpose = purpose
        __props__['purpose'] = purpose

        __self__.address = pulumi.runtime.UNKNOWN
        __self__.creation_timestamp = pulumi.runtime.UNKNOWN
        __self__.label_fingerprint = pulumi.runtime.UNKNOWN
        __self__.self_link = pulumi.runtime.UNKNOWN
        """
        The URI of the created resource.
        """

        super(GlobalAddress, __self__).__init__(
            'gcp:compute/globalAddress:GlobalAddress',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'address' in outs:
            self.address = outs['address']
        if 'addressType' in outs:
            self.address_type = outs['addressType']
        if 'creationTimestamp' in outs:
            self.creation_timestamp = outs['creationTimestamp']
        if 'description' in outs:
            self.description = outs['description']
        if 'ipVersion' in outs:
            self.ip_version = outs['ipVersion']
        if 'labelFingerprint' in outs:
            self.label_fingerprint = outs['labelFingerprint']
        if 'labels' in outs:
            self.labels = outs['labels']
        if 'name' in outs:
            self.name = outs['name']
        if 'network' in outs:
            self.network = outs['network']
        if 'prefixLength' in outs:
            self.prefix_length = outs['prefixLength']
        if 'project' in outs:
            self.project = outs['project']
        if 'purpose' in outs:
            self.purpose = outs['purpose']
        if 'selfLink' in outs:
            self.self_link = outs['selfLink']
