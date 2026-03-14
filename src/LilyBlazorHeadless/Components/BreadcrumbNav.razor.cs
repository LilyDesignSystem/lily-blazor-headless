using Microsoft.AspNetCore.Components;

namespace LilyBlazorHeadless.Components;

/// <summary>
/// A breadcrumb nav is a navigation landmark that contains a breadcrumb trail showing the user's
/// current location within a site hierarchy. It renders a `&lt;nav&gt;` element with an accessible
/// label and contains a BreadcrumbList which holds BreadcrumbListItem children.
/// </summary>
/// <example>
/// <code>
/// &lt;BreadcrumbNav label="Breadcrumb"&gt;
///   &lt;BreadcrumbList&gt;
///     &lt;BreadcrumbListItem&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/BreadcrumbListItem&gt;
///     &lt;BreadcrumbListItem&gt;&lt;a href="/products"&gt;Products&lt;/a&gt;&lt;/BreadcrumbListItem&gt;
///     &lt;BreadcrumbListItem current&gt;Widget&lt;/BreadcrumbListItem&gt;
///   &lt;/BreadcrumbList&gt;
/// &lt;/BreadcrumbNav&gt;
/// </code>
/// </example>
public partial class BreadcrumbNav : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-nav" : $"breadcrumb-nav {CssClass}";
}
