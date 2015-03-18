using UnityEngine;
using System.Collections;

public class DetectorDeCruzamento : MonoBehaviour 
{
	[SerializeField]
	private Jogador jogador;

	void OnTriggerEnter (Collider collider) 
	{
		if (collider.CompareTag ("Inimigo")) 
		{
			Debug.Log ("Chegou no fim do caminho!");
			Destroy (collider.gameObject);
			jogador.PerdeVida ();
		}
	}
}
