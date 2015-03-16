using UnityEngine;
using System.Collections;

public class GeradorDeInimigos : MonoBehaviour 
{

	public GameObject inimigo;
	private float momentoDaUltimaGeracao;
	
	[Range(0,3)]
	public float tempoDeCriacao = 2f;
	
	void Update () 
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao) 
		{
			momentoDaUltimaGeracao = tempoAtual;
			Vector3 posicaoDoGerador = this.transform.position;
			Instantiate (inimigo, posicaoDoGerador, Quaternion.identity);
		}
	}
}