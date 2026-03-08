# Vosk-UCRT64 Portable Distribution

Professional binary distribution of **Vosk-API** optimized for **Windows UCRT64** environments.

## Overview
Portable build for developers using **MSYS2 UCRT64** toolchain or seeking a dependency-free deployment on Windows 10/11.

## Key Features
* **Portable:** Works without a full MSYS2 installation.
* **C-SDK:** Headers and DLLs included for C/C++/C# integration.
* **Python Ready:** Pre-compiled `.whl` package available in Releases.

## Project Structure
* `/bin` ― Shared libraries (available in Releases).
* `/include`` ― C/C++ Header files.
* `/python` — Python-specific instructions.
* `/samples` — Usage examples.

## Installation

### Python
Download `vosk-0.3.47-py3-none-any.whl` from Releases and install:

```bash
pip install vosk-0.3.47-py3-none-any.whl`
```J
### C / C++ / C#
1. Download `vosk-win-ucrt64-v0.1.0-alpha.zip` from Releases.
2. Link against `libvosk.dll` and include headers from `/include`.

## License
Distributed under the Apache License 2.0.