using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AK47 : RangedWeapon
{

    private const string sprayPatterLocation = "Assets\\Weapons\\AK47.spray";

    public AK47() : base(sprayPatterLocation)
    {

    }

    public override void attack()
    {
        
    }
}
