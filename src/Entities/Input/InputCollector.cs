
using System.Collections.Generic;
using System;
namespace Input
{

    class InputCollector
    {

        public class CollectInputConfig<T>
        {
            public string inputMessage;
            public Dictionary<int, T> inputMapper;

            public bool clearScrean = true;

            public CollectInputConfig(string inputMessage, Dictionary<int, T> inputMapper)
            {
                this.inputMessage = inputMessage;
                this.inputMapper = inputMapper;
            }

            public CollectInputConfig(
            string inputMessage, Dictionary<int, T> inputMapper, bool clearScrean)
             :
            this(inputMessage, inputMapper)
            {
                this.clearScrean = clearScrean;
            }
        }

        public class CollectAnyInputConfig
        {
            public string inputMessage;
            public bool clearScrean = true;

            public CollectAnyInputConfig(string inputMessage)
            {
                this.inputMessage = inputMessage;
            }

            public CollectAnyInputConfig(string inputMessage, bool clearScrean)
            : this(inputMessage)
            {
                this.clearScrean = clearScrean;
            }
        }
        public static T CollectInput<T>(CollectInputConfig<T> config)
        {

            while (true)
            {
                if (config.clearScrean)
                    Console.Clear();
                Console.WriteLine(config.inputMessage);
                int input = int.Parse(Console.ReadLine());
                if (config.inputMapper.ContainsKey(input))
                    return config.inputMapper[input];

            }
        }

        public static string CollectAnyInput(CollectAnyInputConfig config)
        {
            if (config.clearScrean)
                Console.Clear();
            Console.WriteLine(config.inputMessage);
            string input = Console.ReadLine();
            return input;
        }
    }
}