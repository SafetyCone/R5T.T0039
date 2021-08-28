using System;


namespace R5T.T0039
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class EmptyExtensionMethodBase : IEmptyExtensionMethodBase
    {
        #region Static

        public static EmptyExtensionMethodBase Instance { get; } = new();

        #endregion
    }
}