using System;
using System.Collections.Generic;
using System.Text;

namespace PORTAL_ACADEMICO_DOMAIN.Alumno;

public interface IAlumnoRepository {

    Task<Alumno?> GetByIdAsyncAlumno(Guid Id, CancellationToken cancellationToken= default);

    Task<List<Alumno>> GetAllAsyncAlumno(CancellationToken cancellationToken = default);


   void AddAlumno(Alumno alumno);
   void UpdateAlumno(Guid Id);
   void DeleteAlumno(Alumno alumno);

    



}