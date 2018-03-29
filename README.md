
# DisasterAwareness

An alternative general alert system made in response to the 2018 missile warning incident in Hawaii. 

## Why did we pick this implementation and how it we Plan on Implementing it? 

By using Windows Form, we can create a user interface and use code to manipulate data. Thanks to the tight integration within the Microsoft Technology Stack, Windows Form can be easily used in conjunction with the .NET Framework. Visual Studio was the clear choice as an IDE due to its compatibility with both .NET and Windows Form. 

The login page will be implemented using sqlite as a database that both stores the login information of the person as well as the times logged in. This provides extra security, and accountability. The rest of the UI is locked behind the login system and communicates with single session static variable store, despite the individual pages being discrete. Upon completion of the form the session is sent to the messaging system which acts as the bridge between the program and the exterior services. The data will be parsed, and split up according to need. This also presents a good place to check the validity of the data.

The programming language chosen is C#. This is mostly due to its decent documentation when paired with Visual Studios UI tools. This presents us with an easy way to build the UI without unnecessary hassle. C# also presents the group with a language familiar enough that learning curve shouldn’t be an issue for members of the project. 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and running purposes.

### Prerequisites

- ##### Windows

Since this project is built using the Windows Form library, you need to have a Windows enviornment to run it.

- ##### GitKraken or SourceTree or Any git client

Visit https://www.gitkraken.com/ and follow the instructions for installion on your particular platform. 

- ##### Visual Studio

Visit https://www.visualstudio.com/ and follow the instructions for installion. 

```
During installation make sure to select the packages indicated below, along with any others you would like 
```
![vs_install](https://i.imgur.com/ZxeJU6D.png)

### Installing

[Download a copy of DisasterAwarness](https://github.com/teamhyena/DisasterAwareness/archive/master.zip), or clone the [repository](https://github.com/teamhyena/teamhyena/) using the git client of your choice.

- Launch Visual Studio

- Go to File -> Open -> Project/Solution

- Navigate to the DisasterAwareness directory 

- Open Disaster Awareness Program.sln

- Click Start to run the program

## Built With

* [Visual Studio](https://www.visualstudio.com/) - The IDE
* [Windows Form](https://docs.microsoft.com/en-us/dotnet/framework/winforms/) - A Form Framework
* [GitKraken](https://www.gitkraken.com/) - Git Gui Client


## Versioning

We use .git for versioning along with GitHub. 

## Team Hyena

* **Jory Leech** 
* **Adi Kumar**
* **Nour Lababidi**

