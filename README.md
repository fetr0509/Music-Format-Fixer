# Music Metadata Formatter
A project in C# to fix common MP3 metadata format issues.

This was a small side project that I started as a way to get more familiar with the C# programming language and libraries. 
This program was designed to fix issues that are common with music file metadata downloaded from smaller musicians and sources other than 
large music distribution platforms such as Amazon, iTunes, or Band camp. The issue is that the metadata of downloaded music would 
contain both the artist and the title in the file-name but the file's metadata would be empty.

What this program does is allow you to select a folder containing music. Then after you click the start button it 
will iterate through the files in that folder and if the file is a recognized file type it will parse the file name. 
If it finds a hyphen it will then separate the file name in the way you specified and set the correct metadata along with 
renaming the file to the correct name.  

This program utilizes a library called [Taglib](http://taglib.org/) to access the metadata in the audio files.
 
This program was created using Visual Studios 2012 and can be compiled without any dependencies. 
