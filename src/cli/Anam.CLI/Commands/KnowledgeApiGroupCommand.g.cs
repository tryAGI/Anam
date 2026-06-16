#nullable enable

using System.CommandLine;

namespace Anam.CLI.Commands;

internal static class KnowledgeApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"knowledge", @"Knowledge endpoint commands.");
                         command.Subcommands.Add(KnowledgeCreateKnowledgeGroupCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeDeleteKnowledgeDocumentCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeDeleteKnowledgeGroupCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetKnowledgeDocumentCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetKnowledgeDocumentDownloadCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeGetKnowledgeGroupCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeListKnowledgeGroupDocumentsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeListKnowledgeGroupsCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeSearchKnowledgeGroupCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeUpdateKnowledgeDocumentCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeUpdateKnowledgeGroupCommandApiCommand.Create());
                         command.Subcommands.Add(KnowledgeUploadKnowledgeGroupDocumentCommandApiCommand.Create());
        return command;
    }
}