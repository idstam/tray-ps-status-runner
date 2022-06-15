# tray-ps-status-runner

A tool to show status changes and run pre defined Powershell scripts.

# There are three parts to this application; triggers, patterns and scripts.

## Triggers

A trigger is an observable action that comes with a result that is later used for the **patterns**.

1. CMD - Run a command every X minutes and send the console to the pattern matcher.
2. Powershell - Run some Powershell code every X minutes and send the result to the pattern matcher.
3. File wathcer - Watch a file for changes and send the content of the file to the pattern matcher.

## Patterns
When one of the patterns are found in the content from a trigger the tray icon changes to the corresponding icon and a toaster/balloon is shown for five seconds showing the pattern that was found.

## Scripts

You can have any number of Powershell scripts saved within the application.  
Each script title will be added to the context menu (right click) on the tray icon and can be run by simply clicking them in the menu.

# The tray icon

Beyond running the stored scripts the context menu of the tray icon has the following items:

1. Check - Activate the current trigger
2. Last result - Show the result from the last time a trigger was run
3. Config - Open the configuration UI
4. Exit - Exit the application

# The configuration file
There is a configuration.json in the application folder that has all of the configuration data.  
It can be copied if you want the same configuration of several hosts.
