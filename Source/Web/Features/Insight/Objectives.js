/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { inject } from 'aurelia-framework';
import { QueryCoordinator } from '@dolittle/queries';
import { CurrentAndFuturePeriods } from './CurrentAndFuturePeriods';
import { ObjectivesForPeriod } from './ObjectivesForPeriod';
 

@inject(QueryCoordinator)
export class Objectives {
    #queryCoordinator;

    periods = [];
    objectives = [];
    

    constructor(queryCoordinator) {
        this.#queryCoordinator = queryCoordinator;

        this.populatePeriods();
        this.populateObjectives();
    }

    async populatePeriods() {
        let result = await this.#queryCoordinator.execute(new CurrentAndFuturePeriods());
        this.periods = result.items;
    }

    async populateObjectives() {
        let query = new ObjectivesForPeriod();
        //query.start = new Date();
        //query.end = new Date();
        let result = await this.#queryCoordinator.execute(query);
        this.objectives = result.items;
        result.items.forEach(objective => {
            objective.epicLines = [];

            objective.keyResults.forEach((keyResult, keyResultIndex) => {
                keyResult.epics.forEach((epic, epicIndex) => {
                    let epicLine = objective.epicLines[epicIndex];
                    if( !epicLine ) {
                        epicLine = { epics: [] };
                        objective.epicLines[epicIndex] = epicLine;
                    }
                    epicLine.epics[keyResultIndex] = epic;
                });
            });
        });

    }
}