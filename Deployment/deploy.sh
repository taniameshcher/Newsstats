#!/bin/bash

echo 'Checking for running container...'
if [ $(docker ps -a -q -f name=newsstat) ]; then
    echo 'newsstat data container will be deleted'
    docker rm -f newsstat
fi

echo 'Env vars:'
echo "DOCKER_USER: $DOCKER_USER"
echo "DOCKER_REGISTRY: $DOCKER_REGISTRY"
echo "DOCKER_IMAGE: $DOCKER_IMAGE"

echo 'Login to registry...'
docker login --username $DOCKER_USER --password $DOCKER_PASS $DOCKER_REGISTRY

echo 'Pulling the image...'
docker pull alexproj.azurecr.io/newsstat:latest

echo 'Run...'
docker run \
  -d \
  --name newsstat \
  -p 1234:80 \
  --network=bridge \
  --env GOOGLE_KEY=${GOOGLE_KEY} \
  $DOCKER_IMAGE

echo 'Logout...'
docker logout