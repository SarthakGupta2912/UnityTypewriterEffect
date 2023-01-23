using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{

    [SerializeField] Text textBox;

    private void Start()
    {
       StartCoroutine(TypeWriting());
    }


    IEnumerator TypeWriting()
    {
        string temp = "Hello, how are you?";
        
        for (int i = 0; i <= temp.Length-1; i++)
        {
            textBox.text += temp[i].ToString();
            yield return new WaitForSeconds(0.05f);
        }
    }
}
