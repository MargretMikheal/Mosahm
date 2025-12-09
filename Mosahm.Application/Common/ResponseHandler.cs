using Microsoft.Extensions.Localization;
using Mosahm.Application.Resources;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Mosahm.Application.Common
{
    public class ResponseHandler
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        public ResponseHandler(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
        }

        public Response<T> Success<T>(T data, string message = null)
        {
            return new Response<T>(data, message ?? _localizer[SharedResourcesKeys.Success])
            {
                StatusCode = HttpStatusCode.OK,
            };
        }

        public Response<T> Created<T>(T data)
        {
            return new Response<T>(data, _localizer[SharedResourcesKeys.Created])
            {
                StatusCode = HttpStatusCode.Created,
            };
        }

        public Response<T> Deleted<T>()
        {
            return new Response<T>(_localizer[SharedResourcesKeys.Deleted], succeeded: true)
            {
                StatusCode = HttpStatusCode.OK
            };
        }

        public Response<T> NotFound<T>(string message = null, Dictionary<string, List<string>> errors = null)
        {
            return new Response<T>(message ?? _localizer[SharedResourcesKeys.NotFound])
            {
                Errors = errors,
                StatusCode = HttpStatusCode.NotFound
            };
        }

        public Response<T> Unauthorized<T>(string message = null, Dictionary<string, List<string>> errors = null)
        {
            return new Response<T>(message ?? _localizer[SharedResourcesKeys.Unauthorized], succeeded: false)
            {
                Errors = errors,
                StatusCode = HttpStatusCode.Unauthorized
            };
        }

        public Response<T> BadRequest<T>(string message = null, Dictionary<string, List<string>> errors = null)
        {
            return new Response<T>(message ?? _localizer[SharedResourcesKeys.BadRequest])
            {
                Errors = errors,
                StatusCode = HttpStatusCode.BadRequest
            };
        }

        public Response<T> UnprocessableEntity<T>(Dictionary<string, List<string>> errors, string message = null)
        {
            return new Response<T>(message ?? _localizer[SharedResourcesKeys.UnprocessableEntity], succeeded: false)
            {
                Errors = errors,
                StatusCode = HttpStatusCode.UnprocessableEntity,
            };
        }
        public Response<T> ValidationErrors<T>(Dictionary<string, List<string>> errors, string message = null)
        {
            return new Response<T>
            {
                Succeeded = false,
                Message = message ?? "Validation errors occurred",
                Errors = errors,
                StatusCode = HttpStatusCode.BadRequest
            };
        }
    }
}
