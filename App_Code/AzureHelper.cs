using System;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

/// <summary>
/// Summary description for AzureHelper
/// </summary>
public static class AzureHelper
{
    private readonly static CloudStorageAccount account = CloudStorageAccount.Parse(
            CloudConfigurationManager.GetSetting("StorageConnectionString"));

    public static CloudStorageAccount Account
    {
        get { return account; }
    }

    public static CloudTableClient TableClient
    {
        get { return account.CreateCloudTableClient(); }
    }
}