using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GolfSolitaire {


public enum eGolfCardState
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardGolf : Card
{
    public eCardState state = eCardState.drawpile;
    public List<CardGolf> hiddenBy = new List<CardGolf>();
    public int layoutID;
    public SlotDef slotDef;

    override public void OnMouseUpAsButton() {
        Golf.S.CardClicked(this);
        base.OnMouseUpAsButton();
    }
}
}