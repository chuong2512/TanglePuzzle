using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeManager : MonoBehaviour
{
    public levelloder levelloder;

    public void LoadLevel()
    {
	    levelloder.LoadScene();
    }
}
