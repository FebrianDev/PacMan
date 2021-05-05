﻿using UnityEngine;

public class Player : Character
{
    #region Singleton

    private static Player _player;

    public static Player Instance
    {
        get
        {
            if (_player == null)
            {
                _player = FindObjectOfType<Player>();
            }

            return _player;
        }
    }

    #endregion

    public override void Movement()
    {
        if (Input.GetKey(KeyCode.A) && !CheckCollider(Vector2.left))
            Move(Vector2.left);
        else if (Input.GetKey(KeyCode.D) && !CheckCollider(Vector2.right))
            Move(Vector2.right);
        else if (Input.GetKey(KeyCode.W) && !CheckCollider(Vector2.up))
            Move(Vector2.up);
        else if (Input.GetKey(KeyCode.S) && !CheckCollider(Vector2.down))
            Move(Vector2.down);
    }
}