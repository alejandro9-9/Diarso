using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno_Perfil;

public interface IAlumno_PerfilRepository {

    Task<Alumno_Perfil?> GetByIdAsyncAlumno_Perfil(Guid id, CancellationToken cancellationToken= default);

    Task<List<Alumno_Perfil>> GetAllAsyncAlumno_Perfil( CancellationToken cancellationToken= default);

    void Add(Alumno_Perfil alumno_Perfil);

    void Update(Alumno_Perfil alumno_Perfil);


    void Delete(Guid id);
   

}