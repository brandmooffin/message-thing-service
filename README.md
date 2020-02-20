# message-thing-service

## Project Overview
* .Net Core Api
* MongoDb
* Postman Collection

## Getting Started 
- Download or clone the repo (or fork it!)

## Setting up the service (locally)
- Download and install Visual Studio https://visualstudio.microsoft.com/downloads/
    - Visual Studio is available for both macOS and Windows for freeee
    - For linux users, check out Rider by JetBrains https://www.jetbrains.com/rider/
- Build and run the project
    - Visual Studio should start up the service locally
    - There may be a warning about accepting dev certificates; it's cool just accept it
- If you are connecting to MongoDb not locating on your machine be sure to update the connection string in appsettings.json

## Setting up the service (hosted)
- Sign up for Heroku
    - Heroku offers a free tier for hosting applications from websites to services; which is great for dev & test
- Create a new app
- Under the Deploy tab select your Deployment method
    - For this project I used GitHub repo option but the Heroku CLI is another great option if you don't want to fork the repo and hook it up that way
- Link either the GitHub repo (your forked repo) or follow the instructions for the Heroku CLI to get your projected up on Heroku
- Make sure you have the .Net Core buildpack configured
    - Under Settings look for Buildpacks
    - Click Add buildpack and enter https://github.com/jincod/dotnetcore-buildpack
    - This will allow .Net Core support for your Heroku deployment
- Finally deploy!

## Setting up MongoDb (locally)
- Download and install MongoDb https://www.mongodb.com/download-center/community
    - Default installation options should be good enough
- (Optional) Download and install Robo3T https://robomongo.org/download
    - Great tool to help you manage your mongoDb databases

## Setting up MongoDb (hosted)
- Sign up for MongoDb Atlas https://www.mongodb.com/cloud/atlas
    - MongoDb Atlas offers a free tier which is excellent for dev & test
- Create a new project
    - Give it a name and then build a new cluster
- Make sure you have your service's ip address whitelisted
    - Setting should be found in Network Access under Security
    - Alternatively, you have the option to open the connection to any ip address; while this is clearly the easiest, it also the most vulnerable so be careful
- Finally make sure to grab that connection string and place that into the appsettings.json in the project

## Using Postman
This project also provides a Postman collection and you check out their site for more info https://www.postman.com/

If you already have Postman installed and unfamiliar with importing collection, here's how to get that setup:
- Open up Postman
- There should be an Import button towards the top left; click that!
- Click Choose Files and navigate to `MessagingThingService API.postman_collection`
- That should do it! Make sure to update the url with either your localhost or the url where the service is hosted

## Contributing
Interested in helping make changes, adding features, or just want to help maintain this project in any way? 

If you would like to help maintain this project please feel free to reach out on our slack https://join.slack.com/t/sefloridatech/shared_invite/enQtNDcxMDc4MDM1OTg4LTAyOWE1ZDliZWQ0MTkyYTc3NzM4ODEzYzYxODNiNGQwNzQxNWE0MDk5NDRlZDE2NDAwOThjZjExYmJjY2M0YWU

This project is open source and is open to anyone that's interested in looking to learn or would like to improve this project. 
