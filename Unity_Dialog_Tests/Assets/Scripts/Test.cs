using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JSONFactory;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NarrativeEvent testEvent = JSONAssembly.RunJSONFactoryForScene(1);
        Debug.Log(testEvent.dialogues[0].characterType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
