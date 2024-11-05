open System

open Avalonia
open Avalonia.Themes.Simple

open Fabulous.Avalonia
open type Fabulous.Avalonia.View

let view () =
    DesktopApplication(Window(VStack() { () }))

let program = Program.stateless view

[<EntryPoint; STAThread>]
let main args =
    FabulousAppBuilder
        .Configure(SimpleTheme, program)
        .UsePlatformDetect()
        .StartWithClassicDesktopLifetime(args)
