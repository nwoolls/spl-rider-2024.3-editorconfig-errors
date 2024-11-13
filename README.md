# README

This project demonstrates two separate issues w/ Rider 2024.3.

## Regression (?) - Error Indicators in the Solution Explorer for .editorconfig violations

This can be seen in the `Program.cs` file. It _does_ contain an `.editorconfig` violation, but this manifests as an error indicator in the Solution Explorer, which was not the case in Rider 2024.2.

This is very annoying in larger solutions, but can be fixed by addressing style violations.

See: https://youtrack.jetbrains.com/issue/RIDER-119899

## Bug - Error Indicators in the Solution Explorer for Unknown Reason(s)

This can be seen in `UnitTest1.cs`. There is an error indicator for this file in the Solution Explorer, but not the editor. Checking the **Problems** tool window shows no error for the file in the **File** tab, but in the **All Solution Files** files, shows `<App.Tests>\UnitTest1.cs:378 Anonymous function can be made static`.

This issue does not exist in 2024.2.

This is very annoying in larger solutions, and cannot be worked around.

See: https://youtrack.jetbrains.com/issue/RIDER-119901
