using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSystemGenerator : MonoBehaviour
{
	private string axiom = "F";
	private string currStr;
	private Dictionary<char, string> rules = new Dictionary<char, string>();

	private float length;
	private float angle;

	private bool isGenerating = false;

	private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();

	// use this for initialization
    void Start()
    {
    	rules.Add('F', "FF+[+F-F>[<F>F>]-F]-[-F+F<[>F<F<]+F]");

    	// axiom = "F-G-G";
    	// rules.Add('F', "F-G+F+G-F");
    	// rules.Add('G', "GG");

        currStr = axiom;

        //angle = 120f;
        angle = 25f;
        length = 10f;

        StartCoroutine(GenerateLSystem());
    }

    IEnumerator GenerateLSystem()
    {
    	int count = 0;

    	while(count < 4)
    	{
    		if(!isGenerating)
    		{
    			isGenerating = true;
    			StartCoroutine(Generate(count));
    			count++;
    		}
    		else
    		{
    			yield return new WaitForSeconds(0.1f);
    		}
    	}
    }

    IEnumerator Generate(int count)
    {
    	string newStr = "";
    	Color color = Color.white;

    	char[] stringChar = currStr.ToCharArray();

    	for (int i = 0; i < stringChar.Length; i++)
    	{
    		char curr = stringChar[i];

    		if(rules.ContainsKey(curr))
    		{
    			newStr += rules[curr];
    		}
    		else
    		{
    			newStr += curr.ToString();
    		}
    	}

    	currStr = newStr;

    	Debug.Log(currStr);

    	stringChar = currStr.ToCharArray();

    	for (int i = 0; i < stringChar.Length; i++)
    	{
    		char curr = stringChar[i];

    		if(curr == 'F')
    		{
    			if(count == 0)
    			{

    				color = new Color(Random.Range(0.129f, 0.184f), Random.Range(0.063f, 0.09f), 0.0f);
    			}
    			else if(count == 1)
    			{
    				color = new Color(Random.Range(0.185f, 0.224f), Random.Range(.091f, 0.11f), 0.0f);
    			}
    			else if(count == 2)
    			{
    				color = new Color(Random.Range(0.225f, 0.267f), Random.Range(0.111f, 0.133f) , 0.0f);
    			}
    			else if(count == 3)
    			{ 
    				color = new Color(Random.Range(0.153f, 0.282f), Random.Range(0.227f, 0.498f), Random.Range(0.0f, 0.2f));
    			}

    			// move forward
    			Vector3 intialPos = transform.position;
    			transform.Translate(Vector3.forward * length);
    			Debug.DrawLine(intialPos, transform.position, color, 10000f, false);
    			yield return null;
    		}
    		else if(curr == '+')
    		{
    			transform.Rotate(Vector3.up * angle);
    		}
    		else if(curr == '-')
    		{
    			transform.Rotate(Vector3.up * -angle);
    		}
    		else if(curr == '<')
    		{
    			transform.Rotate(Vector3.right * angle*2.5f);
    		}
    		else if(curr == '>')
    		{
    			transform.Rotate(Vector3.right * -angle*2.5f);
    		}
    		else if(curr == '[')
    		{
    			TransformInfo ti = new TransformInfo();
    			ti.position = transform.position;
    			ti.rotation = transform.rotation;
    			transformStack.Push(ti);
    		}
    		else if(curr == ']')
    		{
    			TransformInfo ti = transformStack.Pop();
    			transform.position = ti.position;
    			transform.rotation = ti.rotation;
    		}
    	}
    	isGenerating = false;
    }
}
