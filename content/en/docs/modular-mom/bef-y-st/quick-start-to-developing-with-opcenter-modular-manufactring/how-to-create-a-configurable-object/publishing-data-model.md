---
title: "Publishing Data Model"
weight: 12
---
<!-- 1. [Modular MOM](c:\users\anil.birajdar\desktop\temp\index.html)
1. [Before You Start](c:\users\anil.birajdar\desktop\temp\Before-You-Start_127740192.html)
1. [Quick Start to Developing with Opcenter Modular Manufacturing](c:\users\anil.birajdar\desktop\temp\Quick-Start-to-Developing-with-Opcenter-Modular-Manufacturing_134455239.html)
1. [How to Create a Configurable Object](c:\users\anil.birajdar\desktop\temp\How-to-Create-a-Configurable-Object_125339498.html)
# **Modular MOM : Publishing Data Model**  -->
Created by Unknown User (sergey.postoyalko), last modified by Alvarez Villanueva, Beatriz on Nov 09, 2021 

Follow this procedure to publish the data model.
## **Procedure**
1. Open PowerShell as administrator.
1. Run this command:

dotnet publish <path of your folder for source code>\M1\_<your model name>\M1\_<your model name>.sln -f net5.0 -c Debug -o <path of your folder for source code>\MetadataRuntime\Platform\GeneratedModel\_<your model name>\bin
## **Next Step**
[Configure Platform API](c:\users\anil.birajdar\desktop\temp\Configuring-Platform-API_127739834.html)

Document generated by Confluence on Jul 28, 2022 11:21

[Atlassian](https://www.atlassian.com/)
**Created with an evaluation copy of Aspose.Words. To discover the full versions of our APIs please visit: https://products.aspose.com/words/**
