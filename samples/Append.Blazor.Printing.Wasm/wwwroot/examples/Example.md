@inject DocumentationService DocumentationService
 
@Documentation
<h4>Try it out</h4>
@Code
<br />
<h4>Code</h4>

<pre class="bg-light"><code>@sampleCode</code></pre>

@code{
    [Parameter] public RenderFragment Documentation { get; set; }
    [Parameter] public RenderFragment Code { get; set; }
    [Parameter] public string Name { get; set; }
    private string sampleCode;

    protected override async Task OnParametersSetAsync()
    {
        if (string.IsNullOrEmpty(Name))
            throw new ArgumentException($"Parameter {nameof(Name)} cannot be blank, for component {this.GetType().Name}");

        sampleCode = await DocumentationService.GetSampleCode(Name);
    }
}