// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql
{
    /// <summary>
    /// Creates a new Google SQL Database Instance. For more information, see the [official documentation](https://cloud.google.com/sql/),
    /// or the [JSON API](https://cloud.google.com/sql/docs/admin-api/v1beta4/instances).
    /// 
    /// &gt; **NOTE on `gcp.sql.DatabaseInstance`:** - First-generation instances have been
    /// deprecated and should no longer be created, see [upgrade docs](https://cloud.google.com/sql/docs/mysql/upgrade-2nd-gen)
    /// for more details.
    /// To upgrade your First-generation instance, update your config that the instance has
    /// * `settings.ip_configuration.ipv4_enabled=true`
    /// * `settings.backup_configuration.enabled=true`
    /// * `settings.backup_configuration.binary_log_enabled=true`.  
    /// Apply the config, then upgrade the instance in the console as described in the documentation.
    /// Once upgraded, update the following attributes in your config to the correct value according to
    /// the above documentation:
    /// * `region`
    /// * `database_version` (if applicable)
    /// * `tier`  
    /// Remove any fields that are not applicable to Second-generation instances:
    /// * `settings.crash_safe_replication`
    /// * `settings.replication_type`
    /// * `settings.authorized_gae_applications`
    /// And change values to appropriate values for Second-generation instances for:
    /// * `activation_policy` ("ON_DEMAND" is no longer an option)
    /// * `pricing_plan` ("PER_USE" is now the only valid option)
    /// Change `settings.backup_configuration.enabled` attribute back to its desired value and apply as necessary.
    /// 
    /// &gt; **NOTE on `gcp.sql.DatabaseInstance`:** - Second-generation instances include a
    /// default 'root'@'%' user with no password. This user will be deleted by the provider on
    /// instance creation. You should use `gcp.sql.User` to define a custom user with
    /// a restricted host and strong password.
    /// </summary>
    public partial class DatabaseInstance : Pulumi.CustomResource
    {
        /// <summary>
        /// The connection name of the instance to be used in
        /// connection strings. For example, when connecting with [Cloud SQL Proxy](https://cloud.google.com/sql/docs/mysql/connect-admin-proxy).
        /// </summary>
        [Output("connectionName")]
        public Output<string> ConnectionName { get; private set; } = null!;

        /// <summary>
        /// The MySQL, PostgreSQL or
        /// SQL Server (beta) version to use. Supported values include `MYSQL_5_6`,
        /// `MYSQL_5_7`, `POSTGRES_9_6`,`POSTGRES_11`, `SQLSERVER_2017_STANDARD`,
        /// `SQLSERVER_2017_ENTERPRISE`, `SQLSERVER_2017_EXPRESS`, `SQLSERVER_2017_WEB`.
        /// [Database Version Policies](https://cloud.google.com/sql/docs/sqlserver/db-versions)
        /// includes an up-to-date reference of supported versions.
        /// </summary>
        [Output("databaseVersion")]
        public Output<string?> DatabaseVersion { get; private set; } = null!;

        /// <summary>
        /// 
        /// The full path to the encryption key used for the CMEK disk encryption.  Setting
        /// up disk encryption currently requires manual steps outside of this provider.
        /// The provided key must be in the same region as the SQL instance.  In order
        /// to use this feature, a special kind of service account must be created and
        /// granted permission on this key.  This step can currently only be done
        /// manually, please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#service-account).
        /// That service account needs the `Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter` role on your
        /// key - please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#grantkey).
        /// </summary>
        [Output("encryptionKeyName")]
        public Output<string> EncryptionKeyName { get; private set; } = null!;

        /// <summary>
        /// The first IPv4 address of any type assigned.
        /// </summary>
        [Output("firstIpAddress")]
        public Output<string> FirstIpAddress { get; private set; } = null!;

        [Output("ipAddresses")]
        public Output<ImmutableArray<Outputs.DatabaseInstanceIpAddress>> IpAddresses { get; private set; } = null!;

        /// <summary>
        /// The name of the instance that will act as
        /// the master in the replication setup. Note, this requires the master to have
        /// `binary_log_enabled` set, as well as existing backups.
        /// </summary>
        [Output("masterInstanceName")]
        public Output<string> MasterInstanceName { get; private set; } = null!;

        /// <summary>
        /// A name for this whitelist entry.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The first private (`PRIVATE`) IPv4 address assigned. 
        /// </summary>
        [Output("privateIpAddress")]
        public Output<string> PrivateIpAddress { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The first public (`PRIMARY`) IPv4 address assigned. 
        /// </summary>
        [Output("publicIpAddress")]
        public Output<string> PublicIpAddress { get; private set; } = null!;

        /// <summary>
        /// The region the instance will sit in. Note, Cloud SQL is not
        /// available in all regions - choose from one of the options listed [here](https://cloud.google.com/sql/docs/mysql/instance-locations).
        /// A valid region must be provided to use this resource. If a region is not provided in the resource definition,
        /// the provider region will be used instead, but this will be an apply-time error for instances if the provider
        /// region is not supported with Cloud SQL. If you choose not to provide the `region` argument for this resource,
        /// make sure you understand this.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The configuration for replication. The
        /// configuration is detailed below.
        /// </summary>
        [Output("replicaConfiguration")]
        public Output<Outputs.DatabaseInstanceReplicaConfiguration> ReplicaConfiguration { get; private set; } = null!;

        /// <summary>
        /// Initial root password. Required for MS SQL Server, ignored by MySQL and PostgreSQL.
        /// </summary>
        [Output("rootPassword")]
        public Output<string?> RootPassword { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        [Output("serverCaCert")]
        public Output<Outputs.DatabaseInstanceServerCaCert> ServerCaCert { get; private set; } = null!;

        /// <summary>
        /// The service account email address assigned to the
        /// instance.
        /// </summary>
        [Output("serviceAccountEmailAddress")]
        public Output<string> ServiceAccountEmailAddress { get; private set; } = null!;

        /// <summary>
        /// The settings to use for the database. The
        /// configuration is detailed below.
        /// </summary>
        [Output("settings")]
        public Output<Outputs.DatabaseInstanceSettings> Settings { get; private set; } = null!;


        /// <summary>
        /// Create a DatabaseInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatabaseInstance(string name, DatabaseInstanceArgs args, CustomResourceOptions? options = null)
            : base("gcp:sql/databaseInstance:DatabaseInstance", name, args ?? new DatabaseInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DatabaseInstance(string name, Input<string> id, DatabaseInstanceState? state = null, CustomResourceOptions? options = null)
            : base("gcp:sql/databaseInstance:DatabaseInstance", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DatabaseInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatabaseInstance Get(string name, Input<string> id, DatabaseInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new DatabaseInstance(name, id, state, options);
        }
    }

    public sealed class DatabaseInstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The MySQL, PostgreSQL or
        /// SQL Server (beta) version to use. Supported values include `MYSQL_5_6`,
        /// `MYSQL_5_7`, `POSTGRES_9_6`,`POSTGRES_11`, `SQLSERVER_2017_STANDARD`,
        /// `SQLSERVER_2017_ENTERPRISE`, `SQLSERVER_2017_EXPRESS`, `SQLSERVER_2017_WEB`.
        /// [Database Version Policies](https://cloud.google.com/sql/docs/sqlserver/db-versions)
        /// includes an up-to-date reference of supported versions.
        /// </summary>
        [Input("databaseVersion")]
        public Input<string>? DatabaseVersion { get; set; }

        /// <summary>
        /// 
        /// The full path to the encryption key used for the CMEK disk encryption.  Setting
        /// up disk encryption currently requires manual steps outside of this provider.
        /// The provided key must be in the same region as the SQL instance.  In order
        /// to use this feature, a special kind of service account must be created and
        /// granted permission on this key.  This step can currently only be done
        /// manually, please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#service-account).
        /// That service account needs the `Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter` role on your
        /// key - please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#grantkey).
        /// </summary>
        [Input("encryptionKeyName")]
        public Input<string>? EncryptionKeyName { get; set; }

        /// <summary>
        /// The name of the instance that will act as
        /// the master in the replication setup. Note, this requires the master to have
        /// `binary_log_enabled` set, as well as existing backups.
        /// </summary>
        [Input("masterInstanceName")]
        public Input<string>? MasterInstanceName { get; set; }

        /// <summary>
        /// A name for this whitelist entry.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The region the instance will sit in. Note, Cloud SQL is not
        /// available in all regions - choose from one of the options listed [here](https://cloud.google.com/sql/docs/mysql/instance-locations).
        /// A valid region must be provided to use this resource. If a region is not provided in the resource definition,
        /// the provider region will be used instead, but this will be an apply-time error for instances if the provider
        /// region is not supported with Cloud SQL. If you choose not to provide the `region` argument for this resource,
        /// make sure you understand this.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The configuration for replication. The
        /// configuration is detailed below.
        /// </summary>
        [Input("replicaConfiguration")]
        public Input<Inputs.DatabaseInstanceReplicaConfigurationArgs>? ReplicaConfiguration { get; set; }

        /// <summary>
        /// Initial root password. Required for MS SQL Server, ignored by MySQL and PostgreSQL.
        /// </summary>
        [Input("rootPassword")]
        public Input<string>? RootPassword { get; set; }

        /// <summary>
        /// The settings to use for the database. The
        /// configuration is detailed below.
        /// </summary>
        [Input("settings", required: true)]
        public Input<Inputs.DatabaseInstanceSettingsArgs> Settings { get; set; } = null!;

        public DatabaseInstanceArgs()
        {
        }
    }

    public sealed class DatabaseInstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The connection name of the instance to be used in
        /// connection strings. For example, when connecting with [Cloud SQL Proxy](https://cloud.google.com/sql/docs/mysql/connect-admin-proxy).
        /// </summary>
        [Input("connectionName")]
        public Input<string>? ConnectionName { get; set; }

        /// <summary>
        /// The MySQL, PostgreSQL or
        /// SQL Server (beta) version to use. Supported values include `MYSQL_5_6`,
        /// `MYSQL_5_7`, `POSTGRES_9_6`,`POSTGRES_11`, `SQLSERVER_2017_STANDARD`,
        /// `SQLSERVER_2017_ENTERPRISE`, `SQLSERVER_2017_EXPRESS`, `SQLSERVER_2017_WEB`.
        /// [Database Version Policies](https://cloud.google.com/sql/docs/sqlserver/db-versions)
        /// includes an up-to-date reference of supported versions.
        /// </summary>
        [Input("databaseVersion")]
        public Input<string>? DatabaseVersion { get; set; }

        /// <summary>
        /// 
        /// The full path to the encryption key used for the CMEK disk encryption.  Setting
        /// up disk encryption currently requires manual steps outside of this provider.
        /// The provided key must be in the same region as the SQL instance.  In order
        /// to use this feature, a special kind of service account must be created and
        /// granted permission on this key.  This step can currently only be done
        /// manually, please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#service-account).
        /// That service account needs the `Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter` role on your
        /// key - please see [this step](https://cloud.google.com/sql/docs/mysql/configure-cmek#grantkey).
        /// </summary>
        [Input("encryptionKeyName")]
        public Input<string>? EncryptionKeyName { get; set; }

        /// <summary>
        /// The first IPv4 address of any type assigned.
        /// </summary>
        [Input("firstIpAddress")]
        public Input<string>? FirstIpAddress { get; set; }

        [Input("ipAddresses")]
        private InputList<Inputs.DatabaseInstanceIpAddressGetArgs>? _ipAddresses;
        public InputList<Inputs.DatabaseInstanceIpAddressGetArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.DatabaseInstanceIpAddressGetArgs>());
            set => _ipAddresses = value;
        }

        /// <summary>
        /// The name of the instance that will act as
        /// the master in the replication setup. Note, this requires the master to have
        /// `binary_log_enabled` set, as well as existing backups.
        /// </summary>
        [Input("masterInstanceName")]
        public Input<string>? MasterInstanceName { get; set; }

        /// <summary>
        /// A name for this whitelist entry.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The first private (`PRIVATE`) IPv4 address assigned. 
        /// </summary>
        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The first public (`PRIMARY`) IPv4 address assigned. 
        /// </summary>
        [Input("publicIpAddress")]
        public Input<string>? PublicIpAddress { get; set; }

        /// <summary>
        /// The region the instance will sit in. Note, Cloud SQL is not
        /// available in all regions - choose from one of the options listed [here](https://cloud.google.com/sql/docs/mysql/instance-locations).
        /// A valid region must be provided to use this resource. If a region is not provided in the resource definition,
        /// the provider region will be used instead, but this will be an apply-time error for instances if the provider
        /// region is not supported with Cloud SQL. If you choose not to provide the `region` argument for this resource,
        /// make sure you understand this.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The configuration for replication. The
        /// configuration is detailed below.
        /// </summary>
        [Input("replicaConfiguration")]
        public Input<Inputs.DatabaseInstanceReplicaConfigurationGetArgs>? ReplicaConfiguration { get; set; }

        /// <summary>
        /// Initial root password. Required for MS SQL Server, ignored by MySQL and PostgreSQL.
        /// </summary>
        [Input("rootPassword")]
        public Input<string>? RootPassword { get; set; }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("serverCaCert")]
        public Input<Inputs.DatabaseInstanceServerCaCertGetArgs>? ServerCaCert { get; set; }

        /// <summary>
        /// The service account email address assigned to the
        /// instance.
        /// </summary>
        [Input("serviceAccountEmailAddress")]
        public Input<string>? ServiceAccountEmailAddress { get; set; }

        /// <summary>
        /// The settings to use for the database. The
        /// configuration is detailed below.
        /// </summary>
        [Input("settings")]
        public Input<Inputs.DatabaseInstanceSettingsGetArgs>? Settings { get; set; }

        public DatabaseInstanceState()
        {
        }
    }
}
