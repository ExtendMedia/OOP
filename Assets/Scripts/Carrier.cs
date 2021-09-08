using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrier : Ship //INHERITANCE
{

    private int aviation;
    public int Aviation //ENCAPSULATION
    {
        get { return aviation; }
        set { aviation = value; }
    }
    private int aaGuns;
    public int AAGuns //ENCAPSULATION
    {
        get { return aaGuns; }
        set { aaGuns = value; }
    }


    public override void GenerateShip() //POLYMORPHISM
    {
        base.GenerateShip();
        ShipClass = SetShipClass();
        Aviation = Random.Range(Rank, 51);
        AAGuns = Random.Range(Rank, 21);
    }

    protected override string SetShipClass()
    {
        return "Carrier";
    }




}
