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

__all__ = ['AlertPolicy']


class AlertPolicy(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 combiner: Optional[pulumi.Input[str]] = None,
                 conditions: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 documentation: Optional[pulumi.Input[pulumi.InputType['AlertPolicyDocumentationArgs']]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 notification_channels: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 user_labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A description of the conditions under which some aspect of your system is
        considered to be "unhealthy" and the ways to notify people or services
        about this state.

        To get more information about AlertPolicy, see:

        * [API documentation](https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.alertPolicies)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/monitoring/alerts/)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] combiner: How to combine the results of multiple conditions to
               determine if an incident should be opened.
               Possible values are `AND`, `OR`, and `AND_WITH_MATCHING_RESOURCE`.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]] conditions: A list of conditions for the policy. The conditions are combined by
               AND or OR according to the combiner field. If the combined conditions
               evaluate to true, then an incident is created. A policy can have from
               one to six conditions.
               Structure is documented below.
        :param pulumi.Input[str] display_name: A short name or phrase used to identify the
               condition in dashboards, notifications, and
               incidents. To avoid confusion, don't use the same
               display name for multiple conditions in the same
               policy.
        :param pulumi.Input[pulumi.InputType['AlertPolicyDocumentationArgs']] documentation: A short name or phrase used to identify the policy in dashboards,
               notifications, and incidents. To avoid confusion, don't use the same
               display name for multiple policies in the same project. The name is
               limited to 512 Unicode characters.
               Structure is documented below.
        :param pulumi.Input[bool] enabled: Whether or not the policy is enabled. The default is true.
        :param pulumi.Input[List[pulumi.Input[str]]] notification_channels: Identifies the notification channels to which notifications should be
               sent when incidents are opened or closed or when new violations occur
               on an already opened incident. Each element of this array corresponds
               to the name field in each of the NotificationChannel objects that are
               returned from the notificationChannels.list method. The syntax of the
               entries in this field is
               `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] user_labels: This field is intended to be used for organizing and identifying the AlertPolicy
               objects.The field can contain up to 64 entries. Each key and value is limited
               to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
               can contain only lowercase letters, numerals, underscores, and dashes. Keys
               must begin with a letter.
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

            if combiner is None:
                raise TypeError("Missing required property 'combiner'")
            __props__['combiner'] = combiner
            if conditions is None:
                raise TypeError("Missing required property 'conditions'")
            __props__['conditions'] = conditions
            if display_name is None:
                raise TypeError("Missing required property 'display_name'")
            __props__['display_name'] = display_name
            __props__['documentation'] = documentation
            __props__['enabled'] = enabled
            __props__['notification_channels'] = notification_channels
            __props__['project'] = project
            __props__['user_labels'] = user_labels
            __props__['creation_record'] = None
            __props__['name'] = None
        super(AlertPolicy, __self__).__init__(
            'gcp:monitoring/alertPolicy:AlertPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            combiner: Optional[pulumi.Input[str]] = None,
            conditions: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]]] = None,
            creation_record: Optional[pulumi.Input[pulumi.InputType['AlertPolicyCreationRecordArgs']]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            documentation: Optional[pulumi.Input[pulumi.InputType['AlertPolicyDocumentationArgs']]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            notification_channels: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            project: Optional[pulumi.Input[str]] = None,
            user_labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'AlertPolicy':
        """
        Get an existing AlertPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] combiner: How to combine the results of multiple conditions to
               determine if an incident should be opened.
               Possible values are `AND`, `OR`, and `AND_WITH_MATCHING_RESOURCE`.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]] conditions: A list of conditions for the policy. The conditions are combined by
               AND or OR according to the combiner field. If the combined conditions
               evaluate to true, then an incident is created. A policy can have from
               one to six conditions.
               Structure is documented below.
        :param pulumi.Input[pulumi.InputType['AlertPolicyCreationRecordArgs']] creation_record: A read-only record of the creation of the alerting policy. If provided in a call to create or update, this field will be
               ignored.
        :param pulumi.Input[str] display_name: A short name or phrase used to identify the
               condition in dashboards, notifications, and
               incidents. To avoid confusion, don't use the same
               display name for multiple conditions in the same
               policy.
        :param pulumi.Input[pulumi.InputType['AlertPolicyDocumentationArgs']] documentation: A short name or phrase used to identify the policy in dashboards,
               notifications, and incidents. To avoid confusion, don't use the same
               display name for multiple policies in the same project. The name is
               limited to 512 Unicode characters.
               Structure is documented below.
        :param pulumi.Input[bool] enabled: Whether or not the policy is enabled. The default is true.
        :param pulumi.Input[str] name: -
               The unique resource name for this condition.
               Its syntax is:
               projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID]
               [CONDITION_ID] is assigned by Stackdriver Monitoring when
               the condition is created as part of a new or updated alerting
               policy.
        :param pulumi.Input[List[pulumi.Input[str]]] notification_channels: Identifies the notification channels to which notifications should be
               sent when incidents are opened or closed or when new violations occur
               on an already opened incident. Each element of this array corresponds
               to the name field in each of the NotificationChannel objects that are
               returned from the notificationChannels.list method. The syntax of the
               entries in this field is
               `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] user_labels: This field is intended to be used for organizing and identifying the AlertPolicy
               objects.The field can contain up to 64 entries. Each key and value is limited
               to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
               can contain only lowercase letters, numerals, underscores, and dashes. Keys
               must begin with a letter.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["combiner"] = combiner
        __props__["conditions"] = conditions
        __props__["creation_record"] = creation_record
        __props__["display_name"] = display_name
        __props__["documentation"] = documentation
        __props__["enabled"] = enabled
        __props__["name"] = name
        __props__["notification_channels"] = notification_channels
        __props__["project"] = project
        __props__["user_labels"] = user_labels
        return AlertPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def combiner(self) -> pulumi.Output[str]:
        """
        How to combine the results of multiple conditions to
        determine if an incident should be opened.
        Possible values are `AND`, `OR`, and `AND_WITH_MATCHING_RESOURCE`.
        """
        return pulumi.get(self, "combiner")

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Output[List['outputs.AlertPolicyCondition']]:
        """
        A list of conditions for the policy. The conditions are combined by
        AND or OR according to the combiner field. If the combined conditions
        evaluate to true, then an incident is created. A policy can have from
        one to six conditions.
        Structure is documented below.
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter(name="creationRecord")
    def creation_record(self) -> pulumi.Output['outputs.AlertPolicyCreationRecord']:
        """
        A read-only record of the creation of the alerting policy. If provided in a call to create or update, this field will be
        ignored.
        """
        return pulumi.get(self, "creation_record")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        A short name or phrase used to identify the
        condition in dashboards, notifications, and
        incidents. To avoid confusion, don't use the same
        display name for multiple conditions in the same
        policy.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def documentation(self) -> pulumi.Output[Optional['outputs.AlertPolicyDocumentation']]:
        """
        A short name or phrase used to identify the policy in dashboards,
        notifications, and incidents. To avoid confusion, don't use the same
        display name for multiple policies in the same project. The name is
        limited to 512 Unicode characters.
        Structure is documented below.
        """
        return pulumi.get(self, "documentation")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether or not the policy is enabled. The default is true.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        -
        The unique resource name for this condition.
        Its syntax is:
        projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID]
        [CONDITION_ID] is assigned by Stackdriver Monitoring when
        the condition is created as part of a new or updated alerting
        policy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="notificationChannels")
    def notification_channels(self) -> pulumi.Output[Optional[List[str]]]:
        """
        Identifies the notification channels to which notifications should be
        sent when incidents are opened or closed or when new violations occur
        on an already opened incident. Each element of this array corresponds
        to the name field in each of the NotificationChannel objects that are
        returned from the notificationChannels.list method. The syntax of the
        entries in this field is
        `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`
        """
        return pulumi.get(self, "notification_channels")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="userLabels")
    def user_labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        This field is intended to be used for organizing and identifying the AlertPolicy
        objects.The field can contain up to 64 entries. Each key and value is limited
        to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
        can contain only lowercase letters, numerals, underscores, and dashes. Keys
        must begin with a letter.
        """
        return pulumi.get(self, "user_labels")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

