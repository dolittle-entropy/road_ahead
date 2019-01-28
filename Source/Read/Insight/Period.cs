/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.ReadModels;

namespace Read.Insight
{
    /// <summary>
    /// Represents a period
    /// </summary>
    public class Period : IReadModel
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="Period"/>
        /// </summary>
        public string Title {  get; set; }

        /// <summary>
        /// Gets or sets the start <see cref="DateTimeOffset"/>
        /// </summary>
        public DateTimeOffset StartDate {  get; set; }

        /// <summary>
        /// Gets or sets the end <see cref="DateTimeOffset"/>
        /// </summary>
        public DateTimeOffset EndDate {  get; set; }
    }
}