module Task5

(*
 * Smallest multiple
 *
 * 2520 is the smallest number that can be divided by each of the
 * numbers from 1 to 10 without any remainder.
 *
 * What is the smallest positive number that is evenly divisible by all
 * of the numbers from 1 to 20?
 *)

let run = 
    let intGenerator =
        Seq.unfold
            (fun x -> Some(x, x + 1)) 
            (1)
    let commonDivider = 5 * 7 *11 * 13 * 17 * 19* 9 * 16

    let evenlyDevisibleBy20 n =     
       n % commonDivider = 0
    
    intGenerator
    |> Seq.find evenlyDevisibleBy20
    |> printfn "%O"