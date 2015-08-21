// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    public static partial class MarsContainerOperationsExtensions
    {
        /// <summary>
        /// Enable the container reregistration.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerId'>
        /// Required. MARS container ID.
        /// </param>
        /// <param name='enableReregistrationRequest'>
        /// Required. Enable Reregistration Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse EnableMarsContainerReregistration(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, string containerId, EnableReregistrationRequest enableReregistrationRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMarsContainerOperations)s).EnableMarsContainerReregistrationAsync(resourceGroupName, resourceName, containerId, enableReregistrationRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enable the container reregistration.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerId'>
        /// Required. MARS container ID.
        /// </param>
        /// <param name='enableReregistrationRequest'>
        /// Required. Enable Reregistration Request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> EnableMarsContainerReregistrationAsync(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, string containerId, EnableReregistrationRequest enableReregistrationRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.EnableMarsContainerReregistrationAsync(resourceGroupName, resourceName, containerId, enableReregistrationRequest, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all container based on the given query filter
        /// string.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerType'>
        /// Required. Type of container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// List of Microsoft Azure Recovery Services (MARS) containers.
        /// </returns>
        public static ListMarsContainerOperationResponse ListMarsContainersByType(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, MarsContainerType containerType, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMarsContainerOperations)s).ListMarsContainersByTypeAsync(resourceGroupName, resourceName, containerType, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all container based on the given query filter
        /// string.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerType'>
        /// Required. Type of container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// List of Microsoft Azure Recovery Services (MARS) containers.
        /// </returns>
        public static Task<ListMarsContainerOperationResponse> ListMarsContainersByTypeAsync(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, MarsContainerType containerType, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListMarsContainersByTypeAsync(resourceGroupName, resourceName, containerType, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all container based on the given query filter
        /// string.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerType'>
        /// Required. Type of container.
        /// </param>
        /// <param name='friendlyName'>
        /// Required. Friendly name of container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// List of Microsoft Azure Recovery Services (MARS) containers.
        /// </returns>
        public static ListMarsContainerOperationResponse ListMarsContainersByTypeAndFriendlyName(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, MarsContainerType containerType, string friendlyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMarsContainerOperations)s).ListMarsContainersByTypeAndFriendlyNameAsync(resourceGroupName, resourceName, containerType, friendlyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all container based on the given query filter
        /// string.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerType'>
        /// Required. Type of container.
        /// </param>
        /// <param name='friendlyName'>
        /// Required. Friendly name of container.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// List of Microsoft Azure Recovery Services (MARS) containers.
        /// </returns>
        public static Task<ListMarsContainerOperationResponse> ListMarsContainersByTypeAndFriendlyNameAsync(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, MarsContainerType containerType, string friendlyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListMarsContainersByTypeAndFriendlyNameAsync(resourceGroupName, resourceName, containerType, friendlyName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Unregister the container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerId'>
        /// Required. MARS container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse UnregisterMarsContainer(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, string containerId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMarsContainerOperations)s).UnregisterMarsContainerAsync(resourceGroupName, resourceName, containerId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unregister the container.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IMarsContainerOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='containerId'>
        /// Required. MARS container ID.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> UnregisterMarsContainerAsync(this IMarsContainerOperations operations, string resourceGroupName, string resourceName, string containerId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UnregisterMarsContainerAsync(resourceGroupName, resourceName, containerId, customRequestHeaders, CancellationToken.None);
        }
    }
}
