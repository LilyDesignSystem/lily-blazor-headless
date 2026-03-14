using Microsoft.AspNetCore.Components;

namespace LilyBlazorHeadless.Components;

/// <summary>
/// A breadcrumb list item represents a single step in a breadcrumb navigation trail. It renders as
/// a semantic `&lt;li&gt;` element designed to be placed inside a BreadcrumbList component. The
/// component supports `aria-current="page"` to indicate when the item represents the user's current
/// location in the site hierarchy.
/// </summary>
/// <example>
/// <code>
/// &lt;BreadcrumbListItem&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/BreadcrumbListItem&gt;
/// &lt;BreadcrumbListItem current&gt;About&lt;/BreadcrumbListItem&gt;
/// </code>
/// </example>
public partial class BreadcrumbListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Current { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-list-item" : $"breadcrumb-list-item {CssClass}";
}
