namespace ConsoleApp2;

public class Assign_2_Class
{


    public static void Main(string[] args)
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 2, 2, 2 };
        int[] result = FindLongestSequence(array);

        Console.WriteLine(string.Join(" ", result));
    }

    public static int[] FindLongestSequence(int[] arr)
    {
        int bestStart = 0, bestLength = 1, currLength = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1]) currLength++;
            else currLength = 1;

            if (currLength > bestLength)
            {
                bestLength = currLength;
                bestStart = i - bestLength + 1;
            }
        }

        int[] longestSequence = new int[bestLength];
        Array.Copy(arr, bestStart, longestSequence, 0, bestLength);
        return longestSequence;
    }


//
    public static void MN(string[] args)
    {
        // Test URLs
        string[] urls =
        {
            "https://www.apple.com/iphone",
            "ftp://www.example.com/employee",
            "https://google.com",
            "www.apple.com"
        };

        // Parse each URL
        foreach (var url in urls)
        {
            ParseURL(url);
        }
    }

    public static void ParseURL(string url)
    {
        string protocol = "";
        string server = "";
        string resource = "";

        // Check for the protocol and server
        if (url.Contains("://"))
        {
            // Split the URL by "://"
            var parts = url.Split(new[] { "://" }, StringSplitOptions.None);
            protocol = parts[0]; // Get the protocol part
            url = parts[1]; // Update url to the remaining part
        }

        // Check for the server and resource
        if (url.Contains("/"))
        {
            // Split the URL by the first occurrence of "/"
            var parts = url.Split(new[] { '/' }, 2); // Only split into two parts
            server = parts[0]; // Get the server part
            resource = parts.Length > 1 ? parts[1] : ""; // Get the resource part, if it exists
        }
        else
        {
            // If no "/" is found, the entire URL is the server
            server = url;
        }

        // Display the results
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
        Console.WriteLine();
    }
}
