# Vosk-UCRT64 Portable Distribution

Professional binary distribution of **Vosk-API** optimized for **Windows UCRT64** environments.

## Overview
This project provides a clean, portable build of Vosk, filling the gap for developers using the modern **MSYS2 UCRT64** toolchain or seeking a dependency-free deployment on Windows 10/11.

## Key Features
* **Portable:** Works out-of-the-box without a full MSYS2 installation.
* **C-SDK:** Header files and import libraries included for C/C++ and C# integration.
* **Python Ready:** Pre-compiled `.whl` package available in Releases.

## Project Structure
* `/bin` — Shared libraries (available in Releases).
* `/include` — C/C++ Header files.
* `/python` — Python-specific instructions.
* `/samples` — Usage examples.

## Installation

### Python
Download `vosk-0.3.47-py3-none-any.whl` from Releases and install:

```bash
pip install vosk-0.3.47-py3-none-any.whl
```

### C / C++ / C#
1. Download `vosk-win-ucrt64-v0.1.0-alpha.zip` from Releases.
2. Link against `libvosk.dll` and include headers from `/include`.

## License
Distributed under the **Apache License 2.0**.
