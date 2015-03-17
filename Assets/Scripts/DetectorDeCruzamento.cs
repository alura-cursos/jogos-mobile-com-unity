using UnityEngine;
using System.Collections;

public class DetectorDeCruzamento : MonoBehaviour 
{
	[SerializeField]
	private Jogador jogador;

	void OnTriggerEnter (Collider inimigo) 
	{
		Debug.Log ("Chegou no fim do caminho!");
		Destroy (inimigo.gameObject);
		jogador.PerdeVida ();
	}
}
