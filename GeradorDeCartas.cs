using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;

public class GeradorDeCartas : MonoBehaviour {

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private Carta Richard() {
        Carta richard = new Carta();
        richard.id = 1;
        richard.nome = "Richard";
        richard.ataque = 10;
        richard.defesa = 10;

        return richard;
    }

    private Carta Nathan() {
        Carta nathan = new Carta();
        nathan.id = 2;
        nathan.nome = "Nathan";
        nathan.ataque = 5;
        nathan.defesa = 15;

        return nathan;
    }

    private Carta Mae() {
        Carta mae = new Carta();
        mae.id = 3;
        mae.nome = "Mãe A Braba";
        mae.ataque = 50;
        mae.defesa = 100;

        return mae;
    }

    private Carta Riane() {
        Carta riane = new Carta();
        riane.id = 4;
        riane.nome = "Riane";
        riane.ataque = 12;
        riane.defesa = 8;

        return mae;
    }

    public List<Carta> GerarCartas() {
        List<Carta> cartas = new List<Carta>();
        cartas.Add(Richard());
        cartas.Add(Nathan());
        cartas.Add(Mae());
        cartas.Add(Riane());

        return cartas;
    }
}
