#!/bin/sh
#java -jar swagger-codegen-cli-2.2.1.jar generate -i http://localhost:5000/swagger/v1/swagger.json -l csharp -o mantle.lib -DpackageName='mantle.lib' -DmodelTests=false -DapiTests=false -o ./mantle-lib/csharp-client/ --release-note 'update to version 1.3.1'


##Care to put the good version AND the call swagger-codegen-cli-2.2.1.jar where it is

java -jar ./swagger-codegen-cli.jar generate -i https://develop.api.mantleblockchain.com/swagger/v1/swagger.json -l csharp -o mantle.lib -DapiTest=false -DmodelTests=false -DpackageName='mantle.lib' --release-note 'update to version 1.3.1' -o ./csharp-client/


#need to push it to nugget after
