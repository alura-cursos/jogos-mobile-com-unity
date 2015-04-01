using UnityEngine;
using System.Collections;

public class FabricaDeTorre : MonoBehaviour 
{

	public void criaTorre (GameObject torrePrefab)
	{
		Instantiate (torrePrefab);
	}
}