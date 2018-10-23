#pragma warning disable IDE0044 // 読み取り専用修飾子を追加する

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class AbstractAgentState {
    private Dictionary<string, AbstracetAgentStateElement> aASEdict 
        = new Dictionary<string, AbstracetAgentStateElement>();


    private string aSName;

    public void UpdataParameter(string operation, string name, float value)
    {
        if (operation == "add")
            aASEdict.Where(x => x.Key == name).FirstOrDefault().Value.AddParameter(value);
        else if (operation == "sub")
            aASEdict.Where(x => x.Key == name).FirstOrDefault().Value.SubParameter(value);
        else if (operation == "mul")
            aASEdict.Where(x => x.Key == name).FirstOrDefault().Value.MultiParameter(value);
    }

    public float GetASEValue(string name)
    {
        return  aASEdict[name].GetParameter();
    }

    public float MaxAttention()
    {
        return aASEdict
            .Aggregate(
            (left, right) => left.Value.GetParameter() > right.Value.GetParameter() ? left : right)
            .Value.GetParameter();
    }

    public float SumAttention(float value)
    {
        return aASEdict.Sum(x => Math.Abs(x.Value.GetParameter()));
    }

    public string MaxAttentionName()
    {
        return aASEdict
            .Select((val) => new { V = val})
            .Aggregate(
            (max, working) => (Math.Abs(max.V.Value.GetParameter()) > Math.Abs(working.V.Value.GetParameter())) ? max : working)
            .V.Key;
    }

    public string getSentence(string aASEName)
    {
        var aASE = aASEdict[aASEName];
        return aASE.GetParameter() > 0 ? aASE.GetPosSentence() : aASE.GetNegSentence();
    }

    public string GetName()
    {
        return aSName;
    }


    public override string ToString()
    {
        return this.aSName 
            + String.Join("\n",  aASEdict.Select(x => x.Value.ToString()).ToArray());
    }
}
