# WakaTime for SQL Server Management Studio

Metrics, insights, and time tracking automatically generated from your programming activity.

## Installation

1. Download the latest release <https://github.com/gandarez/ssms-wakatime/releases/latest>.

2. Right click the downloaded zip file, click `Properties`, click `Unblock`.

3. Unzip the content.

4. Run `AddPackage.bat` to add WakaTime extension into registry white list.

5. Manual instructions:
    1. For legacy versions before `v18`:
        1. Copy the folder `WakaTime` to the desired installation folder(s):
            * v2012 - `C:\Program Files (x86)\Microsoft SQL Server\110\Tools\Binn\ManagementStudio\Extensions`
            * v2014 - `C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\Extensions`
            * v2016 - `C:\Program Files (x86)\Microsoft SQL Server\130\Tools\Binn\ManagementStudio\Extensions`
            * v17 - `C:\Program Files (x86)\Microsoft SQL Server\140\Tools\Binn\ManagementStudio\Extensions`
    2. For SSMS `v18`:
        1. Copy the folder `WakaTime.v18` to the desired installation folder:
            * v18 - `C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Extensions\`
    3. For SSMS `v19`:
        1. Copy the folder `WakaTime.v18` to the desired installation folder:
            * v19 - `C:\Program Files (x86)\Microsoft SQL Server Management Studio 19\Common7\IDE\Extensions\`
    4. For SSMS `v20` / `v21` (Microsoft SQL Management Studio 22):
        1. Build the `SSMS20` project (`SSMS20\SSMS20.csproj`) in `Release` mode.
        2. Copy the folder `WakaTime.v20` (output of the `SSMS20` project) to the desired installation folder:
            * v20 - `C:\Program Files\Microsoft SQL Server Management Studio 20\Common7\IDE\Extensions\`
            * v21 - `C:\Program Files\Microsoft SQL Server Management Studio 21\Common7\IDE\Extensions\`
            * Microsoft SQL Management Studio 22 - `C:\Program Files\Microsoft SQL Server Management Studio 22\Common7\IDE\Extensions\`
        > Note: SSMS v20+ is built on the Visual Studio 2022 (v17.x) shell, so it requires the
        > `SSMS20` project binaries compiled against the VS 2022 SDK. The old `WakaTime.v18`
        > binaries (built for the v15/v16 shell) will NOT load in SSMS v20+.

6. Enter your [api key](https://wakatime.com/settings#apikey), then press `enter`.

7. Use SSMS and your coding activity will be displayed on your [WakaTime dashboard](https://wakatime.com).

## Usage

Visit <https://wakatime.com> to see your coding activity.

![Project Overview](https://wakatime.com/static/img/ScreenShots/Screen-Shot-2016-03-21.png)

## Supported SQL Server Management Studio Editions

* SQL Server Management Studio 2012 (build number 11.0.x.x)
* SQL Server Management Studio 2014 (build number 12.0.x.x)
* SQL Server Management Studio 2016 (build number 13.0.x.x)
* SQL Server Management Studio 17 (build number 14.0.x.x)
* SQL Server Management Studio 18 (build number 15.0.x.x)
* SQL Server Management Studio 19 (build number 19.0.x.x)
* SQL Server Management Studio 20 (build number 20.0.x.x)
* SQL Server Management Studio 21 (build number 21.0.x.x)
* Microsoft SQL Management Studio 22 (build number 22.0.x.x) - uses the `SSMS20` project (VS 2022 v17.x shell)

## Troubleshooting

If the extension was blocked, try running as administrator.

```xml
<description>Appid denied the loading of package</description>
<guid>{52D9C3FF-C893-408E-95E4-D7484EC7FA47}</guid>
```
