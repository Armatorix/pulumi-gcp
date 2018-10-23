# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class Function(pulumi.CustomResource):
    """
    Creates a new Cloud Function. For more information see
    [the official documentation](https://cloud.google.com/functions/docs/)
    and
    [API](https://cloud.google.com/functions/docs/apis).
    """
    def __init__(__self__, __name__, __opts__=None, available_memory_mb=None, description=None, entry_point=None, environment_variables=None, event_trigger=None, https_trigger_url=None, labels=None, name=None, project=None, region=None, retry_on_failure=None, source_archive_bucket=None, source_archive_object=None, timeout=None, trigger_bucket=None, trigger_http=None, trigger_topic=None):
        """Create a Function resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if available_memory_mb and not isinstance(available_memory_mb, int):
            raise TypeError('Expected property available_memory_mb to be a int')
        __self__.available_memory_mb = available_memory_mb
        """
        Memory (in MB), available to the function. Default value is 256MB. Allowed values are: 128MB, 256MB, 512MB, 1024MB, and 2048MB.
        """
        __props__['availableMemoryMb'] = available_memory_mb

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Description of the function.
        """
        __props__['description'] = description

        if entry_point and not isinstance(entry_point, basestring):
            raise TypeError('Expected property entry_point to be a basestring')
        __self__.entry_point = entry_point
        """
        Name of a JavaScript function that will be executed when the Google Cloud Function is triggered.
        """
        __props__['entryPoint'] = entry_point

        if environment_variables and not isinstance(environment_variables, dict):
            raise TypeError('Expected property environment_variables to be a dict')
        __self__.environment_variables = environment_variables
        """
        A set of key/value environment variable pairs to assign to the function.
        """
        __props__['environmentVariables'] = environment_variables

        if event_trigger and not isinstance(event_trigger, dict):
            raise TypeError('Expected property event_trigger to be a dict')
        __self__.event_trigger = event_trigger
        """
        A source that fires events in response to a condition in another service. Structure is documented below. Cannot be used with `trigger_http`.
        """
        __props__['eventTrigger'] = event_trigger

        if https_trigger_url and not isinstance(https_trigger_url, basestring):
            raise TypeError('Expected property https_trigger_url to be a basestring')
        __self__.https_trigger_url = https_trigger_url
        """
        URL which triggers function execution. Returned only if `trigger_http` is used.
        """
        __props__['httpsTriggerUrl'] = https_trigger_url

        if labels and not isinstance(labels, dict):
            raise TypeError('Expected property labels to be a dict')
        __self__.labels = labels
        """
        A set of key/value label pairs to assign to the function.
        """
        __props__['labels'] = labels

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        A user-defined name of the function. Function names must be unique globally.
        """
        __props__['name'] = name

        if project and not isinstance(project, basestring):
            raise TypeError('Expected property project to be a basestring')
        __self__.project = project
        """
        Project of the function. If it is not provided, the provider project is used.
        """
        __props__['project'] = project

        if region and not isinstance(region, basestring):
            raise TypeError('Expected property region to be a basestring')
        __self__.region = region
        """
        Region of function. Currently can be only "us-central1". If it is not provided, the provider region is used.
        """
        __props__['region'] = region

        if retry_on_failure and not isinstance(retry_on_failure, bool):
            raise TypeError('Expected property retry_on_failure to be a bool')
        __self__.retry_on_failure = retry_on_failure
        """
        Whether the function should be retried on failure. This only applies to bucket and topic triggers, not HTTPS triggers.
        Deprecated. Use `event_trigger.failure_policy.retry` instead.
        """
        __props__['retryOnFailure'] = retry_on_failure

        if not source_archive_bucket:
            raise TypeError('Missing required property source_archive_bucket')
        elif not isinstance(source_archive_bucket, basestring):
            raise TypeError('Expected property source_archive_bucket to be a basestring')
        __self__.source_archive_bucket = source_archive_bucket
        """
        The GCS bucket containing the zip archive which contains the function.
        """
        __props__['sourceArchiveBucket'] = source_archive_bucket

        if not source_archive_object:
            raise TypeError('Missing required property source_archive_object')
        elif not isinstance(source_archive_object, basestring):
            raise TypeError('Expected property source_archive_object to be a basestring')
        __self__.source_archive_object = source_archive_object
        """
        The source archive object (file) in archive bucket.
        """
        __props__['sourceArchiveObject'] = source_archive_object

        if timeout and not isinstance(timeout, int):
            raise TypeError('Expected property timeout to be a int')
        __self__.timeout = timeout
        """
        Timeout (in seconds) for the function. Default value is 60 seconds. Cannot be more than 540 seconds.
        """
        __props__['timeout'] = timeout

        if trigger_bucket and not isinstance(trigger_bucket, basestring):
            raise TypeError('Expected property trigger_bucket to be a basestring')
        __self__.trigger_bucket = trigger_bucket
        """
        Google Cloud Storage bucket name. Every change in files in this bucket will trigger function execution. Cannot be used with `trigger_http` and `trigger_topic`.
        Deprecated. Use `event_trigger` instead.
        """
        __props__['triggerBucket'] = trigger_bucket

        if trigger_http and not isinstance(trigger_http, bool):
            raise TypeError('Expected property trigger_http to be a bool')
        __self__.trigger_http = trigger_http
        """
        Boolean variable. Any HTTP request (of a supported type) to the endpoint will trigger function execution. Supported HTTP request types are: POST, PUT, GET, DELETE, and OPTIONS. Endpoint is returned as `https_trigger_url`. Cannot be used with `trigger_bucket` and `trigger_topic`.
        """
        __props__['triggerHttp'] = trigger_http

        if trigger_topic and not isinstance(trigger_topic, basestring):
            raise TypeError('Expected property trigger_topic to be a basestring')
        __self__.trigger_topic = trigger_topic
        """
        Name of Pub/Sub topic. Every message published in this topic will trigger function execution with message contents passed as input data. Cannot be used with `trigger_http` and `trigger_bucket`.
        Deprecated. Use `event_trigger` instead.
        """
        __props__['triggerTopic'] = trigger_topic

        super(Function, __self__).__init__(
            'gcp:cloudfunctions/function:Function',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'availableMemoryMb' in outs:
            self.available_memory_mb = outs['availableMemoryMb']
        if 'description' in outs:
            self.description = outs['description']
        if 'entryPoint' in outs:
            self.entry_point = outs['entryPoint']
        if 'environmentVariables' in outs:
            self.environment_variables = outs['environmentVariables']
        if 'eventTrigger' in outs:
            self.event_trigger = outs['eventTrigger']
        if 'httpsTriggerUrl' in outs:
            self.https_trigger_url = outs['httpsTriggerUrl']
        if 'labels' in outs:
            self.labels = outs['labels']
        if 'name' in outs:
            self.name = outs['name']
        if 'project' in outs:
            self.project = outs['project']
        if 'region' in outs:
            self.region = outs['region']
        if 'retryOnFailure' in outs:
            self.retry_on_failure = outs['retryOnFailure']
        if 'sourceArchiveBucket' in outs:
            self.source_archive_bucket = outs['sourceArchiveBucket']
        if 'sourceArchiveObject' in outs:
            self.source_archive_object = outs['sourceArchiveObject']
        if 'timeout' in outs:
            self.timeout = outs['timeout']
        if 'triggerBucket' in outs:
            self.trigger_bucket = outs['triggerBucket']
        if 'triggerHttp' in outs:
            self.trigger_http = outs['triggerHttp']
        if 'triggerTopic' in outs:
            self.trigger_topic = outs['triggerTopic']
