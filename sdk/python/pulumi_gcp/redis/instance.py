# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['Instance']


class Instance(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alternative_location_id: Optional[pulumi.Input[str]] = None,
                 authorized_network: Optional[pulumi.Input[str]] = None,
                 connect_mode: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location_id: Optional[pulumi.Input[str]] = None,
                 memory_size_gb: Optional[pulumi.Input[float]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 redis_configs: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 redis_version: Optional[pulumi.Input[str]] = None,
                 region: Optional[pulumi.Input[str]] = None,
                 reserved_ip_range: Optional[pulumi.Input[str]] = None,
                 tier: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A Google Cloud Redis instance.

        To get more information about Instance, see:

        * [API documentation](https://cloud.google.com/memorystore/docs/redis/reference/rest/)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/memorystore/docs/redis/)

        ## Example Usage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] alternative_location_id: Only applicable to STANDARD_HA tier which protects the instance
               against zonal failures by provisioning it across two zones.
               If provided, it must be a different zone from the one provided in
               [locationId].
        :param pulumi.Input[str] authorized_network: The full name of the Google Compute Engine network to which the
               instance is connected. If left unspecified, the default network
               will be used.
        :param pulumi.Input[str] connect_mode: The connection mode of the Redis instance.
               Default value is `DIRECT_PEERING`.
               Possible values are `DIRECT_PEERING` and `PRIVATE_SERVICE_ACCESS`.
        :param pulumi.Input[str] display_name: An arbitrary and optional user-provided name for the instance.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Resource labels to represent user provided metadata.
        :param pulumi.Input[str] location_id: The zone where the instance will be provisioned. If not provided,
               the service will choose a zone for the instance. For STANDARD_HA tier,
               instances will be created across two zones for protection against
               zonal failures. If [alternativeLocationId] is also provided, it must
               be different from [locationId].
        :param pulumi.Input[float] memory_size_gb: Redis memory size in GiB.
        :param pulumi.Input[str] name: The ID of the instance or a fully qualified identifier for the instance.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] redis_configs: Redis configuration parameters, according to http://redis.io/topics/config.
               Please check Memorystore documentation for the list of supported parameters:
               https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
        :param pulumi.Input[str] redis_version: The version of Redis software. If not provided, latest supported
               version will be used. Currently, the supported values are:
               - REDIS_5_0 for Redis 5.0 compatibility
               - REDIS_4_0 for Redis 4.0 compatibility
               - REDIS_3_2 for Redis 3.2 compatibility
        :param pulumi.Input[str] region: The name of the Redis region of the instance.
        :param pulumi.Input[str] reserved_ip_range: The CIDR range of internal addresses that are reserved for this
               instance. If not provided, the service will choose an unused /29
               block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
               unique and non-overlapping with existing subnets in an authorized
               network.
        :param pulumi.Input[str] tier: The service tier of the instance. Must be one of these values:
               - BASIC: standalone instance
               - STANDARD_HA: highly available primary/replica instances
               Default value is `BASIC`.
               Possible values are `BASIC` and `STANDARD_HA`.
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

            __props__['alternative_location_id'] = alternative_location_id
            __props__['authorized_network'] = authorized_network
            __props__['connect_mode'] = connect_mode
            __props__['display_name'] = display_name
            __props__['labels'] = labels
            __props__['location_id'] = location_id
            if memory_size_gb is None:
                raise TypeError("Missing required property 'memory_size_gb'")
            __props__['memory_size_gb'] = memory_size_gb
            __props__['name'] = name
            __props__['project'] = project
            __props__['redis_configs'] = redis_configs
            __props__['redis_version'] = redis_version
            __props__['region'] = region
            __props__['reserved_ip_range'] = reserved_ip_range
            __props__['tier'] = tier
            __props__['create_time'] = None
            __props__['current_location_id'] = None
            __props__['host'] = None
            __props__['persistence_iam_identity'] = None
            __props__['port'] = None
        super(Instance, __self__).__init__(
            'gcp:redis/instance:Instance',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            alternative_location_id: Optional[pulumi.Input[str]] = None,
            authorized_network: Optional[pulumi.Input[str]] = None,
            connect_mode: Optional[pulumi.Input[str]] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            current_location_id: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            host: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            location_id: Optional[pulumi.Input[str]] = None,
            memory_size_gb: Optional[pulumi.Input[float]] = None,
            name: Optional[pulumi.Input[str]] = None,
            persistence_iam_identity: Optional[pulumi.Input[str]] = None,
            port: Optional[pulumi.Input[float]] = None,
            project: Optional[pulumi.Input[str]] = None,
            redis_configs: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            redis_version: Optional[pulumi.Input[str]] = None,
            region: Optional[pulumi.Input[str]] = None,
            reserved_ip_range: Optional[pulumi.Input[str]] = None,
            tier: Optional[pulumi.Input[str]] = None) -> 'Instance':
        """
        Get an existing Instance resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] alternative_location_id: Only applicable to STANDARD_HA tier which protects the instance
               against zonal failures by provisioning it across two zones.
               If provided, it must be a different zone from the one provided in
               [locationId].
        :param pulumi.Input[str] authorized_network: The full name of the Google Compute Engine network to which the
               instance is connected. If left unspecified, the default network
               will be used.
        :param pulumi.Input[str] connect_mode: The connection mode of the Redis instance.
               Default value is `DIRECT_PEERING`.
               Possible values are `DIRECT_PEERING` and `PRIVATE_SERVICE_ACCESS`.
        :param pulumi.Input[str] create_time: The time the instance was created in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
        :param pulumi.Input[str] current_location_id: The current zone where the Redis endpoint is placed. For Basic Tier instances, this will always be the same as the
               [locationId] provided by the user at creation time. For Standard Tier instances, this can be either [locationId] or
               [alternativeLocationId] and can change after a failover event.
        :param pulumi.Input[str] display_name: An arbitrary and optional user-provided name for the instance.
        :param pulumi.Input[str] host: Hostname or IP address of the exposed Redis endpoint used by clients to connect to the service.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Resource labels to represent user provided metadata.
        :param pulumi.Input[str] location_id: The zone where the instance will be provisioned. If not provided,
               the service will choose a zone for the instance. For STANDARD_HA tier,
               instances will be created across two zones for protection against
               zonal failures. If [alternativeLocationId] is also provided, it must
               be different from [locationId].
        :param pulumi.Input[float] memory_size_gb: Redis memory size in GiB.
        :param pulumi.Input[str] name: The ID of the instance or a fully qualified identifier for the instance.
        :param pulumi.Input[str] persistence_iam_identity: Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud Storage. Format is
               "serviceAccount:". The value may change over time for a given instance so should be checked before each import/export
               operation.
        :param pulumi.Input[float] port: The port number of the exposed Redis endpoint.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] redis_configs: Redis configuration parameters, according to http://redis.io/topics/config.
               Please check Memorystore documentation for the list of supported parameters:
               https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
        :param pulumi.Input[str] redis_version: The version of Redis software. If not provided, latest supported
               version will be used. Currently, the supported values are:
               - REDIS_5_0 for Redis 5.0 compatibility
               - REDIS_4_0 for Redis 4.0 compatibility
               - REDIS_3_2 for Redis 3.2 compatibility
        :param pulumi.Input[str] region: The name of the Redis region of the instance.
        :param pulumi.Input[str] reserved_ip_range: The CIDR range of internal addresses that are reserved for this
               instance. If not provided, the service will choose an unused /29
               block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
               unique and non-overlapping with existing subnets in an authorized
               network.
        :param pulumi.Input[str] tier: The service tier of the instance. Must be one of these values:
               - BASIC: standalone instance
               - STANDARD_HA: highly available primary/replica instances
               Default value is `BASIC`.
               Possible values are `BASIC` and `STANDARD_HA`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["alternative_location_id"] = alternative_location_id
        __props__["authorized_network"] = authorized_network
        __props__["connect_mode"] = connect_mode
        __props__["create_time"] = create_time
        __props__["current_location_id"] = current_location_id
        __props__["display_name"] = display_name
        __props__["host"] = host
        __props__["labels"] = labels
        __props__["location_id"] = location_id
        __props__["memory_size_gb"] = memory_size_gb
        __props__["name"] = name
        __props__["persistence_iam_identity"] = persistence_iam_identity
        __props__["port"] = port
        __props__["project"] = project
        __props__["redis_configs"] = redis_configs
        __props__["redis_version"] = redis_version
        __props__["region"] = region
        __props__["reserved_ip_range"] = reserved_ip_range
        __props__["tier"] = tier
        return Instance(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="alternativeLocationId")
    def alternative_location_id(self) -> pulumi.Output[str]:
        """
        Only applicable to STANDARD_HA tier which protects the instance
        against zonal failures by provisioning it across two zones.
        If provided, it must be a different zone from the one provided in
        [locationId].
        """
        return pulumi.get(self, "alternative_location_id")

    @property
    @pulumi.getter(name="authorizedNetwork")
    def authorized_network(self) -> pulumi.Output[str]:
        """
        The full name of the Google Compute Engine network to which the
        instance is connected. If left unspecified, the default network
        will be used.
        """
        return pulumi.get(self, "authorized_network")

    @property
    @pulumi.getter(name="connectMode")
    def connect_mode(self) -> pulumi.Output[Optional[str]]:
        """
        The connection mode of the Redis instance.
        Default value is `DIRECT_PEERING`.
        Possible values are `DIRECT_PEERING` and `PRIVATE_SERVICE_ACCESS`.
        """
        return pulumi.get(self, "connect_mode")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        The time the instance was created in RFC3339 UTC "Zulu" format, accurate to nanoseconds.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="currentLocationId")
    def current_location_id(self) -> pulumi.Output[str]:
        """
        The current zone where the Redis endpoint is placed. For Basic Tier instances, this will always be the same as the
        [locationId] provided by the user at creation time. For Standard Tier instances, this can be either [locationId] or
        [alternativeLocationId] and can change after a failover event.
        """
        return pulumi.get(self, "current_location_id")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[Optional[str]]:
        """
        An arbitrary and optional user-provided name for the instance.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def host(self) -> pulumi.Output[str]:
        """
        Hostname or IP address of the exposed Redis endpoint used by clients to connect to the service.
        """
        return pulumi.get(self, "host")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource labels to represent user provided metadata.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="locationId")
    def location_id(self) -> pulumi.Output[str]:
        """
        The zone where the instance will be provisioned. If not provided,
        the service will choose a zone for the instance. For STANDARD_HA tier,
        instances will be created across two zones for protection against
        zonal failures. If [alternativeLocationId] is also provided, it must
        be different from [locationId].
        """
        return pulumi.get(self, "location_id")

    @property
    @pulumi.getter(name="memorySizeGb")
    def memory_size_gb(self) -> pulumi.Output[float]:
        """
        Redis memory size in GiB.
        """
        return pulumi.get(self, "memory_size_gb")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The ID of the instance or a fully qualified identifier for the instance.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="persistenceIamIdentity")
    def persistence_iam_identity(self) -> pulumi.Output[str]:
        """
        Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud Storage. Format is
        "serviceAccount:". The value may change over time for a given instance so should be checked before each import/export
        operation.
        """
        return pulumi.get(self, "persistence_iam_identity")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[float]:
        """
        The port number of the exposed Redis endpoint.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        The ID of the project in which the resource belongs.
        If it is not provided, the provider project is used.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="redisConfigs")
    def redis_configs(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Redis configuration parameters, according to http://redis.io/topics/config.
        Please check Memorystore documentation for the list of supported parameters:
        https://cloud.google.com/memorystore/docs/redis/reference/rest/v1/projects.locations.instances#Instance.FIELDS.redis_configs
        """
        return pulumi.get(self, "redis_configs")

    @property
    @pulumi.getter(name="redisVersion")
    def redis_version(self) -> pulumi.Output[str]:
        """
        The version of Redis software. If not provided, latest supported
        version will be used. Currently, the supported values are:
        - REDIS_5_0 for Redis 5.0 compatibility
        - REDIS_4_0 for Redis 4.0 compatibility
        - REDIS_3_2 for Redis 3.2 compatibility
        """
        return pulumi.get(self, "redis_version")

    @property
    @pulumi.getter
    def region(self) -> pulumi.Output[str]:
        """
        The name of the Redis region of the instance.
        """
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="reservedIpRange")
    def reserved_ip_range(self) -> pulumi.Output[str]:
        """
        The CIDR range of internal addresses that are reserved for this
        instance. If not provided, the service will choose an unused /29
        block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges must be
        unique and non-overlapping with existing subnets in an authorized
        network.
        """
        return pulumi.get(self, "reserved_ip_range")

    @property
    @pulumi.getter
    def tier(self) -> pulumi.Output[Optional[str]]:
        """
        The service tier of the instance. Must be one of these values:
        - BASIC: standalone instance
        - STANDARD_HA: highly available primary/replica instances
        Default value is `BASIC`.
        Possible values are `BASIC` and `STANDARD_HA`.
        """
        return pulumi.get(self, "tier")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

