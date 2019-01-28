#!/bin/bash
docker push dolittle/road_ahead
kubectl patch deployment road_ahead --namespace dolittle -p "{\"spec\":{\"template\":{\"metadata\":{\"labels\":{\"date\":\"`date +'%s'`\"}}}}}"
