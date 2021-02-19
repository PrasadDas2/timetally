﻿// <copyright file="ReporteeDTO.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Models
{
    using System;

    /// <summary>
    /// Represents reportee details.
    /// </summary>
    public class ReporteeDTO
    {
        /// <summary>
        /// Gets or sets user's AAD object identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets display name of user.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets unique user principal name of user.
        /// </summary>
        public string UserPrincipalName { get; set; }
    }
}
