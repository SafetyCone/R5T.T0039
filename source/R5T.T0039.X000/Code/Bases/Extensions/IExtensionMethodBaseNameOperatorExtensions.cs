using System;

using R5T.T0039;

using Instances = R5T.T0039.X000.Instances;


namespace System
{
    public static class IExtensionMethodBaseNameOperatorExtensions
    {
        public static string GetDefinitionInterfaceName(this IExtensionMethodBaseNameOperator _,
            string extensionMethodBaseTypeNameStem)
        {
            var output = Instances.TypeName.GetInterfaceName(extensionMethodBaseTypeNameStem);
            return output;
        }

        public static string GetImplementationClassNameFromDefinitionInterfaceName(this IExtensionMethodBaseNameOperator _,
            string extensionMethodBaseDefinitionInterfaceName)
        {
            var output = Instances.TypeName.GetDefaultImplementationClassNameForInterfaceName(extensionMethodBaseDefinitionInterfaceName);
            return output;
        }
    }
}