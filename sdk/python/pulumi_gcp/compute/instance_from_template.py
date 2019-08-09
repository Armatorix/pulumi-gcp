# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class InstanceFromTemplate(pulumi.CustomResource):
    allow_stopping_for_update: pulumi.Output[bool]
    attached_disks: pulumi.Output[list]
    boot_disk: pulumi.Output[dict]
    can_ip_forward: pulumi.Output[bool]
    cpu_platform: pulumi.Output[str]
    deletion_protection: pulumi.Output[bool]
    description: pulumi.Output[str]
    guest_accelerators: pulumi.Output[list]
    hostname: pulumi.Output[str]
    instance_id: pulumi.Output[str]
    label_fingerprint: pulumi.Output[str]
    labels: pulumi.Output[dict]
    machine_type: pulumi.Output[str]
    metadata: pulumi.Output[dict]
    metadata_fingerprint: pulumi.Output[str]
    metadata_startup_script: pulumi.Output[str]
    min_cpu_platform: pulumi.Output[str]
    name: pulumi.Output[str]
    """
    A unique name for the resource, required by GCE.
    Changing this forces a new resource to be created.
    """
    network_interfaces: pulumi.Output[list]
    project: pulumi.Output[str]
    scheduling: pulumi.Output[dict]
    scratch_disks: pulumi.Output[list]
    self_link: pulumi.Output[str]
    service_account: pulumi.Output[dict]
    shielded_instance_config: pulumi.Output[dict]
    source_instance_template: pulumi.Output[str]
    """
    Name or self link of an instance
    template to create the instance based on.
    """
    tags: pulumi.Output[list]
    tags_fingerprint: pulumi.Output[str]
    zone: pulumi.Output[str]
    """
    The zone that the machine should be created in. If not
    set, the provider zone is used.
    """
    def __init__(__self__, resource_name, opts=None, allow_stopping_for_update=None, attached_disks=None, boot_disk=None, can_ip_forward=None, deletion_protection=None, description=None, guest_accelerators=None, hostname=None, labels=None, machine_type=None, metadata=None, metadata_startup_script=None, min_cpu_platform=None, name=None, network_interfaces=None, project=None, scheduling=None, scratch_disks=None, service_account=None, shielded_instance_config=None, source_instance_template=None, tags=None, zone=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a VM instance resource within GCE. For more information see
        [the official documentation](https://cloud.google.com/compute/docs/instances)
        and
        [API](https://cloud.google.com/compute/docs/reference/latest/instances).
        
        This resource is specifically to create a compute instance from a given
        `source_instance_template`. To create an instance without a template, use the
        `compute.Instance` resource.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: A unique name for the resource, required by GCE.
               Changing this forces a new resource to be created.
        :param pulumi.Input[str] source_instance_template: Name or self link of an instance
               template to create the instance based on.
        :param pulumi.Input[str] zone: The zone that the machine should be created in. If not
               set, the provider zone is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_instance_from_template.html.markdown.
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

            __props__['allow_stopping_for_update'] = allow_stopping_for_update
            __props__['attached_disks'] = attached_disks
            __props__['boot_disk'] = boot_disk
            __props__['can_ip_forward'] = can_ip_forward
            __props__['deletion_protection'] = deletion_protection
            __props__['description'] = description
            __props__['guest_accelerators'] = guest_accelerators
            __props__['hostname'] = hostname
            __props__['labels'] = labels
            __props__['machine_type'] = machine_type
            __props__['metadata'] = metadata
            __props__['metadata_startup_script'] = metadata_startup_script
            __props__['min_cpu_platform'] = min_cpu_platform
            __props__['name'] = name
            __props__['network_interfaces'] = network_interfaces
            __props__['project'] = project
            __props__['scheduling'] = scheduling
            __props__['scratch_disks'] = scratch_disks
            __props__['service_account'] = service_account
            __props__['shielded_instance_config'] = shielded_instance_config
            if source_instance_template is None:
                raise TypeError("Missing required property 'source_instance_template'")
            __props__['source_instance_template'] = source_instance_template
            __props__['tags'] = tags
            __props__['zone'] = zone
            __props__['cpu_platform'] = None
            __props__['instance_id'] = None
            __props__['label_fingerprint'] = None
            __props__['metadata_fingerprint'] = None
            __props__['self_link'] = None
            __props__['tags_fingerprint'] = None
        super(InstanceFromTemplate, __self__).__init__(
            'gcp:compute/instanceFromTemplate:InstanceFromTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, allow_stopping_for_update=None, attached_disks=None, boot_disk=None, can_ip_forward=None, cpu_platform=None, deletion_protection=None, description=None, guest_accelerators=None, hostname=None, instance_id=None, label_fingerprint=None, labels=None, machine_type=None, metadata=None, metadata_fingerprint=None, metadata_startup_script=None, min_cpu_platform=None, name=None, network_interfaces=None, project=None, scheduling=None, scratch_disks=None, self_link=None, service_account=None, shielded_instance_config=None, source_instance_template=None, tags=None, tags_fingerprint=None, zone=None):
        """
        Get an existing InstanceFromTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: A unique name for the resource, required by GCE.
               Changing this forces a new resource to be created.
        :param pulumi.Input[str] source_instance_template: Name or self link of an instance
               template to create the instance based on.
        :param pulumi.Input[str] zone: The zone that the machine should be created in. If not
               set, the provider zone is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_instance_from_template.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["allow_stopping_for_update"] = allow_stopping_for_update
        __props__["attached_disks"] = attached_disks
        __props__["boot_disk"] = boot_disk
        __props__["can_ip_forward"] = can_ip_forward
        __props__["cpu_platform"] = cpu_platform
        __props__["deletion_protection"] = deletion_protection
        __props__["description"] = description
        __props__["guest_accelerators"] = guest_accelerators
        __props__["hostname"] = hostname
        __props__["instance_id"] = instance_id
        __props__["label_fingerprint"] = label_fingerprint
        __props__["labels"] = labels
        __props__["machine_type"] = machine_type
        __props__["metadata"] = metadata
        __props__["metadata_fingerprint"] = metadata_fingerprint
        __props__["metadata_startup_script"] = metadata_startup_script
        __props__["min_cpu_platform"] = min_cpu_platform
        __props__["name"] = name
        __props__["network_interfaces"] = network_interfaces
        __props__["project"] = project
        __props__["scheduling"] = scheduling
        __props__["scratch_disks"] = scratch_disks
        __props__["self_link"] = self_link
        __props__["service_account"] = service_account
        __props__["shielded_instance_config"] = shielded_instance_config
        __props__["source_instance_template"] = source_instance_template
        __props__["tags"] = tags
        __props__["tags_fingerprint"] = tags_fingerprint
        __props__["zone"] = zone
        return InstanceFromTemplate(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

