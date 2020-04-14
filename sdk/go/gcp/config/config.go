// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi/config"
)

func GetAccessContextManagerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:accessContextManagerCustomEndpoint")
}
func GetAccessToken(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:accessToken")
}
func GetAppEngineCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:appEngineCustomEndpoint")
}
func GetBatching(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:batching")
}
func GetBigQueryCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:bigQueryCustomEndpoint")
}
func GetBigqueryDataTransferCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:bigqueryDataTransferCustomEndpoint")
}
func GetBigqueryReservationCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:bigqueryReservationCustomEndpoint")
}
func GetBigtableCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:bigtableCustomEndpoint")
}
func GetBillingCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:billingCustomEndpoint")
}
func GetBinaryAuthorizationCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:binaryAuthorizationCustomEndpoint")
}
func GetCloudBillingCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudBillingCustomEndpoint")
}
func GetCloudBuildCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudBuildCustomEndpoint")
}
func GetCloudFunctionsCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudFunctionsCustomEndpoint")
}
func GetCloudIotCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudIotCustomEndpoint")
}
func GetCloudRunCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudRunCustomEndpoint")
}
func GetCloudSchedulerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudSchedulerCustomEndpoint")
}
func GetCloudTasksCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:cloudTasksCustomEndpoint")
}
func GetComposerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:composerCustomEndpoint")
}
func GetComputeBetaCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:computeBetaCustomEndpoint")
}
func GetComputeCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:computeCustomEndpoint")
}
func GetContainerAnalysisCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:containerAnalysisCustomEndpoint")
}
func GetContainerBetaCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:containerBetaCustomEndpoint")
}
func GetContainerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:containerCustomEndpoint")
}
func GetCredentials(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "gcp:credentials")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "GOOGLE_CREDENTIALS", "GOOGLE_CLOUD_KEYFILE_JSON", "GCLOUD_KEYFILE_JSON").(string)
}
func GetDataFusionCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dataFusionCustomEndpoint")
}
func GetDataflowCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dataflowCustomEndpoint")
}
func GetDataprocBetaCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dataprocBetaCustomEndpoint")
}
func GetDataprocCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dataprocCustomEndpoint")
}
func GetDatastoreCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:datastoreCustomEndpoint")
}
func GetDeploymentManagerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:deploymentManagerCustomEndpoint")
}
func GetDialogflowCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dialogflowCustomEndpoint")
}
func GetDnsBetaCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dnsBetaCustomEndpoint")
}
func GetDnsCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:dnsCustomEndpoint")
}
func GetFilestoreCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:filestoreCustomEndpoint")
}
func GetFirebaseCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:firebaseCustomEndpoint")
}
func GetFirestoreCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:firestoreCustomEndpoint")
}
func GetGameServicesCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:gameServicesCustomEndpoint")
}
func GetHealthcareCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:healthcareCustomEndpoint")
}
func GetIamCredentialsCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:iamCredentialsCustomEndpoint")
}
func GetIamCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:iamCustomEndpoint")
}
func GetIapCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:iapCustomEndpoint")
}
func GetIdentityPlatformCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:identityPlatformCustomEndpoint")
}
func GetKmsCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:kmsCustomEndpoint")
}
func GetLoggingCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:loggingCustomEndpoint")
}
func GetMlEngineCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:mlEngineCustomEndpoint")
}
func GetMonitoringCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:monitoringCustomEndpoint")
}
func GetProject(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "gcp:project")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "GOOGLE_PROJECT", "GOOGLE_CLOUD_PROJECT", "GCLOUD_PROJECT", "CLOUDSDK_CORE_PROJECT").(string)
}
func GetPubsubCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:pubsubCustomEndpoint")
}
func GetRedisCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:redisCustomEndpoint")
}
func GetRegion(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "gcp:region")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "GOOGLE_REGION", "GCLOUD_REGION", "CLOUDSDK_COMPUTE_REGION").(string)
}
func GetRequestTimeout(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:requestTimeout")
}
func GetResourceManagerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:resourceManagerCustomEndpoint")
}
func GetResourceManagerV2beta1CustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:resourceManagerV2beta1CustomEndpoint")
}
func GetRuntimeConfigCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:runtimeConfigCustomEndpoint")
}
func GetRuntimeconfigCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:runtimeconfigCustomEndpoint")
}
func GetScopes(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:scopes")
}
func GetSecretManagerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:secretManagerCustomEndpoint")
}
func GetSecurityCenterCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:securityCenterCustomEndpoint")
}
func GetSecurityScannerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:securityScannerCustomEndpoint")
}
func GetServiceManagementCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:serviceManagementCustomEndpoint")
}
func GetServiceNetworkingCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:serviceNetworkingCustomEndpoint")
}
func GetServiceUsageCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:serviceUsageCustomEndpoint")
}
func GetSourceRepoCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:sourceRepoCustomEndpoint")
}
func GetSpannerCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:spannerCustomEndpoint")
}
func GetSqlCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:sqlCustomEndpoint")
}
func GetStorageCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:storageCustomEndpoint")
}
func GetStorageTransferCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:storageTransferCustomEndpoint")
}
func GetTpuCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:tpuCustomEndpoint")
}
func GetUserProjectOverride(ctx *pulumi.Context) bool {
	return config.GetBool(ctx, "gcp:userProjectOverride")
}
func GetVpcAccessCustomEndpoint(ctx *pulumi.Context) string {
	return config.Get(ctx, "gcp:vpcAccessCustomEndpoint")
}
func GetZone(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "gcp:zone")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "GOOGLE_ZONE", "GCLOUD_ZONE", "CLOUDSDK_COMPUTE_ZONE").(string)
}
