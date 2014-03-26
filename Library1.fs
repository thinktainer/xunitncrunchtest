namespace XunitTest

open Xunit

type TheseDontRun () =
    [<Fact>]
    member this.ShouldNotRun () =
        failwith "Oh snap, i ran!"

[<Trait("Category", "Unit")>]
type TheseWillRun () =
    [<Fact>]
    member this.ShouldRun () =
        Assert.True(true)

module ``These won't run`` =
    [<Fact>]
    let ``I will throw if i run`` () =
        failwith "Oh noes!"

[<Trait("Category", "Unit")>]
module ``But these will``=
    [<Fact>]
    let ``I will run`` () =
        Assert.True(true)

