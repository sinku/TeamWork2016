﻿using UnityEngine;
using System.Collections;

public class GameManager : SingletonMonoBehaviour<GameManager> {

    void Start()
    {
        BGMManager.Instance.Play("stageselect");
    }

    public bool isDead = false;

    public void Dead()
    {
        FadeManager.Instace.LoadLevel("MainGame", 4.0f);
        isDead = true;
    }

    public void SceneEnd()
    {
        FadeManager.Instace.LoadLevel("StageSelect", 2.0f);
        Debug.Log("on");
    }

}
