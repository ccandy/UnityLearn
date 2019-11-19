using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace UnityLearn.Gameplay
{
    public class CodeSample : MonoBehaviour
    {
        // Start is called before the first frame update
        #region Variables
        private int _nameToDisplay = 5;
        #endregion

        void Start()
        {
            SayHelloWorld();
        }

        private void SayHelloWorld()
        {
            for (int n = 0; n < _nameToDisplay; n++)
            {
                Debug.Log("Hello World");
            }

        }
    }
}
    
