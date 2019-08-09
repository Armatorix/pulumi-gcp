# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class NotificationChannel(pulumi.CustomResource):
    description: pulumi.Output[str]
    display_name: pulumi.Output[str]
    enabled: pulumi.Output[bool]
    labels: pulumi.Output[dict]
    name: pulumi.Output[str]
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    type: pulumi.Output[str]
    user_labels: pulumi.Output[dict]
    verification_status: pulumi.Output[str]
    def __init__(__self__, resource_name, opts=None, description=None, display_name=None, enabled=None, labels=None, project=None, type=None, user_labels=None, __props__=None, __name__=None, __opts__=None):
        """
        A NotificationChannel is a medium through which an alert is delivered
        when a policy violation is detected. Examples of channels include email, SMS,
        and third-party messaging applications. Fields containing sensitive information
        like authentication tokens or contact info are only partially populated on retrieval.
        
        Notification Channels are designed to be flexible and are made up of a supported `type`
        and labels to configure that channel. Each `type` has specific labels that need to be
        present for that channel to be correctly configured. The labels that are required to be
        present for one channel `type` are often different than those requried for another.
        Due to these loose constraints it's often best to set up a channel through the UI
        and import when setting up a brand new channel type to determine which
        labels are required.
        
        A list of supported channels per project the `list` endpoint can be
        accessed programatically or through the api explorer at  https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannelDescriptors/list .
        This provides the channel type and all of the required labels that must be passed.
        
        
        To get more information about NotificationChannel, see:
        
        * [API documentation](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.notificationChannels)
        * How-to Guides
            * [Notification Options](https://cloud.google.com/monitoring/support/notification-options)
            * [Monitoring API Documentation](https://cloud.google.com/monitoring/api/v3/)
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/monitoring_notification_channel.html.markdown.
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

            __props__['description'] = description
            if display_name is None:
                raise TypeError("Missing required property 'display_name'")
            __props__['display_name'] = display_name
            __props__['enabled'] = enabled
            __props__['labels'] = labels
            __props__['project'] = project
            if type is None:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
            __props__['user_labels'] = user_labels
            __props__['name'] = None
            __props__['verification_status'] = None
        super(NotificationChannel, __self__).__init__(
            'gcp:monitoring/notificationChannel:NotificationChannel',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, display_name=None, enabled=None, labels=None, name=None, project=None, type=None, user_labels=None, verification_status=None):
        """
        Get an existing NotificationChannel resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/monitoring_notification_channel.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["description"] = description
        __props__["display_name"] = display_name
        __props__["enabled"] = enabled
        __props__["labels"] = labels
        __props__["name"] = name
        __props__["project"] = project
        __props__["type"] = type
        __props__["user_labels"] = user_labels
        __props__["verification_status"] = verification_status
        return NotificationChannel(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

