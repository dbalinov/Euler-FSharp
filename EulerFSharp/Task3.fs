module Task3

(*
 * Largest prime factor
 *
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * 
 * What is the largest prime factor of the number 600851475143 ?
 *)

let run = 
    let sqrtInt = float >> sqrt >> bigint
     
    let getFactors n = [
        let limit = sqrtInt n
        for i in 2I .. limit do
           if bigint.op_Modulus(n, i) = 0I
           then yield i 
    ]

    let isPrime n = 
        let limit = sqrtInt n
        [2I..limit]
        |> List.forall (fun x -> n % x <> 0I)
        
    getFactors 600851475143I
    |> List.filter isPrime
    |> List.last
    |> printfn "%A"
