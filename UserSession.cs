namespace LONTAR
{
    public static class UserSession
    {
        public static string IdAdminLogin { get; set; }
        public static bool IsLoggedIn => !string.IsNullOrEmpty(IdAdminLogin);
    }
}
