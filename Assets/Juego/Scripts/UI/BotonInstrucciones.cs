using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonInstrucciones : MonoBehaviour
{
    public void OnclickBotonInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }
}
