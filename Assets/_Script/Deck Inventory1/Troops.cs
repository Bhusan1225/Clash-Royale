using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCard", menuName = "Card/Troop")]
public class Troops : Card

{
    [Header("Troop")]
    public TroopType troopType;

    public enum TroopType
    {
        Meelee,
        Ranged,
        Swarm,
        Tank
    }
    
    public float health;
    public float maxHealth;
    public float attackPower;

    public override Card GetCard() { return this; }
    public override Troops GetTroops() { return this; }
    public override Spell GetSpell() { return null; }
    public override Builder GetBuilder() { return null; }
}
