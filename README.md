Latex Starter (beta)
===================

**Latex starter**  -  dont't wait.. start your master thesis in latex today
and keep nice structure of project.

# Features

 - structure prepare eve forn big thesis
 - cross platform (Mac OSX, Windows, Linux)
 - build with shortcut in  Visual Studio Code:
    -   `ctrl + shift + b`   Windows, Linux
	-   `cmd + shift + b`   MacOS

 - **Bibtex** - keep bibliography in source.bib
 - **Glossaries** - list acronmyms and glocaries
 - **Poslish** characters supported (ąęółźźńć)

# Requirements 

###All platforms:
 1. Mitex 2.9 - (https://miktex.org/download
 2. Git for [Windows](https://git-scm.com/download/win), [MacOSX, Linux](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)
 2. [Visual Studio Code](https://code.visualstudio.com/download)
 3. Perl for [Windows](http://strawberryperl.com/),  [MacOSX](https://learn.perl.org/installing/osx.html),  [Linux](https://learn.perl.org/installing/unix_linux.html)
 4. Python 2.7 for [Windows](https://www.python.org/downloads/windows/), [Mac OSX](https://www.python.org/downloads/mac-osx/), [Linux](http://docs.python-guide.org/en/latest/starting/install/linux/)


# How to run project ?

 1. Clone  project: `git clone https://github.com/darekf77/latex-starter.git`
 2. Open **latex-starter** forlder with **Visual Studio Code**.
 3. Ooptional step) Go to *Extensions* / *Show Workspace Recommended Extensions* and click install for all of them.
 3. Build sample project:
	 -   `ctrl + shift + b`   Windows, Linux
	 -   `cmd + shift + b`   MacOS




### Known bugs
#### Windows 
- before **build** open latex pdf reader **TexWorks**  
(you can do this from powershell: `start C:\Program Files\MiKTeX 2.9\miktex\bin\x64\texworks.exe` or from start menu) and then use shortcut to do builds

### Questions
#### - Why I can't see files like .gitignore ?
- open file `.vscode/settings.json` and edit  **"files.exclude"**:

