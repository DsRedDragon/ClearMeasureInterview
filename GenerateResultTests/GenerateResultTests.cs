using ClearMeasureInterview;
using System.Text.RegularExpressions;

namespace ResultGeneratorTests
{
    [TestClass]
    public class GenerateResultTests
    {
        private const string input1Text = "Input1";
        private const string input2Text = "Input2";
        private const string input3Text = "Input3";

        private const int input1Val = 3;
        private const int input2Val = 5;
        private const int input3Val = 2;

        [TestMethod]
        public void CheckThatTotalLinesMatchesUpperBound()
        {
            var pairsToMatch = new Dictionary<int, string>();
            var upperBound = 100;

            ResultGenerator generator = new ResultGenerator();
            var result = generator.GenerateResult(upperBound, pairsToMatch);

            // Fetch number of lines generated.
            int numLines = result.Count(x => x.Equals('\n'));

            // Number of lines generated should match the upperbound
            Assert.AreEqual(upperBound, numLines);
        }

        [TestMethod]
        public void CheckThatSinglePairMatches()
        {
            var pairsToMatch = new Dictionary<int, string>();
            var upperBound = 20;

            pairsToMatch.Add(input1Val, input1Text);

            ResultGenerator generator = new ResultGenerator();
            var result = generator.GenerateResult(upperBound, pairsToMatch);

            // Get the value of how many times the input1 text appears in the string
            var countInput1 = Regex.Matches(result, input1Text).Count();

            // Compare the numebr of times the input1 appears in the string, with how many times the upperbound is divisible by the input1 value
            Assert.AreEqual(countInput1, upperBound / input1Val);
        }

        [TestMethod]
        public void CheckThatDoublePairMatches()
        {
            var pairsToMatch = new Dictionary<int, string>();
            var upperBound = 20;

            pairsToMatch.Add(input1Val, input1Text);
            pairsToMatch.Add(input2Val, input2Text);

            ResultGenerator generator = new ResultGenerator();
            var result = generator.GenerateResult(upperBound, pairsToMatch);

            // Get the value of how many times the input1 text appears in the string
            var countInput1 = Regex.Matches(result, input1Text).Count();
            // Get the value of how many times the input2 text appears in the string
            var countInput2 = Regex.Matches(result, input2Text).Count();

            // Compare the numebr of times the input1 appears in the string, with how many times the upperbound is divisible by the input1 value
            Assert.AreEqual(countInput1, upperBound/input1Val);
            // Compare the numebr of times the input2 appears in the string, with how many times the upperbound is divisible by the input2 value
            Assert.AreEqual(countInput2, upperBound/input2Val);
        }

        [TestMethod]
        public void CheckThatTriplePairMatches()
        {
            var pairsToMatch = new Dictionary<int, string>();
            var upperBound = 20;

            pairsToMatch.Add(input1Val, input1Text);
            pairsToMatch.Add(input2Val, input2Text);
            pairsToMatch.Add(input3Val, input3Text);

            ResultGenerator generator = new ResultGenerator();
            var result = generator.GenerateResult(upperBound, pairsToMatch);

            // Get the value of how many times the input1 text appears in the string
            var countInput1 = Regex.Matches(result, input1Text).Count();
            // Get the value of how many times the input2 text appears in the string
            var countInput2 = Regex.Matches(result, input2Text).Count();
            // Get the value of how many times the input3 text appears in the string
            var countInput3 = Regex.Matches(result, input3Text).Count();

            // Compare the numebr of times the input1 appears in the string, with how many times the upperbound is divisible by the input1 value
            Assert.AreEqual(countInput1, upperBound / input1Val);
            // Compare the numebr of times the input2 appears in the string, with how many times the upperbound is divisible by the input2 value
            Assert.AreEqual(countInput2, upperBound / input2Val);
            // Compare the numebr of times the input3 appears in the string, with how many times the upperbound is divisible by the input3 value
            Assert.AreEqual(countInput3, upperBound / input3Val);
        }
    }
}