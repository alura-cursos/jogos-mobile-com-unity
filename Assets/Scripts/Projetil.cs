using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour {

	[Range(0,5)]
	public float velocidade;

	void Update () {
		Vector3 posicaoAtual = transform.position;
		Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
		transform.position = posicaoAtual + deslocamento;
	}
}
