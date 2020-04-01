using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var testClass1=CloneHelper.createTestClass();
        Debug.LogError($"{testClass1.age},{testClass1.height},{testClass1.monitors[0]}");
        ////浅clone
        //TestClass testclass2 = testClass1.Clone();
        //testclass2.age = 80;
        //testclass2.monitors[0] = 100;
        //Debug.LogError($"浅克隆原类{testClass1.age},{testClass1.height},{testClass1.monitors[0]}");
        //Debug.LogError($"浅克隆克隆类{testclass2.age},{testclass2.height},{testclass2.monitors[0]}");

        //深clone
        TestClass testClass3 = testClass1.DeepClone<TestClass>();
        testClass3.age = 30;
        testClass3.monitors[0] = 50;
        Debug.LogError($"深克隆原类{testClass1.age},{testClass1.height},{testClass1.monitors[0]}");
        Debug.LogError($"深克隆原类{testClass3.age},{testClass3.height},{testClass3.monitors[0]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
