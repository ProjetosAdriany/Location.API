using System;
using System.Collections.Generic;
using Api.Domain.DTOs;
using Api.Domain.DTOs.User;

namespace Api.Service.Test.User
{
    public class UserTests
    {
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string NameUpdate { get; set; }
        public static string EmailUpdate { get; set; }
        public Guid Id { get; set; }

        public List<UserDTO> listUserDTO = new List<UserDTO>();
        public UserDTO userDTO;
        public UserCreateDTO userCreateDTO;
        public UserCreateResultDTO userCreateResultDTO;
        public UserUpdateDTO userUpdateDTO;
        public UserUpdateResultDTO userUpdateResultDTO;

        public UserTests()
        {
            Id = Guid.NewGuid();
            Name = Faker.Name.FullName();
            Email = Faker.Internet.Email();
            NameUpdate = Faker.Name.FullName();
            EmailUpdate = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UserDTO
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email()
                };
                listUserDTO.Add(dto);
            }

            userDTO = new UserDTO
            {
                Id = Id,
                Name = Name,
                Email = Email
            };

            userCreateDTO = new UserCreateDTO
            {
                Name = Name,
                Email = Email
            };

            userCreateResultDTO = new UserCreateResultDTO
            {
                Id = Id,
                Name = Name,
                Email = Email,
                CreateAt = DateTime.UtcNow
            };

            userUpdateDTO = new UserUpdateDTO
            {
                Id = Id,
                Name = NameUpdate,
                Email = EmailUpdate
            };

            userUpdateResultDTO = new UserUpdateResultDTO
            {
                Id = Id,
                Name = NameUpdate,
                Email = EmailUpdate,
                UpdateAt = DateTime.UtcNow
            };
        }

    }
}
