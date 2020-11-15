@inject DocumentationService DocumentationService
@using MonacoRazor
@Documentation
<h4>Try it out</h4>
@Code
<br />
<h4>Code</h4>

<CodeEditor Language="razor" @bind-Code="sampleCode"/>

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