using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.Fundamnetos;

namespace CursoCSharp {
    class Program {
       static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
            });


            central.SelecionarEExecutar();
        }
    }
}