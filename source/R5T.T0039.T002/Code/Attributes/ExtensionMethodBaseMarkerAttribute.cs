using System;


namespace R5T.T0039.T002
{
    /// <summary>
    /// Marks an interface as being an empty extension method base.
    /// Also allows specifying that an interface is *not* an empty extension method base. This is useful for decorating interfaces that happen to be in the canonical bases location, but that are *not* empty extension method bases.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ExtensionMethodBaseMarkerAttribute : Attribute
    {
        private readonly bool zIsEmptyExtensionMethodBase;
        public bool IsEmptyExtensionMethodBase
        {
            get
            {
                return this.zIsEmptyExtensionMethodBase;
            }
        }


        public ExtensionMethodBaseMarkerAttribute(
            bool isEmptyExtensionMethodBase = true)
        {
            this.zIsEmptyExtensionMethodBase = isEmptyExtensionMethodBase;
        }
    }
}
