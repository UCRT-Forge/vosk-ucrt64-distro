# \# Vosk-UCRT64 Portable Distribution

# 

# Professional binary distribution of \*\*Vosk-API\*\* (Kaldi-based speech recognition) optimized for \*\*Windows UCRT64\*\* environments.

# 

# \## Overview

# This project provides a clean, portable build of Vosk, filling the gap for developers using the modern \*\*MSYS2 UCRT64\*\* toolchain or seeking a dependency-free deployment on Windows 10/11.

# 

# \### Why UCRT64?

# Unlike legacy MSVCRT builds, this distribution is linked against `ucrtbase.dll`, ensuring better compatibility with modern C++ standards and Windows system libraries.

# 

# \## Key Features

# \* \*\*Portable:\*\* Works out-of-the-box without a full MSYS2 installation.

# \* \*\*C-SDK:\*\* Header files and import libraries included for C/C++ and C# integration.

# \* \*\*Python Ready:\*\* Pre-compiled `.whl` package available for modern Python versions.

# \* \*\*Minimal Dependencies:\*\* Verified to run in clean `cmd.exe` environments.

# 

# \## Project Structure

# \* `/bin` — Shared libraries and dependencies (available in Releases).

# \* `/include` — C/C++ Header files.

# \* `/python` — Python-specific artifacts and instructions.

# \* `/samples` — Basic usage examples.

# 

# \## Installation

# \### Python

# Download the latest `.whl` from the \*\*Releases\*\* section and install via pip:

# ```bash

# pip install vosk-0.3.47-py3-none-any.whl

# C / C++ / C#

# Download the vosk-ucrt64-artifacts.zip from Releases.

# 

# Link against libvosk.dll and include headers from /include.

# 

# Acknowledgments

# Original core logic and models by:

# 

# Alphacephei (Vosk-API)

# 

# Kaldi ASR contributors

# 

# License

# Distributed under the Apache License 2.0.

