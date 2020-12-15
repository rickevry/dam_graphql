using DAM.Core.GraphQL.Repository;
using DAM.Core.GraphQL.Schemas.TermsetDomain;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace DAM.Core.GraphQL.Configuration.Repositories
{
    public class TermsetRepositoryConfiguration : IRepositoryConfiguration
    {
        private readonly ITermsetRepository _repository;

        public TermsetRepositoryConfiguration(ITermsetRepository repository)
        {
            _repository = repository;
        }

        public void ConfigureGraphQLMutationFields(ObjectGraphType parent)
        {
        }

        public void ConfigureGraphQLQueryFields(ObjectGraphType parent)
        {
            parent.Field<ListGraphType<TermsetGraphType>>(
                "GetTermsetById",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "termsetId" }
                ),
                resolve: context =>
                {
                    var termsetId = context.GetArgument<String>("termsetId");
                    return _repository.GetListByEidAsync(termsetId);
                });

            parent.Field<TermsetGraphType>(
               "GetFoldersByWorkspace",
               arguments: new QueryArguments(
                   new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "workspaceId" }
               ),
               resolve: context =>
               {
                   var workspaceId = context.GetArgument<String>("workspaceId");
                   return _repository.GetFoldersByWorkspace(workspaceId);
               });
        }

        public void ConfigureGraphQLSubscriptionFields(ObjectGraphType parent)
        {
        }
    }
}
