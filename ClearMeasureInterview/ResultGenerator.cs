using System.Text;

namespace ClearMeasureInterview
{
    public class ResultGenerator
    {
        public string GenerateResult(int upperBounds, Dictionary<int, string> numberStringPairs)
        {
            // Initialize StringBuilder
            StringBuilder result = new StringBuilder();

            // Loop through until we hit the value in upperBounds
            for (int i = 1; i <= upperBounds; i++) 
            {
                // By Default we want to display the number
                var displayNumber = true;
                
                //Creating a new string builder here to build the inner string as one line
                StringBuilder substring = new StringBuilder();

                // Loop through passed in Key Value Pairs to see if we should display text instead of the number
                foreach (var numberPair in numberStringPairs) 
                {
                    // Check if number is divisible by the key in the key/Value pair
                    if (i % numberPair.Key == 0)
                    {
                        // number is divisible, so we want to display the text here / Not appending a new line, because if we have multiple that match, we want them on same line.
                        substring.Append(numberPair.Value);

                        // Setting the value so we dont display the number, as we have displayed a special string instead.
                        displayNumber = false;
                    }
                }

                if (displayNumber)
                {
                    // No special cases defined above, so we display the number.
                    result.AppendLine(i.ToString());
                }
                else
                {
                    // Use the text we created in the special case logic above.
                    result.AppendLine(substring.ToString());
                }
            }

            return result.ToString();
        }
    }
}