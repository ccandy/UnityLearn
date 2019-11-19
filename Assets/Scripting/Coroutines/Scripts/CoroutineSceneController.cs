using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoroutineSceneController : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Shape> gameShapes;
   

    void Start()
    {
        StartCoroutine("SetShapeBlue");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    

    private void SetShapeRed()
    {
        foreach(Shape shape in gameShapes)
        {
            shape.SetColor(Color.red);
        }
    }

    private IEnumerator SetShapeBlue()
    {
        Debug.Log("in coroutine");
        foreach (Shape shape in gameShapes)
        {
            shape.SetColor(Color.blue);
            //expand to next frame;
            yield return null;
        }
    }   
}
