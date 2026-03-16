/// KAIST CS220 In-Class Activity Project

/// Modify the function `gcd` in such a way that the function computes the
/// greatest common divisor of two 32-bit integers.
let rec gcd a b =
  if b = 0 then a
  elif a = 0 then b
  else gcd b (a % b)

gcd 360 210
|> printfn "%d"
