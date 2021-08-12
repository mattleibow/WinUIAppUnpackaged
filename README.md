# WinUI App (Unpackaged)

Let's be real for a moment. Windows is cool. Software is cool. But NEW Windows software is very cool.

This repo is a demo of how to have a unpackaged WinUI app that not only runs without an appx, but also runs as Any CPU.

## Prerequisites

I followed this guide: https://docs.microsoft.com/windows/apps/windows-app-sdk/tutorial-unpackaged-deployment

But, you just need to download and install these:
 - https://github.com/microsoft/WindowsAppSDK/releases/download/v0.8-preview/ProjectReunion-0.8Preview-Install-x64.exe
 - https://github.com/microsoft/WindowsAppSDK/releases/download/v0.8-preview/ProjectReunion-0.8Preview-Install-x86.exe
 
## Building

Open the solution and first build the `Microsoft.ProjectReunion.Bootstrap` project. This will create a special nuget packge that is just to help AnyCPU work.

Then, run the app.
