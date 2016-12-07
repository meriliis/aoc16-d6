#load "Library1.fs"
open D6

open System

let path = System.IO.Path.Combine(__SOURCE_DIRECTORY__,"input.txt")
let input = System.IO.File.ReadAllLines path

let message = for i in [0..(input.[0].Length-1)] do
                input
                |> Array.map (fun s -> s.Substring(i, 1))
                |> Seq.groupBy id
                |> Seq.map (fun (letter, seq) -> letter, Seq.length seq)
                |> List.ofSeq
                |> List.sortBy (fun (fst, snd) -> -snd)
                |> List.item(0)
                |> (fun (fst, snd) -> printf "%s" fst)


