using System;
using Framework;

namespace MedicStudio.DataEntities
{
	public class SpMedicinaGeneralIns : StoredProcedure
	{
		public SpMedicinaGeneralIns(): base("SpMedicinaGeneralIns")
		{
			this.AddParameter("@pIdConsultaMG", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdPaciente", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pIdMedico", System.Data.SqlDbType.Int, DBNull.Value);
			this.AddParameter("@pMotivoConsulta", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pProblemasActuales", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pMedicamentos", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pObservaciones", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pEnfermedadesCronicas", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pEnfermedadesImportantes", System.Data.SqlDbType.Text, DBNull.Value);
			this.AddParameter("@pDiagnstico", System.Data.SqlDbType.Text, DBNull.Value);
		}

		public int IdConsultaMG
		{
			get { return Utils.IsNull(this.Command.Parameters["@pIdConsultaMG"].Value, 0); }
			set { this.Command.Parameters["@pIdConsultaMG"].Value = value; }
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

		public string Medicamentos
		{
			get { return Utils.IsNull(this.Command.Parameters["@pMedicamentos"].Value, ""); }
			set { this.Command.Parameters["@pMedicamentos"].Value = value; }
		}

		public string Observaciones
		{
			get { return Utils.IsNull(this.Command.Parameters["@pObservaciones"].Value, ""); }
			set { this.Command.Parameters["@pObservaciones"].Value = value; }
		}

		public string EnfermedadesCronicas
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEnfermedadesCronicas"].Value, ""); }
			set { this.Command.Parameters["@pEnfermedadesCronicas"].Value = value; }
		}

		public string EnfermedadesImportantes
		{
			get { return Utils.IsNull(this.Command.Parameters["@pEnfermedadesImportantes"].Value, ""); }
			set { this.Command.Parameters["@pEnfermedadesImportantes"].Value = value; }
		}

		public string Diagnstico
		{
			get { return Utils.IsNull(this.Command.Parameters["@pDiagnstico"].Value, ""); }
			set { this.Command.Parameters["@pDiagnstico"].Value = value; }
		}
	}
}