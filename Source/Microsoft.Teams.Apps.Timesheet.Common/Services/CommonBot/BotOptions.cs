﻿// <copyright file="BotOptions.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Common.Services.CommonBot
{
    /// <summary>
    /// Options used for holding metadata for the bot.
    /// </summary>
    public class BotOptions
    {
        /// <summary>
        /// Gets or sets the Microsoft app Id for the bot.
        /// </summary>
        public string MicrosoftAppId { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft app password for the bot.
        /// </summary>
        public string MicrosoftAppPassword { get; set; }
    }
}
