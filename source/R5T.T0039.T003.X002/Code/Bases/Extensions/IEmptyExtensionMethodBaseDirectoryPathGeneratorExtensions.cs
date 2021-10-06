using System;

using R5T.T0039.T003;
using R5T.T0039.T003.X002;


namespace System
{
    public static class IEmptyExtensionMethodBaseDirectoryPathGeneratorExtensions
    {
        public static string GetEmptyExtensionMethodBaseDirectoryPath(this IExtensionMethodBaseDirectoryPathGenerator _,
            string projectFilePath)
        {
            var projectDirectoryPath = Instances.ProjectPathsOperator.GetCodeDirectoryPath(
                projectFilePath);

            var emptyExtensionMethodBaseDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                projectDirectoryPath,
                Instances.CodeDirectoryName.Bases(),
                Instances.CodeDirectoryName.Interfaces());

            return emptyExtensionMethodBaseDirectoryPath;
        }
    }
}
