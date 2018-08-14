using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class RangedWeapon : Weapon {

    private string sprayPatternLocation;
    protected List<Spray> sprayPattern;

    protected RangedWeapon (string _sprayPatterLocation) : base ()
    {
        SprayPatternLocation = _sprayPatterLocation;
        sprayPattern = new List<Spray>();

        loadSprayPattern();

    }

    public string SprayPatternLocation
    {
        get { return sprayPatternLocation; }
        set { sprayPatternLocation = value; }
    }

    protected void loadSprayPattern ()
    {
        SprayPatterLoadHandler loadHandler = new SprayPatterLoadHandler(SprayPatternLocation);
        sprayPattern = loadHandler.SprayPatternList;
    }
   

}
