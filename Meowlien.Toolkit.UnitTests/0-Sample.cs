using Meowlien.Toolkit; // 想要做測試的目標來源

// 注意: 此命名空間為：參考範本，禁止使用範本空間 ( 即：命名空間以 Sample 做結尾 )
namespace Meowlien.Toolkit.UnitTests.Sample {

    // 作爲範例的測試類 (真正需要測試的是呼叫目標來源的類別 or 方法)
    public static class Sample {
        public static T Add<T>(T a, T b) {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA + dynamicB;
        }
    }

    [TestClass]     // 標記-作爲測試類 (包含了關於 Sample 的測試項) *命名規範：XxxTests
    public class SampleTests {

        [TestMethod]    // 標記-作爲測試方法 (所有斷言方法)
        public void Test_UnitTest_AllAssert() {
            // Assert.AreEqual(expected, actual);          // 驗證-兩個值是否 <相等>
            // Assert.IsTrue(condition);                   // 驗證-條件是否為 <真>
            // Assert.IsFalse(condition);                  // 驗證-條件是否為 <假>
            // Assert.IsNull(obj);                         // 驗證-對象是否為 <空>
            // Assert.IsNotNull(obj);                      // 驗證-對象是否 <不為空>
            // Assert.ThrowsException<T>(action);          // 驗證-指定操作是否 <引發了特定類型的異常>
        }

        [TestMethod]
        public void TestMethod_Add_ReturnsCorrectSum() {

            // 預期-結果
            int expected = 9; // 反例：預期結果與實際不同即可
            // 實際-結果
            int actual = Sample.Add(4, 5); // 呼叫-欲測試的方法

            // 斷言-驗證兩個值是否 <相等>
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_UnitTest_OnlyOutput() {
            // 單純輸出以下内容
            Console.WriteLine("Test Output Debug Message.");

            // 由於沒有進行 <斷言判斷> ，因此此測試方法必然正確
        }

    }
}