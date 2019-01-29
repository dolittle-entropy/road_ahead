/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/


namespace Read.Insight
{
    /// <summary>
    /// Represents an epic
    /// </summary>
    public class Epic
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the percent complete
        /// </summary>
        public int PercentComplete { get; set; }
    }
}