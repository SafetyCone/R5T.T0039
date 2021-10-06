using System;


namespace R5T.T0039.T003
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBaseDirectoryPathGenerator : IExtensionMethodBaseDirectoryPathGenerator
    {
        #region Static

        public static ExtensionMethodBaseDirectoryPathGenerator Instance { get; } = new();

        #endregion
    }
}