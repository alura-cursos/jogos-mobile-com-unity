using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour {

	[Range(0,5)]
	public float velocidade;
	private GameObject alvo;

	void Start () 
	{
		alvo = GameObject.Find("Inimigo");
	}

	void Update () 
	{
		anda ();
		alteraDirecao ();
	}

	private void anda()
	{
		Vector3 posicaoAtual = transform.position;
		Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
		transform.position = posicaoAtual + deslocamento;
	}

	private void alteraDirecao() 
	{
		Vector3 posicaoAtual = transform.position;
		Vector3 posicaoDoAlvo = alvo.transform.position;
		Vector3 direcaoDoAlvo = posicaoDoAlvo - posicaoAtual;
		transform.rotation = Quaternion.LookRotation (direcaoDoAlvo);
	}
}
