# Sprint x Report 
Video Link: https://youtu.be/m3ARQ2yJ0qw
## What's New (User Facing)
 * Dashboard UI effects
 * Partial dashboard UI
 * Partial messaging page UI
 * Sample messaging page UI effects
 * Login page error handling
 * Login page UI
 * Profile page questionnaire
 * Profile page UI
 * Transitions between features
 * Simultaneous form access for dashboard and messaging page

## Work Summary (Developer Facing)
We accomplished basic UIs for each feature (dashboard, login, profile, and messaging), along with some minor functionalities. The dashboard established a theme for the entire application, so the login and messaging pages follow a similar layout and color scheme. The first goal for each feature was to establish a somewhat aesthetic UI, which was accomplished. The main colors decided for the dashboard were dark blue and white. Upon completion of the dashboard's appearance, its basic UI effects were implemented. When the user hovers over clickable sections, they highlight, as is the case with most modern applications. Furthermore, each feature presented different goals, so one feature may seem more detailed than another. However, this is due to code and layout experimenting and focus on specific elements. For example, some time was taken from the messaging page UI to experiment with form transitioning. A possibility was to layer UIs in one C# form. However, we wanted to see if separating features in different forms, yet accessing them properly, was possible. Fortunately, it turns out we aren't restricted to a single form. In addition, minor functionalities such as incorrect password handling and account creation were implemented for the login feature following its basic appearance. The profile page acquired an elegant questionnaire following its fundamental appearance completion. Sprint 1 was successfully completed with no leftover goals. However, this is just the beginning and major improvements are on the horizon. Such improvements include UI aesthetics, better database incorporation, code organization, and more event handling. To summarize, we learned an abundance of information about Windows app creation using Visual Studio and C#, team planning, GitHub coordination, UI techniques, design, and events.

## Unfinished Work
The dashboard is currently unfinished due to complexity and time overestimation. Too many goals may have been attributed to the dashboard, but they have been moved to Sprint 2. The team leader is working on the dashboard, which is complex and the central part of the application, while balancing other project planning and requirements. Therefore, unfinished dashboard work is very valid for Sprint 1. Goals for other features may have been lighter or more experimental, which is a possible reason behind their earlier completion. By completion, we are referring to met criteria for Sprint 1, not actual completion for the final product.

## Completed Issues/User Stories
Here are links to the issues that we completed in this sprint:

 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/24
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/17
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/14
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/13
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/10
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/8
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/5
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/4
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/3
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/2
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/1

## Incomplete Issues/User Stories
Here are links to issues we worked on but did not complete in this sprint:
* https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/9 <<We overestimated our time and too many goals were assigned to dashboard>>

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:
 * [Form1.Designer.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Form1.Designer.cs)
 * [Form1.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Form1.cs)
 * [Program.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Program.cs)
 * [login.Designer.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/login.Designer.cs)
 * [login.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/login.cs)
 * [messageDash.Designer.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/messageDash.Designer.cs)
 * [messageDash.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/messageDash.cs)
 
## Retrospective Summary
Here's what went well:
  * UI samples
  * Minor database planning
  * Communication
  * Coordination
  * Timeliness
  * Planning
  * GitHub incorporation
  * Meetings 
 
Here's what we'd like to improve:
   * Each feature's UI
   * Database configurations
   * Code cleanliness and organization
   * Code comments
  
Here are changes we plan to implement in the next sprint:
   * More tools on toolbar for messaging page
   * Smooth transitions between dashboard and features without using one crowded form
   * Nicer UIs
   * Code organization
