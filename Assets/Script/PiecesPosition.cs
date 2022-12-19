using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesPosition : MonoBehaviour
{
    private Vector3 rightPosition;
    public bool inRightPosition;
    // Start is called before the first frame update
    void Start()
    {
        rightPosition = transform.position;        
    }
    public void Init()
	{
        transform.position = new Vector3(Random.Range(-9, 8), Random.Range(-1, -16), 0);
    }
  

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, rightPosition)<0.4 && !inRightPosition && GameManager.instance.isInGame)
        {
            transform.position = rightPosition;
            inRightPosition = true;

        }
        



    }
    
}
