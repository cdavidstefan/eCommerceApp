
namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaulMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaulMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request you have made.",
                401 => "Authorized you are not.",
                404 => "Resource found it was not",
                500 => "The errors are the path to the dark side.",
                _ => null
            };
        }
    }
}