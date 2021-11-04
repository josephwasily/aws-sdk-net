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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKMeetings service
    ///</summary>
    public class ChimeSDKMeetingsPaginatorFactory : IChimeSDKMeetingsPaginatorFactory
    {
        private readonly IAmazonChimeSDKMeetings client;

        internal ChimeSDKMeetingsPaginatorFactory(IAmazonChimeSDKMeetings client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAttendees operation
        ///</summary>
        public IListAttendeesPaginator ListAttendees(ListAttendeesRequest request) 
        {
            return new ListAttendeesPaginator(this.client, request);
        }
    }
}