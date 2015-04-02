using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour, Projetil {

	void Start () 
	{
		autoDestroiDepoisDeSegundos (0.1f);
	}

	public void defineAlvo (Inimigo inimigo)
	{
		LineRenderer lineRenderer = GetComponent<LineRenderer> ();
		GameObject inimigoGameObject = inimigo.gameObject;
		lineRenderer.SetPosition (0, this.gameObject.transform.position);
		lineRenderer.SetPosition (1, inimigoGameObject.transform.position);
	}

	private void autoDestroiDepoisDeSegundos(float segundos) 
	{
		Destroy (this.gameObject, segundos);
	}
}
