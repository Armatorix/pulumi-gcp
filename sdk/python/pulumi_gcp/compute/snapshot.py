# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Snapshot(pulumi.CustomResource):
    creation_timestamp: pulumi.Output[str]
    description: pulumi.Output[str]
    disk_size_gb: pulumi.Output[float]
    label_fingerprint: pulumi.Output[str]
    labels: pulumi.Output[dict]
    licenses: pulumi.Output[list]
    name: pulumi.Output[str]
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    snapshot_encryption_key: pulumi.Output[dict]
    snapshot_id: pulumi.Output[float]
    source_disk: pulumi.Output[str]
    source_disk_encryption_key: pulumi.Output[dict]
    source_disk_link: pulumi.Output[str]
    storage_bytes: pulumi.Output[float]
    zone: pulumi.Output[str]
    def __init__(__self__, resource_name, opts=None, description=None, labels=None, name=None, project=None, snapshot_encryption_key=None, source_disk=None, source_disk_encryption_key=None, zone=None, __props__=None, __name__=None, __opts__=None):
        """
        Represents a Persistent Disk Snapshot resource.
        
        Use snapshots to back up data from your persistent disks. Snapshots are
        different from public images and custom images, which are used primarily
        to create instances or configure instance templates. Snapshots are useful
        for periodic backup of the data on your persistent disks. You can create
        snapshots from persistent disks even while they are attached to running
        instances.
        
        Snapshots are incremental, so you can create regular snapshots on a
        persistent disk faster and at a much lower cost than if you regularly
        created a full image of the disk.
        
        
        To get more information about Snapshot, see:
        
        * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/snapshots)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/compute/docs/disks/create-snapshots)
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_snapshot.html.markdown.
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
            __props__['labels'] = labels
            __props__['name'] = name
            __props__['project'] = project
            __props__['snapshot_encryption_key'] = snapshot_encryption_key
            if source_disk is None:
                raise TypeError("Missing required property 'source_disk'")
            __props__['source_disk'] = source_disk
            __props__['source_disk_encryption_key'] = source_disk_encryption_key
            __props__['zone'] = zone
            __props__['creation_timestamp'] = None
            __props__['disk_size_gb'] = None
            __props__['label_fingerprint'] = None
            __props__['licenses'] = None
            __props__['self_link'] = None
            __props__['snapshot_id'] = None
            __props__['source_disk_link'] = None
            __props__['storage_bytes'] = None
        super(Snapshot, __self__).__init__(
            'gcp:compute/snapshot:Snapshot',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, creation_timestamp=None, description=None, disk_size_gb=None, label_fingerprint=None, labels=None, licenses=None, name=None, project=None, self_link=None, snapshot_encryption_key=None, snapshot_id=None, source_disk=None, source_disk_encryption_key=None, source_disk_link=None, storage_bytes=None, zone=None):
        """
        Get an existing Snapshot resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] self_link: The URI of the created resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_snapshot.html.markdown.
        """
        opts = pulumi.ResourceOptions(id=id) if opts is None else opts.merge(pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["creation_timestamp"] = creation_timestamp
        __props__["description"] = description
        __props__["disk_size_gb"] = disk_size_gb
        __props__["label_fingerprint"] = label_fingerprint
        __props__["labels"] = labels
        __props__["licenses"] = licenses
        __props__["name"] = name
        __props__["project"] = project
        __props__["self_link"] = self_link
        __props__["snapshot_encryption_key"] = snapshot_encryption_key
        __props__["snapshot_id"] = snapshot_id
        __props__["source_disk"] = source_disk
        __props__["source_disk_encryption_key"] = source_disk_encryption_key
        __props__["source_disk_link"] = source_disk_link
        __props__["storage_bytes"] = storage_bytes
        __props__["zone"] = zone
        return Snapshot(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

