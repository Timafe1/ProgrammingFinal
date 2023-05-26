using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickUp : PickUp
{
    public Sprite newCarColorSprite;

    public override void Activate()
    {
        player.sr.sprite = newCarColorSprite;
    }
}
