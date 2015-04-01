using UnityEngine;
using System.Collections;

public class FabricaDeTorre : MonoBehaviour 
{
	private Vector3 localDeConstrucao;
	[SerializeField] private Jogador jogador;

	public void criaTorre (GameObject torrePrefab)
	{
		TorreController torre = torrePrefab.GetComponent<TorreController> ();
		int custoDaTorre = torre.GetCusto ();
		if (jogador.podeGastar (custoDaTorre)) 
		{
			jogador.gasta(custoDaTorre);
			Instantiate (torrePrefab, localDeConstrucao, Quaternion.identity);
		}
	}

	public void SetLocalDeConstrucao(Vector3 localDeConstrucao)
	{
		this.localDeConstrucao = localDeConstrucao;
	}
}