#!/bin/bash

# Download the SurrealDB package
curl -sSf https://install.surrealdb.com | sh

surreal start
