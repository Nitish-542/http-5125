# Back-End-Web-Development-1---HTTP-5125-RNA

# Repository Name

This repository contains [**Back-End-Web-Development-1---HTTP-5125**](https://github.com/Nitish-542/http-5125).

In this course, I learned server-side web development using **C#**. I explored how to create data-driven websites and gained hands-on experience in pulling data from various external sources. My skills in building robust web applications with **ASP.NET** have been further developed, enhancing my ability to create dynamic and interactive websites.

### 📚 Assignments

#### Assignment 1

##### 🔗 Project Files
You can view the project files for Assignment 0 [here](https://github.com/Nitish-542/http-5125/tree/main/Assignment01).

##### 💻 Code Sample
Here's a quick code sample demonstrating how to use the main feature of the project:
```csharp
// Sample code for Assignment 1
﻿using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : Controller
    {
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return ("Welcome to 5125!");
        }

       
        [HttpGet(template: "example")]
        public string example()
        {
            return ("This is Nitish Sharma.");
        }
    }
}
```

### ⚠️ Warning
Please ensure you have all necessary dependencies installed before running the project. Refer to the installation instructions in the repository.

### ℹ️ Note
This project is open-source and welcomes contributions! Feel free to fork the repository and submit pull requests.
