# Blazor Rich Text Editor — Export to PDF

A Blazor sample demonstrating how to export Rich Text Editor content to a downloadable PDF.

## Project Overview

This sample shows how to capture HTML content from the Blazor Rich Text Editor and convert it to a PDF for download. The example demonstrates calling an export service (server-side or client-side) that renders the editor content to PDF and returns the file to the browser.

## Key Points

- Export Rich Text Editor content to PDF
- Demonstrates calling an export service from a button action
- Uses Syncfusion document/pdf libraries for conversion (where applicable)

## Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022+ or VS Code
- Syncfusion license (if required by NuGet packages)

## Setup & Running Steps

Installation

```bash
git clone https://github.com/SyncfusionExamples/blazor-richtexteditor-export-pdf.git
cd blazor-richtexteditor-export-pdf
```

Restore NuGet packages

```bash
dotnet restore
```

Run the application

```bash
dotnet run
```

Or open `RichTextEditor.sln` in Visual Studio and run (F5).

## Usage

Open the running sample in your browser, enter or paste content into the Rich Text Editor, and click the export button. The sample converts the editor HTML to PDF and triggers a file download.

## Troubleshooting

- Ensure NuGet packages are restored and the project builds before running.
- If export fails, check browser console and server logs for errors and confirm any required licenses are configured.

## Support

This sample is provided for demonstration purposes. For issues, open an issue in the repository.

## See also

- [Online examples](https://blazor.syncfusion.com/demos/rich-text-editor/overview?theme=fluent2)
- [Documentation](https://blazor.syncfusion.com/documentation/rich-text-editor/getting-started-webapp)
