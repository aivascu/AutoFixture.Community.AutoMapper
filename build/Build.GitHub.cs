using Nuke.Common;
using Nuke.Common.CI.GitHubActions;

[GitHubActions(
    "continuous",
    GitHubActionsImage.WindowsLatest,
    OnPullRequestBranches = new[] { MasterBranch, DevelopBranch },
    PublishArtifacts = false,
    InvokedTargets = new[] { nameof(Cover), nameof(Pack) },
    ImportGitHubTokenAs = nameof(GitHubToken))]
[GitHubActions(
    "release",
    GitHubActionsImage.WindowsLatest,
    OnPushBranches = new[] { MasterBranch },
    PublishArtifacts = false,
    InvokedTargets = new[] { nameof(Cover), nameof(Publish) },
    ImportGitHubTokenAs = nameof(GitHubToken),
    ImportSecrets = new[] {nameof(NuGetApiKey)})]
partial class Build
{
    [Parameter("GitHub auth token")]
    readonly string GitHubToken;
}