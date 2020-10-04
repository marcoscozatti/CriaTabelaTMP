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
	class CadAmigoMap : EntityTypeConfiguration<CadAmigo>
	{
		public CadAmigoMap()
		{
			this.ToTable("CadAmigo");  //toTable pede o nome da tabela, pode ser o mesmo da classe
			this.HasKey(c => c.Id);
			this.Property(c => c.Id).HasColumnName("ID_CADAMIGO").IsRequired();
			this.Property(c => c.Nome).HasColumnName("NOME_CADAMIGO").IsRequired();
			this.Property(c => c.Celular).HasColumnName("CEL_CADAMIGO");
			this.Property(c => c.telefone).HasColumnName("TEL_CADAMIGO");
		}
	}
}
