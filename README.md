# Bug on iPadOS 26.5
When using the `DisplayPromptAsync` method with a numeric keyboard on iPadOS 26.5, 
tapping on the input field causes the keyboard to flip to an alphanumeric keyboard. 
This behavior is unexpected and disrupt the user experience.

### Steps to Reproduce
1. Run the provided .NET MAUI application on an iPadOS 26.5 simulator.
2. Click on the "Click me" (`CounterBtn`) button to trigger the `DisplayPromptAsync` method with a numeric keyboard.
3. Tap on the input field to observe the numeric keyboard dissapearing and a **new** alphanumeric keyboard showing up.

This behavior is unexpected and disrupt the user experience.