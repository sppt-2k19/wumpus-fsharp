namespace UFSharp
open UnityEngine

type Default(g:GameObject) as self =
    let mutable go = g
    let mutable transform = g.transform
    
    member this.Start() =
        ignore
    
    member this.Update() =
        ignore
    

