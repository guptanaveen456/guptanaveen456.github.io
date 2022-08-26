﻿---
title: "Setting Up a New Model from Template"
url: /modularmom/before-you-start/quick-start-to-developing-with-opcenter-modular-manufactring/how-to-create-a-configurable-object/preparing-metadataruntime-platform/
weight: 5
---
<!-- 1. [Modular MOM](c:\users\anil.birajdar\desktop\temp\index.html)
1. [Before You Start](c:\users\anil.birajdar\desktop\temp\Before-You-Start_127740192.html)
1. [Quick Start to Developing with Opcenter Modular Manufacturing](c:\users\anil.birajdar\desktop\temp\Quick-Start-to-Developing-with-Opcenter-Modular-Manufacturing_134455239.html)
1. [How to Create a Configurable Object](c:\users\anil.birajdar\desktop\temp\How-to-Create-a-Configurable-Object_125339498.html)
# **Modular MOM : Setting Up a New Model from Template**  -->
Created by Unknown User (sergey.postoyalko), last modified by Aghazarian, Nick on Nov 08, 2021 

Modular MOM provides the **M1\_Template** and **M1\_Template.Tests** repos as a tool used to create a starting point for a new model. Its usage is described below.
## **Procedure**
1. Prepare repositories for your new model
   1. Contact the Configuration Manager to create two repositories for your model with the names
      1. __M1*\_<*__*your model name__>__*
      1. __M1*\_<*__*your model name__>.__*__Tests__
         Note that a short name without spaces for the model facilitates the management. 
   1. The repos can be at [https://tfs05mom.industrysoftware.automation.siemens.com/MOM/ModularMOM/_git/](https://tfs05mom.industrysoftware.automation.siemens.com/MOM/ModularMOM/_git/WS_M1_Template.Tests) or on a different server (e.g. gitlab).
1. Ensure you have cloned the **M1\_Template** and **M1\_Template.Tests** repos.
1. Open PowerShell window as administrator.
1. Go to the folder <*path of your folder for source code*>\**M1\_Template** and execute the following command where <*your model name*> is the name of the model created above. 

.\Copy-From-Template.ps1 <your model name>

1. If your repos are stored in the same server as the M1\_Template, you can accept the default for the model repo by pressing Enter when you see this message:
   ![](Setting-Up-a-New-Model-from-Template\_127733030.002.png)
1. If your repos were created on a different server, enter the URL for that server at the prompt.
1. Open Visual Studio
1. Build the solution **M1\_<***your model name***>.sln** located in <*path of your folder for source code*>\**M1\_**<*your model name*>.
## **Next Step**
[Create a Configurable Object](https://momwiki02.industrysoftware.automation.siemens.com/display/RevMOM/Creating+a+New+CO)
## **Attachments:**
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [Press Enter.png](c:\users\anil.birajdar\desktop\temp\attachments\127733030\127739722.png) (image/png) 
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [SettingNewModel_PressEnter.png](c:\users\anil.birajdar\desktop\temp\attachments\127733030\127741262.png) (image/png) 
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [SettingNewModel_PressEnter.png](c:\users\anil.birajdar\desktop\temp\attachments\127733030\127741261.png) (image/png) 
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [ReplacingExistingModel_PressEnter.png](c:\users\anil.birajdar\desktop\temp\attachments\127733030\127741263.png) (image/png) 
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [ReplacingExistingModel_Error.png](c:\users\anil.birajdar\desktop\temp\attachments\127733030\127741269.png) (image/png) 
![](Setting-Up-a-New-Model-from-Template\_127733030.003.png) [Replacing Existing Model with New Model.docx](c:\users\anil.birajdar\desktop\temp\attachments\127733030\134458703.docx) (application/vnd.openxmlformats-officedocument.wordprocessingml.document) 

Document generated by Confluence on Jul 28, 2022 11:21

[Atlassian](https://www.atlassian.com/)
**Created with an evaluation copy of Aspose.Words. To discover the full versions of our APIs please visit: https://products.aspose.com/words/**