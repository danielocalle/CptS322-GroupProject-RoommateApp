using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace RoommateAppLibrary
{
    public class RoommateRequest
    {
        public int RequestId { get; set; }
        public string SenderUsername { get; set; }
        public string ReceiverUsername { get; set; }
        public string Status { get; set; } // "Pending", "Accepted", or "Rejected"
    }
    
    public static class RoommateService
    {
        // Method to send a roommate request
        public static bool SendRequest(string senderUsername, string receiverUsername)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                // Check if the request already exists
                var existingRequest = cnn.QueryFirstOrDefault<RoommateRequest>(
                    "SELECT * FROM RoommateRequests WHERE SenderUsername = @Sender AND ReceiverUsername = @Receiver AND Status = 'Pending'",
                    new { Sender = senderUsername, Receiver = receiverUsername });

                if (existingRequest != null)
                {
                    return false; // Request already exists
                }

                // Insert the new request
                cnn.Execute(
                    "INSERT INTO RoommateRequests (SenderUsername, ReceiverUsername, Status) VALUES (@Sender, @Receiver, 'Pending')",
                    new { Sender = senderUsername, Receiver = receiverUsername });

                return true;
            }
        }

        // Method to view received roommate requests
        public static List<RoommateRequest> ViewRequests(string receiverUsername)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                return cnn.Query<RoommateRequest>(
                    "SELECT * FROM RoommateRequests WHERE ReceiverUsername = @Receiver AND Status = 'Pending'",
                    new { Receiver = receiverUsername }).AsList();
            }
        }

        // Method to accept a roommate request
        public static bool AcceptRequest(int requestId)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                // Get the request details
                var request = cnn.QueryFirstOrDefault<RoommateRequest>(
                    "SELECT * FROM RoommateRequests WHERE RequestId = @Id AND Status = 'Pending'",
                    new { Id = requestId });

                if (request == null)
                {
                    return false; // Request not found or already handled
                }

                // Update the request status to Accepted
                cnn.Execute(
                    "UPDATE RoommateRequests SET Status = 'Accepted' WHERE RequestId = @Id",
                    new { Id = requestId });

                // Establish connection in the UserRoommates table
                cnn.Execute(
                    "INSERT INTO UserRoommates (User1, User2) VALUES (@User1, @User2)",
                    new { User1 = request.SenderUsername, User2 = request.ReceiverUsername });

                return true;
            }
        }

        // Method to view accepted roommates
        public static List<string> ViewAcceptedRoommates(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                var roommates = cnn.Query<string>(
                    "SELECT CASE WHEN User1 = @Username THEN User2 ELSE User1 END AS Roommate " +
                    "FROM UserRoommates WHERE User1 = @Username OR User2 = @Username",
                    new { Username = username }).AsList();

                return roommates;
            }
        }
    }
}
