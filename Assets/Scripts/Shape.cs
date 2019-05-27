using UnityEngine;
using System.Collections;

public class Shape : MonoBehaviour
{
	public GameObject cube;
	public GameObject cylinder;
	void OnGUI()
	{
		if (GUILayout.Button("向左移动Cube"))
		{
			cube.transform.Translate(new Vector3(-0.5f, 0f, 0f));
		}
		if (GUILayout.Button("向右移动Cube"))
		{
			cube.transform.position = cube.transform.position + new Vector3(0.5f, 0f, 0f);
		}
		if (GUILayout.Button("放大Cube"))
		{
			cube.transform.localScale *= 1.2f;
		}
		if (GUILayout.Button("缩小Cube"))
		{
			cube.transform.localScale *= 0.8f;
		}
		if (GUILayout.Button("旋转Cube"))
		{
			cube.transform.Rotate(new Vector3(0, 10, 0));
		}
		if (GUILayout.Button("围绕圆柱旋转Cube"))
		{
			cube.transform.RotateAround(cylinder.transform.position, Vector3.up, 10);
		}
	}
}