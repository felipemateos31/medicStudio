using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpPsicologiaIns : StoredProcedure
	{
		public SpPsicologiaIns(): base("SpPsicologiaIns")
		{
			this.AddParameter("@pIdConsultaPs", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdPaciente", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdMedico", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pMotivo", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pAntecedentes", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pRelacionFamiliar", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pDescripcionCircAmigos", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pActividadesIndividuales", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pCasado", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pUnionLibre", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@psoltero", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pAlcohol", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pFuma", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pSustancias", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pExpectativaTerapia", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pCompromisos", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pResultados", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pRecomendaciones", System.Data.SqlDbType.Text, DBNull.Value);
		}

		public int IdConsultaPs
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsultaPs"].Value, 0); }
			set { this.Command.Parameters["@pIdConsultaPs"].Value = value; }
		}

		public int IdPaciente
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdPaciente"].Value, 0); }
			set { this.Command.Parameters["@pIdPaciente"].Value = value; }
		}

		public int IdMedico
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdMedico"].Value, 0); }
			set { this.Command.Parameters["@pIdMedico"].Value = value; }
		}


		public string Motivo
		{
			get { return Utils.IsNull(this.Command.Parameters["@pMotivo"].Value, ""); }
			set { this.Command.Parameters["@pMotivo"].Value = value; }
		}

		public string Antecedentes
		{
			get { return Utils.IsNull(this.Command.Parameters["@pAntecedentes"].Value, ""); }
			set { this.Command.Parameters["@pAntecedentes"].Value = value; }
		}

		public string RelacionFamiliar
		{
			get { return Utils.IsNull(this.Command.Parameters["@pRelacionFamiliar"].Value, ""); }
			set { this.Command.Parameters["@pRelacionFamiliar"].Value = value; }
		}

		public string DescripcionCircAmigos
		{
			get { return Utils.IsNull(this.Command.Parameters["@pDescripcionCircAmigos"].Value, ""); }
			set { this.Command.Parameters["@pDescripcionCircAmigos"].Value = value; }
		}

		public string ActividadesIndividuales
		{
			get { return Utils.IsNull(this.Command.Parameters["@pActividadesIndividuales"].Value, ""); }
			set { this.Command.Parameters["@pActividadesIndividuales"].Value = value; }
		}

		public bool Casado
		{
			get { return Utils.IsNull(this.Command.Parameters["@pCasado"].Value, false); }
			set { this.Command.Parameters["@pCasado"].Value = value; }
		}

		public bool UnionLibre
		{
            get { return Utils.IsNull(this.Command.Parameters["@pUnionLibre"].Value, false); }
			set { this.Command.Parameters["@pUnionLibre"].Value = value; }
		}

		public bool Soltero
		{
            get { return Utils.IsNull(this.Command.Parameters["@psoltero"].Value, false); }
			set { this.Command.Parameters["@psoltero"].Value = value; }
		}

		public bool Alcohol
		{
			get { return Utils.IsNull(this.Command.Parameters["@pAlcohol"].Value, false); }
			set { this.Command.Parameters["@pAlcohol"].Value = value; }
		}

		public bool Fuma
		{
            get { return Utils.IsNull(this.Command.Parameters["@pFuma"].Value, false); }
			set { this.Command.Parameters["@pFuma"].Value = value; }
		}

		public bool Sustancias
		{
			get { return Utils.IsNull(this.Command.Parameters["@pSustancias"].Value, false); }
			set { this.Command.Parameters["@pSustancias"].Value = value; }
		}

		public string ExpectativaTerapia
		{
			get { return Utils.IsNull(this.Command.Parameters["@pExpectativaTerapia"].Value, ""); }
			set { this.Command.Parameters["@pExpectativaTerapia"].Value = value; }
		}

		public string Compromisos
		{
			get { return Utils.IsNull(this.Command.Parameters["@pCompromisos"].Value, ""); }
			set { this.Command.Parameters["@pCompromisos"].Value = value; }
		}

		public string Resultados
		{
			get { return Utils.IsNull(this.Command.Parameters["@pResultados"].Value, ""); }
			set { this.Command.Parameters["@pResultados"].Value = value; }
		}

		public string Recomendaciones
		{
			get { return Utils.IsNull(this.Command.Parameters["@pRecomendaciones"].Value, ""); }
			set { this.Command.Parameters["@pRecomendaciones"].Value = value; }
		}
	}
}