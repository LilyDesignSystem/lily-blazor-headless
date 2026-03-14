using Microsoft.AspNetCore.Components;

namespace LilyBlazorHeadless.Components;

/// <summary>
/// A breadcrumb list is an ordered list that contains BreadcrumbListItem children, representing
/// the hierarchical trail in a breadcrumb navigation. It renders a semantic `&lt;ol&gt;` element to
/// convey the ordered relationship of pages in the site hierarchy.
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
public partial class BreadcrumbList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-list" : $"breadcrumb-list {CssClass}";
}
