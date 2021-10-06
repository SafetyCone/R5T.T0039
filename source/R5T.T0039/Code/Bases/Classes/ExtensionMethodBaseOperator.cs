using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExtensionMethodBaseOperator : IExtensionMethodBaseOperator
    {
        #region Static
        
        public static ExtensionMethodBaseOperator Instance { get; } = new();

        #endregion
    }
}