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
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices.Models
{
    /// <summary>
    /// The definition of a Service resource base object with name.
    /// </summary>
    public partial class ManagementResponseObject : ManagementBaseObject
    {
        private string _instanceId;
        
        /// <summary>
        /// Optional. Object InstanceId.
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Object Name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool _operationInProgress;
        
        /// <summary>
        /// Optional. Object OperationInProgress.
        /// </summary>
        public bool OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ManagementResponseObject class.
        /// </summary>
        public ManagementResponseObject()
        {
        }
    }
}
