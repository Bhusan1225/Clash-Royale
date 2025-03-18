
using UnityEngine;


[CreateAssetMenu(fileName = "newCard", menuName = "Card/Builder")]
public class Builder : CARD
{

    [Header("Builder")]
    public BuilderType builderType;

    public enum BuilderType
    {
       Defensive,
       Spawner,
       Utility
    }

    public float health;
    public float maxHealth;
    public float spawningTime;

    public override CARD GetCard() { return this; }
    public override Troops GetTroops() { return null; }
    public override Spell GetSpell() { return null; }
    public override Builder GetBuilder() { return this; }
}
