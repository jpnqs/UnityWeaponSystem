using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SprayPatterLoadHandler {

    // Attributes
    private List<Spray> _sprayPatternList;
    private List<string> _sprayPatternContent;

    // Constants
    private const string SPRAY_SHOT_START = "<shot>";
    private const int SPRAY_PROPERTY_LENGTH = 4;
    private const string APOSTROPHE = "'";
    private const string INITIAL = "";

    // Constructor
    public SprayPatterLoadHandler (string path)
    {
        this.SprayPatternList = new List<Spray>();
        this.SprayPatternContent = new List<string>();
        this.readFile(path);
        this.generateSprayObjects();
    }

    // Methods
    private void readFile(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string s = INITIAL;
            do
            {
                if (s != null)
                {
                    s = sr.ReadLine();
                    s = condense(s);
                    this.SprayPatternContent.Add(s);
                }
            } while (s != null);
        }
    }

    private void generateSprayObjects ()
    {
        for (int x = 0; x < this.SprayPatternContent.Count; x++)
        {
            string s = this.SprayPatternContent[x];

            if (s == SPRAY_SHOT_START)
            {
                string property = INITIAL;
                int z = 0;

                for (int y = 1; y < SPRAY_PROPERTY_LENGTH; y++)
                {
                    property += SprayPatternContent[x + y];
                    z = y;
                }
                SprayPatternList.Add(this.generateSprayObject(property));

                x += z;
            }
        }
    }

    private Spray generateSprayObject(string shot)  
    {
        List<int> valuePar = new List<int>();

        for (int x = 1; x < shot.Length; x++)
        {
            string s = shot[x].ToString();

            if (s == APOSTROPHE)
            {
                valuePar.Add(x);
            }
        }

        Spray spray = new Spray(convertTextToDouble(valuePar[0], valuePar[1], shot),
                                convertTextToDouble(valuePar[2], valuePar[3], shot),
                                convertTextToDouble(valuePar[4], valuePar[5], shot));

        return spray;

    }

    private double convertTextToDouble (int par1, int par2, string text)
    {
        string SubString = text.Substring(par1, par2 - par1);
        SubString = SubString.Replace(APOSTROPHE, INITIAL);
        double Double = Convert.ToDouble(SubString);
        return Double;
    }

    private string condense(string text)
    {
        if (text != null)
        {
            text = text.Replace(" ", "");
            text = text.Replace("\t", "");
        }
        return text;
    }

    // Properties
    public List<Spray> SprayPatternList
    {
        get { return _sprayPatternList; }
        set { _sprayPatternList = value; }
    }

    protected List<string> SprayPatternContent
    {
        get { return _sprayPatternContent; }
        set { _sprayPatternContent = value; }
    }

}
