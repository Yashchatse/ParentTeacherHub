﻿using ParentTeacherBridge.API.Models;

namespace ParentTeacherBridge.API.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Task<Student?> GetByEnrollmentNoAsync(string enrollmentNo);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Student student);
        Task<bool> ExistsAsync(int id);
        Task<bool> EnrollmentNoExistsAsync(string enrollmentNo, int? excludeId = null);
        Task<IEnumerable<Student>> GetStudentsByClassAsync(int classId);
        Task<IEnumerable<Student>> SearchStudentsAsync(string searchTerm);
    }
}
