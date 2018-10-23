#pragma warning disable IDE0044 // 読み取り専用修飾子を追加する

using System;
using System.Collections;
using System.Collections.Generic;

public class AbstracetAgentStateElement {
    private string aSEName = "";
    private float parameter = 0.0f;
    private List<string> posSentences = new List<string>();
    private string unknownPosSentence = "";
    private List<string> negSentences = new List<string>();
    private string unknownNegSentence = "";
    private System.Random r = new System.Random();

    // Accessor for Sentences
    // Positive
    public List<string> PosSentences
    {
        get
        {
            return posSentences;
        }

        set
        {
            posSentences = value;
        }
    }

    public int GetPosSenteceLength()
    {
        return PosSentences.Count;
    }

    public void AddPosSentence(string sentence)
    {
        if (PosSentences.Contains(sentence))
            PosSentences.Add(sentence);
    }

    public string GetPosSentence(int idx)
    {
        if (PosSentences.Count < idx)
            return PosSentences[idx];
        else if (PosSentences.Count == 0)
            return PosSentences[r.Next(PosSentences.Count)];
        else
            return unknownPosSentence;

    }

    public string GetPosSentence()
    {
        var idx = r.Next(this.GetPosSenteceLength());
        return this.GetPosSentence(idx);
    }

    // Negative
    public List<string> NegSentences
    {
        get
        {
            return negSentences;
        }

        set
        {
            negSentences = value;
        }
    }

    public void AddNegSentence(string sentence)
    {
        if (NegSentences.Contains(sentence))
            NegSentences.Add(sentence);
    }

    public int GetNegSenteceLength()
    {
        return NegSentences.Count;
    }

    public string GetNegSentence(int idx)
    {
        if (NegSentences.Count < idx)
            return NegSentences[idx];
        else if (NegSentences.Count == 0)
            return NegSentences[r.Next(NegSentences.Count)];
        else
            return unknownNegSentence;

    }

    public string GetNegSentence()
    {
        var idx = r.Next(this.GetNegSenteceLength());
        return this.GetNegSentence(idx);
    }

    // Operator for Parameters
    public virtual float GetParameter()
    {
        return parameter;
    }

    public virtual void SetParameter(float parameter)
    {
        this.parameter = parameter;
    }

    public virtual float AddParameter(float value)
    {
        return parameter;
    }

    public virtual float SubParameter(float value)
    {
        return parameter;
    }

    public virtual float MultiParameter(float value)
    {
        return parameter;
    }

    public string getName()
    {
        return aSEName;
    }

    public override string ToString()
    {

        return aSEName + ":" + parameter;
    }

}
