// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Contains information about an Azure Batch account.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class BatchAccountInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountInner class.
        /// </summary>
        public BatchAccountInner() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountInner class.
        /// </summary>
        /// <param name="coreQuota">The core quota for this Batch
        /// account.</param>
        /// <param name="poolQuota">The pool quota for this Batch
        /// account.</param>
        /// <param name="activeJobAndJobScheduleQuota">The active job and job
        /// schedule quota for this Batch account.</param>
        /// <param name="accountEndpoint">The endpoint used by this account to
        /// interact with the Batch services.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Invalid', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Cancelled'</param>
        /// <param name="autoStorage">The properties and status of any auto
        /// storage account associated with the account.</param>
        public BatchAccountInner(int coreQuota, int poolQuota, int activeJobAndJobScheduleQuota, string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string accountEndpoint = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), AutoStorageProperties autoStorage = default(AutoStorageProperties))
            : base(location, id, name, type, tags)
        {
            AccountEndpoint = accountEndpoint;
            ProvisioningState = provisioningState;
            AutoStorage = autoStorage;
            CoreQuota = coreQuota;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
        }

        /// <summary>
        /// Gets the endpoint used by this account to interact with the Batch
        /// services.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accountEndpoint")]
        public string AccountEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the provisioned state of the resource. Possible
        /// values include: 'Invalid', 'Creating', 'Deleting', 'Succeeded',
        /// 'Failed', 'Cancelled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the properties and status of any auto storage account
        /// associated with the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageProperties AutoStorage { get; set; }

        /// <summary>
        /// Gets or sets the core quota for this Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.coreQuota")]
        public int CoreQuota { get; set; }

        /// <summary>
        /// Gets or sets the pool quota for this Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.poolQuota")]
        public int PoolQuota { get; set; }

        /// <summary>
        /// Gets or sets the active job and job schedule quota for this Batch
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.activeJobAndJobScheduleQuota")]
        public int ActiveJobAndJobScheduleQuota { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            if (this.AutoStorage != null)
            {
                this.AutoStorage.Validate();
            }
        }
    }
}