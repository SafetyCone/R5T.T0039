using System;
using System.Threading.Tasks;


namespace R5T.T0039.D002.I002
{
    public class EmptyExtensionMethodBaseDirectoryPathConvention : IEmptyExtensionMethodBaseDirectoryPathConvention
    {
        public Task<string> GetEmptyExtensionMethodBaseDirectoryPath(string projectFilePath)
        {
            var output = Instances.EmptyExtensionMethodBaseDirectoryPathGenerator.GetEmptyExtensionMethodBaseDirectoryPath(
                projectFilePath);

            return Task.FromResult(output);
        }
    }
}
