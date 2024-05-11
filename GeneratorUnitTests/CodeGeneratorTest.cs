using KhronosGroup.Gltf.Generator.JsonSchema;

using NUnit.Framework;

using System.IO;

namespace KhronosGroup.Gltf.Generator.UnitTests
{
    [TestFixture]
    public class CodeGeneratorTest
    {
        private const string RelativePathToSchemaDir = @"..\..\..\..\..\glTF\specification\2.0\schema\";
        private string AbsolutePathToSchemaDir;

        [SetUp]
        public void Init()
        {
            AbsolutePathToSchemaDir = Path.Combine(TestContext.CurrentContext.TestDirectory, RelativePathToSchemaDir);
        }

        [Test]
        public void ParseSchemas_DirectReferences()
        {
            var loader = new SchemaLoader(AbsolutePathToSchemaDir + "glTFProperty.schema.json");
            loader.ParseSchemas();

            Assert.That(3, Is.EqualTo(loader.FileSchemas.Keys.Count));
        }

        [Test]
        public void ParseSchemas_IndirectReferences()
        {
            var loader = new SchemaLoader(AbsolutePathToSchemaDir + "glTF.schema.json");
            loader.ParseSchemas();

            Assert.That(33, Is.EqualTo(loader.FileSchemas.Keys.Count));
        }

        [Test]
        public void ExpandSchemaReferences_DirectReferences()
        {
            var loader = new SchemaLoader(AbsolutePathToSchemaDir + "glTFProperty.schema.json");
            loader.ParseSchemas();

            Assert.That(3, Is.EqualTo(loader.FileSchemas.Keys.Count));

            loader.ExpandSchemaReferences();

            Assert.That(loader.FileSchemas["glTFProperty.schema.json"].Properties["extensions"].ReferenceType, Is.Null);
            Assert.That(loader.FileSchemas["glTFProperty.schema.json"].Properties["extras"].ReferenceType, Is.Null);
        }

        [Test]
        public void CSharpGenTest()
        {
            var loader = new SchemaLoader(AbsolutePathToSchemaDir + "glTF.schema.json");
            loader.ParseSchemas();
            loader.ExpandSchemaReferences();
            loader.EvaluateInheritance();
            loader.PostProcessSchema();
            var generator = new CodeGenerator(loader.FileSchemas);
            generator.CSharpCodeGen(TestContext.CurrentContext.TestDirectory);
        }
    }
}
