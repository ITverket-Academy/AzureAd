namespace AzureAD.Example;

public class UserInfo
{
    public bool IsAuthenticated { get; set; }

    public Dictionary<string, string> Claims { get; set; }
}