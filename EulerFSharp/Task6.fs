module Task6

(*
 * Sum square difference
 *
 * The sum of the squares of the first ten natural numbers is,
 * 1^2 + 2^2 + ... + 10^2 = 385
 * 
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10)^2 = 55^2 = 3025
 *
 * Hence the difference between the sum of the squares of the first ten natural
 * numbers and the square of the sum is 3025 − 385 = 2640.
 *
 * Find the difference between the sum of the squares of the first one hundred
 * natural numbers and the square of the sum.
 *)

let run =
    let sumOfSquares list =
         list
         |> List.map (fun x -> x * x)
         |> List.sum
    let squareOfSum list = 
        let sum = List.sum list
        sum * sum
    
    let difference list =
        (squareOfSum list) - (sumOfSquares list)

    printfn "%d" (difference [1..100])