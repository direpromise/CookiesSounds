@echo off
for /r %%i in (*.wav *.mp3) do (
    ffmpeg -i "%%i" -c:a libvorbis -q:a 4 "%%~dpni.ogg"
)