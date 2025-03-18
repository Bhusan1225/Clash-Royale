using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class CARD : ScriptableObject 
{

    public string cardName;
    public Sprite cardIcon;
    //public GameObject characterModel;

    public abstract CARD GetCard();
    public abstract Troops GetTroops();
    public abstract Spell GetSpell();
    public abstract Builder GetBuilder();

}

