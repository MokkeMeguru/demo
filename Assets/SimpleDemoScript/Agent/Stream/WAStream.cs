#pragma warning disable IDE0044 // 読み取り専用修飾子を追加する

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// It is Streaming data about Weather Information
/// </summary>
public class WAStream : AbstractStream {
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
