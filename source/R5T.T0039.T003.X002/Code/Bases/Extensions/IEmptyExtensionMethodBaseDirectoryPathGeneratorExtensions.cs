using System;

using R5T.Lombardy;

using R5T.T0039.T003;
using R5T.T0039.T003.X002;


namespace System
{
    public static class IEmptyExtensionMethodBaseDirectoryPathGeneratorExtensions
    {
        public static string GetEmptyExtensionMethodBaseDirectoryPath(this IEmptyExtensionMethodBaseDirectoryPathGenerator _,
            string projectFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var projectDirectoryPath = Instances.ProjectPathsOperator.GetCodeDirectoryPath(
                projectFilePath,
                stringlyTypedPathOperator);

            var emptyExtensionMethodBaseDirectoryPath = stringlyTypedPathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.CodeDirectoryName.Bases(),
                Instances.CodeDirectoryName.Interfaces());

            return emptyExtensionMethodBaseDirectoryPath;
        }
    }
}
