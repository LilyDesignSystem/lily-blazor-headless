using Microsoft.AspNetCore.Components;

namespace LilyBlazorHeadless.Components;

/// <summary>
/// A single expandable section within an AccordionList, using the native HTML `&lt;details&gt;`
/// element for built-in disclosure behavior. The consumer provides a `&lt;summary&gt;` element and
/// content as children.
/// </summary>
/// <example>
/// <code>
/// &lt;AccordionListItem&gt;
///   &lt;summary&gt;Question&lt;/summary&gt;
///   &lt;p&gt;Answer&lt;/p&gt;
/// &lt;/AccordionListItem&gt;
/// </code>
/// </example>
public partial class AccordionListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "accordion-list-item" : $"accordion-list-item {CssClass}";
}
