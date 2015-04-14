using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour, Projetil {

	[SerializeField] private GameObject fumacaDoLaserPrefab;

	void Start () 
	{
		autoDestroiDepoisDeSegundos (0.1f);
	}

	public void defineAlvo (Inimigo inimigo)
	{
		LineRenderer lineRenderer = GetComponent<LineRenderer> ();
		GameObject inimigoGameObject = inimigo.gameObject;
		Vector3 posicaoDoInimigo = inimigoGameObject.transform.position;
		lineRenderer.SetPosition (0, this.gameObject.transform.position);
		lineRenderer.SetPosition (1, posicaoDoInimigo);
		Queima (posicaoDoInimigo);
	}

	private void autoDestroiDepoisDeSegundos(float segundos) 
	{
		Destroy (this.gameObject, segundos);
	}

	private void Queima (Vector3 posicaoDoInimigo) 
	{
		GameObject fumaca = Instantiate(fumacaDoLaserPrefab, posicaoDoInimigo, Quaternion.identity) as GameObject;
		Destroy (fumaca, 1);
	}
}
