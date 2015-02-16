# Music-Format-Fixer
A project in C# to fix common music file format issues

Music Format Fixer

This was a quick little side project that I started as a way to get more familiar with C#. 
This program was designed to fix the common music file format error in which a piece 
of downloaded music would contain both the artist and the title in the file-name but the file meta data would be empty.
What this program does is allow you to select a folder containing music. Then after you press go it will go through the files
in that folder and if the file is a recognized file type it will parse the file name. If it finds a hyphen it will then separate the 
file name in the way you specified and set the correct meta data along with setting the track title as the file name.    
 
Music Format Fixer was created in C# using Visual Studios 2012. I used a library called Taglib
which allowed me to access the meta data of different music file formats easily.
