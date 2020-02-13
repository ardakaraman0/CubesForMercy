using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject finishLine;

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().LevelFinished();
    }

}
