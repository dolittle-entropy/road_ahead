/*---------------------------------------------------------------------------------------------
 *  This file is an automatically generated ReadModel Proxy
 *  
 *--------------------------------------------------------------------------------------------*/
import { ReadModel } from  '@dolittle/readmodels';

export class KeyResult extends ReadModel
{
    constructor() {
        super();
        this.artifact = {
           id: '054047b0-850a-4b9a-9258-b31c4687128b',
           generation: '1'
        };
        this.originIdentifier = '';
        this.title = '';
        this.description = '';
        this.confidence = 0;
        this.leadBy = [];
        this.epics = [];
        this.statusGroups = [];
        this.metrics = [];
    }
}