// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGenf37c95b329FeaturePopulator))]
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"HelloWorld.Grains, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleansGeneratedCodeD6601D91
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof(global::HelloWorld.Grains.GreetingArchive))]
    internal sealed class OrleansCodeGenHelloWorld_Grains_GreetingArchiveSerializer
    {
        private readonly global::System.Action<global::HelloWorld.Grains.GreetingArchive, global::System.Collections.Generic.List<global::System.String>> setField0;
        public OrleansCodeGenHelloWorld_Grains_GreetingArchiveSerializer(global::Orleans.Serialization.IFieldUtils fieldUtils)
        {
            global::System.Reflection.FieldInfo field0 = typeof(global::HelloWorld.Grains.GreetingArchive).GetField(@"<Greetings>k__BackingField", (System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public));
            setField0 = (global::System.Action<global::HelloWorld.Grains.GreetingArchive, global::System.Collections.Generic.List<global::System.String>>)fieldUtils.GetReferenceSetter(field0);
        }

        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public global::System.Object DeepCopier(global::System.Object original, global::Orleans.Serialization.ICopyContext context)
        {
            global::HelloWorld.Grains.GreetingArchive input = ((global::HelloWorld.Grains.GreetingArchive)original);
            global::HelloWorld.Grains.GreetingArchive result = new global::HelloWorld.Grains.GreetingArchive();
            context.RecordCopy(original, result);
            setField0(result, (global::System.Collections.Generic.List<global::System.String>)context.DeepCopyInner(input.Greetings));
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.ISerializationContext context, global::System.Type expected)
        {
            global::HelloWorld.Grains.GreetingArchive input = (global::HelloWorld.Grains.GreetingArchive)untypedInput;
            context.SerializeInner(input.Greetings, typeof(global::System.Collections.Generic.List<global::System.String>));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.IDeserializationContext context)
        {
            global::HelloWorld.Grains.GreetingArchive result = new global::HelloWorld.Grains.GreetingArchive();
            context.RecordObject(result);
            setField0(result, (global::System.Collections.Generic.List<global::System.String>)context.DeserializeInner(typeof(global::System.Collections.Generic.List<global::System.String>)));
            return (global::HelloWorld.Grains.GreetingArchive)result;
        }
    }
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGenf37c95b329FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof(global::HelloWorld.Grains.HelloArchiveGrain)));
            feature.Classes.Add(new global::Orleans.Metadata.GrainClassMetadata(typeof(global::HelloWorld.Grains.HelloGrain)));
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddSerializerType(typeof(global::HelloWorld.Grains.GreetingArchive), typeof(OrleansGeneratedCodeD6601D91.OrleansCodeGenHelloWorld_Grains_GreetingArchiveSerializer));
            feature.AddKnownType(@"HelloWorld.Grains.HelloArchiveGrain,HelloWorld.Grains", @"HelloWorld.Grains.HelloArchiveGrain");
            feature.AddKnownType(@"HelloWorld.Grains.GreetingArchive,HelloWorld.Grains", @"HelloWorld.Grains.GreetingArchive");
            feature.AddKnownType(@"HelloWorld.Grains.HelloGrain,HelloWorld.Grains", @"HelloWorld.Grains.HelloGrain");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
