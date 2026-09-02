

# Municipal Services Reporting Application

---

## 1. Overview

This is a Windows Forms application that allows citizens to report issues and service requests to their local municipality. The application is built in C# using .NET Framework and is designed to be simple and user-friendly.

The application is part of a larger project that will eventually include local events and service request tracking. For now, only the "Report Issues" feature is active.

---

## 2. Features

- Clean main menu with three options (only Report Issues works)
- A form where users can enter details about their issue
- Progress bar that shows how much of the form is filled in
- Random encouraging messages to keep users motivated
- Ability to attach files (up to 5) to a report
- Input validation to make sure all required fields are filled
- Success message with a reference number when a report is submitted

---

## 3. System Requirements

Before you can run the application, make sure your computer meets these requirements:

| Requirement | Details |
|-------------|---------|
| Operating System | Windows 7 or later |
| .NET Framework | Version 4.7.2 or higher |
| RAM | Minimum 2GB |
| Storage | At least 50MB free space |

If you're not sure which version of .NET Framework you have, go to Control Panel > Programs and Features and look for "Microsoft .NET Framework" in the list.

---

## 4. How to Compile the Application

### If you have Visual Studio:

1. Open the solution file by double-clicking `MunicipalServicesApp.sln`
2. Once the project loads, go to **Build** > **Build Solution** (or press Ctrl+Shift+B)
3. Wait for the build to complete. You should see "Build succeeded" at the bottom.

### If you are using the command line:

Open Command Prompt and navigate to the project folder, then run:

```
msbuild MunicipalServicesApp.sln
```

---

## 5. How to Run the Application

### Option 1: From Visual Studio

After building the project, press **F5** or click the green **Start** button.

### Option 2: From File Explorer

1. Navigate to the output folder:
   - If you built in Debug mode: `bin\Debug\`
   - If you built in Release mode: `bin\Release\`
2. Double-click `MunicipalServicesApp.exe`

---

## 6. How to Use the Application

### Step 1: Start the Application

Double-click the `MunicipalServicesApp.exe` file. The main menu will appear.

### Step 2: Click "Report Issues"

You will see three buttons on the main menu:
- **Report Issues** (this one works)
- **Local Events and Announcements** (greyed out - coming in Part 2)
- **Service Request Status** (greyed out - coming in Part 3)

Click the **Report Issues** button to open the reporting form.

### Step 3: Fill in the Form

The form asks for the following information:

| Field | Required? | What to Enter |
|-------|-----------|---------------|
| Name | Yes | Your first name |
| Surname | Yes | Your last name |
| Gender | Yes | Select from the dropdown list |
| Location | Yes | Where the issue is (e.g., "Corner of Main and Church Street") |
| Category | Yes | Select from: Sanitation, Roads, Utilities, Public Safety, Other |
| Description | Yes | A detailed description of what happened |
| Attachments | No | Click "Attach File" to add images or documents (max 5) |

### Step 4: Watch Your Progress

As you fill in the form, look at the progress bar at the bottom. It will move forward as you complete each section. You'll also see encouraging messages that change randomly, like:

- "Thank you for helping improve our community!"
- "Your report makes a difference!"
- "Together we can make our municipality better!"

### Step 5: Submit Your Report

Once all required fields are filled, click the **Submit Report** button. You'll get a confirmation message with a reference number. The form will then clear automatically.

### Step 6: Go Back

Click the **Back** button to return to the main menu. You can also close the form by clicking the X in the top-right corner.

---

## 7. What the Progress Bar Shows

The progress bar tracks how much of the form you've completed:

| Section | Percentage |
|---------|------------|
| Name | 15% |
| Surname | 15% |
| Gender | 15% |
| Location | 20% |
| Category | 20% |
| Description | 15% |
| **Total** | **100%** |

---

## 8. Common Problems and Solutions

### Problem: Application won't start

**Solution:** Make sure .NET Framework 4.7.2 is installed on your computer. You can download it from Microsoft's website.

### Problem: "Mark of the Web" error when compiling

**Solution:** Right-click the `.resx` files in the project folder, go to Properties, and click the "Unblock" button. Then rebuild the project.

### Problem: Can't attach files

**Solution:** Make sure the files you're trying to attach aren't open in another program. Also, keep file sizes reasonable (under 10MB is recommended).

### Problem: Submit button doesn't work

**Solution:** Make sure all required fields are filled. If any field is empty, a message will appear telling you what's missing.

### Problem: Progress bar isn't updating

**Solution:** Make sure you're typing in the fields and selecting options from the dropdowns. The progress bar updates in real-time as you complete each section.

---

## 9. Technical Information

| Aspect | Details |
|--------|---------|
| Programming Language | C# |
| Framework | .NET Framework 4.7.2 |
| User Interface | Windows Forms |
| Data Storage | List<ReportedIssue> (in-memory) |
| File Handling | OpenFileDialog, System.IO |
| Event Handling | Click, TextChanged, SelectedIndexChanged |

### Data Structure Used

The application stores reported issues in a `List<ReportedIssue>` object. Each issue has these properties:

- Name (string)
- Surname (string)
- Gender (string)
- Location (string)
- Category (string)
- Description (string)
- Attachments (List<string>)
- ReportDate (DateTime)
- Status (string)

---

## 10. What's Coming in Parts 2 and 3

**Part 2 (Local Events and Announcements):**
- Display events in an organised way
- Search for events by category and date
- Use advanced data structures like stacks, queues, and dictionaries
- Show recommended events based on what users search for

**Part 3 (Service Request Status):**
- Track the progress of reported issues
- Use unique reference numbers to find requests
- Use trees, heaps, and graphs to organise data
- Show the status of each request (Pending, In Progress, Resolved)

---

## 11. Contact

If you need help or have questions:

| Contact Method | Details |
|----------------|---------|
| Email | it-support@municipality.gov.za |
| Phone | 0800-MUNI-HELP (0800 686 4435) |

---

## 12. Version Information

| Item | Details |
|------|---------|
| Version | 1.0 |
| Release Date | 2026 |
| Module | PROG7312 / AAPD7112 |
| Student Name | Kone Moshapho |
| Student Number | ST10365593 |

---

## 13. License

This application was developed as part of an academic project for the IIE. All rights reserved.

---

*End of README File*
