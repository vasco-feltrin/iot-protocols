namespace NetCoreClient.Sensors;

interface ISensor
{
    string ToJson();
    string EndPoint { get;  }
}