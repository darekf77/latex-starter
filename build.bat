cls
IF EXIST "C:\\Program Files\\MiKTeX 2.9\\miktex\\bin\\x64" (
    echo "MiKText founded"
) ELSE (
    echo "Please install MiKTeX 2.9 https://miktex.org/2.9/setup"
    exit /b
)
IF EXIST "dist" (
    rmdir "dist" /s /q
    mkdir "dist"
) ELSE (
    mkdir "dist"
)
rm MyAwesomeMasterThesis.pdf
pdflatex main -interaction=nonstopmode
bibtex main
makeglossaries main
pdflatex main -interaction=nonstopmode
pdflatex main -interaction=nonstopmode

REM copy main.tex dist
move main.* dist
move dist\main.tex .
copy dist\main.pdf MyAwesomeMasterThesis.pdf
START "" "C:\\Program Files\\MiKTeX 2.9\\miktex\\bin\\x64\\texworks.exe"  MyAwesomeMasterThesis.pdf
echo "done"

