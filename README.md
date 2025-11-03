# 🎉 EventEase — Blazor WebAssembly Event Management App

---

## 🧭 Overview
**EventEase** is a modern **Blazor WebAssembly single-page application (SPA)** designed to streamline event management.  
It allows users to:
- Browse events with dynamic details (name, date, location)
- Register for events using validated forms
- Track attendance across sessions  
- Experience smooth navigation and responsive interactivity — all running **directly in the browser** using **C#** and **.NET** (no JavaScript required).

This project was developed as part of a **three-activity series** demonstrating foundational component creation, debugging & optimization, and advanced feature integration using **Microsoft Copilot**.

---

## ⚙️ Features

### 🧩 Core Features
- **Event Card Component** — Displays event name, date, and location with two-way data binding  
- **Routing System** — Seamless navigation between Home, Details, Registration, and Attendance pages  
- **Input Validation** — Ensures proper data entry and prevents invalid submissions  
- **Performance Optimization** — Uses `<Virtualize>` for large datasets to improve load speed  
- **Custom 404 Page** — Handles invalid routes gracefully  

### 🚀 Advanced Features
- **Registration Form with Validation** — Data annotations ensure clean user input  
- **Session State Management** — Persists user session data using a scoped service  
- **Attendance Tracker** — Displays list of registered participants per event  
- **AI-Assisted Development** — Built efficiently using **Microsoft Copilot** suggestions for structure, syntax, and performance tuning  

---

## 🧠 How Microsoft Copilot Helped

Microsoft Copilot was instrumental throughout the project lifecycle by:
- Generating **boilerplate component code** and **data models** in Blazor  
- Suggesting **two-way data binding** syntax and form validation logic  
- Assisting with **debugging routing errors** and optimizing virtualized lists  
- Automating repetitive code (service setup, form structure, layout design)  
- Offering context-based fixes for **performance bottlenecks**  

> _Result: Faster development, cleaner syntax, and improved maintainability._

---

## 🧰 Tech Stack

| Category | Technology |
|-----------|-------------|
| **Frontend Framework** | Blazor WebAssembly (.NET 8) |
| **Language** | C# / Razor |
| **State Management** | Custom Scoped Service (Dependency Injection) |
| **Styling** | CSS3 (Custom Minimal Theme) |
| **AI Assistance** | Microsoft Copilot |
| **Version Control** | Git & GitHub |

---

## 📊 Performance Optimizations
- Implemented lazy loading via <Virtualize> for large event lists.
- Minimized re-rendering by limiting StateHasChanged() calls.
- Added input validation and conditional rendering for efficient updates.
- Reduced routing errors with a NotFound page for invalid paths.

---

## 🔒 Validation & Error Handling
- Ensures required fields (name, email) are filled before submission.
- Uses Blazor’s built-in DataAnnotationsValidator for clean validation messages.
- Gracefully handles invalid URLs and displays a user-friendly 404 page.

---

## 📦 Future Enhancements
- Integration with backend APIs for real event data.
- User authentication and role-based access control.
- Offline support using Blazor PWA capabilities.
- Advanced analytics and event filtering.

---

## 📜 **License**
This project is for educational purposes under Coursera Microsoft Full Stack Developer assignment. You may modify and use this project for learning, but proper credit to the author is appreciated.
