/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Linq;
using Dolittle.Queries;

namespace Read.Insight
{

    /// <summary>
    /// Represents a query for getting objectives within a period
    /// </summary>
    public class ObjectivesForPeriod : IQueryFor<Objective>
    {
        /// <summary>
        /// Gets or sets the start of the period
        /// </summary>
        public DateTimeOffset Start { get; set; }

        /// <summary>
        /// Gets or sets the end of the period
        /// </summary>
        public DateTimeOffset End { get; set; }

        /// <summary>
        /// Gets the query
        /// </summary>
        public IQueryable<Objective>    Query => new Objective[0].AsQueryable();       
    }
}