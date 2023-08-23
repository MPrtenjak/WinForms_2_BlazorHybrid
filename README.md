# WinForms_2_BlazorHybrid

Welcome to the WinForms_2_BlazorHybrid GitHub repository!

This repository serves as a comprehensive guide for upgrading a legacy C# WinForms application with Blazor Hybrid. Throughout the process, we will walk you through each step of the upgrade and provide detailed documentation for easy reference.

Throughout this tutorial we will enhance your application **from this form:**

![Old windows Form](https://github.com/MPrtenjak/WinForms_2_BlazorHybrid/wiki/images/old-form.png)

**To this:**

![New Blazor Form](https://github.com/MPrtenjak/WinForms_2_BlazorHybrid/wiki/images/new-form.png)

## Important Note:

Before proceeding, it is crucial to understand the following points:

- To ensure clarity and simplicity, we have chosen a minimal application as an example instead of a large code repository.
- Each step of the upgrading process will be documented as a separate commit in Git, allowing you to easily follow along and observe the changes.
- Accompanying each commit, an executable file will be provided for your convenience, enabling you to visualize the upgrading process without the need to build the program.

## Upgrading Process:

When upgrading a significant WinForms application, it is essential to minimize risks and avoid making drastic changes that could break existing functionality. Our approach focuses on introducing minimal modifications while achieving the desired upgrade.

## Selecting the Initial Project:

To demonstrate the upgrading process, we have randomly selected a project from the internet. The chosen project exhibits the typical characteristics of a legacy application, including disorganization and the absence of best practices.

Please note that the selected application is relatively small and written by a single developer. However, for the purpose of this demonstration, we will consider it as a larger, poorly written application to simulate the challenges faced in real-world scenarios.

## Selected Application:

For this demonstration, we obtained the application from the webpage [sourcecodester.com](https://www.sourcecodester.com/tutorials/c/12232/c-simple-crud-application-sqlite.html). The source code is available for download in a zip file.

**It is important to note that we have no intention to insult or criticize the original developer. The application was chosen randomly based on meeting the described conditions.**

Please keep in mind that this repository aims to provide insights into the upgrading process and should not be considered a comprehensive solution for every legacy application scenario.

## How to Use This Repository

To make the most of this repository, follow the steps below:

1. Clone the repository to your development computer using the following command:

   ```
   git clone <repository-url>
   ```

2. Once the repository is cloned, navigate to the project directory using the command:

   ```
   cd WinForms_2_BlazorHybrid
   ```

3. You can explore the code at each step by switching to the corresponding branch. The branch names follow the format `STEP1` to `STEP14`, representing each step of the upgrading process. Use the following command to switch to a specific branch:

   ```
   git checkout <branch-name>
   ```

4. Along with each commit, there is an extensive Wiki page that provides detailed documentation for each step. To access the Wiki pages, start from the [first step](../../wiki/STEP-1-Unzipping-the-initial-project) and follow the table of contents.

By following these steps and referring to the associated Wiki pages, you can easily understand and navigate through the upgrading process of the legacy WinForms application to a Blazor Hybrid application.

## Steps:

To navigate through the upgrading process, please refer to the table of contents on the right or [proceed to Step 1: Unzipping the Initial Project](../../wiki/STEP-1-Unzipping-the-initial-project). 

Each step is thoroughly documented, allowing you to follow the upgrade process easily and understand the changes made at each stage.

We hope this repository proves to be a valuable resource for upgrading your legacy WinForms application with Blazor Hybrid.

[Proceed to Step 1: Unzipping the Initial Project](../../wiki/STEP-1-Unzipping-the-initial-project). 
