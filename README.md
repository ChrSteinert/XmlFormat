# XmlFormat

… a most simple tool to format xml files.

It uses .NET's XmlDocument to load and then save the xml file again, which is then with an applied formatting.

## Build

It can be build with a .NET SDK (3.0.100 or newer) by running `dotnet build`.

## Usage

Supply the to be formatted files as command line arguments. XmlFormat accepts multiple files:

```bash
xmlf ./file1.xml ../folder1/file2.xml ./file.xml.ref
```
