# FluentFileSystem
FluentFileSystem (or FFS) for .NET is a filesystem abstraction library. FluentFileSystem intends to make dealing with the filesystem easier, by treating each directory and file as an object. 

Because of its design, custom filesystems can be plugged in to further enhance the library.

## Examples:
    // First, create a FileSystemService.
    var fileSystemService = FileSystemService(new FileSystem());
    
    // Chaining:
    // Get a file called "C.txt" in sub directory "A\B" of "C:\Users\":
    var directory = fileSystemService.GetDirectory("C:\Users\");
    var fileTwoLevelsDown = directory.GetDirectory("A").GetDirectry("B").GetFile("C.txt");
    
    // LINQ Querying:
    var bigFilesInDirectory = directory.GetFiles().Where(x=> x.Length > 10737418240);
    
    // File Copying:
    var newFile = directory.GetFile("newNonExistingFile.txt");
    await fileTwoLevelsDown.CopyToAsync(newFile, overwrite: false, CancellationToken.None);

Contributors to this project are welcome to add their attribution information to the project under the Contributors section below:
# Contributors 
<add your credit here>

# License 
MIT. 
    
# FluentFileSystem Copyright 
Copyright (c) 2023 Michael D. Corbett

Email: michael@mdcorbett.com 

Github: https://github.com/vector-man

Website: https://mdcorbett.com
