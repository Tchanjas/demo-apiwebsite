using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication_StartupSeed_v2.Models;

namespace WebApplication_StartupSeed_v2.Migrations {
	public class MySeed {

		public static void CarregaDados(MyDB context) {

			// ############################################################################################
			// adiciona DONOS
			var donos = new List<Donos> {
				new Donos  {DonoID=1, Nome = "Luís Freitas", NIF ="813635582" },
				new Donos  {DonoID=2, Nome = "Andreia Gomes", NIF ="854613462" },
				new Donos  {DonoID=3, Nome = "Cristina Sousa", NIF ="265368715" },
				new Donos  {DonoID=4, Nome = "Sónia Rosa", NIF ="835623190" },
				new Donos  {DonoID=5, Nome = "António Santos", NIF ="751512205" },
				new Donos  {DonoID=6, Nome = "Gustavo Alves", NIF ="728663835" },
				new Donos  {DonoID=7, Nome = "Rosa Vieira", NIF ="644388118" },
				new Donos  {DonoID=8, Nome = "Daniel Dias", NIF ="262618487" },
				new Donos  {DonoID=9, Nome = "Tânia Gomes", NIF ="842615197" },
				new Donos  {DonoID=10, Nome = "Andreia Correia", NIF ="635139506" },
				new Donos  {DonoID=11, Nome = "Márcio Alves", NIF ="715428372" },
				new Donos  {DonoID=12, Nome = "Inês Martins", NIF ="348385836" },
				new Donos  {DonoID=13, Nome = "Teresinha Vieira", NIF ="365555205" },
				new Donos  {DonoID=14, Nome = "Marco Soares", NIF ="540161898" },
				new Donos  {DonoID=15, Nome = "Lourdes Vieira", NIF ="528411261" },
				new Donos  {DonoID=16, Nome = "Júlio Morais", NIF ="266563928" },
				new Donos  {DonoID=17, Nome = "Carmem Oliveira", NIF ="717250604" },
				new Donos  {DonoID=18, Nome = "Denise Silva", NIF ="843547587" },
				new Donos  {DonoID=19, Nome = "Cristina Melo", NIF ="416933279" },
				new Donos  {DonoID=20, Nome = "Augusto Rosa", NIF ="485162005" }
			};

			donos.ForEach(dd => context.Donos.AddOrUpdate(d => d.Nome,dd));
			context.SaveChanges();

			// ############################################################################################
			// adiciona ANIMAIS
			var animais = new List<Animais > {
				new Animais  {AnimalID=1, Nome = "Bubi", Especie ="cão", Raca="Pastor Alemão", Peso=24, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=1},
				new Animais  {AnimalID=2, Nome = "Pastor", Especie ="cão", Raca="Serra Estrela", Peso=50, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=3},
				new Animais  {AnimalID=3, Nome = "Tripé", Especie ="cão", Raca="Serra Estrela", Peso=45, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=2},
				new Animais  {AnimalID=4, Nome = "Kika", Especie ="cão", Raca="Serra Estrela", Peso=39, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=5},
				new Animais  {AnimalID=5, Nome = "Traquina", Especie ="cão", Raca="Serra Estrela", Peso=55, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=6},
				new Animais  {AnimalID=6, Nome = "Rufia", Especie ="cão", Raca="Serra Estrela", Peso=45, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=9},
				new Animais  {AnimalID=7, Nome = "Morde Tudo", Especie ="cão", Raca="Dobreman", Peso=39, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=10},
				new Animais  {AnimalID=8, Nome = "Forte", Especie ="cão", Raca="Rotweiler", Peso=20, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=7},
				new Animais  {AnimalID=9, Nome = "Mau", Especie ="cão", Raca="Rotweiler", Peso=38, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=8},
				new Animais  {AnimalID=10, Nome = "Saltitão", Especie ="cão", Raca="Rotweiler", Peso=36, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=1},
				new Animais  {AnimalID=11, Nome = "Amigo", Especie ="cão", Raca="Labrador", Peso=24, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=1},
				new Animais  {AnimalID=12, Nome = "Pintas", Especie ="cão", Raca="Labrador", Peso=6, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=8},
				new Animais  {AnimalID=13, Nome = "Babado", Especie ="cão", Raca="Labrador", Peso=45, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=11},
				new Animais  {AnimalID=14, Nome = "Bebé", Especie ="cão", Raca="Labrador", Peso=35, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=12},
				new Animais  {AnimalID=15, Nome = "Bernardo", Especie ="cão", Raca="São Bernardo", Peso=67, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=15},
				new Animais  {AnimalID=16, Nome = "Miau", Especie ="gato", Raca="siamês", Peso=2, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=16},
				new Animais  {AnimalID=17, Nome = "Tareco", Especie ="gato", Raca="siamês", Peso=1, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=17},
				new Animais  {AnimalID=18, Nome = "Fofo", Especie ="gato", Raca="persa", Peso=10, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=17},
				new Animais  {AnimalID=19, Nome = "Pantufa", Especie ="gato", Raca="persa", Peso=1, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=18},
				new Animais  {AnimalID=20, Nome = "Vadio", Especie ="gato", Raca="rafeiro", Peso=2, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=19},
				new Animais  {AnimalID=21, Nome = "Saltador", Especie ="Cavalo", Raca="Lusitana", Peso=780, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=20},
				new Animais  {AnimalID=22, Nome = "Crina Branca", Especie ="Cavalo", Raca="Lusitana", Peso=900, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=13},
				new Animais  {AnimalID=23, Nome = "Brincalhão", Especie ="Cavalo", Raca="Lusitana", Peso=458, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=12},
				new Animais  {AnimalID=24, Nome = "Malhada", Especie ="Vaca", Raca="Charolesa", Peso=452, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=13},
				new Animais  {AnimalID=25, Nome = "Coxa", Especie ="Vaca", Raca="Charolesa", Peso=562, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=13},
				new Animais  {AnimalID=26, Nome = "Tansa", Especie ="Vaca", Raca="Charolesa", Peso=284, Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), DonosFK=14},
				new Animais  {AnimalID=27, Nome = "Salta Pocinha", Especie ="Cavalo", Raca="Lusitana", Imagem="Imagens/img1.jpg", Data = new DateTime(2015, 5, 15, 13, 45, 0), Peso=793, DonosFK=4}

			};

			animais.ForEach(aa => context.Animais.AddOrUpdate(a => a.Nome,aa));
			context.SaveChanges();

		}

	}
}