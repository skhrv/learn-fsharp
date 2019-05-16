// 20.3.1
let vat n x = x + x / 100.00 * double n

// 20.3.2
let unvat n x = x - x / (100.00 + double n) * double n

// 20.3.3
let rec min f = fun n ->
  if((f n) = 0) then n
  else min f (n - 1)
