class Program {
    static void Main(string[] args) {
        string input;
        double number;
        double sum = 0;
        double count = 0;
        double max = double.MinValue;
        double min = double.MaxValue;

        while (true) {
            Console.Write("Enter a number (or 'End' to stop): ");
            input = Console.ReadLine();

            if (input == "End") {
                break;
            }

            if (!double.TryParse(input, out number)) {
                Console.WriteLine("Invalid input, please try again.");
                continue;
            }

            sum += number;
            count++;
            if (number > max) {
                max = number;
            }
            if (number < min) {
                min = number;
            }
        }

        Console.Write("Enter mode of statistical operation (FindMax, FindMin, FindMean): ");
        string mode = Console.ReadLine();

        switch (mode) {
            case "FindMax":
                Console.WriteLine("Maximum number entered: " + max);
                break;
            case "FindMin":
                Console.WriteLine("Minimum number entered: " + min);
                break;
            case "FindMean":
                if (count == 0) {
                    Console.WriteLine("No numbers entered.");
                } else {
                    double mean = sum / count;
                    Console.WriteLine("Arithmetic mean of numbers entered: " + mean);
                }
                break;
            default:
                Console.WriteLine("Invalid mode.");
                break;
        }
    }
}
