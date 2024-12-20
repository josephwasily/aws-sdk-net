/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// This is the response object from the CreateLicenseServerEndpoint operation.
    /// </summary>
    public partial class CreateLicenseServerEndpointResponse : AmazonWebServiceResponse
    {
        private string _identityProviderArn;
        private string _licenseServerEndpointArn;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity provider specified in the request.
        /// </para>
        /// </summary>
        public string IdentityProviderArn
        {
            get { return this._identityProviderArn; }
            set { this._identityProviderArn = value; }
        }

        // Check to see if IdentityProviderArn property is set
        internal bool IsSetIdentityProviderArn()
        {
            return this._identityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServerEndpointArn. 
        /// <para>
        /// The ARN of the <c>LicenseServerEndpoint</c> resource.
        /// </para>
        /// </summary>
        public string LicenseServerEndpointArn
        {
            get { return this._licenseServerEndpointArn; }
            set { this._licenseServerEndpointArn = value; }
        }

        // Check to see if LicenseServerEndpointArn property is set
        internal bool IsSetLicenseServerEndpointArn()
        {
            return this._licenseServerEndpointArn != null;
        }

    }
}