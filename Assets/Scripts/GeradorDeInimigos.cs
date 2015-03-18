using UnityEngine;
using System.Collections;

public class GeradorDeInimigos : MonoBehaviour 
{

	public GameObject inimigo;
	private float momentoDaUltimaGeracao;
	
	[Range(0,3)]
	public float tempoDeCriacao = 2f;

	[SerializeField]
	private int quantidadeDeInimigos = 5;
	private int inimigosGerados = 0;
	
	void Update () 
	{
		if (podeGerarInimigo ()) 
		{
			geraInimigo ();
		} 
		else 
		{
			Destroy (this.gameObject);
		}
	}

	private void geraInimigo () 
	{
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao) 
		{
			momentoDaUltimaGeracao = tempoAtual;
			Vector3 posicaoDoGerador = this.transform.position;
			Instantiate (inimigo, posicaoDoGerador, Quaternion.identity);
			inimigosGerados ++;
		}
	}

	private bool podeGerarInimigo()
	{
		return quantidadeDeInimigos > inimigosGerados;
	}
}