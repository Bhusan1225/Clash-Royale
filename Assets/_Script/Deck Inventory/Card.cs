using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Card :ScriptableObject
{
    
    public string cardName;
    public int ElevireValue;

    public Sprite cardIcon;
    //public GameObject characterModel;
    public float characterSpeed;
    public float characterRange;


    public abstract Card GetCard();
    public abstract Troops GetTroops();
    public abstract Spell GetSpell();
    public abstract Builder GetBuilder();
}


