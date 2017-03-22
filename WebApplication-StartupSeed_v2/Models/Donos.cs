using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication_StartupSeed_v2.Models {
	public class Donos {

		// criar o construtor desta classe
		// e carregar a lista de Animais
		public Donos() {
			ListaDeAnimais = new HashSet<Animais>();
		}


		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)] // impede que o ID seja autonumber
		public int DonoID { get; set; }

		[Required]
		public string Nome { set; get; }

		[Required]
		public string NIF { get; set; }


		// especificar que um DONO tem muitos ANIMAIS
		public ICollection<Animais> ListaDeAnimais { get; set; }

	}
}