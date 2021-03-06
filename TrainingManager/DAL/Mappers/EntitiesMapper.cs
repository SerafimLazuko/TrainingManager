﻿using DAL.Interfaces.DTO;
using ORM.Entities;

namespace DAL.Mappers
{
    public static class EntitiesMapper
    {
        /// <summary>
        /// Maps user DTO entity to user entity
        /// </summary>
        /// <param name="userDto">User DTO entity</param>
        /// <returns>User entity</returns>
        public static User ToUser(this UserDto userDto)
        {
            return new User()
            {
                Id = userDto.Id,
                RoleId = userDto.RoleId,
                Name = userDto.Name,
                Surname = userDto.Surname,
                Patronymic = userDto.Patronymic,
                GithubLink = userDto.GithubLink,
                Email = userDto.Email,
                PhoneNumber = userDto.PhoneNumber
            };
        }

        /// <summary>
        /// Maps user entity to user DTO entity
        /// </summary>
        /// <param name="user">User entity</param>
        /// <returns>User DTO entity</returns>
        public static UserDto ToUserDto(this User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                RoleId = user.RoleId,
                Name = user.Name,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                GithubLink = user.GithubLink,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
        }

        /// <summary>
        /// Maps module DTO entity to module entity
        /// </summary>
        /// <param name="moduleDto">Module DTO entity</param>
        /// <returns>Module entity</returns>
        public static Module ToModule(this ModuleDto moduleDto)
        {
            return new Module()
            {
                Id = moduleDto.Id,
                Name = moduleDto.Name,
                Description = moduleDto.Description,
                CreatedAt = moduleDto.CreatedAt,
                Deadline = moduleDto.Deadline
            };
        }

        /// <summary>
        /// Maps module entity to module DTO entity
        /// </summary>
        /// <param name="module">Module entity</param>
        /// <returns>Module DTO entity</returns>
        public static ModuleDto ToModuleDto(this Module module)
        {
            return new ModuleDto()
            {
                Id = module.Id,
                Name = module.Name,
                Description = module.Description,
                CreatedAt = module.CreatedAt,
                Deadline = module.Deadline
            };
        }

        /// <summary>
        /// Maps student module DTO entity to student module entity
        /// </summary>
        /// <param name="studentModuleDto">Student DTO entity</param>
        /// <returns>Student entity</returns>
        public static StudentModule ToStudentModule(this StudentModuleDto studentModuleDto)
        {
            return new StudentModule()
            {
                Id = studentModuleDto.Id,
                StudentId = studentModuleDto.StudentId,
                ModuleId = studentModuleDto.ModuleId,
                Grade = studentModuleDto.Grade,
                Feedback = studentModuleDto.Feedback,
                GithubLink = studentModuleDto.GithubLink,
                DoneAt = studentModuleDto.DoneAt
            };
        }

        /// <summary>
        /// Maps student module entity to student module DTO entity
        /// </summary>
        /// <param name="studentModule">Student module entity</param>
        /// <returns>Student module DTO entity</returns>
        public static StudentModuleDto ToStudentModuleDto(this StudentModule studentModule)
        {
            return new StudentModuleDto()
            {
                Id = studentModule.Id,
                StudentId = studentModule.StudentId,
                ModuleId = studentModule.ModuleId,
                Grade = studentModule.Grade,
                Feedback = studentModule.Feedback,
                GithubLink = studentModule.GithubLink,
                DoneAt = studentModule.DoneAt
            };
        }

        /// <summary>
        /// Maps workshop DTO entity to workshop entity
        /// </summary>
        /// <param name="workshopDto">Workshop DTO entity</param>
        /// <returns>Workshop entity</returns>
        public static Workshop ToWorkshop(this WorkshopDto workshopDto)
        {
            return new Workshop()
            {
                Id = workshopDto.Id,
                ModuleId = workshopDto.ModuleId,
                DateTime = workshopDto.DateTime,
                Location = workshopDto.Location
            };
        }

        /// <summary>
        /// Maps workshop entity to workshop DTO entity
        /// </summary>
        /// <param name="workshop">Workshop entity</param>
        /// <returns>Workshop DTO entity</returns>
        public static WorkshopDto ToWorkshopDto(this Workshop workshop)
        {
            return new WorkshopDto()
            {
                Id = workshop.Id,
                ModuleId = workshop.ModuleId,
                DateTime = workshop.DateTime,
                Location = workshop.Location
            };
        }
    }
}
