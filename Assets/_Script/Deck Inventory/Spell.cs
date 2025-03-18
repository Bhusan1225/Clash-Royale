using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : CARD
{
    public override CARD GetCard() { return this; }
    public override Troops GetTroops() { return null; }
    public override Spell GetSpell() { return this; }
    public override Builder GetBuilder() { return null; }
}
