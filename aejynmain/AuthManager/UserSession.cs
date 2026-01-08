using System;

namespace aejynmain.AuthManager
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        
        public static bool IsAdmin => string.Equals(Role, "admin", StringComparison.OrdinalIgnoreCase);
    public static bool IsRentalAgent => string.Equals(Role, "rental agent", StringComparison.OrdinalIgnoreCase);
        
        public static void SetSession(int userId, string username, string role)
        {
            UserID = userId;
            Username = username;
            Role = role;
        }
        
        public static void ClearSession()
        {
            UserID = 0;
            Username = string.Empty;
            Role = string.Empty;
        }
    }
}
