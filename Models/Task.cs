// PSEUDOCODE PLAN:
// 1. The Razor view references `Mission08_Team0211.Models.Task`. Ensure such a class exists.
// 2. Create a minimal `Task` model in the `Mission08_Team0211.Models` namespace.
// 3. Add the properties the view expects:
//      - int TaskId
//      - string Task         (view uses `t.Task`)
//      - DateTime? DueDate   (view uses `DueDate?.ToShortDateString()` so nullable)
//      - bool Completed
//      - int Quadrant
// 4. Keep the class minimal so it compiles. If your real model uses a different name or namespace,
//    either adjust the Razor `@model` line to the correct type or rename/move the model to match.
// 5. After adding this file, rebuild the project to verify the CS0234 error is resolved.
//
// If you already have a different model type (e.g. `TodoItem`, `TaskItem`, etc.), do NOT add this file.
// Instead update `Views/Home/Quadrants.cshtml` to use the correct fully-qualified type.

using System;

namespace Mission08_Team0211.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        // Matches the view which uses `t.Task` for the task description
        public string Task { get; set; } = string.Empty;

        // Nullable because the view uses the null-conditional operator
        public DateTime? DueDate { get; set; }

        public bool Completed { get; set; }

        public int Quadrant { get; set; }
    }
}