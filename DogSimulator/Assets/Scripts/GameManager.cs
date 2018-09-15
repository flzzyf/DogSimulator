using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public bool isPaused;
	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.F))
        {
            DialogManager.Instance().DisplayNextSentence();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SoundManager.Instance().Play("Woof1");
        }

    }
}
