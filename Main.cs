using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
    public void Start()
    {
        AK47 ak47;

        ak47 = new AK47();

        ak47.attack();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AK47 ak47;

            ak47 = new AK47();

            ak47.attack();
        }
    }
}
