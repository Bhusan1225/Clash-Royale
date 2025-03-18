using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newCard", menuName = "Card/Spell")]
public class Spell : CARD
{

    [Header("Spell")]
    public SpellType spellType;

    public enum SpellType
    {
        DamageSpell,
        ControlSpell,
        Buff_DebuffSpell,
    }

    public float spawnTime;

    public override CARD GetCard() { return this; }
    public override Troops GetTroops() { return null; }
    public override Spell GetSpell() { return this; }
    public override Builder GetBuilder() { return null; }
}
