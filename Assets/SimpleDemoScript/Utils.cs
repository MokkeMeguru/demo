public enum Attr
{
    WalkToGuest,
    SitDownOnTheChair,
    SitDownOnTheFloor,
    GoToWindow,
    SeeWindow,
    SeeGuest,
    RandomWalk,
    WaveHands,
    Free,
    None
}

public enum Feel
{
    Happy,
    Smile,
    Sad,
    Normal,
    Angry,
    Awake,
    None
}

public class AttrOrder
{
    private readonly Attr attr;
    private readonly Feel feel;
    private readonly bool timer;
    private readonly float feel_parameter;
    public AttrOrder(Attr attr, Feel feel)
    {
        this.attr = attr;
        this.feel = feel;
        this.timer = false;
        this.feel_parameter = 0.5;
    }
    public AttrOrder(Attr attr, Feel feel, bool timer)
    {
        this.attr = attr;
        this.feel = feel;
        this.timer = timer;
        this.feel_parameter = 0.5;
    }

    public Attr GetAttr()
    {
        return this.attr;
    }
    public Feel GetFeel()
    {
        return this.feel;
    }
    public Feel GetFeelParameter()
    {
        return this.feel_parameter;
    }
}
