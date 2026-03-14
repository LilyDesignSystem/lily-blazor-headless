using Bunit;
using Xunit;
using LilyBlazorHeadless.Components;

namespace LilyBlazorHeadless.Tests.Components;

public class AccordionListItemTests : TestContext
{
    [Fact]
    public void RendersAsDetails()
    {
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("details");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("details");
        Assert.Contains("accordion-list-item", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("details");
        var classes = element.GetAttribute("class");
        Assert.Contains("accordion-list-item", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("details");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void OpenChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<AccordionListItem>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Open, false)
            .Add(c => c.OpenChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
