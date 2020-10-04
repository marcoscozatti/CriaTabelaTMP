using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Entity;
using CriaTabelaTMP.Controles.Mapa;
using CriaTabelaTMP.Entidade;
using System.Data.Entity.ModelConfiguration;

namespace CriaTabelaTMP.Controles.Contexto
{
	class SistemaContexto : DbContext 
	{
		public SistemaContexto() : base("Server=DESKTOP-SEV4FT3\\SQLEXPRESS; Database=bdtelefone; Integrated Security=true;")
		{

		}


		//método de envio e recebimento (get e set), o nome Telefones será o nome da tabela
		//irá gerar a partir do modelo uma tabela com este nome com o método get e set
		public DbSet<Telefone> Telefones { get; set; }
		public DbSet<CadAmigo> CadAmigos { get; set; }

		//só digitar as iniciais protected overrid void On... ele preenche o resto
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<SistemaContexto>(null);  //inicializar o bd
			//mapeamento para criacao das tabelas
			modelBuilder.Configurations.Add(new TelefoneMap());  //redirecionar para a Entidade
			modelBuilder.Configurations.Add(new CadAmigoMap());
		}

		/*Ante temos que instalar o EntityFramework
		 * install-Package EntityFramework
		 * Para fazer a migração faça:
		 * 1-) enable-migrations
		 * 2-) Add-migration banco
		 * 3-) update-database
		 * */


	}


}