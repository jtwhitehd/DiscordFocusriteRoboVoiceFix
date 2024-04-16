# Focusrite Discord Fix

I got tired of being told that I sounded like a robot and going into task manager every time my computer went into sleep mode. 

This utility resolves an audio issue that occurs when using certain Focusrite audio interfaces with Discord (**specifically the Focusrite Scarlet 2i2 3rd Gen**). Users may experience poor and robotic voice transmission due to the `audiodg.exe` process running across multiple processor cores. This program automates the solution by setting the processor affinity of `audiodg.exe` to a single core, ensuring clear audio transmission.

## Description

The program checks and corrects the processor affinity of the `audiodg.exe` process to run on a single core if it is not already set. This is necessary because the affinity setting may reset when a computer goes to sleep or periodically over time. The utility needs to be run as an administrator. It automatically checks the process every five minutes. If the affinity is currently set correctly, it will log a dot (.) in the console to indicate a check without any changes (which isn't necessary and can be removed if you don't care). Start the program at system boot-up and forget about it.

## Installation

1. Download the project files from this repository.
2. Open the project in Visual Studio.
3. Compile the project to generate an executable.

## Usage

To use the Focusrite Discord Fix:

1. Simply run the program as an administrator.
2. Optionally, assign it to start automatically with Windows for complete automation.
