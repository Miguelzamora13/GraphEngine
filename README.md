# Graph Engine - Open Source

<!--
| - | Windows Multi Targeting | Ubuntu 16.04 .NET Core |
|:------:|:------:|:------:|
|Build|![Build status badge]()|![Build status badge]()|
-->

This repository contains the source code of Microsoft [Graph Engine][graph-engine] and its graph
query language -- [Language Integrated Knowledge Query][likq] (LIKQ).

Microsoft Graph Engine is a distributed in-memory data processing engine,
underpinned by a strongly-typed in-memory key-value store and a general-purpose distributed computation
engine.

[LIKQ][likq-gh]
is a versatile graph query language atop Graph Engine. It
combines the capability of fast graph exploration with the flexibility
of lambda expression. Server-side computations can be expressed in
lambda expressions, embedded in LIKQ, and executed on Graph Engine servers during graph traversal.

## Getting started

### Building on Windows

Install [Visual Studio 2022 or 2019][vs] with the following components selected:

- .NET desktop development
    - .NET Framework 4.6.1 development tools
- Desktop development with C++
    - Windows 10 SDK
<!--    - Windows 8.1 SDK and UCRT SDK -->
- .NET SDK 6.0

[.NET SDK x64][dotnet-download] can alternatively be installed using their standalone installers.

The Windows build will generate multi-targeting nuget packages.
Open a powershell window, run `tools/build.ps1` for Visual Studio 2022 or `tools/build.ps1 -VS2019` for Visual Studio 2019.

### Building on Linux

Install `libunwind8`, `g++`, `cmake` and `libssl-dev`. For example, run `sudo apt install libunwind8 g++ cmake libssl-dev` on Ubuntu.

Install [.NET SDK x64 6.0][dotnet-download] and execute `bash tools/build.sh`.

The build script has been on `Ubuntu 20.04`.

### How to use the built Graph Engine packages

Nuget packages will be built as `build/GraphEngine**._version_.nupkg`.
The folder `build/` will be registered as a local NuGet repository and the local package cache for
`GraphEngine.Core` will be cleared. After the packages are built, run `dotnet restore` to use the newly built package.

### Run your first Graph Engine app

Go to the `samples/Friends/Friends` folder, execute `dotnet restore` and `dotnet run` to run the sample project.

## How to contribute

Pull requests, issue reports, and suggestions are welcome.

Please read the [code of conduct](CODE_OF_CONDUCT.md) before contributing code.

Follow these [instructions](SECURITY.md) for reporting security issues.

## License

Copyright (c) Microsoft Corporation. All rights reserved.

Licensed under the [MIT](LICENSE.md) license.

## Disclaimer

Microsoft Graph Engine is a research project. It is not an officially supported Microsoft product.

<!--
Links
-->

[graph-engine]: https://www.graphengine.io/

[likq]: https://www.graphengine.io/video/likq.video.html

[likq-gh]: https://github.com/Microsoft/GraphEngine/tree/master/src/Modules/LIKQ

[academic-graph-search]: https://azure.microsoft.com/en-us/services/cognitive-services/academic-knowledge/

[vs-extension]: https://visualstudiogallery.msdn.microsoft.com/12835dd2-2d0e-4b8e-9e7e-9f505bb909b8

[graph-engine-core]: https://www.nuget.org/packages/GraphEngine.Core/

[likq-nuget]: https://www.nuget.org/packages/GraphEngine.LIKQ/

[vs]: https://www.visualstudio.com/

[dotnet-download]: https://dotnet.microsoft.com/

[license]: LICENSE.md
