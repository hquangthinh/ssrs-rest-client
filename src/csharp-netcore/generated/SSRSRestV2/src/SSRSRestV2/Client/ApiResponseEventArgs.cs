using System;
using System.Net;

namespace SSRSRestV2.Client
{
    /// <summary>
    /// Useful for tracking server health.
    /// </summary>
    public class ApiResponseEventArgs : EventArgs
    {
        /// <summary>
        /// The time the request was sent.
        /// </summary>
        public DateTime RequestedAt { get; }

        /// <summary>
        /// The time the response was received.
        /// </summary>
        public DateTime ReceivedAt { get; }

        /// <summary>
        /// The HttpStatusCode received.
        /// </summary>
        public HttpStatusCode HttpStatus { get; }

        /// <summary>
        /// The path requested.
        /// </summary>
        public string PathFormat { get; }

        /// <summary>
        /// The elapsed time from request to response.
        /// </summary>
        public TimeSpan ToTimeSpan => this.ReceivedAt - this.RequestedAt;

        /// <summary>
        /// The path
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The event args used to track server health.
        /// </summary>
        /// <param name="requestedAt"></param>
        /// <param name="receivedAt"></param>
        /// <param name="httpStatus"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        public ApiResponseEventArgs(DateTime requestedAt, DateTime receivedAt, HttpStatusCode httpStatus, string pathFormat, string path)
        {
            RequestedAt = requestedAt;
            ReceivedAt = receivedAt;
            HttpStatus = httpStatus;
            PathFormat = pathFormat;
            Path = path;
        }
    }
}
