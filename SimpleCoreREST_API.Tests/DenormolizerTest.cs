using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SimpleCoreREST_API.Data;
using SimpleCoreREST_API.Services;
using Xunit;

namespace SimpleCoreREST_API.Tests
{
  public class DenormolizerTest
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var denormolizer = new Denormolizer();

      string inputString;
      using (var reader = new StreamReader("RestAPI_JSON_Input.json"))
        inputString =reader.ReadToEnd();
      var input = JsonConvert.DeserializeObject<List<Route>>(inputString);

      string outputString;
      using (var reader = new StreamReader("RestAPI_JSON_Output.json"))
        outputString = reader.ReadToEnd();
      var output = JsonConvert.DeserializeObject<List<DenormolizeRoute>>(outputString);

      // Act
      var result = input.SelectMany(item => denormolizer.Invoke(item)).ToList();

      // Assert
      Assert.Equal(output, result);
    }
  }
}
