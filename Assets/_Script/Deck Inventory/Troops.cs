using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troops : CARD

{
    public override CARD GetCard() { return this; }
    public override Troops GetTroops() { return this; }
    public override Spell GetSpell() { return null; }
    public override Builder GetBuilder() { return null; }
}
