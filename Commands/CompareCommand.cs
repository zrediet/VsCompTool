namespace VsCompTool.Commands
{
    [Command(PackageIds.Compare)]
    internal sealed class CompareCommand : BaseCommand<CompareCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("Compare Command Clicked", "Button clicked");
        }
    }
}
