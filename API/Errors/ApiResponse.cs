using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

         private string GetDefaultMessageForStatusCode(int statusCode)
        {
           return statusCode switch
           {
               400 => "You have made a bad request",
               401 => "Sorry, You're not authorized",
               404 => "Resource found not found",
               500 => "Error has, we're fixing it",
               _ => null
           };
        }


    }
}