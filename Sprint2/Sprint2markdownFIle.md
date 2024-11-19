# Sprint x Report 
Video Link: 
## What's New (User Facing)
 * more functionality for messaging
 * Multiple instance setup
 * Search for user by Name
 * Match Similarity Ranking
 

## Work Summary (Developer Facing)
This week, progress was made on enhancing the functionality of the Roommate App. Key updates include the addition of messaging capabilities to improve user communication. A multiple instance setup was implemented, allowing two users to work on the app simultaneously. A search feature was introduced to enable users to search for individuals by name within the database. Additionally, a match similarity ranking system was developed to rank users based on preference similarity scores, providing better insights for roommate compatibility. These features collectively improve user experience and application functionality.

## Unfinished Work
The dashboard still needs to be developed. While it was moved from Sprint 1 due to time constraints and the need to implement the other features first, Now that we have some more features and functinality on the roommate app we will be able to focus on the dashboard more. It will be a key priority in Sprint 3

In addition to the dashboard, the settings tab also needs to be implemented, it will enhance user customization within the app. Messaging functionality, was introduced in Sprint 1, but will require further development to offer a more robust and user-friendly communication system. Finally, the matching tab, which displays users ranked by similarity scores, needs refinement and polishing to improve clarity, accuracy, and user experience.

## Completed Issues/User Stories
Here are links to the issues that we completed in this sprint:

 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/31
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/28
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/35
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/17
 * https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/29

## Incomplete Issues/User Stories
Here are links to issues we worked on but did not complete in this sprint:
* https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/issues/9 <<We made other issues the priority, we will complete this in sprint 3>>

## Code Files for Review
Please review the following code files, which were actively developed during this sprint, for quality:
 * [Form1.Designer.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Form1.Designer.cs)
 * [Form1.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Form1.cs)
 * [Program.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/Program.cs)
 * [messageDash.Designer.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/messageDash.Designer.cs)
 * [messageDash.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/RoomMate_WinFormsApp/messageDash.cs)
 * [RoommateApp.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/Preferences/RoommateApp.cs)
 * [SQLiteDataAccess.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/Preferences/SQLiteDataAccess.cs)
 * [UserInfo.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/Preferences/UserInfo.cs)
 * [UserInfoWithInt.cs](https://github.com/danielocalle/CptS322-GroupProject-RoommateApp/blob/main/RoomMate%20Application/Preferences/UserInfoWithInt.cs)


 
## Retrospective Summary
Here's what went well:
  * UI development
  * Minor database planning
  * Communication
  * GitHub incorporation (commit, pull request, etc)
  * Meetings 
 
Here's what we'd like to improve:
   * Each feature's UI
   * Code cleanliness and organization
   * Code comments
   * Planning
  
Here are changes we plan to implement in the next sprint:
   * More tools on toolbar for messaging page
   * Smooth transitions between dashboard and features without using one crowded form
   * Nicer UIs
   * Code organization
