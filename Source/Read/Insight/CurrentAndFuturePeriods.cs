/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Linq;
using Dolittle.Queries;

namespace Read.Insight
{
    /// <summary>
    /// Represents a query for getting current and future periods
    /// </summary>
    public class CurrentAndFuturePeriods : IQueryFor<Period>
    {
        /// <summary>
        /// Gets the query
        /// </summary>
        public IQueryable<Period> Query => new Period[0].AsQueryable();
    }
}