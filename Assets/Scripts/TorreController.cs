using UnityEngine;
using System.Collections;

public class TorreController : MonoBehaviour 
{

	public GameObject projetil;
	private float momentoDoUltimoDisparo;

	[Range(0,3)]
	public float tempoDeRecarga = 1f;

	void Update () 
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) 
		{
			momentoDoUltimoDisparo = tempoAtual;
			GameObject pontoDeDisparo = GameObject.Find ("CanhaoDaTorre/PontoDeDisparo");
			Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
			Instantiate (projetil, posicaoDoPontoDeDisparo, Quaternion.identity);
		}
	}
}