# Tiago Neves
# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged as follows:

* `sandbox` - An empty project that you can use to play around with any concepts you like.
* `csharp-prep` - Starter projects for each of the C# Prep assignments.
* `prepare` - Starter projects for each of the preparation Learning Activities.
* `prove` - Starter projects for each of the prove Developer projects.
* `foundation` - Starter projects for foundation projects.

## TIPS - Terms and Definitions
# C#
- The standard in C# is to use TitleCase for class and method names, and to use _underscoreCamelCase for our member variable names (the underscore to private variables)
- Class is just a template for something. It only becomes useful when an instance is created and assigned to a variable in your program. An instance is the realization of attributes and methods in the computer's memory

- Class - A new custom data type that defines attributes (member variables) and methods. This is like a blueprint to create instances or objects of that class. Example: A Person has given name and family name.

- Instance - A variable whose data type is the class. We often use the term Object interchangeably. Example: We can have two instances of the Person class: one for John, and one for Mary.

- Instantiate - A verb that means "to create an instance of." Example: We can instantiate the Person class to create a new object.

- Method - A member function. Methods are called using "dot notation" with an instance of the class before the dot. Example: person1.GetEasternName()


## Questions
# Explain the meaning of Version Control
- Version control is way to manage files saving his state as a history telling, working this way, provides the possibility to track changes on files.
# Highlight a benefit of Version Control
- One benefit of using Version Control is the possibility of changing back to a previus version of a project being able to rolling back to a version of a software in case of it is causing a break down of the application due to some change in the code.
# Provide an application of Version Control. This means, provide an example of how Version Control could be used.
- You have a lot of database SQL procedures and scripts that should be executed on a creation of a new application, also you need to increment and change the application database with tables, procedures, triggers. Instead of saving it to a simple folder you use some application of Version Control to help you manage it.
# Show a command used in Version Control (for example a Git command)
- git status
# Thoroughly explain these concepts (this likely cannot be done in less than 100 words)
- Git status is used to represent the status of the files, and folders in a branch. This command can show you what files are currently being tracked in the actual repository, it shows which files have been staged (represented by green color), changed, or deleted, and also shows files that are not tracked (represented by red color),  or folders that are not tracked if you don't add these files that are untracked to your repository when you commit and push the files to the server, the untracked files will not go up to the Version Control Server. Otherwise, files and folders tracked gonna be sent to the server.

