using UnityEngine;
using System.Collections;
using UniRx;

/// <summary>
/// This class get Weather-Information from VF Server
/// IF VF Server did not have the information,
/// VF server will access OpenWeatherAPI to get information.
/// IF it have that, VF Server will return the stored information.
/// 
/// <seealso cref="AbstractSpout"> Abstract Class </seealso> will show us 
/// some usefull information of these "Spout" classes.
/// </summary>
public class WeatherAPISpout : AbstractSpout
{
    /// <summary>
    /// get information from VF Server via VFAPISockets
    /// sketch:
    /// 1. call request
    /// 2. send message to VFAPISocket as VFAPIRequest class object
    /// 3. get information as json as WeatherInfo class object
    /// </summary>
    void RequestWeatherInformation() {

    }
}
