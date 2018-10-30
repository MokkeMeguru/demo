using UnityEngine;
using System.Collections;

/// <summary>
/// This class parse weather-data from WeatherAPISpout
/// and connect all AgentState
/// for the function: Agent.UpdateState
/// ex. temparature  - {a t_i + (1 - a) t^var} / 10 
///     -> [1, 0] -> hot? cold? normal?
/// </summary>
public class WABolt : AbstractBolt
{

}
