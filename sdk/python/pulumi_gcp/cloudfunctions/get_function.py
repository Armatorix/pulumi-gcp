# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs

__all__ = [
    'GetFunctionResult',
    'AwaitableGetFunctionResult',
    'get_function',
]

@pulumi.output_type
class GetFunctionResult:
    """
    A collection of values returned by getFunction.
    """
    def __init__(__self__, available_memory_mb=None, description=None, entry_point=None, environment_variables=None, event_triggers=None, https_trigger_url=None, id=None, ingress_settings=None, labels=None, max_instances=None, name=None, project=None, region=None, runtime=None, service_account_email=None, source_archive_bucket=None, source_archive_object=None, source_repositories=None, timeout=None, trigger_http=None, vpc_connector=None, vpc_connector_egress_settings=None):
        if available_memory_mb and not isinstance(available_memory_mb, float):
            raise TypeError("Expected argument 'available_memory_mb' to be a float")
        pulumi.set(__self__, "available_memory_mb", available_memory_mb)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if entry_point and not isinstance(entry_point, str):
            raise TypeError("Expected argument 'entry_point' to be a str")
        pulumi.set(__self__, "entry_point", entry_point)
        if environment_variables and not isinstance(environment_variables, dict):
            raise TypeError("Expected argument 'environment_variables' to be a dict")
        pulumi.set(__self__, "environment_variables", environment_variables)
        if event_triggers and not isinstance(event_triggers, list):
            raise TypeError("Expected argument 'event_triggers' to be a list")
        pulumi.set(__self__, "event_triggers", event_triggers)
        if https_trigger_url and not isinstance(https_trigger_url, str):
            raise TypeError("Expected argument 'https_trigger_url' to be a str")
        pulumi.set(__self__, "https_trigger_url", https_trigger_url)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if ingress_settings and not isinstance(ingress_settings, str):
            raise TypeError("Expected argument 'ingress_settings' to be a str")
        pulumi.set(__self__, "ingress_settings", ingress_settings)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if max_instances and not isinstance(max_instances, float):
            raise TypeError("Expected argument 'max_instances' to be a float")
        pulumi.set(__self__, "max_instances", max_instances)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if project and not isinstance(project, str):
            raise TypeError("Expected argument 'project' to be a str")
        pulumi.set(__self__, "project", project)
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        pulumi.set(__self__, "region", region)
        if runtime and not isinstance(runtime, str):
            raise TypeError("Expected argument 'runtime' to be a str")
        pulumi.set(__self__, "runtime", runtime)
        if service_account_email and not isinstance(service_account_email, str):
            raise TypeError("Expected argument 'service_account_email' to be a str")
        pulumi.set(__self__, "service_account_email", service_account_email)
        if source_archive_bucket and not isinstance(source_archive_bucket, str):
            raise TypeError("Expected argument 'source_archive_bucket' to be a str")
        pulumi.set(__self__, "source_archive_bucket", source_archive_bucket)
        if source_archive_object and not isinstance(source_archive_object, str):
            raise TypeError("Expected argument 'source_archive_object' to be a str")
        pulumi.set(__self__, "source_archive_object", source_archive_object)
        if source_repositories and not isinstance(source_repositories, list):
            raise TypeError("Expected argument 'source_repositories' to be a list")
        pulumi.set(__self__, "source_repositories", source_repositories)
        if timeout and not isinstance(timeout, float):
            raise TypeError("Expected argument 'timeout' to be a float")
        pulumi.set(__self__, "timeout", timeout)
        if trigger_http and not isinstance(trigger_http, bool):
            raise TypeError("Expected argument 'trigger_http' to be a bool")
        pulumi.set(__self__, "trigger_http", trigger_http)
        if vpc_connector and not isinstance(vpc_connector, str):
            raise TypeError("Expected argument 'vpc_connector' to be a str")
        pulumi.set(__self__, "vpc_connector", vpc_connector)
        if vpc_connector_egress_settings and not isinstance(vpc_connector_egress_settings, str):
            raise TypeError("Expected argument 'vpc_connector_egress_settings' to be a str")
        pulumi.set(__self__, "vpc_connector_egress_settings", vpc_connector_egress_settings)

    @property
    @pulumi.getter(name="availableMemoryMb")
    def available_memory_mb(self) -> float:
        """
        Available memory (in MB) to the function.
        """
        return pulumi.get(self, "available_memory_mb")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the function.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="entryPoint")
    def entry_point(self) -> str:
        """
        Name of a JavaScript function that will be executed when the Google Cloud Function is triggered.
        """
        return pulumi.get(self, "entry_point")

    @property
    @pulumi.getter(name="environmentVariables")
    def environment_variables(self) -> Mapping[str, Any]:
        return pulumi.get(self, "environment_variables")

    @property
    @pulumi.getter(name="eventTriggers")
    def event_triggers(self) -> List['outputs.GetFunctionEventTriggerResult']:
        """
        A source that fires events in response to a condition in another service. Structure is documented below.
        """
        return pulumi.get(self, "event_triggers")

    @property
    @pulumi.getter(name="httpsTriggerUrl")
    def https_trigger_url(self) -> str:
        """
        If function is triggered by HTTP, trigger URL is set here.
        """
        return pulumi.get(self, "https_trigger_url")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="ingressSettings")
    def ingress_settings(self) -> str:
        """
        Controls what traffic can reach the function.
        """
        return pulumi.get(self, "ingress_settings")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, Any]:
        """
        A map of labels applied to this function.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="maxInstances")
    def max_instances(self) -> float:
        """
        The limit on the maximum number of function instances that may coexist at a given time.
        """
        return pulumi.get(self, "max_instances")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the Cloud Function.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> Optional[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def region(self) -> Optional[str]:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter
    def runtime(self) -> str:
        """
        The runtime in which the function is running.
        """
        return pulumi.get(self, "runtime")

    @property
    @pulumi.getter(name="serviceAccountEmail")
    def service_account_email(self) -> str:
        """
        The service account email to be assumed by the cloud function.
        """
        return pulumi.get(self, "service_account_email")

    @property
    @pulumi.getter(name="sourceArchiveBucket")
    def source_archive_bucket(self) -> str:
        """
        The GCS bucket containing the zip archive which contains the function.
        """
        return pulumi.get(self, "source_archive_bucket")

    @property
    @pulumi.getter(name="sourceArchiveObject")
    def source_archive_object(self) -> str:
        """
        The source archive object (file) in archive bucket.
        """
        return pulumi.get(self, "source_archive_object")

    @property
    @pulumi.getter(name="sourceRepositories")
    def source_repositories(self) -> List['outputs.GetFunctionSourceRepositoryResult']:
        """
        The URL of the Cloud Source Repository that the function is deployed from. Structure is documented below.
        """
        return pulumi.get(self, "source_repositories")

    @property
    @pulumi.getter
    def timeout(self) -> float:
        """
        Function execution timeout (in seconds).
        """
        return pulumi.get(self, "timeout")

    @property
    @pulumi.getter(name="triggerHttp")
    def trigger_http(self) -> bool:
        """
        If function is triggered by HTTP, this boolean is set.
        """
        return pulumi.get(self, "trigger_http")

    @property
    @pulumi.getter(name="vpcConnector")
    def vpc_connector(self) -> str:
        """
        The VPC Network Connector that this cloud function can connect to.
        """
        return pulumi.get(self, "vpc_connector")

    @property
    @pulumi.getter(name="vpcConnectorEgressSettings")
    def vpc_connector_egress_settings(self) -> str:
        """
        The egress settings for the connector, controlling what traffic is diverted through it.
        """
        return pulumi.get(self, "vpc_connector_egress_settings")


class AwaitableGetFunctionResult(GetFunctionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetFunctionResult(
            available_memory_mb=self.available_memory_mb,
            description=self.description,
            entry_point=self.entry_point,
            environment_variables=self.environment_variables,
            event_triggers=self.event_triggers,
            https_trigger_url=self.https_trigger_url,
            id=self.id,
            ingress_settings=self.ingress_settings,
            labels=self.labels,
            max_instances=self.max_instances,
            name=self.name,
            project=self.project,
            region=self.region,
            runtime=self.runtime,
            service_account_email=self.service_account_email,
            source_archive_bucket=self.source_archive_bucket,
            source_archive_object=self.source_archive_object,
            source_repositories=self.source_repositories,
            timeout=self.timeout,
            trigger_http=self.trigger_http,
            vpc_connector=self.vpc_connector,
            vpc_connector_egress_settings=self.vpc_connector_egress_settings)


def get_function(name: Optional[str] = None,
                 project: Optional[str] = None,
                 region: Optional[str] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetFunctionResult:
    """
    Get information about a Google Cloud Function. For more information see
    the [official documentation](https://cloud.google.com/functions/docs/)
    and [API](https://cloud.google.com/functions/docs/apis).


    :param str name: The name of a Cloud Function.
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
    __ret__ = pulumi.runtime.invoke('gcp:cloudfunctions/getFunction:getFunction', __args__, opts=opts, typ=GetFunctionResult).value

    return AwaitableGetFunctionResult(
        available_memory_mb=__ret__.available_memory_mb,
        description=__ret__.description,
        entry_point=__ret__.entry_point,
        environment_variables=__ret__.environment_variables,
        event_triggers=__ret__.event_triggers,
        https_trigger_url=__ret__.https_trigger_url,
        id=__ret__.id,
        ingress_settings=__ret__.ingress_settings,
        labels=__ret__.labels,
        max_instances=__ret__.max_instances,
        name=__ret__.name,
        project=__ret__.project,
        region=__ret__.region,
        runtime=__ret__.runtime,
        service_account_email=__ret__.service_account_email,
        source_archive_bucket=__ret__.source_archive_bucket,
        source_archive_object=__ret__.source_archive_object,
        source_repositories=__ret__.source_repositories,
        timeout=__ret__.timeout,
        trigger_http=__ret__.trigger_http,
        vpc_connector=__ret__.vpc_connector,
        vpc_connector_egress_settings=__ret__.vpc_connector_egress_settings)
