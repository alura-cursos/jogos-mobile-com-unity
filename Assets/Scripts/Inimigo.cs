using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour 
{

	private NavMeshAgent agente;
	public int vida;
	
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
}
