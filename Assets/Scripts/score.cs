using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform playerPos;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (playerPos.position.z / 20).ToString("0");
    }
}
