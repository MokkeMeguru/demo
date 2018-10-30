using UnityEngine;
using System.Collections;

/// <summary>
/// It is Streaming data about User Information
/// </summary>
public class UStream : AbstractStream
{
    private readonly static AbstractSpout weatherSpout = new UserSpout();

    /// <summary>
    /// the information got via RequestWeatherInformation will send WABolt
    /// WABolt will sends message to some AgentState classes
    /// </summary>
    void SendToBolt()
    {
    }

    /// <summary>
    /// run corutine which get weather information by 30 minutes
    /// </summary>
    // Use this for initialization
    void Start()
    {

    }
}
