﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler : MonoBehaviour
{

    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies;
    // Start is called before the first frame update
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
            {
                return;
            }

            Debug.Log("Pozbyłeś się wszystkich wrogów");
            _nextLevelIndex++;
            string nextLevelName = "Level" + _nextLevelIndex;
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
