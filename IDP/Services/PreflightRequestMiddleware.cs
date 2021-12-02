using System;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

namespace IDP.Services {
  public class PreflightRequestMiddleware {
    private readonly RequestDelegate Next;
    public PreflightRequestMiddleware(RequestDelegate next) {
      Next = next;
    }

    public Task Invoke(HttpContext context) {
      return BeginInvoke(context);
    }

    private Task BeginInvoke(HttpContext context) {
     Debug.WriteLine("Preflight Begins");
     Debug.WriteLine("Context: ", context.Request);
    
      return Next.Invoke(context);
    }
  }

  public static class PreflightRequestExtensions {
    public static IApplicationBuilder UsePreflightRequestHandler(this IApplicationBuilder builder) {
      return builder.UseMiddleware<PreflightRequestMiddleware>();
    }
  }
}