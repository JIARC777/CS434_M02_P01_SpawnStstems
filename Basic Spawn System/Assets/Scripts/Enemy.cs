using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, iCopyable
    
{
    
    // Start is called before the first frame update
    public iCopyable Copy()
    {     
        return Instantiate(this);
    }
}



