using UnityEngine;
using System.Collections;

/// <summary>
/// It is Streaming data about VF's body Information
/// </summary>
public class BStreeam : AbstractStream
{
    private static readonly AbstractSpout weatherSpout = new BodySpout();

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
