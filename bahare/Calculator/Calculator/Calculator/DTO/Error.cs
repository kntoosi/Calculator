using System.Collections.Generic;

namespace Calculator.DTO
{
    public struct ErrorTypes
    {
   
        public const string invalid_request = "invalid_request";

        public const string server_unexpected_error = "server_unexpected_error";

        public const string not_found = "not_found";
    }

    public class Error
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public short StatusCode { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
    }

    public class ErrorList
    {
        public List<Error> Errors { get; set; }

        public ErrorList()
        {
            this.Errors = new List<Error>();
        }

        public ErrorList(params Error[] _errors)
        {
            this.Errors = new List<Error>();
            for (int i = 0; i < _errors.Length; i++)
                this.Errors.Add(_errors[i]);
        }
    }
}
