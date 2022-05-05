module Views
open Giraffe.DotLiquid


let index model =
  dotLiquidHtmlTemplate "test.html" model
