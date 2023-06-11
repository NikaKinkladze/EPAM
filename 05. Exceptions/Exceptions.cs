using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class VehicleNotFoundException : Exception
    {
        public VehicleNotFoundException()
        {
        }

        public VehicleNotFoundException(string message) : base(message)
        {
        }

        public VehicleNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class InitializationException : Exception
    {
        public InitializationException()
        {
        }

        public InitializationException(string message) : base(message)
        {
        }

        public InitializationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class AddException : Exception
    {
        public AddException()
        {
        }

        public AddException(string message) : base(message)
        {
        }

        public AddException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class UpdateAutoException : Exception
    {
        public UpdateAutoException()
        {
        }

        public UpdateAutoException(string message) : base(message)
        {
        }

        public UpdateAutoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class RemoveAutoException : Exception
    {
        public RemoveAutoException()
        {
        }

        public RemoveAutoException(string message) : base(message)
        {
        }

        public RemoveAutoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }


}
