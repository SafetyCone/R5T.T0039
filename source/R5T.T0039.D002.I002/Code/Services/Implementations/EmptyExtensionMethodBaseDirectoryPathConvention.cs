using System;
using System.Threading.Tasks;

using R5T.Lombardy;


namespace R5T.T0039.D002.I002
{
    public class EmptyExtensionMethodBaseDirectoryPathConvention : IEmptyExtensionMethodBaseDirectoryPathConvention
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public EmptyExtensionMethodBaseDirectoryPathConvention(
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public Task<string> GetEmptyExtensionMethodBaseDirectoryPath(string projectFilePath)
        {
            var output = Instances.EmptyExtensionMethodBaseDirectoryPathGenerator.GetEmptyExtensionMethodBaseDirectoryPath(
                projectFilePath,
                this.StringlyTypedPathOperator);

            return Task.FromResult(output);
        }
    }
}
