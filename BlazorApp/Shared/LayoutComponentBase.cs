using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared
{
  public abstract class LayoutComponentBase : ComponentBase
  {
    [Parameter]
    public RenderFragment? Body { get; set; }
  }
}
