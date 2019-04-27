//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var mygetFeed = Argument("mygetFeed", "");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var absoluteRootDir = MakeAbsolute(Directory("../"));
var rootDir = Directory(absoluteRootDir.FullPath);
var artifactsDir = rootDir + Directory("artifacts");
var srcDir = rootDir + Directory("src");
var toolsDir = artifactsDir + Directory("tools");
var nugetFile = toolsDir + File("nuget.exe");
var gitVersionFile = toolsDir + Directory("GitVersion.CommandLine") + Directory("tools") + File("GitVersion.exe");
var guardUnitTestProjectFile = rootDir + Directory("tests") + Directory("MGR.Guard.UnitTests") + File("MGR.Guard.UnitTests.csproj");

var nugetPackagePublicationFeed = "https://www.nuget.org/api/v2/package";
var informationalVersion = "1.0.0";
var publishPackage = true;
var packagePublishingApiKeyName = "NUGET_API_KEY";
var isBuildingPR = HasEnvironmentVariable("APPVEYOR_PULL_REQUEST_NUMBER");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{

});

Task("Install-Tools-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    var defaultInstallSettings = new NuGetInstallSettings {
        OutputDirectory = toolsDir,
        ExcludeVersion = true,
        ToolPath = nugetFile,
        Version = "4.0.0"
    };
    NuGetInstall("GitVersion.CommandLine", defaultInstallSettings);
});

public string GetBranchName(GitVersion gitVersion)
{
    var branchName = EnvironmentVariable("APPVEYOR_REPO_BRANCH") ?? gitVersion.BranchName ?? "<Not Set>";
    return branchName;
}

public string GetPreReleaseNumber(string branchName, GitVersion gitVersion)
{
    if(branchName != gitVersion.BranchName || gitVersion.PreReleaseNumber == null)
    {
        return "1";
    }
    return gitVersion.PreReleaseNumber.Value.ToString();
}

Task("Prepare-Build")
    .IsDependentOn("Install-Tools-Packages")
    .Does(() =>
{
    if(!isBuildingPR)
    {
        var gitVersionSettings = new GitVersionSettings
        {
            ToolPath = gitVersionFile
        };
        var gitVersion = GitVersion(gitVersionSettings);
        var subVersion = "";
        var version = gitVersion.MajorMinorPatch;
        var branchName = GetBranchName(gitVersion);
        var buildNumber = GetPreReleaseNumber(branchName, gitVersion);
        if (branchName == "dev")
        {
            subVersion = "-alpha" + buildNumber;
            nugetPackagePublicationFeed = mygetFeed;
            packagePublishingApiKeyName = "MYGET_API_KEY";
            publishPackage = !string.IsNullOrEmpty(nugetPackagePublicationFeed);
        }
        else if (branchName.StartsWith("release-"))
        {
            subVersion = "-beta" + buildNumber;
        }
        else if (branchName != "master")
        {
            publishPackage = false;
        }
        informationalVersion = version + subVersion;
    }
    else
    {
        publishPackage = false;
    }
    publishPackage &= HasEnvironmentVariable(packagePublishingApiKeyName);
});

Task("Build")
    .IsDependentOn("Prepare-Build")
    .Does(() =>
{
    var settings = new DotNetCoreBuildSettings {
        Configuration = configuration,
        ArgumentCustomization = args => args.Append("-p:Version=" + informationalVersion)
    };
    DotNetCoreBuild(rootDir, settings);
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    var settings = new DotNetCoreTestSettings {
        Configuration = configuration,
        NoBuild = true
    };
    DotNetCoreTest(guardUnitTestProjectFile, settings);
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////
Task("Default")
    .IsDependentOn("Run-Unit-Tests")
    ;

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////
RunTarget(target);
