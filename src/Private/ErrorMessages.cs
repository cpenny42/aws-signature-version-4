using Amazon.Util;

namespace AwsSignatureVersion4.Private
{
    public static class ErrorMessages
    {
        public static readonly string XAmzDateHeaderExists =
            $"Request contains header with name '{HeaderKeys.XAmzDateHeader}'. It should not " +
            "since it is the responsibility of AwsSignatureVersion4 to add it.";

        public static readonly string AuthorizationHeaderExists =
            $"Request contains header with name '{HeaderKeys.AuthorizationHeader}'. It should not " +
            "since it is the responsibility of AwsSignatureVersion4 to add it.";

        public const string InvalidRequestUri =
            "An invalid request URI was provided. The request URI must either be an absolute " +
            "URI or BaseAddress must be set.";

        public const string S3DoesNotSupportPost = "Uploading files to S3 using POST is not " +
            "supported by AWS, use PUT instead.";
    }
}
