using System;


namespace R5T.T0039.T003
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class EmptyExtensionMethodBaseDirectoryPathGenerator : IEmptyExtensionMethodBaseDirectoryPathGenerator
    {
        #region Static

        public static EmptyExtensionMethodBaseDirectoryPathGenerator Instance { get; } = new();

        #endregion
    }
}