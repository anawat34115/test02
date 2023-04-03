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
                Console.WriteLine(max);
                break;
            case "FindMin":
                Console.WriteLine(min);
                break;
            case "FindMean":
                if (count == 0) {
                } else {
                    double mean = sum / count;
                    Console.WriteLine(mean);
                }
                break;
            default:
                Console.WriteLine("Invalid mode.");
                break;
        }
    }
}
