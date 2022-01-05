using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBaseFunctionality : IExtensionMethodBaseFunctionality
    {
        #region Static
        
        public static ExtensionMethodBaseFunctionality Instance { get; } = new();

        #endregion
    }
}