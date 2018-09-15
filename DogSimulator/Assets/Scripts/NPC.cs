using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour 
{
    public float dialogRange = 2f;
    public float sightRange = 3f;
    public Dialog dialog;

    public LayerMask layer_player;

    bool playerInSight;

	void Update () 
	{
        if(!playerInSight)
        {
            //进入对话范围
            foreach (var item in Physics2D.OverlapCircleAll(transform.position, dialogRange, layer_player))
            {
                playerInSight = true;

                DialogManager.Instance().TriggerDialog(dialog);
            }
        }
        else
        {
            //视野内无玩家
            if(Physics2D.OverlapCircleAll(transform.position, sightRange, layer_player).Length == 0)
            {
                playerInSight = false;
            }
        }
        
	}

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, dialogRange);
    }
}
