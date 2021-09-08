using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship 
{

    private string shipName;
    public string ShipName 
    {
        get { return shipName; }
        private set { shipName = value; }
    }
    private string shipClass;
    public string ShipClass //ENCAPSULATION
    {
        get { return shipClass; }
        set { shipClass = value; }
    }

    private int rank;
    public int Rank //ENCAPSULATION
    {
        get { return rank; }
        set { rank = value; }
    }

    private int armor;
    public int Armor //ENCAPSULATION
    {
        get { return armor; }
        set { armor = value; }
    }
    private int artillery;
    public int Artillery //ENCAPSULATION
    {
        get { return artillery; }
        set { artillery = value; }
    }
    private int speed;
    public int Speed //ENCAPSULATION
    {
        get { return speed; }
        set { speed = value; }
    }



    private string RandomShipName()
    {
        string[] shipNameList = new string[] { "Black Swan", "Bougainville", "Chengan", "Erie", "Eritrea", "Gryf", "Hashidate", "Hermelin", "Orlan", "Mikasa", "Albany", "Almirante Abreu", "Chester", "Chikuma", "Diana", "Diana Lima", "Dresden", "Emden", "Jurien de la Gravière", "Nino Bixio", "Novik", "Weymouth", "Enseigne Gabolde", "Longjiang", "Medea", "Sampson", "Smith", "Storozhevoi", "Tachibana", "Tachibana Lima", "Tátra", "Umikaze", "V-25", "Bellerophon", "Dreadnought", "Kawachi", "Knyaz Suvorov", "König Albert", "Nassau", "South Carolina", "Turenne", "Aurora", "Bogatyr", "Caledon", "Charleston", "Friant", "Katori", "Kolberg", "Oleg", "St. Louis", "Taranto", "Tenryu", "Varyag", "Campbeltown", "Derzki", "Fusilier", "G-101", "Phra Ruang", "Romulus", "Valkyrie", "Vampire", "Wakatake", "Wickes", "Hermes", "Hosho", "Langley", "Rhein", "Arkansas Beta", "Courbet", "Dante Alighieri", "Gangut", "Imperator Nikolai I", "Ishizuchi", "Kaiser", "Myogi", "Orion", "Wyoming", "Alberto di Giussano", "Danae", "De Ruyter", "Duguay-Trouin", "Iwaki Alpha", "Karlsruhe", "Kuma", "Phoenix", "Svietlana", "Yūbari" };

        return shipNameList[Random.Range(0, shipNameList.Length)];
    }


    protected virtual string SetShipClass()
    {
        return "Ship";
    }
    public virtual void GenerateShip()
    {
        ShipName = RandomShipName();
        Rank = Random.Range(1, 10);
        Armor = Random.Range(Rank*5, Rank * 10);
        Artillery = Random.Range(Rank * 5, Rank * 10);
        Speed = Random.Range(Rank * 5, Rank * 10);
    }


}
