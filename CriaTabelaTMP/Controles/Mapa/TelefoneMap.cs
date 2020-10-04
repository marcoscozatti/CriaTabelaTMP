using CriaTabelaTMP.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaTabelaTMP.Controles.Mapa
{
	class TelefoneMap : EntityTypeConfiguration<Telefone>  // faz a ligacao com a entidade telefone
	{
		public TelefoneMap()
		{
			this.ToTable("Telefone");  //toTable pede o nome da tabela, pode ser o mesmo da classe
			this.HasKey(d => d.Id);
			this.Property(d => d.Id).HasColumnName("ID_TELEFONE").IsRequired();
			this.Property(d => d.Nome).HasColumnName("NOME_TELEFONE").IsRequired();
			this.Property(d => d.Tel).HasColumnName("TEL_TELEFONE");
		}
	}
}
