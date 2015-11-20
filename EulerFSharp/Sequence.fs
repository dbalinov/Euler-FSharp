module Sequence

(* Number operations *)

let sqrtI = float >> sqrt >> bigint

let isPrime n =
    match n with
    | _ when n > 3I && (n % 2I = 0I || n % 3I = 0I) -> false
    | _ ->
        let limit = sqrtI n + 1I
        [2I..limit] 
        |> List.forall (fun x -> n % x <> 0I)


(* Sequences *)

let naturalNumbers =
    Seq.unfold
        (fun x -> Some(x, x + 1I)) 
        (1I)

let primeNumbers =
    naturalNumbers
    |> Seq.filter isPrime

let fibonacciNumbers =
    Seq.unfold
        (fun (current, next) -> Some(current, (next, current + next)))
        (0I, 1I)