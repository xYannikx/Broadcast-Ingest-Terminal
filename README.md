<div align="center">
  <img src="BroadcastIngestTerminal/icon.ico" width="128" alt="Broadcast Ingest Terminal Icon">
  <h1>Broadcast Ingest Terminal</h1>
  <p><strong>A bilingual, lightweight Windows tool for SD broadcast ingest workflows.</strong></p>
</div>

<div align="center">
  <strong><a href="#english">English</a></strong> | <strong><a href="#deutsch">Deutsch</a></strong>
</div>

---

## <a id="english"></a>English

A lightweight Windows tool designed to convert **16:9 source material** into broadcast-ready **SD masters (576i)**. 
Built in C# (.NET 2.0) and optimized for maximum compatibility: running flawlessly on everything from Windows 2000 up to Windows 11.

### Download
Get the latest installer here:  
**[Download Broadcast Ingest Terminal v1.0 (Setup.exe)](https://github.com/xYannikx/Broadcast-Ingest-Terminal/releases/latest)**

### Features
- **Broadcast-Ready Output:** Converts videos into two `.mov` files (v210 Uncompressed 10-bit, 576i, PCM 48kHz Stereo):
  - 1x 16:9 FHA (Full Height Anamorphic) Master
  - 1x 4:3 LB (Letterbox) Master
- **Smart Framerate Adaptation:** Profiles for 25p, 25i, 23.976p, 24p, and 29.97i (including speedup and pitch correction).
- **Bilingual UI:** Switch live between English and German.
- **Live Progress Bar:** Real-time progress tracking during video processing.
- **Data Management:** Output masters and settings are stored in the user's "Documents" folder.

### System Requirements
- **OS:** Windows 2000, XP x86 & x64, Vista x86 & x64, 7 x64, 8 x64, 10 x64 or 11.
- **Framework:** .NET Framework 2.0 (or higher).
- **Engine:** Powered by FFmpeg (automatically included by the installer, featuring a legacy version for older OS).
- *Note for developers:* To test the code locally in Visual Studio, you must manually place the required FFmpeg executables into your `bin/Debug` folder.

---

## <a id="deutsch"></a>Deutsch

Ein ressourcenschonendes Windows-Tool, um **16:9 Quellmaterial** exakt in sendefähige **SD-Broadcast-Master (576i)** zu konvertieren. 
Entwickelt in C# (.NET 2.0) und optimiert für maximale Kompatibilität: von Windows 2000 bis Windows 11.

### Download
Lade dir den aktuellen Installer hier herunter:  
**[Download Broadcast Ingest Terminal v1.0 (Setup.exe)](https://github.com/xYannikx/Broadcast-Ingest-Terminal/releases/latest)**

### Features
- **Sendefähiger Output:** Konvertiert Videos in zwei `.mov`-Dateien (v210 Uncompressed 10-bit, 576i, PCM 48kHz Stereo):
  - 1x 16:9 FHA (Full Height Anamorphic) Master
  - 1x 4:3 LB (Letterbox) Master
- **Intelligente Framerate-Anpassung:** Profile für 25p, 25i, 23.976p, 24p und 29.97i (inkl. Speedup und Pitch-Korrektur).
- **Mehrsprachig:** Unterstützt Deutsch und Englisch (Live-Umschaltung im Menü).
- **Live-Progressbar:** Präzise Fortschrittsanzeige während der Verarbeitung.
- **Datenmanagement:** Einstellungen und Master-Dateien werden im "Dokumente"-Ordner des Nutzers gespeichert.

### Systemanforderungen
- **Betriebssystem:** Windows 2000, XP x86 & x64, Vista x86 & x64, 7 x64, 8 x64, 10 x64 oder 11.
- **Framework:** .NET Framework 2.0 (oder höher).
- **Engine:** Nutzt FFmpeg (wird vom Installer automatisch mitgeliefert, inkl. einer Legacy-Version für alte Systeme).
- *Hinweis für Entwickler:* Um den Code lokal in Visual Studio zu kompilieren und zu testen, müssen die benötigten FFmpeg-Dateien manuell in den lokalen `bin/Debug` Ordner gelegt werden.

---

## Credits
- **Creator:** [xYannikx](https://github.com/xYannikx)
- **Icon Creator:** [Trisii](https://github.com/Trisii)
- **License:** MIT License
