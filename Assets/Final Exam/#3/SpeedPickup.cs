using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickup : PickUp
{
    public float originalSpeed;
    public float boostedSpeed = 5f;

    public override void Activate()
    {
        originalSpeed = player.moveSpeed; 
        player.moveSpeed = boostedSpeed;

        StartCoroutine(ResetSpeedAfterDelay());
    }

    private IEnumerator ResetSpeedAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        player.moveSpeed = originalSpeed;
    }
}
