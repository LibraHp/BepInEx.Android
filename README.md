# BepInEx.Android

Fork of [BepInEx](https://github.com/BepInEx/BepInEx) customized for running on Android IL2CPP games via the NextBep launcher.

This fork adapts the upstream BepInEx 6.0.0 preloader chain for Android: environment variable discovery, CoreCLR bootstrap via `coreclr_create_delegate`, and native interop through libfusion.so.

## Changes from upstream

- `NextCoreEntrypoint.Start()` as entry point (called from native via delegate)
- Environment variable based path discovery (`NEXT_*` vars set by libfusion)
- `NextInterop.cs` for P/Invoke back to native (logging, hook management)
- `Il2CppInteropManager` adapted for Android library loading
- Branding: `FUSION` renamed to `NEXT`, assembly names updated

## Building

```bash
cd BepInEx.Android
dotnet build BepInEx.sln -c Release_Unity
# Output: bin/Unity.IL2CPP/
```

## Platform support

|              | Windows | macOS | Linux | Android |
|--------------|---------|-------|-------|---------|
| Unity Mono   | No     | No   | No   | N/A     |
| Unity IL2CPP | No     | No    | No   | Yes     |
| .NET / XNA   | Yes     | Mono  | Mono  | N/A     |

## Upstream resources

- [BepInEx documentation](https://docs.bepinex.dev/master/)

## License

LGPL-2.1 — same as upstream BepInEx.
