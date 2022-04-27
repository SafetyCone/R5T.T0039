using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.T0039.D002.I002
{[ServiceImplementationMarker]
    public class EmptyExtensionMethodBaseDirectoryPathConvention : IEmptyExtensionMethodBaseDirectoryPathConvention,IServiceImplementation
    {
        public Task<string> GetEmptyExtensionMethodBaseDirectoryPath(string projectFilePath)
        {
            var output = Instances.EmptyExtensionMethodBaseDirectoryPathGenerator.GetEmptyExtensionMethodBaseDirectoryPath(
                projectFilePath);

            return Task.FromResult(output);
        }
    }
}
