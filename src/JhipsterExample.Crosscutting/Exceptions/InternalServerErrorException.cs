using JhipsterExample.Crosscutting.Constants;

namespace JhipsterExample.Crosscutting.Exceptions;

public class InternalServerErrorException : BaseException
{
    public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
    {
    }
}
