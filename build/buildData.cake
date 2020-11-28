public class BuildData
{
    public string Configuration { get; }

    public string VersionNumber { get; }

    public string VersionBuild { get; }

    public BuildData(
        string configuration,
        string versionNumber,
        string versionBuild)
    {
        Configuration = configuration;
        VersionNumber = versionNumber;
        VersionBuild = versionBuild;
    }
}

public class BuildPaths
{
    public DirectoryPath RootDirectoryPath;
    public DirectoryPath WorkingDirectoryPath;
    public DirectoryPath WorkingSourcesDirectoryPath;
    public DirectoryPath WorkingDotNetDirectoryPath;
    public DirectoryPath WorkingNuGetDirectoryPath;
    public DirectoryPath WorkingVstsDirectoryPath;
    public DirectoryPath WorkingSolutionDirectoryPath;
    public FilePath WorkingSolutionFilePath;
    public DirectoryPath SolutionDirectoryPath;
    public FilePath SolutionFilePath;

    public BuildPaths(
        string configuration,
        string versionNumber,
        string versionBuild)
    {
        public DirectoryPath RootDirectoryPath;
        public DirectoryPath WorkingDirectoryPath;
        public DirectoryPath WorkingSourcesDirectoryPath;
        public DirectoryPath WorkingDotNetDirectoryPath;
        public DirectoryPath WorkingNuGetDirectoryPath;
        public DirectoryPath WorkingVstsDirectoryPath;
        public DirectoryPath WorkingSolutionDirectoryPath;
        public FilePath WorkingSolutionFilePath;
        public DirectoryPath SolutionDirectoryPath;
        public FilePath SolutionFilePath;
    }

    workingDir = resolveDirectoryPath("./../working/"),
    workingDirSources = resolveDirectoryPath("./../working/sources/"),
    workingDirDotNet = resolveDirectoryPath("./../working/dotnet/"),
    workingDirNuget = resolveDirectoryPath("./../working/nuget/"),
    workingDirVSTS = resolveDirectoryPath("./../working/vsts/"),
    workingDirSolutionDir = resolveDirectoryPath("./../working/sources/src/"),
    workingDirSolutionPath = resolveDirectoryPath("./../working/sources/src/MagicChunks.sln"),

    solutionDir = resolveDirectoryPath("./../src/"),
    solutionPath = resolveDirectoryPath("./../src/MagicChunks.sln"),
}