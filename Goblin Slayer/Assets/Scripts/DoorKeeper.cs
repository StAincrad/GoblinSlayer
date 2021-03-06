﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeeper : MonoBehaviour
{

    /// <summary>
    /// Disable collider and sprite of the gate
    /// </summary>
    public void OpenNextLvl()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    /// <summary>
    /// Load next level
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameplayManager.OnGameOver();
    }



}
