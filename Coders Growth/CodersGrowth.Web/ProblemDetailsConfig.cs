using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

public static class ProblemDetailsConfig
{
    public static void UseProblemDetailsExceptionHandler(this IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.UseExceptionHandler(construtor =>
        {
            construtor.Run(async contexto =>
            {
                var exceptionHandlerFeature = contexto.Features.Get<IExceptionHandlerFeature>();

                if (exceptionHandlerFeature != null)
                {
                    var exception = exceptionHandlerFeature.Error;
                    var problemDetails = CreateProblemDetails(contexto, exception);
                    var logger = loggerFactory.CreateLogger("GlobalExceptionHandler");

                    LogException(logger, exception);

                    var json = JsonConvert.SerializeObject(problemDetails, new JsonSerializerSettings());
                    await contexto.Response.WriteAsync(json);
                }
            });
        });
    }

    private static ProblemDetails CreateProblemDetails(HttpContext contexto, Exception exception)
    {
        var problemDetails = new ProblemDetails
        {
            Instance = contexto.Request.HttpContext.Request.Path
        };

        switch (exception)
        {
            case BadHttpRequestException badRequest:
                ConfigureBadRequestProblemDetails(problemDetails, badRequest);
                break;
            case ValidationException validationException:
                ConfigureValidationProblemDetails(problemDetails, validationException);
                break;
            case SqlException sqlException:
                ConfigureSqlProblemDetails(problemDetails, sqlException);
                break;
            default:
                ConfigureDefaultProblemDetails(problemDetails, exception);
                break;
        }

        return problemDetails;
    }

    private static void ConfigureBadRequestProblemDetails(ProblemDetails problemDetails, BadHttpRequestException exception)
    {
        problemDetails.Title = "A requisição é inválida";
        problemDetails.Status = StatusCodes.Status400BadRequest;
        problemDetails.Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1";
        problemDetails.Detail = exception.Message;
    }

    private static void ConfigureValidationProblemDetails(ProblemDetails problemDetails, ValidationException exception)
    {
        problemDetails.Title = "Erro ao Validar Objeto";
        problemDetails.Status = StatusCodes.Status500InternalServerError;
        problemDetails.Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1";

        var details = string.Join("\n", exception.Errors.Select(e => e.ErrorMessage));
        problemDetails.Detail = details;
    }

    private static void ConfigureSqlProblemDetails(ProblemDetails problemDetails, SqlException exception)
    {
        problemDetails.Title = "Exceção no banco de dados";
        problemDetails.Status = StatusCodes.Status500InternalServerError;
        problemDetails.Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1";
        problemDetails.Detail = exception.Message;
    }

    private static void ConfigureDefaultProblemDetails(ProblemDetails problemDetails, Exception exception)
    {
        problemDetails.Title = exception.Message;
        problemDetails.Status = StatusCodes.Status500InternalServerError;
        problemDetails.Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1";
        problemDetails.Detail = exception.StackTrace;
    }

    private static void LogException(ILogger logger, Exception exception)
    {
        logger.LogError($"Erro Inesperado: {exception}");
    }
}