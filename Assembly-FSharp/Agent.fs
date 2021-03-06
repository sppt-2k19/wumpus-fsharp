namespace Wumpus
    open UnityEngine
    
    type Agent() =
        inherit MonoBehaviour()
        let mutable target = new Vector3(0.0f, 1.35f, 0.0f)
        let mutable spent:float32 = 0.0f
        let mutable dur = 0.0f
        
        member this.Start() =
            ()
           
        member this.Update() =
            spent <- spent + Time.deltaTime
            if Vector3.Distance(this.transform.position, target) < Mathf.Epsilon then
                this.transform.position <- target
            else 
                this.transform.position <- Vector3.Slerp(this.transform.position, target, spent / dur)
        
        member this.SetLerpPos(pos, ?duration) =
            let duration = defaultArg duration 1.0f
            spent <- 0.0f
            dur <- duration
            target <- pos