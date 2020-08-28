#!/bin/sh
echo "Generating and publishing csharp nuget package for mantle API."
show_help(){
	print_info "Welcome to Mantle csharp nuget package generator\n"
	echo "The possible arguments are :\n\n"
	echo "--help, -h	shows help\n"
	echo "--version, -v	Version that will be pushed to nuget.org\n"
	echo "--release-note, -r 	release note that will be pushed\n"
	echo "--path, -p	location of the  swagger.json or url(REQUIRED)\n"

	exit 1	
}

Nc='\033[0m'
Red='\033[0;31m'
Blue='\033[0;34m'
Green='\033[0;32m'

print_info(){
	echo "$Blue[INFO]$Nc $1"
}

print_error(){
	echo "$Red[Error]$Nc Invalid: $1"
}

print_success(){
	echo "$Green[Success]$Nc $1"
}

shift_fct(){
	shift
	if [ $# -lt 0 ]; then
		print_error "Must have a $1 value is arg is given"
		exit 1
	fi
	shift
}


if [ $# -eq 0 ]; then
	show_help
fi
Release_note="Minor update"
Path=""
VERSION="1.0.0"

while [ $# -ne 0 ]; do
	key=$1
	case $key in
		-h | --help)
		show_help
		;;
		-v | --version)
		Version=$2
		shift
		if [ $# -lt 1 ]; then
			print_error "Version must have a value"
			exit 1
		fi
		shift
		;;
		-r | --release_note)
		Release_note=$2
		shift
		if [ $# -lt 1 ]; then
			print_error "Release_note must have a value"
			exit 1
		fi
		shift
		;;
		-p | --path)
		Path=$2
		shift
		if [ $# -lt 1 ]; then
			print_error "Path arg must have a value"
			exit 1
		fi
		shift
		;;
		*-*)
		print_error $key
		show_help
		;;
		*)
		shift
		;;
	esac
done

if [ -z $Path ]; then
	print_error "Path argument must be present\n"
	exit 1
fi

#Installing swagger-codegen-cli
#You can download the version you want at https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/
print_info "Downloading Swagger-codegen-cli\n"
Err=$(curl -o $PWD/swagger-codegen-cli.jar -w '%http_code' -f https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.4.9/swagger-codegen-cli-2.4.9.jar)

if [ $? -eq 0 ]; then
	print_success "Downloaded swagger-codegen-cli with success.\n"
else
	print_error "Cannot download swagger-codegen-cli, please download it manually at https://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/\n"
	print_error $Err
	exit 1
fi

#Generating client sdk
print_info "Generating client sdk for c#"
#Gen_Error=$(java -jar ./swagger-codegen-cli.jar generate -i httpss://develop.api.mantleblockchain.com/swagger/v1/swagger.json -l csharp -o mantle.lib -DapiTest=false -DmodelTests=false -DpackageName='mantle.lib' --release-note $Release_note -o ./csharp-client/)
if [ $? -eq 0 ]; then
	print_success "Generation successful\n"
else
	print_error "Cannot generate csharp sdk\n"
	print_error $Gen_Error
fi



#need to push it to nugget after
#mono nuget.exe pack src/mantle.lib/mantle.lib.nuspec -Version 1.3.1
#dotnet push
