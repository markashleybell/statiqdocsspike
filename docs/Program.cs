await Bootstrapper
        .Factory
        .CreateDocs(args)

        // This works (but includes a bunch of cruft which we don't want)
        // .AddSourceFiles("../../src/**/*.cs")

        // This is the default as mentioned here: https://www.statiq.dev/guide/docs/specifying-code
        // This *doesn't* work, as it seems it's relative to the 'input' folder...
        .AddSourceFiles("../src/**/{!.git,!bin,!obj,!packages,!*.Tests,}/**/*.cs")

        // This works (note the extra ../ at the start)
        .AddSourceFiles("../../src/**/{!.git,!bin,!obj,!packages,!*.Tests,}/**/*.cs")

        .RunAsync();