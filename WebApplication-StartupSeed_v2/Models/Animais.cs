using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication_StartupSeed_v2.Models {
	public class Animais {

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)] // impede que o ID seja autonumber
		public int AnimalID { get; set; }

		[Required]
		[StringLength(30)]
		public string Nome { get; set; }

		[Required]
		[StringLength(30)]
		public string Especie { get; set; }

		[Required]
		[StringLength(30)]
		public string Raca { get; set; }

		public float Peso { get; set; }

		public float? Altura { get; set; }

        [StringLength(500)]
        public string Imagem { get; set; }
        public DateTime Data { get; set; }


        // ****************************************************
        // criar a chave forasteira
        // relaciona o objeto ANIMAL com um objeto DONO
        public Donos Dono { get; set; }

		// cria um atributo para funcionar como FK, na BD
		// e relaciona-o com o atributo anterior
		[ForeignKey("Dono")]
		public int DonosFK { get; set; }
		// ****************************************************

	}
}