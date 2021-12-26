namespace BlazorWebAssemblyServiceLifetimeDemo.Client.Services;

public static class IdHelper
{
    private static int currentId;

    public static int  GetNextId()
    {
        currentId++;
        return currentId;
    }
}