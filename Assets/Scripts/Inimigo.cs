using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour 
{

	private NavMeshAgent agente;
	public int vida;
	[SerializeField] private int recompensa;
	
	void Start () 
	{
		agente = GetComponent<NavMeshAgent>();
		GameObject fimDoCaminho = GameObject.Find ("FimDoCaminho");
		Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
		agente.SetDestination (posicaoDoFimDoCaminho);
	}

	public void recebeDano(int pontosDeDano) 
	{
		vida -= pontosDeDano;
		if (vida <= 0) 
		{
			Destroy(this.gameObject);
		}
	}

	void OnDestroy() {
		Jogador jogador = GameObject.Find("DadosDoJogador").GetComponent<Jogador>();
		jogador.ganhaRecompensa(recompensa);
	}
}
