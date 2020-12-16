using StrawberryShake.CodeGeneration.CSharp.Builders;

namespace StrawberryShake.CodeGeneration.CSharp.Extensions
{
    public static class DescriptorExtensions
    {
        public static TypeBuilder ToBuilder(this TypeDescriptor typeDescriptor) =>
            new TypeBuilder()
                .SetName(typeDescriptor.Name)
                .SetIsNullable(typeDescriptor.IsNullable)
                .SetListType(typeDescriptor.ListType);
    }
}