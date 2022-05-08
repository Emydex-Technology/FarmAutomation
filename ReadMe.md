# About this Repository
This repository provides a base project template to complete their coding test as part of the Emydex Web Developer recruitment process. This project is designed to test candidates skill level and experience developing a RESTful API library to be consumed by a mobile application.

# Project Description

Emydex web development team is super excited with the prospect of building a prototype of industry first Farm Automation System also referred to as farming of the future. 
With this App, the farmers will be able to operate their farm machineries remotely and carry out farm operations like feeding the animals, milking the cow and shearing the sheep etc. 

The UI team is looking to call API endpoints to -
1. Get a list of all available IoT devices registered on the farm
2. Switch On and Off the currently registered device
3. Feed all the animals on the farm 
4. Start and stop milking the cow
5. Shear sheep
6. Get the count of all animals currently in farm

# Roadblocks & Expectations

While the front team has been making good progress with App, the back end team is struggling to expose these IoT operations through a well designed RESTful APIs.
The team is now relying on your expertise to design and develop these RESTful APIs to help the project progress.

However, there are few basic guidelines and requirements the team expects you to follow when building the API back-end to give the thumps up

1. Every IoT device is different, so all operations on the device must be done with the help of the standard interface defined in the core library (IFarmAutomationDevice). 
   It should be easily possible to switch over to a different IoT device without impacting the entire code base and help with unit testing

2. List of registered devices must only be access through the repository provided (IDeviceRepository)

3. These devices have a secret activation key which should never be exposed outside. 
   When returning a list of devices, you need to make sure you not to accidentally expose this to the UI via the APIs

4. Powering On and Powering Off the IoT device feature must force authorization.  
   You are expected to make use of the custom FarmerAuthorize attribute when designing endpoints to support such operations
   There is no expectation to implement security apart from making sure to apply the FarmerAuthorize attribute.

5. Currently team is only testing the RoboFarmPLC IoT device. So make sure to use this device instead of the AutoFarmPLC

6. There should be no modification to the DeviceWrappers, DeviceRepository classes or the Emydex.FarmAutomation.IoT.Core library project

# Important 
When submitting your solution for review please provide a short summary of how you have met the requirements of this project and your assumptions or reason to take any particular approach. Tell us why your solution is the best compared the rest of the Candidates

