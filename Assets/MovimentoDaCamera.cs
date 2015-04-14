using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovimentoDaCamera : MonoBehaviour {

	public List<GameObject> pontos;
	public List<float> tempos;

	float acumulador;
	Vector3 posicaoInicial;
	Quaternion rotacaoInicial;
	float tempo;
	GameObject ponto;
	int index = 0;

	// Use this for initialization
	void Start () {
		ponto = pontos [index];
		tempo = tempos [index];
		posicaoInicial = transform.position;
		rotacaoInicial = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		acumulador += Time.deltaTime;
		MoveCamera ();
	}
	
	void MoveCamera ()
	{
		transform.position = Vector3.Lerp (posicaoInicial, ponto.transform.position, acumulador / tempo);
		transform.rotation = Quaternion.Slerp (rotacaoInicial, ponto.transform.rotation, acumulador / tempo);
		if (acumulador >= tempo) {
			acumulador -= tempo;
			index = (index + 1) % 6;
			posicaoInicial = ponto.transform.position;
			rotacaoInicial = ponto.transform.rotation;
			ponto = pontos[index];
			tempo = tempos[index];
			MoveCamera();
		}
	}
}
