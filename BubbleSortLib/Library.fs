namespace BubbleSortLib

// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

module Sorter =


    let swap i j (arr : 'a []) =
        let tmp = arr.[i]
        arr.[i] <- arr.[j]
        arr.[j] <- tmp

    let sort arr =
        let rec loop (arr : 'a []) =
            let mutable swaps = 0
            for i = 0 to arr.Length - 2 do
                if arr.[i] > arr.[i+1] then
                    swap i (i+1) arr
                    swaps <- swaps + 1

            if swaps > 0 then loop arr else arr

        loop arr