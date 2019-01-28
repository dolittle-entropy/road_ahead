/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { inject } from 'aurelia-framework';
import { QueryCoordinator } from '@dolittle/queries';
import { CurrentAndFuturePeriods } from './CurrentAndFuturePeriods';
 

@inject(QueryCoordinator)
export class Objectives {
    #queryCoordinator;

    #periods = [];

    constructor(queryCoordinator) {
        this.#queryCoordinator = queryCoordinator;

        this.populatePeriods();
    }

    async populatePeriods() {
        let result = await this.#queryCoordinator.execute(new CurrentAndFuturePeriods());
        this.#periods = result.items;
    }
}