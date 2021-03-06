// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SnapshotsOperations.
    /// </summary>
    public static partial class SnapshotsOperationsExtensions
    {
            /// <summary>
            /// List snapshots
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            public static IEnumerable<Snapshot> List(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName)
            {
                return operations.ListAsync(resourceGroupName, accountName, poolName, volumeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List snapshots
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Snapshot>> ListAsync(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static Snapshot Get(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                return operations.GetAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> GetAsync(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static Snapshot Create(this ISnapshotsOperations operations, Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                return operations.CreateAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> CreateAsync(this ISnapshotsOperations operations, Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static Snapshot Update(this ISnapshotsOperations operations, SnapshotPatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                return operations.UpdateAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> UpdateAsync(this ISnapshotsOperations operations, SnapshotPatch body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static void Delete(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static Snapshot BeginCreate(this ISnapshotsOperations operations, Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                return operations.BeginCreateAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Snapshot object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Snapshot> BeginCreateAsync(this ISnapshotsOperations operations, Snapshot body, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(body, resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            public static void BeginDelete(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete snapshot
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='poolName'>
            /// The name of the capacity pool
            /// </param>
            /// <param name='volumeName'>
            /// The name of the volume
            /// </param>
            /// <param name='snapshotName'>
            /// The name of the mount target
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISnapshotsOperations operations, string resourceGroupName, string accountName, string poolName, string volumeName, string snapshotName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, volumeName, snapshotName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
