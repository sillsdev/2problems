# 2problems

> Some people, when confronted with a problem, think 'I know, I'll use regular expressions.' Now they have two problems. --Jamie Zawinski

2Problems is a GUI utility to process multiple files through a set of regular expressions. Sets of expressions are placed, one per line, in a "rule file", which should be placed in the rules subfolder.

After processing, you can view the resulting files, either in a text window or embedded browser.

2Problems is a poor reinvention of wheel, but it was quick to build and is suitable for giving to my less-technical colleagues (only 12k, zipped). I write the regular expressions [[rule file]Rules File Format] for them, but then they can run it on their own files as needed. And when there's something you can't do with a regular expression, I can grab the code and add some c# to get the job done.

![Screenshot](http://i.imgur.com/hv5QRhh.png)

##Requirements
.Net Framework ver 2.0 or greater. Should work fine under mono on Linux.

##Installation
Get the latest from the Files tab above, unzip the folder and run the exe.

##Adding your own rules
Add your own rule sets by placing them in the rules folder. The file should end in ".txt" and start with a comment. See [Rules File Format](https://github.com/sillsdev/2problems/wiki/Rules-File-Format) for instructions.
