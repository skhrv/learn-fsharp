// 16.1
let notDivisible (n, m) = (m % n = 0)

// 16.2
let prime n =
  let rec loop m = 
    if m > int(System.Math.Sqrt(double n)) then true
    elif notDivisible(m, n) then false
    else loop(m + 1)
  if n = 2 then true
  elif n < 2 then false
  else loop 2
