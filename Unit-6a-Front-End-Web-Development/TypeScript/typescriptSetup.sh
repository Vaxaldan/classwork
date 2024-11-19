#!/bin/bash
clear
echo "This process will setup a TypeScript in the folder you specify"
echo
read -r -p "Enter name for project folder: " folderName
mkdir "${folderName}"
cd "${folderName}"
npm init -y
npm i -D typescript ts-node nodemon
npx tsc --init
echo node_modules > .gitignore
echo '{ "execMap": { "ts": "./node_modules/.bin/ts-node" } }' > nodemon.json
mkdir src
cd src
echo "// typescript file goes here" > index.ts
echo 'console.log("Welcome to TypeScript")' >> index.ts
echo "---------------------------------------------------------------------"
echo "TypeScript project successfully set up in folder: ${folderName}"
echo
echo "You will now be placed in VS COde on the project"
echo 
echo "Although not required, you may add the following lines to the"
echo " end of the package.json, 'scripts' attribute' :"
echo
echo '"start": "ts-node src/index.ts",' 
echo '"start:dev": "nodemon src/index.ts"'
echo 
echo "Be sure you have placed a comma before the entry you add these lines to and "
echo "verify all commas and braces are still matched and correct before you save the change"
echo
echo "These lines are not required to run and test your TypeScript code"
echo "they just MAY make it slightly more convenient"
echo 
echo "If you don't want to mess with the package.json file, don't"
echo "----------------------------------------------------------------------"
cd ..
code .