If Exists(Select 1 from sys.procedures where name='SpMedicoSel')
drop proc  SpMedicoSel
go
Create proc  SpMedicoSel
(
    @pIdMedico int
 )
as
begin
    select		M.IdMedico,
				M.Nombre,
				M.ApellidoP,
				M.ApellidoM,
				M.Edad,
				M.FechaNac,
				M.EstadoCiv,
				M.Area,
				M.Telefono1,
				M.Telefono2,
				M.Email,
				M.Usuario,
				M.Pass		
    from Medico M
    where  IdMedico=@pIdMedico
end

