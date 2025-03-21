using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card2", menuName = "Card2/create New Card2")]

public class Card2 :ScriptableObject
{
    public int id;
    public string cardName;
    public int ElevireValue;
    public Sprite cardIcon;
    public GameObject characterModel;
    public float characterSpeed;
    public float characterRange;
}

