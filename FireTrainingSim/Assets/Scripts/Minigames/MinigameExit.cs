﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameExit : MonoBehaviour
{
    public GameObject m_cameraController;
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            m_cameraController.GetComponent<CameraController>().ChangeCamera("Room Camera");
        }
	}
}
