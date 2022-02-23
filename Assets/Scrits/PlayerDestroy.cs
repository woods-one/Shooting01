using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    public void DestroyPlayerObject()
    {
        Destroy(this.gameObject);
    }
}
