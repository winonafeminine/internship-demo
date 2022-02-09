#!/bin/bash

# force remove the containers
# for avoiding the containers to start at startup
docker rm -f internship-demo_devcontainer_dotnet_1 \
    internship-demo_devcontainer_mariadb_1 \
    internship-demo_devcontainer_phpmyadmin_1 \
    internship-demo_devcontainer_portainer_1