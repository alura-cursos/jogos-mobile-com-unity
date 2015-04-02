using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour 
{

	[SerializeField]
	private int vida;

	[SerializeField] 
	private int dinheiro;

	public int GetVida () 
	{
		return vida;
	}

	public int GetDinheiro ()
	{
		return dinheiro;
	}

	public void PerdeVida () 
	{
		if (EstaVivo ()) 
		{
			vida --;
		}
	}

	public bool EstaVivo () 
	{
		return vida > 0;
	}

	public bool podeGastar (int dinheiro)
	{
		return this.dinheiro >= dinheiro;
	}

	public void gasta (int dinheiro)
	{
		this.dinheiro -= dinheiro;
	}

	public void ganhaRecompensa(int dinheiro)
	{
		this.dinheiro += dinheiro;
	}
}
