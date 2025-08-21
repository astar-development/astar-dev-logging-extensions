## 🌟 Logging for the Stars: Harnessing the Power of AStar's Logging Tools

Logs are like the breadcrumbs you leave in a software forest. They help you (and your team) retrace steps, identify dragons (bugs 🐉), and make wise decisions. But where do you begin? Let’s dive into
AStar's robust logging tools, which make logging both simple and delightful.
This guide is for beginner or junior developers (and anyone who enjoys a touch of humor). As you read, you’ll learn how to wield the power of:

- **AStarEventIds**: Preconfigured event IDs for structured logging.
- **AStarLogger**: An all-in-one logger and telemetry wonder.
- **LoggingExtensions**: Easy-to-use methods for wiring up Serilog and Application Insights.
- **SerilogConfigure**: The configuration behind AStar logging magic.
- **LogMessageTemplate**: Strongly-typed, reusable logging templates—because why type the same message twice?

Ready? Grab your logging toolbox and let’s get started! 🚀

### 1. **🔢 AStarEventIds: The VIP Pass to Structured Logging**

Think of `AStarEventIds` as a curated playlist of event identifiers. These IDs make your logs structured and searchable. Here’s our first example:

``` c#
// Using the AStarEventIds in your own logger setup
var pageViewEvent = AStarEventIds.PageView;

Console.WriteLine(pageViewEvent.Id);   // Outputs: 1000
Console.WriteLine(pageViewEvent.Name); // Outputs: "Page view"
```

Every log entry can benefit from an **`EventId`**, helping organize and query logs. It’s like shouting “Hey, look here! I’m event #1000!” in the debug console.

### 2. **👨‍🚀 AStarLogger: The Hero Your Project Deserves**

Meet `AStarLogger<TCategoryName>`. This sophisticated logger not only logs messages like a champ but also tracks telemetry events for things like **page views**. AStarLogger is designed to integrate
seamlessly with `ITelemetryClient` and extend `ILogger`.
**How does it work?**

``` c#
// Setting up an AStarLogger
var logger = Substitute.For<ILogger<string>>(); // Mock for simplicity
var telemetryClient = Substitute.For<ITelemetryClient>();

var astarLogger = new AStarLogger<string>(logger, telemetryClient);

// Logging a page view
astarLogger.LogPageView("HomePage");
```

This will log:

- A _structured log_ with an event id (`AStarEventIds.PageView`) and a message like: Page view: HomePage
- A telemetry event to track the page view.

The combined powers of logging and telemetry? It’s like Batman and Robin 🦸🦸 swooping in to save your observability woes.
**Pro Tip:** Always validate `pageName` parameter in `LogPageView`. Null values are a software villain. 🤦‍♂️

### 3. **🔌 LoggingExtensions: Plug-and-Play Logging Setup**

When configuring a web or host application, the `LoggingExtensions` class makes connecting Serilog and Application Insights a breeze. Imagine being able to say, “Hey, app, just add Serilog and manage
the rest.” That’s exactly what happens here.

#### Configure Logging for a Web Application:

``` c#
var builder = WebApplication.CreateBuilder(args);

// Add Serilog logging (optionally load an external config file)
builder.AddSerilogLogging("serilogsettings.json");

// Continue setting up the builder...
var app = builder.Build();
```

#### Configure Logging for a Host Application:

``` c#
var builder = new HostApplicationBuilder();

// Add Serilog logging
builder.AddSerilogLogging("serilogsettings.json");

// And you're ready to log!
```

Here’s what happens under the hood:

1. **Reads external JSON settings** for Serilog, if provided (e.g., `serilogsettings.json`).
2. **Adds `AStarLogger` for telemetry-enabled logging** to your application’s services.
3. Auto-configures Serilog to write logs to **console** and **Azure Application Insights**, with a clean and structured template.

Like a good butler 🧑‍🍳, `LoggingExtensions` quietly ensures all your logging needs are met.

### 4. **📋 SerilogConfigure: The Brains Behind the Operation**

The `SerilogConfigure` class is an internal utility that knows how to configure Serilog. If `LoggingExtensions` sets the stage, `SerilogConfigure` is the stagehand ensuring all props are in place.
**Behind-the-Scenes Setup:**

``` c#
new LoggerConfiguration()
    .WriteTo.ApplicationInsights(telemetryConfig, TelemetryConverter.Traces)
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {Message:lj}{NewLine}{Exception}")
    .ReadFrom.Configuration(configuration);
```

What’s happening here? It’s setting up these critical parts:

1. Logs go to **Application Insights**.
2. Console output gets formatted with timestamps, log levels, and exceptions.
3. External configuration (`serilogsettings.json`) is loaded.

### 5. **🛠️ LogMessageTemplate: Predefined Messages for Convenience**

Why write the same logging message repeatedly when you can have reusable, strongly-typed templates with `[LoggerMessage]`?
**A Simple Example:**

``` c#
var logger = Substitute.For<ILogger>();

// Log a 400 (Bad Request)
LogMessageTemplate.BadRequest(logger, "/example-path");

// Log a 404 (Not Found)
LogMessageTemplate.NotFound(logger, "/missing-resource");
```

These helper methods will output descriptive log entries like:

``` 
[14:23:01 Warning] Bad Request (400) for `/example-path`
[14:23:02 Warning] Not Found (404) for `/missing-resource`
```

This not only saves time but ensures message consistency across your application.

### 6. **✨ Put It All Together: Logging in Action**

Here’s how you might use all the above in an ASP.NET Core application:
**Program.cs:**

``` c#
var builder = WebApplication.CreateBuilder(args);

// Add Serilog with optional external settings
builder.AddSerilogLogging();

var app = builder.Build();

// Add middleware/demo routes
app.MapGet("/", (ILogger<AStarLogger<string>> logger, ITelemetryClient telemetry) =>
{
    var astarLogger = new AStarLogger<string>(logger, telemetry);

    astarLogger.LogPageView("HomePage"); // Logs and tracks telemetry
    logger.LogWarning("This is a warning log.");
    LogMessageTemplate.NotFound(logger, "/missing-resource");

    return Results.Ok("Check your logs for structured awesomeness.");
});

app.Run();
```

### 🧭 Why Structured Logs and Telemetry Matter

Searching through unstructured logs is like trying to find Waldo in a snowstorm. By using **structured logs and telemetry**, you:

- Make logs searchable by event ID, category name, or severity.
- Gain insights into user behavior (e.g., which pages they visited).
- Debug production issues quickly.

### 🎉 A Quick Recap

- **🔢 AStarEventIds** organizes and identifies log entries with unique IDs.
- **👨‍🚀 AStarLogger** combines structured logs with telemetry tracking.
- **🔌 LoggingExtensions** simplifies Serilog and Application Insights configuration.
- **📋 SerilogConfigure** ensures your logs are sent to reliable sinks.
- **🛠️ LogMessageTemplate** makes strongly-typed reusable logs.

### 🚀 Closing Logs

Think of logging as your time traveler’s diary—it tells the story of **what, when, and where** something happened. Whether you’re debugging a 500 error or hunting down a performance issue, AStar’s
logging tools ensure you’re logging like a pro from day one.
The next time someone asks if your app has proper logging, smile and say, “Oh, you bet—we’re logging for the stars!” 🌟
