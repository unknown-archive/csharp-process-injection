#include <iostream>
#include <Windows.h>

int main()
{
    STARTUPINFO si;
    si.cb = sizeof(si);
    ZeroMemory(&si, sizeof(si));

    PROCESS_INFORMATION pi;
    ZeroMemory(&pi, sizeof(pi));

    BOOL success = CreateProcess(
        L"C:\\Windows\\System32\\notepad.exe",
        NULL,
        0,
        0,
        FALSE,
        0,
        NULL,
        L"C:\\Windows\\System32",
        &si,
        &pi);

    if (success)
    {
        printf("Process created with PID: %d.\n", pi.dwProcessId);
        return 0;
    }
    else
    {
        printf("Failed to create process. Error code: %d.\n", GetLastError());
        return 1;
    }
}