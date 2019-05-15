// 17.1
let rec pow = function
  | (s, 0) -> ""
  | (s, n) -> s + pow(s, n - 1)

// 17.2
let rec isIthChar (s: string, n: int, c: char) =
  let length = String.length s
  if (n >= length) then false
  elif (s.[n] = c) then true
  else isIthChar(s, n + 1, c)

// 17.3
let rec occFromIth (s: string, n: int, c: char) =
  let length = String.length s
  if (n >= length) then 0
  elif (s.[n] = c) then 1 + occFromIth(s, n + 1, c)
  else occFromIth(s, n + 1, c)

