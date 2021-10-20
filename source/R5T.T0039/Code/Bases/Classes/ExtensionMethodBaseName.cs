using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBaseName : IExtensionMethodBaseName
    {
        #region Static
        
        public static ExtensionMethodBaseName Instance { get; } = new();

        #endregion
    }
}