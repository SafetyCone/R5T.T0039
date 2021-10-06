using System;

using R5T.T0037;
using R5T.T0040;
using R5T.T0041;


namespace R5T.T0039.T003.X002
{
    public static class Instances
    {
        public static ICodeDirectoryName CodeDirectoryName { get; } = T0037.CodeDirectoryName.Instance;
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IProjectPathsOperator ProjectPathsOperator { get; } = T0040.ProjectPathsOperator.Instance;
    }
}
