using UnityEngine;
using System.Collections;

public class FabricaDeTorre : MonoBehaviour 
{
	private Vector3 localDeConstrucao;

	public void criaTorre (GameObject torrePrefab)
	{
		Instantiate (torrePrefab, localDeConstrucao, Quaternion.identity);
	}

	public void SetLocalDeConstrucao(Vector3 localDeConstrucao)
	{
		this.localDeConstrucao = localDeConstrucao;
	}
}