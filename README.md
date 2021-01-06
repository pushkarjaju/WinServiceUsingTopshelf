# Windows Service Using TopShelf

Services in Windows are really powerful tools for automation, but they are often overlooked. These small applications run constantly in the background and can be used for a number of tasks from the simple to the complex. We have created a service, Which will run in background every second and print current timestampt.

## We have used DotNetCore 3.1
###### Used Topshelf package (nuget Install-Package Topshelf) => Topshelf is an open source project for hosting services without friction. By referencing Topshelf, your console application *becomes* a service installer with a comprehensive set of command-line options for installing, configuring, and running your application as a service.

We have to run below command to install the service.
> WinServiceUsingTopshelf.exe install Start

For un-installing use below command
> WinServiceUsingTopshelf.exe uninstall

