﻿@page "/Error"
@using Microsoft.Extensions.Logging
@using System.Diagnostics
<h1 class="text-danger">Error.</h1>
<h2 class="text-danger">An error occurred while processing your request.</h2>

@if (ShowRequestId)
{
<p>
<strong>Request ID:</strong> <code>@RequestId</code>
</p>
}
<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>

@code {
[Inject]
public ILogger<ErrorModel> Logger { get; set; }
public string RequestId { get; set; }

public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

protected override void OnInitialized()
{
    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    Logger.LogError($"An error occurred with request ID: {RequestId}");
}
}