# Blazor Test Project with Tailwind CSS

A Blazor WebAssembly project with Tailwind CSS integration for development.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Bun](https://bun.sh) - JavaScript runtime & package manager
- Node.js (for Tailwind CSS)

## Development Setup

1. Install dependencies:

```bash
bun i
```

2. Start the development server:

```bash
bun start
```

This will:

- Start the Blazor WebAssembly app on http://localhost:5112
- Watch for changes in your CSS files and automatically rebuild Tailwind CSS

## Project Structure

- `BlazorApp/` - Main Blazor WebAssembly application
  - `wwwroot/css/tailwind.css` - Source CSS file with Tailwind directives
  - `wwwroot/css/tailwind-output-min.css` - Generated Tailwind CSS file

## Development Workflow

1. The `bun start` command runs both the Blazor app and Tailwind CSS watcher concurrently
2. Make changes to your Blazor components using Tailwind CSS classes
3. The Tailwind CSS watcher will automatically rebuild the CSS file
4. Refresh your browser to see the changes

## Note

This setup is intended for development only.
