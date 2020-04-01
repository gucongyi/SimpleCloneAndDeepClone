using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TestClass
{
    public int age;
    public int height;
    public List<int> monitors = new List<int>();
    public TestClass Clone()
    {
        return (TestClass)this.MemberwiseClone();
    }
}
