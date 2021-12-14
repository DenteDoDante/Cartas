using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jogo : MonoBehaviour{
    private Jogador jogador, npc;
    private Console console;
    void Start()
    {
        IniciarJogo();
    }

    void Update()
    {
        
    }

    private Jogador GerarJogador() {
        Jogador jogador = new Jogador();
        jogador.id = 1;
        jogador.nome = "Richard";
        jogador.vida = 100;
        jogador.cartas = GeradorDeCartas.GerarCartas();

        return jogador;
    }

    private Jogador GerarNPC() {
        Jogador npc = new Jogador();
        npc.id = 2;
        npc.nome = "Nathan";
        npc.vida = 100;
        npc.cartas = GeradorDeCartas.GerarCartas();

        return npc;
    }

    private void IniciarJogo() {
        GerarJogador();
        GerarNPC();
        Jogar();
    }

    private void Jogar() {
        Carta cartaJogador = jogador1.cartas[Random.Range(0, jogador1.cartas.Count)];
        Carta cartaNpc = npc2.cartas[Random.Range(0, jogador1.cartas.Count)];

        if (cartaJogador.ataque > cartaNpc.defesa) {
            npc.vida -= cartaJogador.ataque - cartaNpc.defesa;
            console.Log("Você atacou o NPC com a carta " + cartaJogador.nome + " e ele perdeu " + (cartaJogador.ataque - cartaNpc.defesa) + " de vida");
        } else {
            cartaJogador.vida -= cartaNpc.ataque - cartaJogador.defesa;
            console.Log("Você perdeu " + (cartaNpc.ataque - cartaJogador.defesa) + " de vida");
        }

    }
}
