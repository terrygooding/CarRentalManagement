using Microsoft.AspNetCore.Components;
using System.Net;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            _interceptor = interceptor;
            _navManager = navManager;
        }

        public void MonitorEvent() => _interceptor.AfterSend += InterceptorResponse;

        public void InterceptorResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode) 
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        _navManager.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;

                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        _navManager.NavigateTo("Unauthorized");
                        message = "you are not authorised to access this resource";
                        break;
                    
                    default:
                        _navManager.NavigateTo("/500");
                        message = "Something went wrong please contact Administrator";
                        break;
                }
                throw new Exception(message);
            }
        }

        public void DisposeEvent() => _interceptor.AfterSend -= InterceptorResponse;
    }
}
