public class Spray
{

    private double _addX;
    private double _addY;
    private double _damage;

    /// <summary>
    /// Constructor of class "Spray"
    /// <paramref name="x"/>
    /// <paramref name="y"/>
    /// <paramref name="dmg"/>
    /// </summary>
    public Spray (double x, double y, double dmg)
    {
        this.addX = x;
        this.addY = y;
        this.damage = dmg;
    }

    /// <summary>
    /// The value wich is added to x-axis
    /// <para>addX</para>
    /// </summary>
    public double addX
    {
        get { return _addX; }
        set { _addX = value; }
    }

    /// <summary>
    /// The value wich is added to y-axis
    /// <para>addY</para>
    /// </summary>
    public double addY
    {
        get { return _addY; }
        set { _addY = value; }
    }

    /// <summary>
    /// The value wich is used as damage by shot
    /// <para>Damage</para>
    /// </summary>
    public double damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

}
