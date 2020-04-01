using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class CloneHelper
{
    public static T DeepClone<T>(this T obj)
    {
        object retval;
        using (MemoryStream ms = new MemoryStream())
        {
            BinaryFormatter bf = new BinaryFormatter();
            //序列化成流
            bf.Serialize(ms, obj);
            ms.Seek(0, SeekOrigin.Begin);
            //反序列化成对象
            retval = bf.Deserialize(ms);
            ms.Close();
        }
        return (T)retval;
    }

    public static TestClass createTestClass()
    {
        List<int> temp = new List<int>();
        temp.Add(10);
        temp.Add(20);
        TestClass testClass = new TestClass() { age = 10, height = 20, monitors= temp };
        return testClass;
    }

}
