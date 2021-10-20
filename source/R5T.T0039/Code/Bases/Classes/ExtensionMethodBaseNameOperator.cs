using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBaseNameOperator : IExtensionMethodBaseNameOperator
    {
        #region Static
        
        public static ExtensionMethodBaseNameOperator Instance { get; } = new();

        #endregion
    }
}