// 20.3.1
let vat n x = x + x / 100.00 * double n

// 20.3.2
let unvat n x = x - x / (100.00 + double n) * double n

// 20.3.3
let min f =
  let rec loop n =
    if((f n) = 0) then n
    else loop (n + 1)
  loop 0
