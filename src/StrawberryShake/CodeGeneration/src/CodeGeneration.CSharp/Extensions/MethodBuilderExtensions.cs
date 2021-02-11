using System;
using StrawberryShake.CodeGeneration.CSharp.Builders;

namespace StrawberryShake.CodeGeneration.CSharp
{
    internal static class MethodBuilderExtensions
    {
        public static MethodBuilder SetPublic(this MethodBuilder builder)
        {
            return builder.SetAccessModifier(AccessModifier.Public);
        }

        public static MethodBuilder SetPrivate(this MethodBuilder builder)
        {
            return builder.SetAccessModifier(AccessModifier.Private);
        }

        public static MethodBuilder SetInternal(this MethodBuilder builder)
        {
            return builder.SetAccessModifier(AccessModifier.Internal);
        }

        public static MethodBuilder SetProtected(this MethodBuilder builder)
        {
            return builder.SetAccessModifier(AccessModifier.Protected);
        }

        public static MethodBuilder AddParameter(
            this MethodBuilder builder,
            string name,
            Action<ParameterBuilder> configure)
        {
            ParameterBuilder? parameterBuilder = ParameterBuilder.New().SetName(name);
            configure(parameterBuilder);
            builder.AddParameter(parameterBuilder);
            return builder;
        }
    }
}