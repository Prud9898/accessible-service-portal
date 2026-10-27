# Accessible Service Portal

**Original demonstration project** for a C#/.NET and accessibility-focused developer portfolio. This is **not** a client application, and does not contain client code or data.

## Stack
- ASP.NET Core MVC on .NET 8
- C#, Razor, semantic HTML5, responsive CSS
- Built-in MVC model validation and anti-forgery protection
- In-memory repository and read-only REST API (`GET /api/requests`)

## Accessibility implementation examples
- Skip navigation link, landmark regions, meaningful page titles and heading hierarchy
- Visible keyboard focus, responsive layout, reduced-motion preference
- Associated labels, help text, required field indications, `aria-invalid`, validation messages
- Error summary focused on failed form submission
- Success status message, table caption and header scopes
- No mouse-only interactions required for core workflow

## Run locally
1. Install the .NET 8 SDK.
2. From this folder run `dotnet run`.
3. Open the HTTPS localhost URL printed by the terminal.
4. Try creating a request, submitting an empty form, and navigating entirely by keyboard.

## Suggested validation steps (NOT YET COMPLETED)
- Run axe DevTools on Index and Create pages, including invalid and success states.
- Test keyboard-only navigation, focus order and skip link.
- Test NVDA or JAWS reading order, form labels, error announcements, and status updates.
- Inspect at 200% and 400% zoom and narrow viewport sizes.
- Confirm contrast with a dedicated checker; verify against WCAG 2.1 AA and applicable Section 508 requirements.
- Record issues, fixes and screenshots in an audit report.

**Status:** Source code created; build, browser tests, automated axe scans, screen-reader tests, and formal WCAG/Section 508 conformance have **not** been verified in this environment. Do not claim certification or full conformance based on this repository.

## Privacy/security
The repository is a demo only. It stores submitted form content in process memory, has no authentication, and is not designed for deployment with real personal information. The public API intentionally exposes only request ID, category, and timestamp.

## Portfolio talking points
- Explain how semantic HTML and native controls reduce unnecessary ARIA.
- Demonstrate server-side validation with accessible error feedback.
- Discuss the distinction between implementing accessibility patterns and validating conformance with assistive technology.
- Show the process for remediating axe findings and retesting before release.
