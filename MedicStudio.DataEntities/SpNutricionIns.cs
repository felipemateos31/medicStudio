using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpNutricionIns : StoredProcedure
	{
		public SpNutricionIns(): base("SpNutricionIns")
		{
			this.AddParameter("@pIdConsultaNut", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdPaciente", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdMedico", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pMotivoConsulta", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pProblemasActuales", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pPeso", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEstatura", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pTalla", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pIMC", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pPecho", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pAbdomen", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pCuello", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pBrazo", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEnfermedadImp", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pInfoMedicamentos", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pCirugia", System.Data.SqlDbType.Bit, DBNull.Value);
			this.AddParameter("@pTipoDeCirugia", System.Data.SqlDbType.VarChar, DBNull.Value);
			this.AddParameter("@pEnfermedadesCornicas", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pActividadFisica", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pObservaciones", System.Data.SqlDbType.Text, DBNull.Value);
		}

		public int IdConsultaNut
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsultaNut"].Value, 0); }
			set { this.Command.Parameters["@pIdConsultaNut"].Value = value; }
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

		public string MotivoConsulta
		{
			get { return Utils.IsNull(this.Command.Parameters["@pMotivoConsulta"].Value, ""); }
			set { this.Command.Parameters["@pMotivoConsulta"].Value = value; }
		}

		public string ProblemasActuales
		{
			get { return Utils.IsNull(this.Command.Parameters["@pProblemasActuales"].Value, ""); }
			set { this.Command.Parameters["@pProblemasActuales"].Value = value; }
		}

		public string Peso
		{
			get { return Utils.IsNull(this.Command.Parameters["@pPeso"].Value, ""); }
			set { this.Command.Parameters["@pPeso"].Value = value; }
		}

		public string Estatura
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEstatura"].Value, ""); }
			set { this.Command.Parameters["@pEstatura"].Value = value; }
		}

		public string Talla
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTalla"].Value, ""); }
			set { this.Command.Parameters["@pTalla"].Value = value; }
		}

		public string IMC
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIMC"].Value, ""); }
			set { this.Command.Parameters["@pIMC"].Value = value; }
		}

		public string Pecho
		{
			get { return Utils.IsNull(this.Command.Parameters["@pPecho"].Value, ""); }
			set { this.Command.Parameters["@pPecho"].Value = value; }
		}

		public string Abdomen
		{
			get { return Utils.IsNull(this.Command.Parameters["@pAbdomen"].Value, ""); }
			set { this.Command.Parameters["@pAbdomen"].Value = value; }
		}

		public string Cuello
		{
			get { return Utils.IsNull(this.Command.Parameters["@pCuello"].Value, ""); }
			set { this.Command.Parameters["@pCuello"].Value = value; }
		}

		public string Brazo
		{
			get { return Utils.IsNull(this.Command.Parameters["@pBrazo"].Value, ""); }
			set { this.Command.Parameters["@pBrazo"].Value = value; }
		}

		public string EnfermedadImp
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEnfermedadImp"].Value, ""); }
			set { this.Command.Parameters["@pEnfermedadImp"].Value = value; }
		}

		public string InfoMedicamentos
		{
			get { return Utils.IsNull(this.Command.Parameters["@pInfoMedicamentos"].Value, ""); }
			set { this.Command.Parameters["@pInfoMedicamentos"].Value = value; }
		}

		public bool Cirugia
		{
			get { return Utils.IsNull(this.Command.Parameters["@pCirugia"].Value, false); }
			set { this.Command.Parameters["@pCirugia"].Value = value; }
		}

		public string TipoDeCirugia
		{
			get { return Utils.IsNull(this.Command.Parameters["@pTipoDeCirugia"].Value, ""); }
			set { this.Command.Parameters["@pTipoDeCirugia"].Value = value; }
		}

		public string EnfermedadesCornicas
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEnfermedadesCornicas"].Value, ""); }
			set { this.Command.Parameters["@pEnfermedadesCornicas"].Value = value; }
		}

		public string ActividadFisica
		{
			get { return Utils.IsNull(this.Command.Parameters["@pActividadFisica"].Value, ""); }
			set { this.Command.Parameters["@pActividadFisica"].Value = value; }
		}

		public string Observaciones
		{
			get { return Utils.IsNull(this.Command.Parameters["@pObservaciones"].Value, ""); }
			set { this.Command.Parameters["@pObservaciones"].Value = value; }
		}
	}
}