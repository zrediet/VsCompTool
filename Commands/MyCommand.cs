using System.ComponentModel.Design;
using System.Threading;
using Microsoft.VisualStudio.Text;

namespace VsCompTool.Commands
{
    [Command(PackageIds.Compare)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            //Switch the execution to the main thread to avoid deadlock 
            await Package.JoinableTaskFactory.SwitchToMainThreadAsync();

            DocumentView documentView = await VS.Documents.GetActiveDocumentViewAsync();
            if (documentView?.TextView == null) return;

            SnapshotPoint position = documentView.TextView.Caret.Position.BufferPosition;
            documentView.TextBuffer?.Insert(position, Guid.NewGuid().ToString());

             

        }
    }
}
