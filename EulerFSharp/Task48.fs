module Task48

(*
 * Self powers
 *
 * The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
 * 
 * Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
 * 
 *)

let run = 
    let selfPow n = n ** (n |> int)
    let sum = 
        [1I..1000I]
        |> List.map (fun i -> selfPow i)
        |> List.sum
    sum % (selfPow 10I)
    |> printfn "%A"