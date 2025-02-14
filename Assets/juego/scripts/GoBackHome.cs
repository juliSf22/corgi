using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class GoBackHome : MonoBehaviour
{
    public void BackHome()
    {
        MMSceneLoadingManager.LoadScene("home");
    }
}