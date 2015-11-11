module Task4

(*
 * Largest palindrome product
 *
 * A palindromic number reads the same both ways. The largest palindrome made
 * from the product of two 2-digit numbers is 9009 = 91 × 99.
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 *)

let run =
    let reverseNumber n = 
       let rec reverse n partial = 
           match n with
           | 0 -> partial
           | _ -> reverse (n / 10) (partial * 10 + n % 10)
       reverse n 0
   
    let palindromeMultiplication list = 
        list 
        |> List.collect (fun x -> list |> List.map (fun y -> x * y))
        |> List.filter (fun x -> x = reverseNumber x)
        |> List.max

    let twoDigitNumbers = [10..99]
    let threeDigitNumbers = [100..999]

    palindromeMultiplication threeDigitNumbers
    |> printfn "%A"