using System.Collections.Generic;

namespace MongoTool
{
    public static class JsonHelpers
    {
        public static string FormatJson(this string json)
        {
            var output = new List<char>();

            var level = 0;
            var midString = false;

            for (var i = 0; i < json.Length; i++)
            {
                var c = json[i];

                if (c == '"')
                    midString = !midString;

                if (c == ' ' && !midString)
                    continue;


                // before
                if (!midString)
                {
                    switch (c)
                    {
                        case ':':
                            output.Add(' ');
                            break;
                        case '}':
                        case ']':
                            NewLine(--level, ref output);
                            break;
                    }
                }

                // char
                output.Add(c);

                // after
                if (!midString)
                {
                    switch (c)
                    {
                        case ':':
                            output.Add(' ');
                            break;
                        case '{':
                        case '[':
                            NewLine(++level, ref output);
                            break;
                        case ';':
                        case ',':
                            NewLine(level, ref output);
                            break;

                    }
                }
            }

            return new string(output.ToArray());
        }

        private static void NewLine(int tabLevel, ref List<char> target)
        {
            const int tabWidth = 4;
            target.Add('\r');
            target.Add('\n');

            for (var i = 0; i < tabLevel; i++)
            {
                for(var j = 0; j < tabWidth; j++)
                    target.Add(' ');
            }
        }
    }
}
