using System;
using System.Collections.Generic;
using System.Text;

namespace DbModelService
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        {

        }

        public CustomException(string ExceptionInfo)
            :base(ExceptionInfo)
        {

        }
    }
}
