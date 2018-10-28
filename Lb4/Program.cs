using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Lb4
{
    class Program
    {
        public enum SequenceSign
        {
            Growing
            , Falling
            , NonDefined
        }

        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"../../numbers.in", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string fileContent = streamReader.ReadLine();

            streamReader.Dispose();
            fileStream.Dispose();

            string[] numbers = fileContent.Trim().Split(' ');

            Run(numbers);
        }

        public static void Run( string[] _numbers )
        {
            FileStream ouputStream = new FileStream(@"../../numbers.out", FileMode.Truncate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(ouputStream);

            CultureInfo culture = new CultureInfo("en-US");

            SequenceSign sign = SequenceSign.NonDefined;
            int currentSequenceLenght = 0;
            double previous = -1;

            foreach ( var strNumber in _numbers )
            {
                double current = Double.Parse(strNumber, culture);

                if (previous < 0)
                {
                    previous = current;
                    continue;
                }

                switch (sign)
                {
                    case SequenceSign.Growing:
                        {
                            if (previous < current)
                                ++currentSequenceLenght;
                            else
                            {
                                WriteNumber(streamWriter, currentSequenceLenght, ' ');
                                sign = SequenceSign.Falling;
                                currentSequenceLenght = 2;
                            }
                        }
                        break;

                    case SequenceSign.Falling:
                        {
                            if (previous > current)
                                ++currentSequenceLenght;
                            else
                            {
                                WriteNumber(streamWriter, currentSequenceLenght, ' ');
                                sign = SequenceSign.Growing;
                                currentSequenceLenght = 2;
                            }
                        }
                        break;

                    case SequenceSign.NonDefined:
                        {
                            if (previous < current)
                                sign = SequenceSign.Growing;
                            else
                                sign = SequenceSign.Falling;

                            currentSequenceLenght = 2;
                        }
                        break;

                    default:
                        break;
                }

                previous = current;
            }

            WriteNumber(streamWriter, currentSequenceLenght, '\n');
            streamWriter.Dispose();
            ouputStream.Dispose();
        }

        public static void WriteNumber(StreamWriter _stream, int _number, char _separator)
        {
            _stream.Write(_number);
            _stream.Write(_separator);
        }
    }
}