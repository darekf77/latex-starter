if [ -d "dist" ]; then
    rm -rf "dist" 
    mkdir "dist"
else
    mkdir "dist"
fi
rm MyAwesomeMasterThesis.pdf
pdflatex main -interaction=batchmode/nonstopmode/
bibtex main
makeglossaries main
pdflatex main -interaction=batchmode/nonstopmode/
pdflatex main -interaction=batchmode/nonstopmode/

cp main.tex dist/
mv main.* dist/
mv dist/main.tex .
cp dist/main.pdf MyAwesomeMasterThesis.pdf
open MyAwesomeMasterThesis.pdf
echo "done"

