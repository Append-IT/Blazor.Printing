@inject IPrintingService PrintingService
<Example Name="@this.GetType().Name">
    <Documentation>
        <h3>HTML</h3>
        <p>Print a HTML element with a specific Id.</p>
    </Documentation>
    <Code>
        <form id="printable-form">
            <div class="form-group">
                <label for="exampleInputEmail1">Email address</label>
                <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div class="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
            </div>
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1">
                <label class="form-check-label" for="exampleCheck1">Check me out</label>
            </div>
        </form>

        <button @onclick="@(_ => PrintingService.Print("printable-form", PrintType.Html))">
            Print Form Without Bootstrap Styling
        </button>
    </Code>
</Example>