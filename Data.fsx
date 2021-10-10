// Part 2

// Load the data
#load "one.fsx"

let groups = 
  Data.studs
  |> Seq.map snd
  |> Seq.distinct

let count g =
  Data.studs |> Seq.filter (snd >> (=)g) |> Seq.length

groups
|> Seq.iter (fun g ->
    printfn "Group: %d, # students: %d" g (count g))
