using Meowlien.Toolkit.Logging;

namespace Meowlien.Toolkit.UnitTests.Logging {

    [TestClass]
    public partial class LogFormatterTests {

        // 測試：包格式化是否返回正確格式
        [TestMethod]
        public void Test_Package_ReturnsCorrectFormat() {
            var tDict = MakeDictData();

            LogFormatter.Package logPkg = new("Request");   // Opening

            logPkg.Append("Type", $"POST/GET");

            logPkg.CreateAndPushItems("Route", tDict);

            Console.WriteLine(logPkg.ToString());
            Assert.IsTrue(true);
        }

    }

    // For Data
    public partial class LogFormatterTests {

        /// <summary>
        /// 製造字典數據
        /// </summary>
        public Dictionary<string, Object?> MakeDictData(uint numOfData = 3) {
            Dictionary<string, Object?> dictionary = new();

            for (int i = 0; i < numOfData; i++) {
                string key = $"key_{i + 1}";
                string value = $"Value_{i + 1}";
                dictionary.Add(key, value);
            }

            foreach (var item in dictionary) {
                Console.WriteLine(string.Format("{0,5} : {1,-5}", item.Key, item.Value));
            }

            return dictionary;
        }

    }

}
