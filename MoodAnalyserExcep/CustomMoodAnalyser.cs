using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserExcep
{
    public class CustomMoodAnalyser : Exception
    {
            public ExceptionType type;
            public enum ExceptionType
            {
                NULL_EXCEPTION,
                EMPTY_EXCEPTION
            }
            public CustomMoodAnalyser(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }

