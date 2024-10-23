using System;
using System.Data;
using System.IO;
using System.Text;
using Moq;
using Xunit;

namespace jbLib.SqlServer.Tests
{
    public class ClassFromTableTest
    {
        private DataTable GetSampleDataTable()
        {
            var table = new DataTable("SampleTable");
            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            return table;
        }

        [Fact]
        public void ToString_ShouldReturnCorrectClassString()
        {
            // Arrange
            var mockDbProxy = new Mock<IDbProxy>();
            var dataTable = GetSampleDataTable();
            var classFromTable = new ClassFromTable(mockDbProxy.Object, dataTable, "SampleNamespace");

            // Act
            var result = classFromTable.ToString();

            // Assert
            var expected = new StringBuilder()
                .AppendLine("namespace SampleNamespace;")
                .AppendLine("public class SampleTable")
                .AppendLine("{")
                .AppendLine("  public Int32 Id { get; set; }")
                .AppendLine("  public String Name { get; set; } = string.Empty;")
                .AppendLine("}")
                .ToString();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Print_ShouldOutputCorrectClassString()
        {
            // Arrange
            var mockDbProxy = new Mock<IDbProxy>();
            var dataTable = GetSampleDataTable();
            var classFromTable = new ClassFromTable(mockDbProxy.Object, dataTable, "SampleNamespace");

            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            classFromTable.Print();
            string resulted = sw.ToString();

            // Assert
            var expected = new StringBuilder()
                .AppendLine("namespace SampleNamespace;")
                .AppendLine("public class SampleTable")
                .AppendLine("{")
                .AppendLine("  public Int32 Id { get; set; }")
                .AppendLine("  public String Name { get; set; } = string.Empty;")
                .AppendLine("}")
                .AppendLine()
                .ToString();

            Assert.Equal(expected, resulted);
        }

        [Fact]
        public void SaveToFile_ShouldCreateFileWithCorrectContent()
        {
            // Arrange
            var mockDbProxy = new Mock<IDbProxy>();
            var dataTable = GetSampleDataTable();
            var classFromTable = new ClassFromTable(mockDbProxy.Object, dataTable, "SampleNamespace");
            var tempPath = Path.GetTempPath();
            var expectedFilePath = Path.Combine(tempPath, "SampleTable.cs");

            // Act
            classFromTable.SaveToFile(tempPath);

            // Assert
            Assert.True(File.Exists(expectedFilePath));
            var expectedContent = new StringBuilder()
                .AppendLine("namespace SampleNamespace;")
                .AppendLine("public class SampleTable")
                .AppendLine("{")
                .AppendLine("  public Int32 Id { get; set; }")
                .AppendLine("  public String Name { get; set; } = string.Empty;")
                .AppendLine("}")
                .ToString();

            var actualContent = File.ReadAllText(expectedFilePath);
            Assert.Equal(expectedContent, actualContent);

            // Cleanup
            File.Delete(expectedFilePath);
        }
    }
}