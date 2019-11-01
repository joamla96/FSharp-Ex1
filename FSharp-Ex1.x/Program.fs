// Learn more about F# at http://fsharp.org

open System

// Ex 1.1
let g n =
    n + 4

// Ex 1.2
let h x y =
    System.Math.Sqrt(x*x + y*y)

// Ex 1.3
let gf = function
    | x -> x + 4
    
let hf = function
    | (x ,y) -> System.Math.Sqrt(x*x + y*y)

// Ex 1.4
let rec f = function
    | 0 -> 0
    | n when n > 0 -> n + f(n-1)
    | _ -> -1

// Ex 1.5
let rec fib = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib(n-1) + fib(n-2)
    
// Ex 1.6
let rec sum = function
    | (m, 0) -> m
    | (m, n) -> sum(m, n-1) + (m + n)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    
    0 // return an integer exit code
