using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas.FolderDomain;
using GraphQL;
using GraphQL.Types;
using System;

namespace DAM.Core.GraphQL.Configuration.Repositories
{
    public class FolderRepositoryConfiguration : IRepositoryConfiguration
    {
        private readonly IFolderRepository _repository;

        public FolderRepositoryConfiguration(IFolderRepository repository)
        {
            _repository = repository;
        }

        public void ConfigureGraphQLMutationFields(ObjectGraphType parent)
        {
            parent.Field<FolderGraphType>(
               "UpdateFolderTitle",
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "folderId" },
                   new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "title" }
               ),
               resolve: context =>
               {
                   var folderId = context.GetArgument<Guid>("folderId");
                   var title = context.GetArgument<string>("title");

                   return _repository.UpdateFolderTitleAsync(folderId, title);
               });

        }

        public void ConfigureGraphQLQueryFields(ObjectGraphType parent)
        {
            parent.Field<ListGraphType<FolderGraphType>>(
                "GetFoldersByWorkspaceId",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "workspaceId" }
                ),
                resolve: context =>
                {
                    var workspaceId = context.GetArgument<Guid>("workspaceId");
                    return _repository.GetFoldersByWorkspaceIdAsync(workspaceId);
                });
        }

        public void ConfigureGraphQLSubscriptionFields(ObjectGraphType parent)
        {
        }
    }
}
