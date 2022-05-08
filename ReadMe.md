# About this Repository
This repository is used as part of the Emydex recruitment process. Candidates are expected to complete a basic coding test. This is to allow our technical team to get a better insight into their coding skills and suitability for the role on offer. 
This repository provides a base working project template for the fictitious Farm Automation System being developed by the Emydex Web Development Team.  
This exercise is designed to test candidates' coding skills and experience building a RESTful API library to be consumed by a mobile application. 

# Project Description

Emydex's web development team is super excited with the prospect of building a prototype of the industry-first Farm Automation System also referred to as the farming of the future. With this App, farmers will be able to operate their farm machinery remotely and carry out farm operations like feeding the animals, milking the cow and shearing the sheep etc through their mobile phone easily. 

The UI team needs APIs to meet the following requirements -
1. Get a list of all available IoT devices registered on the farm
2. Switch On and Off the currently registered device
3. Feed all the animals on the farm 
4. Start and stop milking the cow
5. Shear sheep
6. Get the count of all animals currently on the farm

# Roadblocks & Expectations
While the front team has been making good progress with App, the back end team is struggling to expose these IoT operations through well designed RESTful APIs.
The team is now relying on your expertise and skills to design and develop these RESTful APIs and help the project suceed.

However, there are a few basic guidelines and requirements the team expects you to follow when building the API back-end to get the thumbs up

1. Every IoT device is different, so all operations on the device must be done with the help of the standard interface defined in the core library (IFarmAutomationDevice). 
   It should be easily possible to switch over to a different IoT device without impacting the entire code base and help with unit testing

2. List of registered devices must only be accessed through the repository provided (IDeviceRepository)

3. These devices have a secret activation key which should never be exposed outside. 
   When returning a list of devices, you need to make sure you do not accidentally expose this to the UI via the APIs

4. Powering On and Powering Off the IoT device feature must force authorization.  
   You are expected to make use of the custom FarmerAuthorize attribute when designing endpoints to support such operations
   There is no expectation to implement security apart from making sure to apply the FarmerAuthorize attribute.

5. Currently the team is only testing the RoboFarmPLC IoT device. So make sure to use this device instead of the AutoFarmPLC

6. There should be no modification to the DeviceWrappers, DeviceRepository classes or the Emydex.FarmAutomation.IoT.Core library project

# Important 
When submitting your solution for review, please provide a summary of how you have met the requirements of this project, any assumptions you have made and reason for you to take any particular approach for this solution. Tell us why your solution is the best compared to the rest of the candidates.

## There is never a perfect solution and each developer solves the problem in their unique way based on their experiences and knowledge. So the least we expect from you is to do your best. 
