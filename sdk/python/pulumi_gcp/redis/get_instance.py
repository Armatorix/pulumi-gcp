# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = [
    'GetInstanceResult',
    'AwaitableGetInstanceResult',
    'get_instance',
]

@pulumi.output_type
class GetInstanceResult:
    """
    A collection of values returned by getInstance.
    """
    def __init__(__self__, alternative_location_id=None, authorized_network=None, connect_mode=None, create_time=None, current_location_id=None, display_name=None, host=None, id=None, labels=None, location_id=None, memory_size_gb=None, name=None, persistence_iam_identity=None, port=None, project=None, redis_configs=None, redis_version=None, region=None, reserved_ip_range=None, tier=None):
        if alternative_location_id and not isinstance(alternative_location_id, str):
            raise TypeError("Expected argument 'alternative_location_id' to be a str")
        pulumi.set(__self__, "alternative_location_id", alternative_location_id)
        if authorized_network and not isinstance(authorized_network, str):
            raise TypeError("Expected argument 'authorized_network' to be a str")
        pulumi.set(__self__, "authorized_network", authorized_network)
        if connect_mode and not isinstance(connect_mode, str):
            raise TypeError("Expected argument 'connect_mode' to be a str")
        pulumi.set(__self__, "connect_mode", connect_mode)
        if create_time and not isinstance(create_time, str):
            raise TypeError("Expected argument 'create_time' to be a str")
        pulumi.set(__self__, "create_time", create_time)
        if current_location_id and not isinstance(current_location_id, str):
            raise TypeError("Expected argument 'current_location_id' to be a str")
        pulumi.set(__self__, "current_location_id", current_location_id)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if host and not isinstance(host, str):
            raise TypeError("Expected argument 'host' to be a str")
        pulumi.set(__self__, "host", host)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if location_id and not isinstance(location_id, str):
            raise TypeError("Expected argument 'location_id' to be a str")
        pulumi.set(__self__, "location_id", location_id)
        if memory_size_gb and not isinstance(memory_size_gb, float):
            raise TypeError("Expected argument 'memory_size_gb' to be a float")
        pulumi.set(__self__, "memory_size_gb", memory_size_gb)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if persistence_iam_identity and not isinstance(persistence_iam_identity, str):
            raise TypeError("Expected argument 'persistence_iam_identity' to be a str")
        pulumi.set(__self__, "persistence_iam_identity", persistence_iam_identity)
        if port and not isinstance(port, float):
            raise TypeError("Expected argument 'port' to be a float")
        pulumi.set(__self__, "port", port)
        if project and not isinstance(project, str):
            raise TypeError("Expected argument 'project' to be a str")
        pulumi.set(__self__, "project", project)
        if redis_configs and not isinstance(redis_configs, dict):
            raise TypeError("Expected argument 'redis_configs' to be a dict")
        pulumi.set(__self__, "redis_configs", redis_configs)
        if redis_version and not isinstance(redis_version, str):
            raise TypeError("Expected argument 'redis_version' to be a str")
        pulumi.set(__self__, "redis_version", redis_version)
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        pulumi.set(__self__, "region", region)
        if reserved_ip_range and not isinstance(reserved_ip_range, str):
            raise TypeError("Expected argument 'reserved_ip_range' to be a str")
        pulumi.set(__self__, "reserved_ip_range", reserved_ip_range)
        if tier and not isinstance(tier, str):
            raise TypeError("Expected argument 'tier' to be a str")
        pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter(name="alternativeLocationId")
    def alternative_location_id(self) -> str:
        return pulumi.get(self, "alternative_location_id")

    @property
    @pulumi.getter(name="authorizedNetwork")
    def authorized_network(self) -> str:
        return pulumi.get(self, "authorized_network")

    @property
    @pulumi.getter(name="connectMode")
    def connect_mode(self) -> str:
        return pulumi.get(self, "connect_mode")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> str:
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="currentLocationId")
    def current_location_id(self) -> str:
        return pulumi.get(self, "current_location_id")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> str:
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def host(self) -> str:
        """
        Hostname or IP address of the exposed Redis endpoint used by clients
        to connect to the service.
        """
        return pulumi.get(self, "host")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="locationId")
    def location_id(self) -> str:
        return pulumi.get(self, "location_id")

    @property
    @pulumi.getter(name="memorySizeGb")
    def memory_size_gb(self) -> float:
        return pulumi.get(self, "memory_size_gb")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="persistenceIamIdentity")
    def persistence_iam_identity(self) -> str:
        return pulumi.get(self, "persistence_iam_identity")

    @property
    @pulumi.getter
    def port(self) -> float:
        """
        The port number of the exposed Redis endpoint.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def project(self) -> Optional[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="redisConfigs")
    def redis_configs(self) -> Mapping[str, str]:
        return pulumi.get(self, "redis_configs")

    @property
    @pulumi.getter(name="redisVersion")
    def redis_version(self) -> str:
        return pulumi.get(self, "redis_version")

    @property
    @pulumi.getter
    def region(self) -> Optional[str]:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="reservedIpRange")
    def reserved_ip_range(self) -> str:
        return pulumi.get(self, "reserved_ip_range")

    @property
    @pulumi.getter
    def tier(self) -> str:
        return pulumi.get(self, "tier")


class AwaitableGetInstanceResult(GetInstanceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceResult(
            alternative_location_id=self.alternative_location_id,
            authorized_network=self.authorized_network,
            connect_mode=self.connect_mode,
            create_time=self.create_time,
            current_location_id=self.current_location_id,
            display_name=self.display_name,
            host=self.host,
            id=self.id,
            labels=self.labels,
            location_id=self.location_id,
            memory_size_gb=self.memory_size_gb,
            name=self.name,
            persistence_iam_identity=self.persistence_iam_identity,
            port=self.port,
            project=self.project,
            redis_configs=self.redis_configs,
            redis_version=self.redis_version,
            region=self.region,
            reserved_ip_range=self.reserved_ip_range,
            tier=self.tier)


def get_instance(name: Optional[str] = None,
                 project: Optional[str] = None,
                 region: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceResult:
    """
    Get information about a Google Cloud Redis instance. For more information see
    the [official documentation](https://cloud.google.com/memorystore/docs/redis)
    and [API](https://cloud.google.com/memorystore/docs/redis/apis).


    :param str name: The name of a Redis instance.
    :param str project: The project in which the resource belongs. If it
           is not provided, the provider project is used.
    :param str region: The region in which the resource belongs. If it
           is not provided, the provider region is used.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['project'] = project
    __args__['region'] = region
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('gcp:redis/getInstance:getInstance', __args__, opts=opts, typ=GetInstanceResult).value

    return AwaitableGetInstanceResult(
        alternative_location_id=__ret__.alternative_location_id,
        authorized_network=__ret__.authorized_network,
        connect_mode=__ret__.connect_mode,
        create_time=__ret__.create_time,
        current_location_id=__ret__.current_location_id,
        display_name=__ret__.display_name,
        host=__ret__.host,
        id=__ret__.id,
        labels=__ret__.labels,
        location_id=__ret__.location_id,
        memory_size_gb=__ret__.memory_size_gb,
        name=__ret__.name,
        persistence_iam_identity=__ret__.persistence_iam_identity,
        port=__ret__.port,
        project=__ret__.project,
        redis_configs=__ret__.redis_configs,
        redis_version=__ret__.redis_version,
        region=__ret__.region,
        reserved_ip_range=__ret__.reserved_ip_range,
        tier=__ret__.tier)
