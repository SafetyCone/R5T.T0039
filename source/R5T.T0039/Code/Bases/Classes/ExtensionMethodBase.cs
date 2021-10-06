using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBase : IExtensionMethodBase
    {
        #region Static

        public static ExtensionMethodBase Instance { get; } = new();

        #endregion
    }
}