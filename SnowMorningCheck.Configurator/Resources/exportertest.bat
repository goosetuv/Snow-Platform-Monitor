::===============================================================
:: Batch file for running the service test command
:: File Version 1.4.1.0
:: Author: Laim McKenzie
:: Copyright (c) Laim McKenzie 2021
:: AUTOMATICALLY UPDATE: TRUE
::===============================================================
net stop snowplatformmonitor
SnowPlatformMonitor.Service.exe --test
net start snowplatformmonitor
pause