using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication_StartupSeed_v2.Models {
	public class MyDB :DbContext{

		public MyDB()
					 : base("DefaultConnection") {
		}
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // impede o SqlServer de tornar o nome das tabelas em plural
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // impede o 'on delete cascade'
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); // impede o 'on delete cascade'
			base.OnModelCreating(modelBuilder);
		}

		// adiciona as tabelas Animais e Donos à BD
		public virtual DbSet<Animais> Animais { get; set; }
		public virtual DbSet<Donos> Donos { get; set; }
	}
}