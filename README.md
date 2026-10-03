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
    4. For SSMS `v20` / `v21` / `v22` (Microsoft SQL Management Studio 22):
        1. Download the prebuilt release from <https://github.com/juanruiz85/ssms-wakatime/releases/latest>:
            * `WakaTime.v22.vsix` - installer package (the `.v22` suffix makes VSIXInstaller.exe detect it as an SSMS extension, not Visual Studio).
            * `SSMS-Wakatime-<version>.zip` - folder with compiled binaries + `AddPackage.bat` (same layout as the official releases).
        2. IMPORTANT: do NOT install the .vsix by double-clicking if you have Visual Studio 2022 installed, because it will offer to install into VS instead of SSMS. Use one of these two options:
            * Option A (recommended - manual install, like the official WakaTime releases):
                1. Unblock and unzip `SSMS-Wakatime-<version>.zip`.
                2. Copy the folder `WakaTime.v22` to:
                    * v20 - `C:\Program Files\Microsoft SQL Server Management Studio 20\Common7\IDE\Extensions\`
                    * v21 - `C:\Program Files\Microsoft SQL Server Management Studio 21\Common7\IDE\Extensions\`
                    * v22 - `C:\Program Files\Microsoft SQL Server Management Studio 22\Common7\IDE\Extensions\`
                3. Run `AddPackage.bat` as administrator (adds the SkipLoading registry entry for the SSMS package whitelist).
                4. Restart SSMS. On first use, SSMS may show a security dialog about the unsigned package - accept it. Then go to `Tools > Options > WakaTime` and enter your API key.
            * Option B (installer): run from a command prompt:
                `"C:\Program Files\Microsoft SQL Server Management Studio 22\Common7\VSIXInstaller.exe" WakaTime.v22.vsix`
                (use the VSIXInstaller.exe that ships WITH SSMS 22, not the one from Visual Studio).
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
