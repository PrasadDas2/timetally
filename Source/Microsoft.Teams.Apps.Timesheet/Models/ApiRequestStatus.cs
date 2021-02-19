﻿// <copyright file="ApiRequestStatus.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Models
{
    /// <summary>
    /// The API request status.
    /// </summary>
    public enum ApiRequestStatus
    {
        /// <summary>
        /// Represents the request is initiated.
        /// </summary>
        Initiated,

        /// <summary>
        /// Represents the request is completed.
        /// </summary>
        Succeeded,

        /// <summary>
        /// Represents the request is failed.
        /// </summary>
        Failed,
    }
}
