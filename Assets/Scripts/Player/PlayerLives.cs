﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public const int STARTING_LIVES = 3;
    public int CurrentLives = STARTING_LIVES;

    public bool IsAlive { get { return CurrentLives > 0; } }

    public void IncreaseLife(int amount)
    {
        CurrentLives += amount;
    }
    public void DecreaseLife(int amount)
    {
        CurrentLives = Mathf.Max(CurrentLives - amount, 0);
    }
}
