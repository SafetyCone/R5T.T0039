using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.T0039.D002
{
    /// <summary>
    /// Stringly-typed path provider, parameterized by project file path.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IEmptyExtensionMethodBaseDirectoryPathConvention
    {
        Task<string> GetEmptyExtensionMethodBaseDirectoryPath(string projectFilePath);
    }
}
