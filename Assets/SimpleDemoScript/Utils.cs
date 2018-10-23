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
    public AttrOrder(Attr attr, Feel feel)
    {
        this.attr = attr;
        this.feel = feel;
        this.timer = false;
    }
    public AttrOrder(Attr attr, Feel feel, bool timer)
    {
        this.attr = attr;
        this.feel = feel;
        this.timer = timer;
    }

    public Attr GetAttr()
    {
        return this.attr;
    }
    public Feel GetFeel()
    {
        return this.feel;
    }
}
