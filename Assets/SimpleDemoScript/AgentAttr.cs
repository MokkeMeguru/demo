using UnityEngine;
using System.Collections;
using UniRx;
using System;

public class AgentAttr : MonoBehaviour
{
    // UniRx 
    private readonly Subject<AttrOrder> attrSubject = new Subject<AttrOrder>();
    // publish reader
    public IObservable<AttrOrder> AttrEvent
    {
        get { return attrSubject; }
    }

    // Attribute initialize function
    private AttrOrder initialize()
    {
        AttrOrder attrOrder = new AttrOrder(Attr.SitDownOnTheChair, Feel.Awake);
        return attrOrder;
    }

    // TODO: this is test flag ... 
    private int count;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Initialize Server");
        attrSubject.OnNext(this.initialize());
        Observable.Interval(TimeSpan.FromSeconds(3.0)).Subscribe(_ => 
        {
            count++;
            attrSubject.OnNext(this.UpdateAgentState(count));
        });
    }

    // Update function
    AttrOrder UpdateAgentState(int count)
    {
        // do something ...
        if (count > 2) 
            return new AttrOrder(Attr.WaveHands, Feel.Happy);
        else 
            return new AttrOrder(Attr.WalkToGuest, Feel.Happy);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
