using Microsoft.AspNetCore.Components;

namespace LilyBlazorHeadless.Components;

/// <summary>
/// A grouping container for AccordionListItem elements within an AccordionNav. Renders a
/// `&lt;div&gt;` with `role="group"` to semantically group the set of disclosure widgets.
/// </summary>
/// <example>
/// <code>
/// &lt;AccordionNav label="FAQ"&gt;
///   &lt;AccordionList label="Questions"&gt;
///     &lt;AccordionListItem&gt;
///       &lt;summary&gt;What is this?&lt;/summary&gt;
///       &lt;p&gt;A design system.&lt;/p&gt;
///     &lt;/AccordionListItem&gt;
///   &lt;/AccordionList&gt;
/// &lt;/AccordionNav&gt;
/// </code>
/// </example>
public partial class AccordionList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "accordion-list" : $"accordion-list {CssClass}";
}
